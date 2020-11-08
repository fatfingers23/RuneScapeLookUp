using System;
using System.ComponentModel.DataAnnotations;
using RuneScapeLookUp.StaticClasses;

namespace RuneScapeLookUp.ViewModels.LookUp
{
    public class SearchViewModel
    {
        [Required]     
        [Display(Name = "Runescape Username")]
        public string RunescapeUsername { get; set; } 
        
        public RunescapeEnums.Game Game { get; set; }
        
    }
}
