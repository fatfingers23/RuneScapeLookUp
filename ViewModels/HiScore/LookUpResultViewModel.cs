using System;
using System.Collections.Generic;
using RuneScapeLookUp.StaticClasses;

namespace RuneScapeLookUp.ViewModels.LookUp
{
    /// <summary>
    /// The view model that is returned to build the View HiScoreResults
    /// </summary>
    public class LookUpResultViewModel
    {
        /// <summary>
        /// A list of Skills and their hiscore data
        /// </summary>
        public IList<SkillData> SkillHSData { get; set; }

        /// <summary>
        /// The users Username
        /// </summary>
        public string Username { get; set; }
        
        /// <summary>
        /// Which game the stats are related to
        /// </summary>
        public RunescapeEnums.Game Game { get; set; }
    }

    /// <summary>
    /// Class to hold skill data from hiscores for user
    /// </summary>
    public class SkillData
    {
        /// <summary>
        /// The name of the skill
        /// </summary>
        public RunescapeEnums.BaseSkillName SkillName { get; set; }

        /// <summary>
        /// Their hiscore rank
        /// </summary>
        public int Rank { get; set;}

        /// <summary>
        /// Their level in game
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// The amount of xp they have
        /// </summary>
        public int Experience { get; set; }
    }

}
