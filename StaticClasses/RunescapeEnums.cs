using System;
using System.Collections.Generic;

namespace RuneScapeLookUp.StaticClasses
{
    public static class RunescapeEnums
    {
        /// <summary>
        /// Current Base Game
        /// </summary>
        public enum Game
        {
            Runescape,
            OldSchoolRunescape
        }

        public enum GameMode
        {
            Ironman,
            HardcoreIronman,
            UltimateIronMan,
            Deadman
        }
        
        /// <summary>
        /// These are the base skills that are in both games. RS3 and OSRS
        /// </summary>
        public enum BaseSkillName
        {
            Overall,
            Attack,
            Defence,
            Strength,
            Hitpoints,
            Ranged,
            Prayer,
            Magic,
            Cooking,
            Woodcutting,
            Fletching,
            Fishing,
            Firemaking,
            Crafting,
            Smithing,
            Mining,
            Herblore,
            Agility,
            Thieving,
            Slayer,
            Farming,
            Runecrafting,
            Hunter,
            Construction
        }

        /// <summary>
        /// these are the skills added to Runescape 3 that are not in osrs
        /// </summary>
        public enum RunescapeAddedSkills
        {
            Summoning, 
            Dungeoneering,
            Divination,
            Invention,
            Archaeology
        }

        /// <summary>
        /// LIst of OSRSActivities that are on hiscores but not skills
        /// </summary>
        public static List<string> OSRSActivities => new List<string>()
        {
            "League Points",
            "Bounty Hunter - Hunter",
            "Bounty Hunter - Rogue",
            "Clue Scrolls (all)",
            "Clue Scrolls (beginner)",
            "Clue Scrolls (easy)",
            "Clue Scrolls (medium)",
            "Clue Scrolls (hard)",
            "Clue Scrolls (elite)",
            "Clue Scrolls (master)",
            "LMS - Rank",
            "Abyssal Sire",
            "Alchemical Hydra",
            "Barrows Chests",
            "Bryophyta",
            "Callisto",
            "Cerberus",
            "Chambers of Xeric",
            "Chambers of Xeric: Challenge Mode",
            "Chaos Elemental",
            "Chaos Fanatic",
            "Commander Zilyana",
            "Corporeal Beast",
            "Crazy Archaeologist",
            "Dagannoth Prime",
            "Dagannoth Rex",
            "Dagannoth Supreme",
            "Deranged Archaeologist",
            "General Graardor",
            "Giant Mole",
            "Grotesque Guardians",
            "Hespori",
            "Kalphite Queen",
            "King Black Dragon",
            "Kraken",
            "Kree'Arra",
            "K'ril Tsutsaroth",
            "Mimic",
            "Nightmare",
            "Obor",
            "Sarachnis",
            "Scorpia",
            "Skotizo",
            "The Gauntlet",
            "The Corrupted Gauntlet",
            "Theatre of Blood",
            "Thermonuclear Smoke Devil",
            "TzKal-Zuk",
            "TzTok-Jad",
            "Venenatis",
            "Vet'ion",
            "Vorkath",
            "Wintertodt",
            "Zalcano",
            "Zulrah",
    
        };
        
        /// <summary>
        /// List of Runescape on activites
        /// </summary>
        public static List<string> RunescapeActivities => new List<string>()
        {
            "Bounty Hunter",
            "B.H. Rogues",
            "Dominion Tower",
            "The Crucible", 
            "Castle Wars games",
            "B.A. Attackers",
            "B.A. Defenders", 
            "B.A. Collectors",
            "B.A. Healers",
            "Duel Tournament", 
            "Mobilising Armies",
            "Conquest", 
            "Fist of Guthix",
            "GG: Athletics",
            "GG: Resource Race",
            "WE2: Armadyl Lifetime Contribution",
            "WE2: Bandos Lifetime Contribution", 
            "WE2: Armadyl PvP kills",
            "WE2: Bandos PvP kills",
            "Heist Guard Level", 
            "Heist Robber Level",
            "CFP: 5 game average", 
            "AF15: Cow Tipping",
            "AF15: Rats killed after the miniquest",
            "RuneScore",
            "Clue Scrolls Easy",
            "Clue Scrolls Medium", 
            "Clue Scrolls Hard",
            "Clue Scrolls Elite",
            "Clue Scrolls Maste",
        };
    }
}
