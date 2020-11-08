using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RuneScapeLookUp.Models;
using RuneScapeLookUp.ViewModels.LookUp;
using RuneScapeLookUp.StaticClasses;
using System.Globalization;

namespace RuneScapeLookUp.Controllers
{
    [Route("[controller]")]
    public class HiScoreController: Controller
    {
        private readonly ILogger<HiScoreController> _logger;

        /// <summary>
        /// A http client instance for making web requests for hiscore data
        /// </summary>
        private static readonly HttpClient client = new HttpClient();

        /// <summary>
        /// The runescape api end point for osrs hiscores
        /// </summary>
        private static readonly string OSRSHiScoreLookUpUrl = "https://secure.runescape.com/m=hiscore_oldschool/index_lite.ws?player=";

        /// <summary>
        /// The runescape api end point for runescape 3 hiscores
        /// </summary>
        private static readonly string RunescapeHiScoreLookUpUrl =
            "https://secure.runescape.com/m=hiscore/index_lite.ws?player=";

        public HiScoreController(ILogger<HiScoreController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Displays the index page for the look up which is the users search bar
        /// </summary>
        /// <returns></returns>
        [HttpGet("")]
        public async Task<IActionResult> Index()
        {
            return View("Index");
        }

        /// <summary>
        /// Http end point for the search
        /// </summary>
        /// <param name="vm"><see cref="SearchViewModel"/>Data to search for a runescape user</param>
        [HttpGet("LookUp")]
        public async Task<IActionResult> LookUpUsername([FromQuery] SearchViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(Index));
            }

            if (vm.Game == RunescapeEnums.Game.OldSchoolRunescape)
            {
                var osrsResultsVm = await FindUsersOSRSHiscores(vm.RunescapeUsername);
                return View("HiScoreResults", osrsResultsVm);
            }
            //Method to return runescape 3 hiscore data like osrs
            //This code is only ran if the the game type is not osrs
            return View("HiScoreResults");
        }

        /// <summary>
        /// A method to look up hiscores stats for a osrs user
        /// </summary>
        /// <param name="username">The users runescape username </param>
        /// <returns><see cref="LookUpResultViewModel"/>a view model for the look up result</returns>
        private async Task<LookUpResultViewModel> FindUsersOSRSHiscores(string username)
        {
            var result = await client.GetStringAsync($"{OSRSHiScoreLookUpUrl}{username}");

            if (string.IsNullOrEmpty(result)) {
                return null;
            }

            var listOfHiscores = result.Split('\n');

            var listOfSkillData = new List<SkillData>();

            var index = 0;

            foreach(RunescapeEnums.BaseSkillName skillName in Enum.GetValues(typeof(RunescapeEnums.BaseSkillName))){
                var skillData = listOfHiscores.ElementAt(index);
                var skillDataParse = skillData.Split(',');

                listOfSkillData.Add(new SkillData
                {
                    SkillName = skillName,
                    Rank = Int32.Parse(skillDataParse.ElementAt(0)),
                    Level = Int32.Parse(skillDataParse.ElementAt(1)),
                    Experience = Int32.Parse(skillDataParse.ElementAt(2)),

                });
                ++index;
            }

            return new LookUpResultViewModel
            {
                SkillHSData = listOfSkillData,
                Username = username,
                Game = RunescapeEnums.Game.OldSchoolRunescape
            };
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
