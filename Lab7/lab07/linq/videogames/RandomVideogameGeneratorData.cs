using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPP.Laboratory.Functional.Lab01
{
    /// <summary>
    /// A class with information of videogames of the PS3, XBox360 and Wii games.
    /// </summary>
    internal class RandomVideogameGeneratorData
    {
        /// <summary>
        /// Header of the videogame data, to interpret its information
        /// </summary>
        public static string[] header =
        {
            "Game", "Platform", "Year", "Genre", "Publisher", "North America", "Europe",
            "Japan", "Rest of World"
        };

        /// <summary>
        /// PS3 game information.
        /// </summary>
        public static string[,] Ps3Games =
        {
            {"Grand Theft Auto V", "PS3", "2013", "Action", "Take-Two Interactive", "6.25", "8.02", "0.85", "3.93"},
            {"Call of Duty: Black Ops II", "PS3", "2012", "Shooter", "Activision", "4.77", "5.41", "0.57", "2.45"},
            {"Call of Duty: Modern Warfare 3", "PS3", "2011", "Shooter", "Activision", "5.42", "5.60", "0.49", "1.59"},
            {"Call of Duty: Black Ops", "PS3", "2010", "Shooter", "Activision", "5.83", "4.26", "0.48", "1.80"},
            {"Gran Turismo 5", "PS3", "2010", "Racing", "Sony Computer Entertainment", "2.86", "4.74", "0.81", "2.11"},
            {"Call of Duty: Modern Warfare 2", "PS3", "2009", "Shooter", "Activision", "4.93", "3.57", "0.38", "1.61"},
            {"Grand Theft Auto IV", "PS3", "2008", "Action", "Take-Two Interactive", "4.65", "3.61", "0.44", "1.58"},
            {"Call of Duty: Ghosts", "PS3", "2013", "Shooter", "Activision", "3.58", "3.38", "0.38", "2.02"},
            {"FIFA Soccer 13", "PS3", "2012", "Action", "Electronic Arts", "1.03", "4.94", "0.13", "2.01"},
            {"Battlefield 3", "PS3", "2011", "Shooter", "Electronic Arts", "2.77", "2.83", "0.35", "1.09"},
            {"FIFA Soccer 14", "PS3", "2013", "Sports", "Electronic Arts", "0.70", "4.04", "0.07", "2.00"},
            {"FIFA Soccer 12", "PS3", "2011", "Sports", "Electronic Arts", "0.81", "4.27", "0.11", "1.41"},
            {
                "Uncharted 3: Drake's Deception", "PS3", "2011", "Action", "Sony Computer Entertainment", "2.67", "2.66",
                "0.19", "1.06"
            },
            {"Call of Duty 4: Modern Warfare", "PS3", "2007", "Shooter", "Activision", "3.02", "2.22", "0.28", "1.01"},
            {
                "Uncharted 2: Among Thieves", "PS3", "2009", "Action", "Sony Computer Entertainment", "3.19", "2.13",
                "0.21", "0.98"
            },
            {"Red Dead Redemption", "PS3", "2010", "Action", "Take-Two Interactive", "2.65", "2.41", "0.17", "1.00"},
            {"Assassin's Creed III", "PS3", "2012", "Action", "Ubisoft", "2.47", "2.42", "0.16", "1.12"},
            {
                "Metal Gear Solid 4: Guns of the Patriots", "PS3", "2008", "Action", "Konami Digital Entertainment", "2.60",
                "1.68", "0.83", "0.82"
            },
            {
                "The Elder Scrolls V: Skyrim", "PS3", "2011", "Role-Playing", "Bethesda Softworks", "2.25", "2.43", "0.25",
                "0.98"
            },
            {
                "LittleBigPlanet", "PS3", "2008", "Platform", "Sony Computer Entertainment", "2.72", "1.84", "0.17", "0.88"
            },
            {"Assassin's Creed II", "PS3", "2009", "Action", "Ubisoft", "2.47", "1.90", "0.21", "0.86"},
            {
                "The Last of Us", "PS3", "2013", "Adventure", "Sony Computer Entertainment Europe", "2.14", "1.92", "0.25",
                "0.97"
            },
            {"Final Fantasy XIII", "PS3", "2009", "Role-Playing", "Square Enix", "1.68", "1.18", "1.87", "0.50"},
            {"Call of Duty: World at War", "PS3", "2008", "Shooter", "Activision", "2.62", "1.79", "0.00", "0.81"},
            {
                "Batman: Arkham City", "PS3", "2011", "Action", "Warner Bros. Interactive Entertainment", "2.50", "1.76",
                "0.11", "0.75"
            },
            {"FIFA Soccer 11", "PS3", "2010", "Sports", "Electronic Arts", "0.59", "3.26", "0.06", "1.12"},
            {"Resident Evil 5", "PS3", "2009", "Action", "Capcom", "1.92", "1.39", "1.08", "0.64"},
            {
                "Uncharted: Drake's Fortune", "PS3", "2007", "Action", "Sony Computer Entertainment", "2.22", "1.70",
                "0.12", "0.76"
            },
            {"Assassin's Creed", "PS3", "2007", "Adventure", "Ubisoft", "1.87", "1.98", "0.09", "0.83"},
            {"God of War III", "PS3", "2010", "Action", "Sony Computer Entertainment", "2.71", "1.30", "0.12", "0.62"},
            {
                "Resistance: Fall of Man", "PS3", "2006", "Shooter", "Sony Computer Entertainment", "1.69", "1.70", "0.14",
                "0.73"
            },
            {
                "Gran Turismo 5 Prologue", "PS3", "2007", "Racing", "Sony Computer Entertainment", "1.26", "1.82", "0.57",
                "0.53"
            },
            {"Assassin's Creed: Revelations", "PS3", "2011", "Action", "Ubisoft", "1.37", "1.99", "0.10", "0.72"},
            {"Batman: Arkham Asylum", "PS3", "2009", "Action", "Eidos Interactive", "2.15", "1.28", "0.07", "0.59"},
            {"Street Fighter IV", "PS3", "2009", "Fighting", "Capcom", "1.93", "1.01", "0.57", "0.51"},
            {"MotorStorm", "PS3", "2006", "Racing", "Sony Computer Entertainment", "1.51", "1.59", "0.06", "0.67"},
            {"Assassin's Creed IV: Black Flag", "PS3", "2013", "Action", "Ubisoft", "1.11", "1.59", "0.12", "0.92"},
            {"Sports Champions", "PS3", "2010", "Sports", "Sony Computer Entertainment", "2.05", "1.08", "0.10", "0.49"},
            {"FIFA Soccer 10", "PS3", "2009", "Sports", "Electronic Arts", "0.57", "2.44", "0.05", "0.52"},
            {"Fallout 3", "PS3", "2008", "Role-Playing", "Bethesda Softworks", "1.87", "1.06", "0.07", "0.51"},
            {"FIFA 15", "PS3", "2014", "Sports", "Electronic Arts", "0.25", "2.03", "0.03", "1.11"},
            {"Battlefield 4", "PS3", "2013", "Shooter", "Electronic Arts", "1.12", "1.25", "0.26", "0.73"},
            {
                "LittleBigPlanet 2", "PS3", "2011", "Platform", "Sony Computer Entertainment", "1.73", "1.00", "0.06",
                "0.46"
            },
            {"Far Cry 3", "PS3", "2012", "Shooter", "Ubisoft", "0.78", "1.60", "0.10", "0.70"},
            {"L.A. Noire", "PS3", "2011", "Adventure", "Take-Two Interactive", "1.21", "1.23", "0.12", "0.50"},
            {"Resident Evil 6", "PS3", "2012", "Action", "Capcom", "0.82", "0.90", "0.88", "0.42"},
            {"The Elder Scrolls IV: Oblivion", "PS3", "2007", "Role-Playing", "Ubisoft", "1.63", "0.83", "0.14", "0.41"},
            {"Killzone 2", "PS3", "2009", "Shooter", "Sony Computer Entertainment", "1.39", "1.05", "0.08", "0.47"},
            {"Gran Turismo 6", "PS3", "2013", "Racing", "Sony Computer Entertainment", "0.45", "1.39", "0.36", "0.78"},
            {"Heavy Rain", "PS3", "2010", "Adventure", "Sony Computer Entertainment", "1.23", "1.13", "0.06", "0.49"},
            {"Battlefield: Bad Company 2", "PS3", "2010", "Shooter", "Electronic Arts", "1.29", "1.08", "0.08", "0.44"},
            {"inFAMOUS", "PS3", "2009", "Action", "Sony Computer Entertainment", "1.70", "0.66", "0.12", "0.35"},
            {"Fallout: New Vegas", "PS3", "2010", "Role-Playing", "Bethesda Softworks", "1.32", "0.97", "0.10", "0.42"},
            {"Assassin's Creed: Brotherhood", "PS3", "2010", "Action", "Ubisoft", "1.83", "0.53", "0.11", "0.30"},
            {"Medal of Honor", "PS3", "2010", "Shooter", "Electronic Arts", "1.26", "1.02", "0.07", "0.42"},
            {"Call of Duty: Advanced Warfare", "PS3", "2014", "Shooter", "Activision", "0.90", "1.07", "0.13", "0.63"},
            {"Need for Speed: Hot Pursuit", "PS3", "2010", "Racing", "Electronic Arts", "1.01", "1.20", "0.03", "0.47"},
            {"Tekken 6", "PS3", "2009", "Fighting", "Namco Bandai Games", "1.16", "0.94", "0.17", "0.42"},
            {"Killzone 3", "PS3", "2011", "Shooter", "Sony Computer Entertainment", "1.38", "0.83", "0.09", "0.37"},
            {
                "Need for Speed: Most Wanted - A Criterion Game", "PS3", "2012", "Racing", "Electronic Arts", "0.65",
                "1.36", "0.06", "0.60"
            },
            {"Final Fantasy XIII-2", "PS3", "2011", "Role-Playing", "Square Enix", "0.77", "0.71", "0.89", "0.27"},
            {"Need for Speed: Shift", "PS3", "2009", "Racing", "Electronic Arts", "0.68", "1.37", "0.04", "0.52"},
            {
                "Mortal Kombat", "PS3", "2011", "Fighting", "Warner Bros. Interactive Entertainment", "1.82", "0.50",
                "0.00", "0.28"
            },
            {"FIFA Soccer 09", "PS3", "2008", "Sports", "Electronic Arts", "0.46", "1.62", "0.04", "0.42"},
            {
                "God of War Collection", "PS3", "2009", "Action", "Sony Computer Entertainment", "1.67", "0.42", "0.06",
                "0.40"
            },
            {
                "Ratchet & Clank Future: Tools of Destruction", "PS3", "2007", "Platform", "Sony Computer Entertainment",
                "0.91", "1.08", "0.08", "0.45"
            },
            {"MineCraft", "PS3", "2014", "Adventure", "Sony Computer Entertainment", "0.95", "0.97", "0.00", "0.58"},
            {"Madden NFL 13", "PS3", "2012", "Sports", "Electronic Arts", "2.04", "0.21", "0.00", "0.20"},
            {"Resistance 2", "PS3", "2008", "Shooter", "Sony Computer Entertainment", "1.13", "0.82", "0.10", "0.38"},
            {"Saints Row: The Third", "PS3", "2011", "Action", "THQ", "0.82", "1.02", "0.18", "0.38"},
            {
                "pro evolution soccer 2011", "PS3", "2010", "Sports", "Konami Digital Entertainment", "0.28", "1.17",
                "0.54", "0.41"
            },
            {"NBA 2K13", "PS3", "2012", "Action", "Take-Two Interactive", "1.65", "0.41", "0.05", "0.27"},
            {"Madden NFL 10", "PS3", "2009", "Sports", "Electronic Arts", "2.02", "0.13", "0.00", "0.21"},
            {"Tomb Raider (2013)", "PS3", "2013", "Action", "Square Enix", "0.56", "1.18", "0.08", "0.53"},
            {"Madden NFL 11", "PS3", "2010", "Sports", "Electronic Arts", "2.01", "0.15", "0.00", "0.19"},
            {
                "Midnight Club: Los Angeles", "PS3", "2008", "Racing", "Take-Two Interactive", "1.47", "0.52", "0.05",
                "0.29"
            },
            {
                "Pro Evolution Soccer 2010", "PS3", "2009", "Sports", "Konami Digital Entertainment", "0.30", "1.26",
                "0.46", "0.26"
            },
            {"Guitar Hero III: Legends of Rock", "PS3", "2007", "Misc", "Activision", "1.38", "0.52", "0.02", "0.29"},
            {"Madden NFL 12", "PS3", "2011", "Sports", "Electronic Arts", "1.88", "0.15", "0.00", "0.16"},
            {
                "Pro Evolution Soccer 2012", "PS3", "2011", "Sports", "Konami Digital Entertainment", "0.33", "0.96",
                "0.55", "0.33"
            },
            {"Dead Island", "PS3", "2011", "Action", "Deep Silver", "1.02", "0.67", "0.15", "0.29"},
            {"Star Wars: The Force Unleashed", "PS3", "2008", "Action", "LucasArts", "0.98", "0.78", "0.00", "0.35"},
            {"LEGO Star Wars: The Complete Saga", "PS3", "2007", "Action", "LucasArts", "0.94", "0.80", "0.00", "0.36"},
            {
                "PES 2009: Pro Evolution Soccer", "PS3", "2008", "Sports", "Konami Digital Entertainment", "0.11", "1.33",
                "0.40", "0.26"
            },
            {"Sonic's Ultimate Genesis Collection", "PS3", "2009", "Misc", "Sega", "1.23", "0.57", "0.00", "0.28"},
            {"NBA 2K12", "PS3", "2011", "Sports", "Take-Two Interactive", "1.57", "0.26", "0.05", "0.17"},
            {"Hitman: Absolution", "PS3", "2012", "Action", "Square Enix", "0.54", "1.01", "0.07", "0.44"},
            {
                "Batman: Arkham Origins", "PS3", "2013", "Action", "Warner Bros. Interactive Entertainment", "0.90", "0.69",
                "0.04", "0.42"
            },
            {
                "God of War: Ascension", "PS3", "2013", "Action", "Sony Computer Entertainment", "1.10", "0.57", "0.04",
                "0.31"
            },
            {"Need For Speed: Undercover", "PS3", "2008", "Racing", "Electronic Arts", "0.62", "0.97", "0.05", "0.39"},
            {"Borderlands 2", "PS3", "2012", "Shooter", "Take-Two Interactive", "0.93", "0.66", "0.10", "0.33"},
            {"Need for Speed: ProStreet", "PS3", "2007", "Racing", "Electronic Arts", "0.71", "0.90", "0.04", "0.37"},
            {"Borderlands", "PS3", "2009", "Shooter", "Take-Two Interactive", "1.14", "0.58", "0.00", "0.28"},
            {
                "Grand Theft Auto: Episodes from Liberty City", "PS3", "2010", "Adventure", "Take-Two Interactive", "0.55",
                "0.93", "0.13", "0.35"
            },
            {"Need for Speed: The Run", "PS3", "2011", "Racing", "Electronic Arts", "0.55", "1.01", "0.03", "0.36"},
            {"Dead Space", "PS3", "2008", "Action", "Electronic Arts", "1.02", "0.64", "0.00", "0.29"},
            {"Dark Souls", "PS3", "2011", "Role-Playing", "Namco Bandai Games", "0.69", "0.47", "0.54", "0.22"},
            {"Burnout Paradise", "PS3", "2008", "Racing", "Electronic Arts", "0.98", "0.61", "0.02", "0.30"},
            {"Madden NFL 09", "PS3", "2008", "Sports", "Electronic Arts", "1.55", "0.14", "0.00", "0.18"},
            {"Guitar Hero: World Tour", "PS3", "2008", "Misc", "Activision", "1.07", "0.54", "0.00", "0.27"},
            {"NBA 2K14", "PS3", "2013", "Sports", "Take-Two Interactive", "1.31", "0.28", "0.04", "0.23"},
            {"Mortal Kombat vs DC Universe", "PS3", "2008", "Fighting", "Midway Games", "1.38", "0.27", "0.00", "0.19"},
            {
                "Ratchet & Clank Future: A Crack in Time", "PS3", "2009", "Platform", "Sony Computer Entertainment", "1.02",
                "0.51", "0.03", "0.25"
            },
            {"Skate 3", "PS3", "2010", "Sports", "Electronic Arts", "0.71", "0.76", "0.00", "0.33"},
            {"Max Payne 3", "PS3", "2012", "Shooter", "Take-Two Interactive", "0.54", "0.85", "0.06", "0.32"},
            {"The Sims 3", "PS3", "2010", "Simulation", "Electronic Arts", "0.68", "0.75", "0.02", "0.32"},
            {"Demon's Souls", "PS3", "2009", "Role-Playing", "Namco Bandai Games", "0.92", "0.31", "0.35", "0.18"},
            {"FIFA Soccer 08", "PS3", "2007", "Sports", "Electronic Arts", "0.35", "1.06", "0.02", "0.32"},
            {"NBA 2K11", "PS3", "2010", "Sports", "Take-Two Interactive", "1.37", "0.20", "0.03", "0.15"},
            {"UFC 2009 Undisputed", "PS3", "2009", "Fighting", "THQ", "1.05", "0.44", "0.01", "0.24"},
            {"inFAMOUS 2", "PS3", "2011", "Action", "Sony Computer Entertainment", "0.99", "0.45", "0.08", "0.22"},
            {"Just Cause 2", "PS3", "2010", "Action", "Square Enix", "0.41", "0.89", "0.06", "0.32"},
            {"Dragon's Dogma", "PS3", "2012", "Adventure", "Capcom", "0.34", "0.42", "0.72", "0.19"},
            {"Saints Row 2", "PS3", "2008", "Action", "THQ", "0.87", "0.53", "0.02", "0.25"},
            {"Fight Night Round 3", "PS3", "2006", "Fighting", "Electronic Arts", "0.80", "0.58", "0.01", "0.26"},
            {"Portal 2", "PS3", "2011", "Shooter", "Valve", "0.79", "0.57", "0.02", "0.25"},
            {"Heavenly Sword", "PS3", "2007", "Action", "Sony Computer Entertainment", "0.56", "0.71", "0.06", "0.29"},
            {"Diablo III", "PS3", "2013", "Role-Playing", "Activision", "0.53", "0.61", "0.13", "0.34"},
            {"Dragon Age: Origins", "PS3", "2009", "Role-Playing", "Electronic Arts", "0.92", "0.40", "0.08", "0.21"},
            {"Rock Band", "PS3", "N/A", "Misc", "Electronic Arts", "0.97", "0.40", "0.00", "0.21"},
            {
                "Pro Evolution Soccer 2008", "PS3", "2007", "Sports", "Konami Digital Entertainment", "0.04", "1.10",
                "0.32", "0.13"
            },
            {"Madden NFL 25", "PS3", "2013", "Sports", "Electronic Arts", "1.46", "0.03", "0.00", "0.10"},
            {"Watch Dogs", "PS3", "2014", "Action", "Ubisoft", "0.41", "0.67", "0.08", "0.39"},
            {"Devil May Cry 4", "PS3", "2008", "Action", "Capcom", "0.56", "0.44", "0.34", "0.21"},
            {
                "Beyond: Two Souls", "PS3", "2013", "Adventure", "Sony Computer Entertainment", "0.42", "0.67", "0.06",
                "0.39"
            },
            {
                "Pro Evolution Soccer 2013", "PS3", "2012", "Sports", "Konami Digital Entertainment", "0.17", "0.61",
                "0.49", "0.26"
            },
            {"BioShock Infinite", "PS3", "2013", "Shooter", "Take-Two Interactive", "0.60", "0.58", "0.04", "0.29"},
            {"BioShock 2", "PS3", "2010", "Shooter", "Take-Two Interactive", "0.82", "0.45", "0.02", "0.21"},
            {"Fight Night Round 4", "PS3", "2009", "Fighting", "Electronic Arts", "0.91", "0.38", "0.00", "0.20"},
            {"Call of Duty 3", "PS3", "2006", "Shooter", "Activision", "0.57", "0.61", "0.03", "0.26"},
            {"Rock Band 2", "PS3", "2008", "Misc", "MTV Games", "1.11", "0.20", "0.00", "0.15"},
            {"Resistance 3", "PS3", "2011", "Shooter", "Sony Computer Entertainment", "0.62", "0.54", "0.05", "0.22"},
            {"SoulCalibur IV", "PS3", "2008", "Fighting", "Ubisoft", "0.71", "0.39", "0.14", "0.20"},
            {"Mafia II", "PS3", "2010", "Action", "Take-Two Interactive", "0.46", "0.66", "0.04", "0.25"},
            {"Dishonored", "PS3", "2012", "Shooter", "Bethesda Softworks", "0.65", "0.48", "0.04", "0.24"},
            {"Sonic Generations", "PS3", "2011", "Platform", "Sega", "0.50", "0.63", "0.02", "0.26"},
            {
                "Lego Marvel Super Heroes", "PS3", "2013", "Action", "Warner Bros. Interactive Entertainment", "0.52",
                "0.56", "0.00", "0.33"
            },
            {"Mass Effect 2", "PS3", "2011", "Role-Playing", "Electronic Arts", "0.75", "0.42", "0.03", "0.19"},
            {"Star Wars: The Force Unleashed II", "PS3", "2010", "Action", "LucasArts", "0.75", "0.44", "0.00", "0.20"},
            {"UFC Undisputed 2010", "PS3", "2010", "Fighting", "THQ", "0.79", "0.39", "0.02", "0.18"},
            {"Kingdom Hearts", "PS3", "2013", "Role-Playing", "Square Enix", "0.64", "0.31", "0.25", "0.19"},
            {"Dead Space 2", "PS3", "2011", "Shooter", "Electronic Arts", "0.70", "0.47", "0.00", "0.20"},
            {"Far Cry 2", "PS3", "2008", "Shooter", "Ubisoft", "0.41", "0.67", "0.01", "0.27"},
            {"BioShock", "PS3", "2008", "Shooter", "Take-Two Interactive", "0.72", "0.44", "0.01", "0.20"},
            {
                "Ni no Kuni: Wrath of the White Witch", "PS3", "2011", "Role-Playing", "Namco Bandai Games", "0.50", "0.43",
                "0.21", "0.22"
            },
            {"Ridge Racer 7", "PS3", "2006", "Racing", "Namco Bandai Games", "0.24", "0.69", "0.16", "0.26"},
            {"Medal of Honor: Warfighter", "PS3", "2012", "Action", "Electronic Arts", "0.42", "0.59", "0.06", "0.27"},
            {"Dead Rising 2", "PS3", "2010", "Action", "Capcom", "0.41", "0.55", "0.15", "0.21"},
            {"Mass Effect 3", "PS3", "2012", "Role-Playing", "Electronic Arts", "0.58", "0.53", "0.03", "0.20"},
            {"Deus Ex: Human Revolution", "PS3", "2011", "Shooter", "Square Enix", "0.47", "0.57", "0.07", "0.22"},
            {"Tom Clancy's Rainbow Six: Vegas 2", "PS3", "2008", "Shooter", "Ubisoft", "0.64", "0.44", "0.04", "0.20"},
            {
                "MotorStorm: Pacific Rift", "PS3", "2008", "Racing", "Sony Computer Entertainment", "0.41", "0.64", "0.02",
                "0.25"
            },
            {"WWE '13", "PS3", "2012", "Action", "THQ", "0.48", "0.57", "0.00", "0.26"},
            {"F1 2010", "PS3", "2010", "Racing", "Codemasters", "0.23", "0.74", "0.08", "0.26"},
            {
                "Marvel vs. Capcom 3: Fate of Two Worlds", "PS3", "2011", "Fighting", "Capcom", "0.79", "0.27", "0.11",
                "0.14"
            },
            {
                "MAG: Massive Action Game", "PS3", "2010", "Shooter", "Sony Computer Entertainment", "0.76", "0.29", "0.09",
                "0.16"
            },
            {"WWE SmackDown vs Raw 2008", "PS3", "2007", "Fighting", "THQ", "0.61", "0.49", "0.01", "0.20"},
            {"Battlefield: Bad Company", "PS3", "2008", "Shooter", "Electronic Arts", "0.74", "0.34", "0.05", "0.18"},
            {
                "Metal Gear Rising: Revengeance", "PS3", "2013", "Action", "Konami Digital Entertainment", "0.37", "0.32",
                "0.44", "0.16"
            },
            {"Rage", "PS3", "2011", "Shooter", "Bethesda Softworks", "0.45", "0.56", "0.06", "0.20"},
            {
                "SOCOM: U.S. Navy SEALs Confrontation", "PS3", "2008", "Shooter", "Sony Computer Entertainment", "0.94",
                "0.16", "0.02", "0.13"
            },
            {"Crysis 2", "PS3", "2011", "Shooter", "Electronic Arts", "0.42", "0.54", "0.06", "0.21"},
            {"Tomb Raider: Underworld", "PS3", "2008", "Adventure", "Eidos Interactive", "0.44", "0.53", "0.05", "0.22"},
            {"Tom Clancy's Rainbow Six: Vegas", "PS3", "2007", "Shooter", "Ubisoft", "0.46", "0.52", "0.03", "0.22"},
            {"Valkyria Chronicles", "PS3", "2008", "Role-Playing", "Sega", "0.68", "0.17", "0.24", "0.12"},
            {"[Prototype]", "PS3", "2009", "Action", "Activision", "0.63", "0.40", "0.00", "0.18"},
            {
                "LEGO Harry Potter: Years 1-4", "PS3", "2010", "Adventure", "Warner Bros. Interactive Entertainment",
                "0.51", "0.49", "0.00", "0.21"
            },
            {
                "LEGO Batman: The Videogame", "PS3", "2008", "Adventure", "Warner Bros. Interactive Entertainment", "0.67",
                "0.36", "0.00", "0.17"
            },
            {"Need for Speed Rivals", "PS3", "2013", "Racing", "Electronic Arts", "0.22", "0.60", "0.04", "0.34"},
            {
                "2010 FIFA World Cup South Africa", "PS3", "2010", "Sports", "Electronic Arts", "0.28", "0.63", "0.07",
                "0.22"
            },
            {
                "Naruto Shippuden: Ultimate Ninja Storm 2", "PS3", "2010", "Fighting", "Namco Bandai Games", "0.40", "0.45",
                "0.15", "0.18"
            },
            {"F1 2011", "PS3", "2011", "Racing", "Codemasters", "0.10", "0.73", "0.11", "0.24"},
            {
                "The ICO & Shadow of the Colossus Collection", "PS3", "2011", "Adventure", "Sony Computer Entertainment",
                "0.59", "0.31", "0.13", "0.15"
            },
            {"Need for Speed Carbon", "PS3", "2006", "Racing", "Electronic Arts", "0.47", "0.47", "0.03", "0.21"},
            {"Medal of Honor: Airborne", "PS3", "2007", "Shooter", "Electronic Arts", "0.23", "0.68", "0.03", "0.25"},
            {"Bayonetta", "PS3", "2009", "Action", "Sega", "0.42", "0.38", "0.21", "0.17"},
            {"One Piece Pirate Musou", "PS3", "2012", "Action", "Namco Bandai Games", "0.01", "0.22", "0.86", "0.09"},
            {"Tales of Xillia", "PS3", "2011", "Role-Playing", "Namco Bandai Games", "0.26", "0.16", "0.67", "0.09"},
            {"FIFA Street", "PS3", "2012", "Sports", "Electronic Arts", "0.09", "0.83", "0.00", "0.25"},
            {"WWE SmackDown vs. Raw 2010", "PS3", "2009", "Fighting", "THQ", "0.47", "0.47", "0.01", "0.20"},
            {"Army of Two", "PS3", "2008", "Shooter", "Electronic Arts", "0.72", "0.25", "0.02", "0.15"},
            {"WWE '12", "PS3", "2011", "Fighting", "THQ", "0.51", "0.44", "0.02", "0.17"},
            {
                "Resident Evil: Operation Raccoon City", "PS3", "2012", "Shooter", "Capcom", "0.46", "0.23", "0.36", "0.09"
            },
            {"Sonic the Hedgehog", "PS3", "2006", "Platform", "Sega", "0.39", "0.05", "0.04", "0.66"},
            {"Ninja Gaiden Sigma", "PS3", "2007", "Action", "Eidos Interactive", "0.56", "0.32", "0.09", "0.16"},
            {
                "Hot Shots Golf: Out of Bounds", "PS3", "2007", "Sports", "Sony Computer Entertainment", "0.30", "0.03",
                "0.76", "0.04"
            },
            {"007: Quantum of Solace", "PS3", "2008", "Action", "Activision", "0.42", "0.49", "0.02", "0.19"},
            {"Mirror's Edge", "PS3", "2008", "Action", "Electronic Arts", "0.29", "0.57", "0.02", "0.23"},
            {
                "Final Fantasy X / X-2 HD Remaster", "PS3", "2013", "Role-Playing", "Square Enix", "0.33", "0.29", "0.31",
                "0.18"
            },
            {
                "LEGO Batman 2: DC Super Heroes", "PS3", "2012", "Action", "Warner Bros. Interactive Entertainment", "0.44",
                "0.47", "0.00", "0.20"
            },
            {"Saints Row IV", "PS3", "2013", "Action", "Deep Silver", "0.47", "0.36", "0.08", "0.19"},
            {"WWE 2K14", "PS3", "2013", "Sports", "Take-Two Interactive", "0.43", "0.41", "0.00", "0.25"},
            {"SingStar", "PS3", "2007", "Misc", "Sony Computer Entertainment", "0.43", "0.53", "0.00", "0.13"},
            {
                "Pro Evolution Soccer 2014", "PS3", "2013", "Action", "Konami Digital Entertainment", "0.02", "0.38",
                "0.50", "0.19"
            },
            {
                "Ratchet & Clank: All 4 One", "PS3", "2011", "Platform", "Sony Computer Entertainment", "0.72", "0.21",
                "0.05", "0.11"
            },
            {"The Beatles: Rock Band", "PS3", "2009", "Misc", "MTV Games", "0.66", "0.28", "0.00", "0.15"},
            {"Yakuza 3", "PS3", "2009", "Adventure", "Sega", "0.19", "0.19", "0.62", "0.08"},
            {"GRID", "PS3", "2008", "Racing", "Codemasters", "0.30", "0.55", "0.03", "0.20"},
            {"ModNation Racers", "PS3", "2010", "Racing", "Sony Computer Entertainment", "0.47", "0.38", "0.06", "0.16"},
            {
                "Injustice: Gods Among Us", "PS3", "2013", "Fighting", "Warner Bros. Interactive Entertainment", "0.40",
                "0.44", "0.01", "0.23"
            },
            {"Dark Souls II", "PS3", "2014", "Action", "Namco Bandai Games", "0.29", "0.27", "0.35", "0.16"},
            {"Virtua Fighter 5", "PS3", "2007", "Fighting", "Sega", "0.28", "0.51", "0.08", "0.20"},
            {"WWE SmackDown vs. Raw 2011", "PS3", "2010", "Fighting", "THQ", "0.43", "0.45", "0.01", "0.18"},
            {"LEGO Star Wars III: The Clone Wars", "PS3", "2011", "Action", "LucasArts", "0.47", "0.41", "0.00", "0.18"},
            {
                "Red Dead Redemption: Undead Nightmare", "PS3", "2010", "Action", "Take-Two Interactive", "0.40", "0.43",
                "0.06", "0.17"
            },
            {"Fight Night Champion", "PS3", "2011", "Fighting", "Electronic Arts", "0.42", "0.46", "0.00", "0.19"},
            {"Guitar Hero 5", "PS3", "2009", "Misc", "Activision", "0.51", "0.38", "0.00", "0.17"},
            {"Rocksmith", "PS3", "2011", "Misc", "Ubisoft", "0.48", "0.32", "0.09", "0.17"},
            {"Prince of Persia", "PS3", "2008", "Adventure", "Ubisoft", "0.46", "0.39", "0.03", "0.18"},
            {"Dante's Inferno", "PS3", "2010", "Action", "Electronic Arts", "0.62", "0.27", "0.04", "0.12"},
            {
                "Naruto: Ultimate Ninja Storm", "PS3", "2008", "Fighting", "Namco Bandai Games", "0.47", "0.33", "0.09",
                "0.15"
            },
            {"DiRT", "PS3", "2007", "Racing", "Codemasters", "0.16", "0.66", "0.00", "0.23"},
            {"Virtua Tennis 3", "PS3", "2007", "Sports", "Sega", "0.22", "0.58", "0.03", "0.22"},
            {"Warhawk", "PS3", "2007", "Simulation", "Sony Computer Entertainment", "0.48", "0.39", "0.00", "0.17"},
            {
                "Castlevania: Lords of Shadow", "PS3", "2010", "Action", "Konami Digital Entertainment", "0.45", "0.33",
                "0.10", "0.15"
            },
            {"The Orange Box", "PS3", "2007", "Shooter", "Electronic Arts", "0.26", "0.56", "0.00", "0.21"},
            {"F1 2012", "PS3", "2012", "Racing", "Codemasters", "0.11", "0.61", "0.05", "0.26"},
            {"DiRT 3", "PS3", "2011", "Racing", "Codemasters", "0.25", "0.55", "0.01", "0.21"},
            {
                "Tom Clancy's Ghost Recon Advanced Warfighter 2", "PS3", "2007", "Shooter", "Ubisoft", "0.34", "0.48",
                "0.02", "0.19"
            },
            {
                "Omerta: City of Gangsters", "PS3", "2011", "Simulation", "Konami Digital Entertainment", "0.48", "0.39",
                "0.00", "0.16"
            },
            {"Aliens vs Predator", "PS3", "2010", "Shooter", "Sega", "0.39", "0.45", "0.00", "0.18"},
            {"Destiny", "PS3", "2014", "Action", "Activision", "0.39", "0.32", "0.10", "0.20"},
            {
                "Toy Story 3: The Video Game", "PS3", "2010", "Action", "Disney Interactive Studios", "0.47", "0.38",
                "0.00", "0.16"
            },
            {"UFC Undisputed 3", "PS3", "2012", "Fighting", "THQ", "0.53", "0.31", "0.03", "0.13"},
            {"Sonic Unleashed", "PS3", "2008", "Platform", "Sega", "0.54", "0.31", "0.01", "0.14"},
            {"Sleeping Dogs", "PS3", "2012", "Action", "Square Enix", "0.28", "0.47", "0.05", "0.19"},
            {
                "LEGO Indiana Jones: The Original Adventures", "PS3", "2008", "Adventure", "Activision", "0.42", "0.40",
                "0.00", "0.17"
            },
            {"Haze", "PS3", "2008", "Shooter", "Ubisoft", "0.49", "0.32", "0.02", "0.15"},
            {"DiRT 2", "PS3", "2009", "Racing", "Codemasters", "0.26", "0.51", "0.00", "0.20"},
            {
                "LEGO The Lord of the Rings", "PS3", "2012", "Action", "Warner Bros. Interactive Entertainment", "0.32",
                "0.44", "0.00", "0.21"
            },
            {
                "Lightning Returns: Final Fantasy XIII", "PS3", "2013", "Role-Playing", "Square Enix", "0.23", "0.18",
                "0.44", "0.11"
            },
            {"Madden NFL 08", "PS3", "2007", "Sports", "Electronic Arts", "0.88", "0.00", "0.00", "0.07"},
            {"Skylanders Giants", "PS3", "2012", "Action", "Activision", "0.29", "0.46", "0.00", "0.21"},
            {"Rayman Origins", "PS3", "2011", "Platform", "Ubisoft", "0.31", "0.46", "0.01", "0.18"},
            {"Guitar Hero: Aerosmith", "PS3", "2008", "Misc", "Activision", "0.70", "0.15", "0.00", "0.10"},
            {"EyePet", "PS3", "2009", "Simulation", "Sony Computer Entertainment", "0.31", "0.51", "0.04", "0.08"},
            {"WWE SmackDown vs. Raw 2009", "PS3", "2008", "Fighting", "THQ", "0.49", "0.29", "0.01", "0.12"},
            {"Yakuza 4", "PS3", "N/A", "Adventure", "Sega", "0.13", "0.11", "0.63", "0.05"},
            {"Lost Planet 2", "PS3", "2010", "Shooter", "Capcom", "0.27", "0.32", "0.20", "0.13"},
            {"SingStar Abba", "PS3", "2008", "Misc", "Sony Computer Entertainment", "0.26", "0.49", "0.00", "0.17"},
            {"Sniper Elite V2", "PS3", "2012", "Shooter", "505 Games", "0.35", "0.36", "0.06", "0.15"},
            {
                "Final Fantasy XIV: A Realm Reborn", "PS3", "2013", "Role-Playing", "Square Enix", "0.27", "0.24", "0.27",
                "0.13"
            },
            {"Driver: San Francisco", "PS3", "2011", "Racing", "Ubisoft", "0.22", "0.49", "0.01", "0.18"},
            {"Tales of Graces f", "PS3", "2010", "Role-Playing", "Namco Bandai Games", "0.26", "0.15", "0.43", "0.08"},
            {"Brutal Legend", "PS3", "2009", "Action", "Electronic Arts", "0.52", "0.26", "0.00", "0.13"},
            {
                "Tom Clancy's Ghost Recon: Future Soldier", "PS3", "2012", "Shooter", "Ubisoft", "0.38", "0.31", "0.09",
                "0.11"
            },
            {"Skylanders SWAP Force", "PS3", "2013", "Platform", "Activision", "0.31", "0.37", "0.00", "0.22"},
            {"Brothers in Arms: Hell's Highway", "PS3", "2008", "Shooter", "Ubisoft", "0.42", "0.33", "0.00", "0.15"},
            {"Buzz! Quiz World", "PS3", "2009", "Misc", "Sony Computer Entertainment", "0.14", "0.56", "0.00", "0.20"},
            {
                "Tom Clancy's Splinter Cell: Blacklist", "PS3", "2013", "Action", "Ubisoft", "0.30", "0.36", "0.05", "0.19"
            },
            {
                "Operation Flashpoint: Dragon Rising", "PS3", "2009", "Shooter", "Codemasters", "0.23", "0.45", "0.05",
                "0.17"
            },
            {"Dead Space 3", "PS3", "2013", "Shooter", "Electronic Arts", "0.39", "0.33", "0.00", "0.17"},
            {
                "White Knight Chronicles: International Edition", "PS3", "2008", "Role-Playing",
                "Sony Computer Entertainment", "0.30", "0.16", "0.36", "0.08"
            },
            {"James Cameron's Avatar: The Game", "PS3", "2009", "Action", "Ubisoft", "0.31", "0.41", "0.00", "0.16"},
            {"Homefront", "PS3", "2011", "Shooter", "THQ", "0.31", "0.39", "0.04", "0.15"},
            {"MLB 12: The Show", "PS3", "2012", "Sports", "Sony Computer Entertainment", "0.83", "0.00", "0.00", "0.05"},
            {"Sonic & SEGA All-Stars Racing", "PS3", "2010", "Racing", "Sega", "0.32", "0.40", "0.00", "0.16"},
            {"Dynasty Warriors 7", "PS3", "2011", "Action", "Tecmo Koei", "0.23", "0.12", "0.46", "0.06"},
            {"EA Sports Active 2", "PS3", "2010", "Sports", "Electronic Arts", "0.50", "0.26", "0.00", "0.12"},
            {
                "LEGO Pirates of the Caribbean: The Video Game", "PS3", "2011", "Action", "Disney Interactive Studios",
                "0.33", "0.38", "0.00", "0.16"
            },
            {"SSX", "PS3", "2012", "Sports", "Electronic Arts", "0.32", "0.39", "0.02", "0.14"},
            {
                "PlayStation All-Stars Battle Royale", "PS3", "2012", "Action", "Sony Computer Entertainment", "0.45",
                "0.24", "0.04", "0.13"
            },
            {"DJ Hero", "PS3", "2009", "Misc", "Activision", "0.41", "0.32", "0.00", "0.14"},
            {"Pure", "PS3", "2008", "Racing", "Disney Interactive Studios", "0.40", "0.32", "0.00", "0.14"},
            {"Buzz! Quiz TV", "PS3", "2008", "Misc", "Sony Computer Entertainment", "0.27", "0.46", "0.00", "0.13"},
            {"MX vs. ATV Reflex", "PS3", "2009", "Racing", "THQ", "0.50", "0.24", "0.00", "0.12"},
            {"The Simpsons Game", "PS3", "2007", "Action", "Electronic Arts", "0.37", "0.34", "0.00", "0.15"},
            {"Call of Juarez: Bound in Blood", "PS3", "2009", "Shooter", "Ubisoft", "0.33", "0.37", "0.01", "0.15"},
            {"Beijing 2008", "PS3", "2008", "Sports", "Sega", "0.13", "0.53", "0.01", "0.18"},
            {
                "Naruto Shippuden: Ultimate Ninja Storm 3", "PS3", "2013", "Fighting", "Namco Bandai Games", "0.27", "0.29",
                "0.15", "0.14"
            },
            {
                "Tiger Woods PGA Tour 12: The Masters", "PS3", "2011", "Sports", "Electronic Arts", "0.50", "0.24", "0.00",
                "0.11"
            },
            {
                "LEGO Indiana Jones 2: The Adventure Continues", "PS3", "2009", "Adventure", "Activision", "0.45", "0.27",
                "0.00", "0.13"
            },
            {
                "Mercenaries 2: World in Flames", "PS3", "2008", "Shooter", "Electronic Arts", "0.28", "0.39", "0.02",
                "0.16"
            },
            {
                "SOCOM 4: U.S. Navy SEALs", "PS3", "2011", "Shooter", "Sony Computer Entertainment", "0.62", "0.10", "0.04",
                "0.07"
            },
            {"Skylanders: Spyro's Adventure", "PS3", "2011", "Action", "Activision", "0.31", "0.38", "0.00", "0.15"},
            {"Dragon Ball Z: Burst Limit", "PS3", "2008", "Fighting", "Atari", "0.21", "0.33", "0.18", "0.12"},
            {"Disney Infinity", "PS3", "2013", "Action", "Disney Interactive Studios", "0.41", "0.26", "0.00", "0.16"},
            {"Ninja Gaiden Sigma 2", "PS3", "2009", "Action", "Ubisoft Annecy", "0.51", "0.15", "0.08", "0.09"},
            {"NBA 2K10", "PS3", "2009", "Sports", "Take-Two Interactive", "0.74", "0.01", "0.01", "0.07"},
            {"Crysis 3", "PS3", "2013", "Shooter", "Electronic Arts", "0.23", "0.39", "0.03", "0.18"},
            {"Time Crisis 4", "PS3", "2007", "Shooter", "Namco Bandai Games", "0.31", "0.32", "0.05", "0.14"},
            {"NCAA Football 11", "PS3", "2010", "Sports", "Electronic Arts", "0.77", "0.00", "0.00", "0.05"},
            {"NCAA Football 13", "PS3", "2012", "Action", "Electronic Arts", "0.78", "0.00", "0.00", "0.04"},
            {"Army of Two: The 40th Day", "PS3", "2010", "Shooter", "Electronic Arts", "0.42", "0.26", "0.01", "0.12"},
            {
                "Ghostbusters: The Video Game", "PS3", "2009", "Action", "Sony Computer Entertainment", "0.33", "0.35",
                "0.00", "0.14"
            },
            {"Skate 2", "PS3", "2009", "Sports", "Electronic Arts", "0.45", "0.24", "0.01", "0.12"},
            {"Tiger Woods PGA Tour 11", "PS3", "2010", "Sports", "Electronic Arts", "0.36", "0.32", "0.00", "0.13"},
            {
                "LEGO Harry Potter: Years 5-7", "PS3", "N/A", "Action", "Warner Bros. Interactive Entertainment", "0.32",
                "0.35", "0.00", "0.15"
            },
            {"The Tomb Raider Trilogy", "PS3", "2011", "Action", "Square Enix", "0.23", "0.42", "0.00", "0.16"},
            {"Darksiders II", "PS3", "2012", "Action", "THQ", "0.32", "0.34", "0.01", "0.14"},
            {
                "Kingdoms of Amalur: Reckoning", "PS3", "2012", "Role-Playing", "Electronic Arts", "0.34", "0.27", "0.09",
                "0.11"
            },
            {"Tekken Tag Tournament 2", "PS3", "2012", "Fighting", "Namco Bandai Games", "0.25", "0.28", "0.13", "0.14"},
            {"NCAA Football 10", "PS3", "2009", "Sports", "Electronic Arts", "0.74", "0.00", "0.00", "0.06"},
            {"NCAA Football 12", "PS3", "2011", "Sports", "Electronic Arts", "0.75", "0.00", "0.00", "0.04"},
            {
                "The Jak and Daxter Collection", "PS3", "2012", "Platform", "Sony Computer Entertainment", "0.54", "0.16",
                "0.00", "0.09"
            },
            {"SingStar Vol. 2", "PS3", "2008", "Misc", "Sony Computer Entertainment", "0.28", "0.38", "0.00", "0.12"},
            {"Guitar Hero: Warriors of Rock", "PS3", "2010", "Misc", "Activision", "0.31", "0.34", "0.00", "0.13"},
            {"DMC", "PS3", "2013", "Action", "Capcom", "0.22", "0.25", "0.19", "0.12"},
            {
                "The Lord of the Rings: War in the North", "PS3", "N/A", "Action", "Warner Bros. Interactive Entertainment",
                "0.23", "0.38", "0.01", "0.15"
            },
            {"Tiger Woods PGA Tour 10", "PS3", "2009", "Sports", "Electronic Arts", "0.41", "0.25", "0.00", "0.12"},
            {"Dragon Age II", "PS3", "2011", "Role-Playing", "Electronic Arts", "0.37", "0.24", "0.05", "0.11"},
            {"Street Fighter X Tekken", "PS3", "2012", "Fighting", "Capcom", "0.37", "0.20", "0.10", "0.09"},
            {"Madden NFL 15", "PS3", "2014", "Sports", "Electronic Arts", "0.66", "0.04", "0.00", "0.06"},
            {
                "LittleBigPlanet Karting", "PS3", "2012", "Action", "Sony Computer Entertainment", "0.34", "0.27", "0.01",
                "0.13"
            },
            {
                "Sid Meier's Civilization Revolution", "PS3", "2008", "Strategy", "Take-Two Interactive", "0.47", "0.18",
                "0.01", "0.09"
            },
            {"Kane & Lynch: Dead Men", "PS3", "2007", "Shooter", "Eidos Interactive", "0.28", "0.32", "0.01", "0.13"},
            {
                "Genji: Days of the Blade", "PS3", "2006", "Action", "Sony Computer Entertainment", "0.18", "0.37", "0.06",
                "0.14"
            },
            {
                "Dragon Ball: Raging Blast", "PS3", "2009", "Fighting", "Namco Bandai Games", "0.35", "0.18", "0.11",
                "0.09"
            },
            {"Duke Nukem Forever", "PS3", "2011", "Shooter", "Take-Two Interactive", "0.32", "0.29", "0.00", "0.12"},
            {
                "X-Men Origins: Wolverine - Uncaged Edition", "PS3", "2009", "Action", "Activision", "0.31", "0.30", "0.00",
                "0.13"
            },
            {
                "Dragon Ball: Raging Blast 2", "PS3", "2010", "Fighting", "Namco Bandai Games", "0.38", "0.16", "0.11",
                "0.08"
            },
            {"NCAA Football 14", "PS3", "2013", "Sports", "Electronic Arts", "0.69", "0.00", "0.00", "0.04"},
            {"Goldeneye 007: Reloaded", "PS3", "2011", "Shooter", "Activision", "0.30", "0.31", "0.00", "0.12"},
            {"Tiger Woods PGA Tour 08", "PS3", "2007", "Sports", "Electronic Arts", "0.21", "0.37", "0.00", "0.14"},
            {
                "Twisted Metal (2012)", "PS3", "2012", "Action", "Sony Computer Entertainment", "0.61", "0.06", "0.00",
                "0.06"
            },
            {"The Godfather II", "PS3", "2009", "Action", "Electronic Arts", "0.40", "0.21", "0.01", "0.11"},
            {
                "The Lord of the Rings: Conquest", "PS3", "2009", "Action", "Electronic Arts", "0.37", "0.24", "0.00",
                "0.12"
            },
            {"Red Faction: Guerrilla", "PS3", "2009", "Shooter", "THQ", "0.32", "0.26", "0.02", "0.12"},
            {"Devil May Cry HD Collection", "PS3", "2012", "Action", "Capcom", "0.37", "0.16", "0.11", "0.08"},
            {"South Park: The Stick of Truth", "PS3", "2014", "Role-Playing", "Ubisoft", "0.30", "0.26", "0.00", "0.16"},
            {"Sniper: Ghost Warrior", "PS3", "2011", "Shooter", "City Interactive", "0.22", "0.33", "0.04", "0.13"},
            {
                "Pirates of the Caribbean: At World's End", "PS3", "2007", "Action", "Disney Interactive Studios", "0.16",
                "0.41", "0.00", "0.15"
            },
            {"Band Hero", "PS3", "2009", "Misc", "Activision", "0.39", "0.22", "0.00", "0.10"},
            {"Marvel: Ultimate Alliance 2", "PS3", "2009", "Role-Playing", "Activision", "0.48", "0.15", "0.00", "0.09"},
            {
                "Naruto Shippuden: Ultimate Ninja STORM Generations", "PS3", "2012", "Fighting", "Namco Bandai Games",
                "0.26", "0.23", "0.14", "0.08"
            },
            {
                "Ace Combat: Assault Horizon", "PS3", "2011", "Action", "Namco Bandai Games", "0.28", "0.15", "0.22",
                "0.07"
            },
            {"Split/Second", "PS3", "2010", "Racing", "Disney Interactive Studios", "0.30", "0.29", "0.01", "0.12"},
            {"Resonance of Fate", "PS3", "2010", "Role-Playing", "Sega", "0.18", "0.21", "0.24", "0.08"},
            {"Brink", "PS3", "2011", "Shooter", "Bethesda Softworks", "0.27", "0.30", "0.01", "0.12"},
            {"SoulCalibur V", "PS3", "2012", "Fighting", "Namco Bandai Games", "0.32", "0.22", "0.07", "0.09"},
            {"MLB 09: The Show", "PS3", "2009", "Sports", "Sony Computer Entertainment", "0.65", "0.00", "0.00", "0.05"},
            {
                "The Amazing Spider-Man (Console Version)", "PS3", "2012", "Action", "Activision", "0.26", "0.32", "0.00",
                "0.13"
            },
            {"DJ Hero 2", "PS3", "2010", "Misc", "Activision", "0.43", "0.18", "0.00", "0.09"},
            {"Dynasty Warriors 6", "PS3", "2007", "Action", "Tecmo Koei", "0.18", "0.07", "0.41", "0.04"},
            {
                "The Walking Dead: A Telltale Games Series", "PS3", "2012", "Adventure", "Avanquest Software", "0.37",
                "0.19", "0.03", "0.11"
            },
            {"MLB 10: The Show", "PS3", "2010", "Sports", "Sony Computer Entertainment", "0.65", "0.00", "0.00", "0.05"},
            {"Blur", "PS3", "2010", "Racing", "Activision", "0.20", "0.34", "0.02", "0.13"},
            {"Tales of Xillia 2", "PS3", "2012", "Role-Playing", "Namco Bandai Games", "0.10", "0.09", "0.45", "0.05"},
            {"MLB 08: The Show", "PS3", "2008", "Sports", "Sony Computer Entertainment", "0.64", "0.00", "0.00", "0.05"},
            {"Prototype 2", "PS3", "2012", "Action", "Activision", "0.31", "0.26", "0.00", "0.10"},
            {"Resident Evil: Revelations", "PS3", "2013", "Action", "Capcom", "0.10", "0.25", "0.21", "0.12"},
            {"IL-2 Sturmovik: Birds of Prey", "PS3", "2009", "Simulation", "505 Games", "0.34", "0.24", "0.00", "0.10"},
            {
                "The LEGO Movie Videogame", "PS3", "2014", "Action", "Warner Bros. Interactive Entertainment", "0.23",
                "0.28", "0.00", "0.16"
            },
            {
                "Star Ocean: The Last Hope International", "PS3", "2010", "Role-Playing", "Square Enix", "0.25", "0.14",
                "0.22", "0.07"
            },
            {
                "Transformers: Revenge of the Fallen", "PS3", "2009", "Action", "Activision", "0.26", "0.29", "0.00",
                "0.12"
            },
            {"Iron Man", "PS3", "2008", "Action", "Sega", "0.32", "0.25", "0.00", "0.11"},
            {"Rocksmith 2014", "PS3", "2013", "Misc", "Ubisoft", "0.31", "0.19", "0.05", "0.12"},
            {"Spider-Man 3", "PS3", "2007", "Platform", "Activision", "0.26", "0.28", "0.02", "0.12"},
            {
                "Prince of Persia: The Forgotten Sands", "PS3", "2010", "Action", "Ubisoft", "0.18", "0.35", "0.01", "0.13"
            },
            {"James Bond 007: Blood Stone", "PS3", "2010", "Action", "Activision", "0.17", "0.34", "0.02", "0.13"},
            {"Top Spin 4", "PS3", "2011", "Sports", "Take-Two Interactive", "0.16", "0.36", "0.00", "0.14"},
            {"God of War Saga", "PS3", "2012", "Action", "Sony Computer Entertainment", "0.63", "0.00", "0.00", "0.04"},
            {"Turok", "PS3", "2008", "Shooter", "Touchstone", "0.34", "0.20", "0.01", "0.10"},
            {
                "Blazing Angels: Squadrons of WWII", "PS3", "2006", "Simulation", "Ubisoft", "0.34", "0.21", "0.00", "0.10"
            },
            {"Unreal Tournament III", "PS3", "2007", "Shooter", "Midway Games", "0.32", "0.23", "0.00", "0.11"},
            {
                "One Piece: Pirate Warriors 2", "PS3", "2013", "Action", "Namco Bandai Games", "0.00", "0.16", "0.42",
                "0.08"
            },
            {"Catherine", "PS3", "2011", "Adventure", "Deep Silver", "0.26", "0.13", "0.20", "0.06"},
            {"The Darkness", "PS3", "2007", "Shooter", "Take-Two Interactive", "0.19", "0.33", "0.00", "0.13"},
            {
                "London 2012: The Official Video Game of the Olympic Games", "PS3", "2012", "Sports", "Sega", "0.05",
                "0.46", "0.00", "0.15"
            },
            {"Tiger Woods PGA Tour 09", "PS3", "2008", "Sports", "Electronic Arts", "0.34", "0.21", "0.00", "0.10"},
            {
                "Fist of the North Star: Ken's Rage", "PS3", "2010", "Action", "Ubisoft Annecy", "0.05", "0.03", "0.55",
                "0.01"
            },
            {"F1 2013", "PS3", "2013", "Action", "Codemasters", "0.01", "0.40", "0.03", "0.21"},
            {"Shaun White Snowboarding", "PS3", "2008", "Sports", "Ubisoft", "0.30", "0.23", "0.01", "0.10"},
            {"MLB 13: The Show", "PS3", "2013", "Sports", "Sony Computer Entertainment", "0.60", "0.00", "0.00", "0.03"},
            {"NBA Live 08", "PS3", "2007", "Sports", "Electronic Arts", "0.55", "0.02", "0.01", "0.06"},
            {
                "Need for Speed: Shift 2 Unleashed", "PS3", "2011", "Racing", "Electronic Arts", "0.18", "0.33", "0.00",
                "0.13"
            },
            {"Book of Spells", "PS3", "2012", "Action", "Sony Computer Entertainment", "0.10", "0.37", "0.00", "0.16"},
            {"Sega Rally Revo", "PS3", "2007", "Racing", "Sega", "0.07", "0.42", "0.00", "0.14"},
            {"2014 FIFA World Cup Brazil", "PS3", "2014", "Sports", "Electronic Arts", "0.09", "0.34", "0.01", "0.19"},
            {"Sengoku Basara: Samurai Heroes", "PS3", "2010", "Action", "Capcom", "0.16", "0.04", "0.40", "0.02"},
            {"Lost Planet: Extreme Condition", "PS3", "2008", "Shooter", "Capcom", "0.30", "0.16", "0.07", "0.08"},
            {"Tom Clancy's EndWar", "PS3", "2008", "Strategy", "Ubisoft", "0.29", "0.22", "0.01", "0.10"},
            {
                "Formula 1: Championship Edition", "PS3", "2006", "Racing", "Sony Computer Entertainment", "0.00", "0.57",
                "0.04", "0.00"
            },
            {"Tony Hawk's Project 8", "PS3", "2006", "Sports", "Activision", "0.29", "0.22", "0.01", "0.10"},
            {"NHL 13", "PS3", "2012", "Sports", "Electronic Arts", "0.31", "0.20", "0.00", "0.11"},
            {"Warriors Orochi 3", "PS3", "2011", "Action", "Ubisoft Annecy", "0.00", "0.03", "0.57", "0.01"},
            {
                "Lollipop Chainsaw", "PS3", "2012", "Action", "Warner Bros. Interactive Entertainment", "0.24", "0.18",
                "0.11", "0.08"
            },
            {"NBA 2K9", "PS3", "2008", "Sports", "Take-Two Interactive", "0.56", "0.00", "0.00", "0.05"},
            {"Wolfenstein", "PS3", "2009", "Shooter", "Activision", "0.24", "0.27", "0.00", "0.11"},
            {
                "White Knight Chronicles II", "PS3", "2010", "Role-Playing", "Sony Computer Entertainment", "0.22", "0.08",
                "0.27", "0.04"
            },
            {"Test Drive Unlimited 2", "PS3", "N/A", "Racing", "Atari", "0.15", "0.32", "0.01", "0.12"},
            {"Guitar Hero: Metallica", "PS3", "2009", "Misc", "Activision", "0.27", "0.23", "0.00", "0.10"},
            {
                "Ratchet & Clank: Into the Nexus", "PS3", "2013", "Shooter", "Sony Computer Entertainment", "0.27", "0.21",
                "0.00", "0.13"
            },
            {"Wet", "PS3", "2009", "Shooter", "Bethesda Softworks", "0.22", "0.26", "0.01", "0.11"},
            {"Vanquish", "PS3", "2010", "Adventure", "Sega", "0.20", "0.21", "0.11", "0.08"},
            {"Sacred 2: Fallen Angel", "PS3", "2009", "Role-Playing", "Deep Silver", "0.21", "0.21", "0.08", "0.09"},
            {"Yakuza 5", "PS3", "2012", "Action", "Sega", "0.00", "0.00", "0.59", "0.00"},
            {"Start the Party!", "PS3", "2010", "Misc", "Sony Computer Entertainment", "0.06", "0.39", "0.00", "0.14"},
            {"Persona 4: Arena", "PS3", "2012", "Fighting", "Atlus", "0.20", "0.09", "0.24", "0.05"},
            {"Tony Hawk: RIDE", "PS3", "2009", "Sports", "Activision", "0.37", "0.13", "0.00", "0.07"},
            {"Disney Universe", "PS3", "2011", "Action", "Disney Interactive Studios", "0.29", "0.20", "0.00", "0.09"},
            {"Yakuza: Dead Souls", "PS3", "2011", "Shooter", "Sega", "0.08", "0.05", "0.42", "0.02"},
            {
                "Dragon Ball Z: Ultimate Tenkaichi", "PS3", "2011", "Fighting", "Namco Bandai Games", "0.25", "0.17",
                "0.09", "0.08"
            },
            {"NHL 11", "PS3", "2010", "Sports", "Electronic Arts", "0.39", "0.12", "0.00", "0.07"},
            {"NCAA Football 09", "PS3", "2008", "Sports", "Electronic Arts", "0.53", "0.00", "0.00", "0.04"},
            {"Aliens: Colonial Marines", "PS3", "2013", "Shooter", "Sega", "0.17", "0.27", "0.00", "0.13"},
            {"Kane & Lynch 2: Dog Days", "PS3", "2010", "Shooter", "Square Enix", "0.16", "0.27", "0.05", "0.10"},
            {"Dynasty Warriors 8", "PS3", "2013", "Action", "Tecmo Koei", "0.10", "0.08", "0.34", "0.05"},
            {
                "Ratchet & Clank Collection", "PS3", "2012", "Action", "Sony Computer Entertainment", "0.35", "0.12",
                "0.02", "0.07"
            },
            {"Top Spin 3", "PS3", "2008", "Sports", "Take-Two Interactive", "0.08", "0.36", "0.00", "0.12"},
            {"NHL 10", "PS3", "2009", "Sports", "Electronic Arts", "0.37", "0.12", "0.00", "0.07"},
            {"BlazBlue: Calamity Trigger", "PS3", "2009", "Fighting", "PQube", "0.35", "0.09", "0.06", "0.06"},
            {"NHL 12", "PS3", "2011", "Sports", "Electronic Arts", "0.34", "0.15", "0.00", "0.07"},
            {"Just Dance 3", "PS3", "2011", "Misc", "Ubisoft", "0.28", "0.19", "0.00", "0.09"},
            {
                "The Sly Collection", "PS3", "2010", "Platform", "Sony Computer Entertainment", "0.43", "0.07", "0.01",
                "0.05"
            },
            {"NieR", "PS3", "2010", "Role-Playing", "Square Enix", "0.14", "0.15", "0.20", "0.06"},
            {"Dead Island: Riptide", "PS3", "2013", "Action", "Deep Silver", "0.23", "0.17", "0.06", "0.09"},
            {"Tom Clancy's HAWX", "PS3", "2009", "Action", "Ubisoft", "0.20", "0.21", "0.05", "0.09"},
            {"Zumba Fitness", "PS3", "2010", "Sports", "505 Games", "0.27", "0.19", "0.00", "0.09"},
            {
                "The Fight: Lights Out", "PS3", "2010", "Fighting", "Sony Computer Entertainment", "0.26", "0.20", "0.00",
                "0.09"
            },
            {"Dead or Alive 5", "PS3", "2012", "Fighting", "Tecmo Koei", "0.20", "0.13", "0.15", "0.07"},
            {
                "Ratchet & Clank: Quest for Booty", "PS3", "2008", "Platform", "Sony Computer Entertainment", "0.00",
                "0.50", "0.00", "0.04"
            },
            {"Rock Band 3", "PS3", "2010", "Misc", "MTV Games", "0.41", "0.08", "0.00", "0.05"},
            {
                "Disgaea 4: A Promise Unforgotten", "PS3", "2011", "Role-Playing", "Nippon Ichi Software", "0.25", "0.10",
                "0.14", "0.05"
            },
            {
                "JoJo's Bizarre Adventure: All Star Battle", "PS3", "2013", "Fighting", "Namco Bandai Games", "0.02",
                "0.01", "0.50", "0.01"
            },
            {
                "Kidou Senshi Gundam: Extreme VS", "PS3", "2011", "Fighting", "Namco Bandai Games", "0.00", "0.00", "0.54",
                "0.00"
            },
            {"3D Dot Game Heroes", "PS3", "2009", "Role-Playing", "SouthPeak Games", "0.34", "0.11", "0.03", "0.06"},
            {"Alice: Madness Returns", "PS3", "2011", "Adventure", "Electronic Arts", "0.19", "0.22", "0.04", "0.09"},
            {"MLB 11: The Show", "PS3", "2011", "Sports", "Sony Computer Entertainment", "0.50", "0.00", "0.00", "0.03"},
            {
                "Enslaved: Odyssey to the West", "PS3", "2010", "Action", "Namco Bandai Games", "0.22", "0.21", "0.01",
                "0.09"
            },
            {"NBA Live 10", "PS3", "2009", "Sports", "Electronic Arts", "0.46", "0.02", "0.01", "0.05"},
            {"F.E.A.R.", "PS3", "2007", "Shooter", "Vivendi Games", "0.17", "0.26", "0.00", "0.10"},
            {"NBA 2K8", "PS3", "2007", "Sports", "Take-Two Interactive", "0.48", "0.01", "0.00", "0.04"},
            {
                "Metal Gear Solid: Ground Zeroes", "PS3", "2014", "Action", "Konami Digital Entertainment", "0.10", "0.10",
                "0.26", "0.06"
            },
            {"Dynasty Warriors: Gundam 3", "PS3", "2010", "Action", "Tecmo Koei", "0.10", "0.04", "0.36", "0.02"},
            {"Legends of WrestleMania", "PS3", "2009", "Fighting", "THQ", "0.29", "0.15", "0.00", "0.07"},
            {"Rayman Legends", "PS3", "2013", "Platform", "Ubisoft", "0.10", "0.27", "0.00", "0.14"},
            {"Spec Ops: The Line", "PS3", "2012", "Shooter", "Take-Two Interactive", "0.17", "0.22", "0.04", "0.09"},
            {"NBA Live 09", "PS3", "2008", "Sports", "Electronic Arts", "0.45", "0.00", "0.02", "0.04"},
            {
                "Terminator Salvation", "PS3", "2009", "Shooter", "Warner Bros. Interactive Entertainment", "0.12", "0.28",
                "0.01", "0.11"
            },
            {"Madden NFL 07", "PS3", "2006", "Sports", "Electronic Arts", "0.46", "0.00", "0.01", "0.04"},
            {"Stuntman: Ignition", "PS3", "2007", "Racing", "THQ", "0.16", "0.25", "0.00", "0.10"},
            {"Way of the Samurai 3", "PS3", "2008", "Action", "Gamebridge", "0.17", "0.08", "0.22", "0.04"},
            {
                "God of War: Origins Collection", "PS3", "2011", "Action", "Sony Computer Entertainment", "0.36", "0.07",
                "0.02", "0.05"
            },
            {"Ratatouille", "PS3", "2007", "Platform", "THQ", "0.09", "0.31", "0.00", "0.11"},
            {"Tiger Woods PGA Tour 13", "PS3", "2012", "Sports", "Electronic Arts", "0.22", "0.20", "0.00", "0.08"},
            {"Doom 3 BFG Edition", "PS3", "2012", "Shooter", "Bethesda Softworks", "0.22", "0.19", "0.00", "0.09"},
            {
                "Monster Hunter Portable 3rd HD Ver.", "PS3", "2011", "Role-Playing", "Capcom", "0.00", "0.00", "0.50",
                "0.00"
            },
            {"Kung Fu Panda", "PS3", "2008", "Platform", "Activision", "0.20", "0.21", "0.00", "0.09"},
            {"Lair", "PS3", "2007", "Action", "Sony Computer Entertainment", "0.35", "0.03", "0.08", "0.04"},
            {"The Evil Within", "PS3", "2014", "Action", "Bethesda Softworks", "0.12", "0.18", "0.09", "0.10"},
            {"SingStar Dance", "PS3", "2010", "Misc", "Sony Computer Entertainment", "0.08", "0.31", "0.00", "0.11"},
            {"NBA 2K15", "PS3", "2014", "Sports", "Take-Two Interactive", "0.33", "0.09", "0.01", "0.07"},
            {
                "Time Crisis: Razing Storm", "PS3", "2010", "Shooter", "Namco Bandai Games", "0.15", "0.19", "0.07", "0.08"
            },
            {"Tiger Woods PGA Tour 07", "PS3", "2006", "Sports", "Electronic Arts", "0.30", "0.12", "0.00", "0.07"},
            {"XCOM: Enemy Unknown", "PS3", "2012", "Strategy", "Take-Two Interactive", "0.20", "0.20", "0.00", "0.10"},
            {
                "DC Universe Online", "PS3", "2011", "Role-Playing", "Sony Online Entertainment", "0.33", "0.10", "0.00",
                "0.06"
            },
            {
                "Dynasty Warriors: Gundam 2", "PS3", "2008", "Action", "Namco Bandai Games", "0.08", "0.06", "0.32", "0.03"
            },
            {"Lost: Via Domus", "PS3", "2008", "Action", "Ubisoft", "0.18", "0.22", "0.00", "0.09"},
            {"R.U.S.E.", "PS3", "2010", "Strategy", "Ubisoft", "0.17", "0.21", "0.02", "0.08"},
            {"Bulletstorm", "PS3", "2011", "Shooter", "Electronic Arts", "0.21", "0.19", "0.01", "0.08"},
            {"Transformers: War for Cybertron", "PS3", "2010", "Action", "Activision", "0.23", "0.17", "0.00", "0.08"},
            {"Sonic the Hedgehog", "PS3", "N/A", "Platform", "N/A", "0.00", "0.48", "0.00", "0.00"},
            {
                "Bleach: Soul Resurreccion", "PS3", "2011", "Fighting", "Nippon Ichi Software", "0.26", "0.10", "0.07",
                "0.05"
            },
            {"Dragon's Crown", "PS3", "2013", "Role-Playing", "Nippon Ichi Software", "0.20", "0.06", "0.17", "0.04"},
            {"Dynasty Warriors Gundam", "PS3", "2007", "Action", "Tecmo Koei", "0.14", "0.01", "0.31", "0.02"},
            {"Assassin's Creed: Rogue", "PS3", "2014", "Action", "Ubisoft", "0.13", "0.21", "0.00", "0.12"},
            {
                "Disgaea 3: Absence of Justice", "PS3", "2008", "Role-Playing", "Square Enix", "0.30", "0.03", "0.11",
                "0.03"
            },
            {
                "Sly Cooper: Thieves in Time", "PS3", "2013", "Platform", "Sony Computer Entertainment Europe", "0.30",
                "0.11", "0.00", "0.07"
            },
            {"Michael Jackson: The Experience", "PS3", "2011", "Misc", "Ubisoft", "0.22", "0.17", "0.00", "0.08"},
            {"Prince of Persia Trilogy", "PS3", "2010", "Action", "Ubisoft", "0.15", "0.23", "0.00", "0.09"},
            {"Dark Sector", "PS3", "2008", "Shooter", "D3Publisher", "0.22", "0.16", "0.01", "0.07"},
            {"Kingdom Hearts II", "PS3", "2014", "Role-Playing", "Square Enix", "0.15", "0.10", "0.14", "0.06"},
            {"The Saboteur", "PS3", "2009", "Action", "Electronic Arts", "0.19", "0.19", "0.00", "0.08"},
            {"NHL 14", "PS3", "2013", "Sports", "Electronic Arts", "0.24", "0.14", "0.00", "0.08"},
            {
                "F.E.A.R. 2: Project Origin", "PS3", "2009", "Shooter", "Warner Bros. Interactive Entertainment", "0.18",
                "0.19", "0.01", "0.08"
            },
            {
                "MotorStorm: Apocalypse", "PS3", "2011", "Racing", "Sony Computer Entertainment", "0.19", "0.18", "0.00",
                "0.08"
            },
            {"Cars 2", "PS3", "2011", "Platform", "Disney Interactive Studios", "0.18", "0.19", "0.00", "0.08"},
            {"Two Worlds II", "PS3", "2011", "Role-Playing", "Unknown", "0.25", "0.08", "0.06", "0.05"},
            {"Sonic & All-Stars Racing Transformed", "PS3", "2012", "Racing", "Sega", "0.07", "0.24", "0.01", "0.11"},
            {"Tony Hawk's Proving Ground", "PS3", "2007", "Sports", "Activision", "0.35", "0.04", "0.00", "0.05"},
            {
                "The Legend of Spyro: Dawn of the Dragon", "PS3", "2008", "Platform", "Vivendi Games", "0.18", "0.17",
                "0.00", "0.08"
            },
            {"Tales of Vesperia", "PS3", "2009", "Role-Playing", "Namco Bandai Games", "0.00", "0.00", "0.43", "0.00"},
            {"Tales of Symphonia", "PS3", "2013", "Role-Playing", "Namco Bandai Games", "0.15", "0.09", "0.13", "0.06"},
            {"Spider-Man: Shattered Dimensions", "PS3", "2010", "Action", "Activision", "0.26", "0.11", "0.00", "0.06"},
            {"Red Faction: Armageddon", "PS3", "2011", "Shooter", "THQ", "0.19", "0.14", "0.03", "0.06"},
            {"MX vs. ATV Untamed", "PS3", "2007", "Racing", "THQ", "0.33", "0.05", "0.00", "0.05"},
            {"MX vs. ATV: Alive", "PS3", "2011", "Racing", "THQ", "0.22", "0.14", "0.00", "0.06"},
            {"DanceStar Party", "PS3", "2011", "Misc", "Sony Computer Entertainment", "0.00", "0.32", "0.00", "0.11"},
            {"Warhammer 40,000: Space Marine", "PS3", "2011", "Shooter", "THQ", "0.12", "0.22", "0.00", "0.08"},
            {"Virtua Tennis 4", "PS3", "2011", "Sports", "Sega", "0.08", "0.23", "0.03", "0.08"},
            {"Def Jam Icon", "PS3", "2007", "Action", "Electronic Arts", "0.15", "0.19", "0.00", "0.08"},
            {"The Walking Dead: Survival Instinct", "PS3", "2013", "Misc", "Activision", "0.22", "0.13", "0.00", "0.07"},
            {"Naughty Bear", "PS3", "2010", "Action", "505 Games", "0.17", "0.17", "0.00", "0.07"},
            {"Alpha Protocol", "PS3", "2010", "Role-Playing", "Sega", "0.18", "0.16", "0.00", "0.07"},
            {
                "Silent Hill: Downpour", "PS3", "2012", "Adventure", "Konami Digital Entertainment", "0.19", "0.12", "0.04",
                "0.06"
            },
            {"Cars: Mater-National Championship", "PS3", "2007", "Racing", "THQ", "0.37", "0.00", "0.00", "0.03"},
            {
                "Disney Epic Mickey 2: The Power of Two", "PS3", "2012", "Action", "Disney Interactive Studios", "0.18",
                "0.15", "0.00", "0.08"
            },
            {"SingStar Queen", "PS3", "2009", "Misc", "Sony Computer Entertainment", "0.09", "0.24", "0.00", "0.07"},
            {"Eternal Sonata", "PS3", "2008", "Role-Playing", "Atari", "0.17", "0.11", "0.07", "0.05"},
            {
                "F.E.A.R. 3", "PS3", "2011", "Shooter", "Warner Bros. Interactive Entertainment", "0.19", "0.14", "0.01",
                "0.06"
            },
            {
                "UEFA Euro 2008 Austria-Switzerland", "PS3", "2008", "Sports", "Electronic Arts", "0.08", "0.26", "0.00",
                "0.06"
            },
            {"Far Cry 4", "PS3", "2014", "Shooter", "Ubisoft", "0.06", "0.22", "0.00", "0.12"},
            {
                "Atelier Rorona: Alchemist of Arland", "PS3", "2009", "Role-Playing", "Nippon Ichi Software", "0.19",
                "0.07", "0.11", "0.04"
            },
            {"Ninja Gaiden 3", "PS3", "2012", "Action", "Tecmo Koei", "0.17", "0.08", "0.11", "0.04"},
            {
                "Atelier Totori: The Adventurer of Arland", "PS3", "2010", "Role-Playing", "Nippon Ichi Software", "0.10",
                "0.06", "0.21", "0.03"
            },
            {"Wall-E", "PS3", "2008", "Platform", "THQ", "0.11", "0.20", "0.00", "0.08"},
            {
                "Cabela's Big Game Hunter 2010", "PS3", "2009", "Sports", "Activision Value", "0.37", "0.00", "0.00",
                "0.03"
            },
            {"Hyperdimension Neptunia", "PS3", "2010", "Role-Playing", "Tecmo Koei", "0.21", "0.07", "0.07", "0.04"},
            {"Tom Clancy's HAWX 2", "PS3", "2010", "Action", "Ubisoft", "0.19", "0.11", "0.03", "0.05"},
            {
                "Star Wars The Clone Wars: Republic Heroes", "PS3", "2009", "Action", "LucasArts", "0.18", "0.15", "0.00",
                "0.07"
            },
            {"Sega Superstars Tennis", "PS3", "2008", "Sports", "Sega", "0.12", "0.19", "0.00", "0.08"},
            {
                "Disney Sing It! High School Musical 3: Senior Year", "PS3", "2008", "Misc", "Disney Interactive Studios",
                "0.07", "0.25", "0.00", "0.07"
            },
            {"TNA iMPACT!", "PS3", "2008", "Fighting", "Midway Games", "0.21", "0.12", "0.00", "0.06"},
            {"Green Day: Rock Band", "PS3", "2010", "Misc", "MTV Games", "0.18", "0.14", "0.00", "0.06"},
            {"BlazBlue: Continuum Shift", "PS3", "2010", "Fighting", "PQube", "0.19", "0.07", "0.09", "0.04"},
            {
                "Disney Infinity 2.0: Marvel Super Heroes", "PS3", "2014", "Action", "Disney Interactive Studios", "0.15",
                "0.15", "0.00", "0.09"
            },
            {"WWE All Stars", "PS3", "2011", "Fighting", "THQ", "0.14", "0.17", "0.00", "0.07"},
            {"NBA 2K7", "PS3", "2006", "Sports", "Take-Two Interactive", "0.30", "0.04", "0.00", "0.04"},
            {"Just Dance 4", "PS3", "2012", "Misc", "Ubisoft", "0.22", "0.10", "0.00", "0.06"},
            {"Metro: Last Light", "PS3", "2013", "Shooter", "Deep Silver", "0.11", "0.16", "0.03", "0.08"},
            {"Transformers: The Game", "PS3", "2007", "Action", "Activision", "0.31", "0.03", "0.01", "0.04"},
            {"TRON: Evolution", "PS3", "2010", "Action", "Disney Interactive Studios", "0.25", "0.09", "0.00", "0.05"},
            {"Armored Core V", "PS3", "2012", "Simulation", "Namco Bandai Games", "0.08", "0.04", "0.24", "0.02"},
            {
                "LEGO Rock Band", "PS3", "2009", "Misc", "Warner Bros. Interactive Entertainment", "0.21", "0.11", "0.00",
                "0.05"
            },
            {"NCAA Football 08", "PS3", "2007", "Sports", "Electronic Arts", "0.35", "0.00", "0.00", "0.03"},
            {"MotoGP 08", "PS3", "2008", "Racing", "Capcom", "0.06", "0.24", "0.00", "0.08"},
            {"Iron Man 2", "PS3", "2010", "Action", "Sega", "0.13", "0.17", "0.00", "0.07"},
            {"Viking: Battle for Asgard", "PS3", "2008", "Action", "Sega", "0.14", "0.17", "0.00", "0.07"},
            {"Condemned 2: Bloodshot", "PS3", "2008", "Shooter", "Sega", "0.16", "0.15", "0.00", "0.06"},
            {
                "Robert Ludlum's The Bourne Conspiracy", "PS3", "N/A", "Action", "Vivendi Games", "0.17", "0.14", "0.00",
                "0.06"
            },
            {
                "Mobile Suit Gundam: Extreme Vs", "PS3", "2014", "Action", "Namco Bandai Games", "0.00", "0.00", "0.37",
                "0.00"
            },
            {"Virtua Tennis 2009", "PS3", "2009", "Sports", "Sega", "0.09", "0.22", "0.00", "0.07"},
            {"Marvel: Ultimate Alliance", "PS3", "2006", "Role-Playing", "Activision", "0.32", "0.02", "0.00", "0.03"},
            {"Asura's Wrath", "PS3", "2012", "Action", "Capcom", "0.15", "0.11", "0.06", "0.05"},
            {"Monopoly Streets", "PS3", "2010", "Misc", "Electronic Arts", "0.15", "0.15", "0.00", "0.07"},
            {
                "Silent Hill: Homecoming", "PS3", "N/A", "Action", "Konami Digital Entertainment", "0.17", "0.13", "0.00",
                "0.06"
            },
            {"Dungeon Siege III", "PS3", "2011", "Role-Playing", "Square Enix", "0.16", "0.12", "0.03", "0.05"},
            {"Katamari Forever", "PS3", "2009", "Puzzle", "Namco Bandai Games", "0.23", "0.04", "0.06", "0.03"},
            {"Bionic Commando", "PS3", "2009", "Platform", "Capcom", "0.12", "0.16", "0.01", "0.07"},
            {"Ryu Ga Gotoku Kenzan!", "PS3", "2008", "Adventure", "Sega", "0.00", "0.00", "0.36", "0.00"},
            {
                "Borderlands: The Pre-Sequel", "PS3", "2014", "Shooter", "Take-Two Interactive", "0.13", "0.13", "0.02",
                "0.08"
            },
            {"Get Fit with Mel B", "PS3", "2010", "Sports", "Black Bean Games", "0.14", "0.16", "0.00", "0.06"},
            {"Skate", "PS3", "2007", "Sports", "Electronic Arts", "0.29", "0.03", "0.00", "0.04"},
            {"GRID 2", "PS3", "2013", "Racing", "Codemasters", "0.05", "0.20", "0.01", "0.09"},
            {
                "Harry Potter and the Deathly Hallows - Part 1", "PS3", "2010", "Action", "Electronic Arts", "0.11", "0.18",
                "0.00", "0.07"
            },
            {"SAW", "PS3", "2009", "Action", "Konami Digital Entertainment", "0.12", "0.16", "0.00", "0.07"},
            {"EA Sports MMA", "PS3", "2010", "Fighting", "Electronic Arts", "0.15", "0.13", "0.01", "0.06"},
            {"NBA Jam", "PS3", "2010", "Sports", "Electronic Arts", "0.18", "0.11", "0.00", "0.05"},
            {"Skylanders: Trap Team", "PS3", "2014", "Action", "Activision", "0.11", "0.15", "0.00", "0.09"},
            {"Enemy Territory: Quake Wars", "PS3", "2008", "Shooter", "Activision", "0.23", "0.07", "0.00", "0.04"},
            {
                "The House of the Dead: Overkill - Extended Cut", "PS3", "2011", "Shooter", "Sega", "0.13", "0.15", "0.00",
                "0.06"
            },
            {
                "Zone of the Enders HD Collection", "PS3", "2012", "Simulation", "Konami Digital Entertainment", "0.15",
                "0.06", "0.09", "0.04"
            },
            {"Transformers: Fall of Cybertron", "PS3", "2012", "Action", "Activision", "0.16", "0.12", "0.00", "0.06"},
            {"Dark Void", "PS3", "2010", "Action", "Capcom", "0.17", "0.12", "0.00", "0.05"},
            {"Conan", "PS3", "2007", "Action", "THQ", "0.13", "0.15", "0.00", "0.06"},
            {"Disney Sing It", "PS3", "2008", "Misc", "Disney Interactive Studios", "0.25", "0.04", "0.00", "0.04"},
            {"Sengoku Musou 3 Z", "PS3", "2011", "Action", "Ackkstudios", "0.00", "0.00", "0.33", "0.00"},
            {
                "The Eye of Judgment", "PS3", "2007", "Misc", "Sony Computer Entertainment", "0.28", "0.00", "0.02", "0.03"
            },
            {"Guitar Hero: Smash Hits", "PS3", "2009", "Misc", "Activision", "0.18", "0.10", "0.00", "0.05"},
            {"NHL 09", "PS3", "2008", "Sports", "Electronic Arts", "0.29", "0.01", "0.00", "0.03"},
            {"Dynasty Warriors 6 Empires", "PS3", "2009", "Action", "Tecmo Koei", "0.13", "0.02", "0.15", "0.02"},
            {"Deadpool", "PS3", "2013", "Action", "Activision", "0.17", "0.10", "0.00", "0.06"},
            {"Mini Ninjas", "PS3", "2009", "Action", "Eidos Interactive", "0.13", "0.14", "0.00", "0.06"},
            {"Racquet Sports", "PS3", "2010", "Sports", "Ubisoft", "0.10", "0.16", "0.00", "0.06"},
            {"WWE 2K15", "PS3", "2014", "Sports", "Take-Two Interactive", "0.13", "0.12", "0.00", "0.07"},
            {"The Shoot", "PS3", "2010", "Shooter", "Sony Computer Entertainment", "0.12", "0.14", "0.01", "0.06"},
            {
                "Buzz! The Ultimate Music Quiz", "PS3", "2010", "Misc", "Sony Computer Entertainment", "0.00", "0.24",
                "0.00", "0.08"
            },
            {
                "Vancouver 2010 - The Official Video Game of the Olympic Winter Games", "PS3", "2010", "Sports", "Sega",
                "0.08", "0.18", "0.00", "0.07"
            },
            {"Transformers: Dark of the Moon", "PS3", "2011", "Action", "Activision", "0.10", "0.15", "0.00", "0.07"},
            {"Just Dance 2014", "PS3", "2013", "Misc", "Ubisoft", "0.13", "0.12", "0.00", "0.07"},
            {
                "Command & Conquer: Red Alert 3 Ultimate Edition", "PS3", "2009", "Strategy", "Electronic Arts", "0.12",
                "0.14", "0.00", "0.06"
            },
            {"Tiger Woods PGA Tour 14", "PS3", "2013", "Sports", "Electronic Arts", "0.12", "0.13", "0.00", "0.07"},
            {"Payday 2", "PS3", "2013", "Action", "505 Games", "0.14", "0.11", "0.00", "0.06"},
            {"Earth Defense Force 2025", "PS3", "2013", "Shooter", "D3Publisher", "0.02", "0.02", "0.27", "0.01"},
            {"Vin Diesel: Wheelman", "PS3", "2009", "Racing", "Ubisoft", "0.12", "0.14", "0.00", "0.06"},
            {"Monopoly", "PS3", "2008", "Misc", "Electronic Arts", "0.24", "0.04", "0.00", "0.04"},
            {"NCAA Basketball 10", "PS3", "2009", "Sports", "Electronic Arts", "0.29", "0.00", "0.00", "0.02"},
            {
                "Wolfenstein: The New Order", "PS3", "2014", "Shooter", "Bethesda Softworks", "0.07", "0.14", "0.02",
                "0.08"
            },
            {"FIFA Street 3", "PS3", "2008", "Sports", "Electronic Arts", "0.07", "0.17", "0.00", "0.06"},
            {"Golden Axe: Beast Rider", "PS3", "2008", "Action", "Sega", "0.12", "0.14", "0.00", "0.06"},
            {"Rugby World Cup 2011", "PS3", "2011", "Sports", "505 Games", "0.00", "0.23", "0.00", "0.08"},
            {"Tekken Hybrid", "PS3", "2011", "Fighting", "Namco Bandai Games", "0.17", "0.07", "0.04", "0.03"},
            {
                "Plants vs Zombies: Garden Warfare", "PS3", "2014", "Action", "Electronic Arts", "0.08", "0.15", "0.00",
                "0.08"
            },
            {"MLB 07: The Show", "PS3", "2007", "Sports", "Sony Computer Entertainment", "0.29", "0.00", "0.00", "0.02"},
            {"Cabela's Dangerous Hunts 2011", "PS3", "2010", "Sports", "Activision", "0.25", "0.04", "0.00", "0.03"},
            {
                "LEGO The Hobbit", "PS3", "2014", "Action", "Warner Bros. Interactive Entertainment", "0.06", "0.16",
                "0.00", "0.09"
            },
            {"Overlord II", "PS3", "2009", "Action", "Codemasters", "0.11", "0.14", "0.00", "0.06"},
            {"DEFIANCE", "PS3", "2013", "Action", "Trion Worlds", "0.17", "0.09", "0.00", "0.05"},
            {
                "Harry Potter and the Half-Blood Prince", "PS3", "2009", "Action", "Electronic Arts", "0.14", "0.11",
                "0.00", "0.05"
            },
            {"Mass Effect Trilogy", "PS3", "2012", "Action", "Electronic Arts", "0.29", "0.00", "0.00", "0.02"},
            {
                "Dai-2-Ji Super Robot Taisen OG", "PS3", "2012", "Strategy", "Namco Bandai Games", "0.00", "0.00", "0.30",
                "0.00"
            },
            {"Operation Flashpoint: Red River", "PS3", "2011", "Shooter", "Codemasters", "0.06", "0.13", "0.07", "0.05"},
            {"James Bond 007: Legends", "PS3", "2012", "Shooter", "Activision", "0.09", "0.15", "0.00", "0.07"},
            {"Sniper: Ghost Warrior 2", "PS3", "2013", "Shooter", "City Interactive", "0.04", "0.16", "0.03", "0.07"},
            {"Dead Rising 2: Off the Record", "PS3", "2011", "Action", "Capcom", "0.09", "0.07", "0.10", "0.03"},
            {"Folklore", "PS3", "2007", "Role-Playing", "Sony Computer Entertainment", "0.19", "0.03", "0.05", "0.03"},
            {"SingStar Take That", "PS3", "2009", "Misc", "Sony Computer Entertainment", "0.00", "0.26", "0.00", "0.03"},
            {"The Darkness II", "PS3", "2012", "Shooter", "Take-Two Interactive", "0.13", "0.12", "0.00", "0.05"},
            {"Binary Domain", "PS3", "2012", "Action", "Sega", "0.07", "0.07", "0.14", "0.03"},
            {"Thief (2014)", "PS3", "2014", "Action", "Square Enix", "0.07", "0.13", "0.02", "0.08"},
            {"Monsters vs. Aliens", "PS3", "2009", "Platform", "Activision", "0.21", "0.05", "0.00", "0.03"},
            {"Major League Baseball 2K8", "PS3", "2008", "Sports", "Bethesda Softworks", "0.27", "0.00", "0.00", "0.02"},
            {
                "Harry Potter and the Deathly Hallows - Part 2", "PS3", "2011", "Action", "Electronic Arts", "0.12", "0.12",
                "0.00", "0.05"
            },
            {
                "The King of Fighters XIII", "PS3", "2011", "Fighting", "Rising Star Games", "0.16", "0.06", "0.04", "0.03"
            },
            {"Def Jam Rapstar", "PS3", "2010", "Misc", "Konami Digital Entertainment", "0.23", "0.04", "0.00", "0.03"},
            {"Remember Me", "PS3", "2013", "Action", "Capcom", "0.07", "0.14", "0.00", "0.07"},
            {"Stranglehold", "PS3", "2007", "Shooter", "Midway Games", "0.24", "0.02", "0.00", "0.03"},
            {
                "Pro Evolution Soccer 2015", "PS3", "2014", "Sports", "Konami Digital Entertainment", "0.02", "0.10",
                "0.12", "0.05"
            },
            {
                "Fist of the North Star: Ken's Rage 2", "PS3", "2012", "Fighting", "Tecmo Koei", "0.00", "0.00", "0.29",
                "0.00"
            },
            {
                "Wanted: Weapons of Fate", "PS3", "2009", "Shooter", "Warner Bros. Interactive Entertainment", "0.14",
                "0.09", "0.01", "0.05"
            },
            {
                "Hot Shots Golf: World Invitational", "PS3", "2012", "Sports", "Sony Computer Entertainment", "0.00",
                "0.00", "0.28", "0.00"
            },
            {
                "MLB 14 The Show", "PS3", "2014", "Action", "Sony Computer Entertainment America", "0.27", "0.00", "0.00",
                "0.02"
            },
            {"Dynasty Warriors: Strikeforce", "PS3", "2009", "Action", "Tecmo Koei", "0.11", "0.07", "0.07", "0.03"},
            {"Front Mission Evolved", "PS3", "2010", "Shooter", "Square Enix", "0.09", "0.06", "0.11", "0.03"},
            {"The Godfather: Dons Edition", "PS3", "2007", "Action", "Electronic Arts", "0.24", "0.01", "0.00", "0.03"},
            {
                "Bladestorm: The Hundred Years' War", "PS3", "2007", "Action", "Tecmo Koei", "0.09", "0.02", "0.14", "0.02"
            },
            {"Dreamworks Madagascar Kartz", "PS3", "2009", "Racing", "Activision", "0.18", "0.07", "0.00", "0.04"},
            {"Starhawk", "PS3", "2012", "Action", "Sony Computer Entertainment", "0.18", "0.05", "0.03", "0.03"},
            {"The Golden Compass", "PS3", "2007", "Action", "Sega", "0.13", "0.10", "0.00", "0.04"},
            {
                "Clash of the Titans: The Videogame", "PS3", "2010", "Action", "Namco Bandai Games", "0.09", "0.13", "0.01",
                "0.05"
            },
            {"F1 Race Stars", "PS3", "2012", "Racing", "Codemasters", "0.03", "0.16", "0.00", "0.08"},
            {
                "Siren: Blood Curse", "PS3", "2008", "Adventure", "Sony Computer Entertainment", "0.00", "0.16", "0.09",
                "0.02"
            },
            {
                "Dead to Rights: Retribution", "PS3", "2010", "Shooter", "Namco Bandai Games", "0.09", "0.12", "0.02",
                "0.05"
            },
            {
                "Majin and the Forsaken Kingdom", "PS3", "2010", "Adventure", "Namco Bandai Games", "0.08", "0.12", "0.01",
                "0.05"
            },
            {
                "El Shaddai: Ascension of the Metatron", "PS3", "2011", "Action", "Ignition Entertainment", "0.10", "0.06",
                "0.08", "0.03"
            },
            {
                "Phineas and Ferb: Across the 2nd Dimension", "PS3", "2011", "Action", "Disney Interactive Studios", "0.12",
                "0.10", "0.00", "0.05"
            },
            {
                "Silent Hill HD Collection", "PS3", "2012", "Action", "Konami Digital Entertainment", "0.12", "0.08",
                "0.03", "0.04"
            },
            {
                "Jikkyou Powerful Pro Yakyuu 2010", "PS3", "2010", "Sports", "Konami Digital Entertainment", "0.00", "0.00",
                "0.27", "0.00"
            },
            {"NBA 07", "PS3", "2006", "Sports", "Sony Computer Entertainment", "0.24", "0.00", "0.01", "0.02"},
            {
                "A.C.E.: Another Century's Episode R", "PS3", "2010", "Simulation", "Namco Bandai Games", "0.00", "0.00",
                "0.26", "0.00"
            },
            {"Gundam Breaker", "PS3", "2013", "Action", "Namco Bandai Games", "0.00", "0.00", "0.26", "0.00"},
            {"Rock Revolution", "PS3", "N/A", "Misc", "Unknown", "0.24", "0.00", "0.00", "0.02"},
            {
                "Dynasty Warriors 7: Xtreme Legends", "PS3", "2011", "Action", "Tecmo Koei", "0.04", "0.04", "0.16", "0.02"
            },
            {
                "Jikkyou Powerful Pro Yakyuu 2011", "PS3", "2011", "Sports", "Konami Digital Entertainment", "0.00", "0.00",
                "0.26", "0.00"
            },
            {"Sorcery", "PS3", "2012", "Role-Playing", "Sony Computer Entertainment", "0.12", "0.10", "0.00", "0.04"},
            {"Sengoku Basara 4", "PS3", "2014", "Action", "Capcom", "0.00", "0.00", "0.26", "0.00"},
            {"Spider-Man: Web of Shadows", "PS3", "2008", "Action", "Activision", "0.20", "0.03", "0.00", "0.03"},
            {"Call of Juarez: The Cartel", "PS3", "2011", "Shooter", "Ubisoft", "0.10", "0.11", "0.00", "0.05"},
            {
                "Jikkyou Powerful Pro Yakyuu 2013", "PS3", "2013", "Sports", "Konami Digital Entertainment", "0.00", "0.00",
                "0.26", "0.00"
            },
            {"Tokyo Jungle", "PS3", "2012", "Action", "Sony Computer Entertainment", "0.00", "0.00", "0.26", "0.00"},
            {
                "Jonah Lomu Rugby Challenge", "PS3", "N/A", "Sports", "Home Entertainment Suppliers", "0.00", "0.19",
                "0.00", "0.07"
            },
            {"Next Hatsune Miku: Project Diva", "PS3", "2013", "Misc", "Sega", "0.06", "0.00", "0.19", "0.00"},
            {"NASCAR 2011: The Game", "PS3", "2011", "Racing", "Activision", "0.24", "0.00", "0.00", "0.01"},
            {"Trivial Pursuit", "PS3", "2009", "Misc", "Electronic Arts", "0.10", "0.10", "0.00", "0.05"},
            {"The Adventures of Tintin: The Game", "PS3", "2011", "Action", "Ubisoft", "0.06", "0.14", "0.00", "0.05"},
            {"Yakuza: Ishin", "PS3", "2014", "Action", "Sega", "0.00", "0.00", "0.25", "0.00"},
            {"NHL 08", "PS3", "2007", "Action", "Electronic Arts", "0.16", "0.06", "0.00", "0.03"},
            {
                "Naruto Shippuden: Ultimate Ninja Storm Revolution", "PS3", "2014", "Fighting", "Namco Bandai Games",
                "0.03", "0.10", "0.07", "0.06"
            },
            {"Dragon Age Origins: Awakening", "PS3", "2010", "Role-Playing", "Spike", "0.23", "0.00", "0.00", "0.02"},
            {"Guitar Hero: Van Halen", "PS3", "2009", "Misc", "Activision", "0.13", "0.09", "0.00", "0.04"},
            {
                "Army of Two: The Devil's Cartel", "PS3", "2013", "Shooter", "Electronic Arts", "0.09", "0.10", "0.01",
                "0.05"
            },
            {"Shadows of the Damned", "PS3", "2011", "Action", "Electronic Arts", "0.09", "0.08", "0.04", "0.03"},
            {"Tony Hawk: Shred", "PS3", "2010", "Sports", "Activision", "0.16", "0.06", "0.00", "0.03"},
            {"Samurai Warriors 4", "PS3", "2014", "Action", "Tecmo Koei", "0.00", "0.00", "0.25", "0.00"},
            {"The Incredible Hulk", "PS3", "2008", "Action", "Sega", "0.20", "0.02", "0.00", "0.02"},
            {"Juiced 2: Hot Import Nights", "PS3", "2007", "Racing", "THQ", "0.18", "0.03", "0.01", "0.03"},
            {
                "Tom Clancy's Splinter Cell: Double Agent", "PS3", "2007", "Action", "Ubisoft", "0.19", "0.03", "0.00",
                "0.03"
            },
            {"Major League Baseball 2K7", "PS3", "2007", "Sports", "Spike", "0.23", "0.00", "0.00", "0.02"},
            {"Rapala Pro Bass Fishing 2010", "PS3", "2010", "Sports", "Activision", "0.17", "0.05", "0.00", "0.03"},
            {"Prison Break: The Conspiracy", "PS3", "2010", "Adventure", "Deep Silver", "0.05", "0.14", "0.00", "0.05"},
            {
                "Dragon Ball Z: Battle of Z", "PS3", "2014", "Fighting", "Namco Bandai Games", "0.05", "0.08", "0.06",
                "0.05"
            },
            {
                "Medieval Moves: Deadmund's Quest", "PS3", "2011", "Action", "Sony Computer Entertainment", "0.11", "0.10",
                "0.00", "0.04"
            },
            {
                "The Testament of Sherlock Holmes", "PS3", "2012", "Adventure", "Focus Home Interactive", "0.05", "0.13",
                "0.00", "0.07"
            },
            {
                "Disney Sing It: Pop Hits", "PS3", "2009", "Misc", "Disney Interactive Studios", "0.16", "0.05", "0.00",
                "0.03"
            },
            {"NASCAR 09", "PS3", "2008", "Racing", "Electronic Arts", "0.21", "0.01", "0.00", "0.02"},
            {
                "SBK Superbike World Championship", "PS3", "2008", "Racing", "Black Bean Games", "0.11", "0.11", "0.00",
                "0.02"
            },
            {
                "Mobile Suit Gundam Battlefield Record U.C.0081", "PS3", "2009", "Action", "Namco Bandai Games", "0.00",
                "0.00", "0.24", "0.00"
            },
            {"Up", "PS3", "2009", "Adventure", "THQ", "0.15", "0.06", "0.00", "0.03"},
            {
                "Hunted: The Demon's Forge", "PS3", "2011", "Role-Playing", "Bethesda Softworks", "0.11", "0.08", "0.02",
                "0.04"
            },
            {
                "Atelier Ayesha: The Alchemist of the Land of Twilight", "PS3", "2012", "Action", "Tecmo Koei", "0.05",
                "0.03", "0.14", "0.02"
            },
            {"Terraria", "PS3", "2013", "Action", "505 Games", "0.02", "0.08", "0.09", "0.04"},
            {
                "The Chronicles of Riddick: Assault on Dark Athena", "PS3", "2009", "Shooter", "Vivendi Games", "0.11",
                "0.09", "0.00", "0.04"
            },
            {"Turning Point: Fall of Liberty", "PS3", "2008", "Shooter", "Codemasters", "0.20", "0.01", "0.00", "0.02"},
            {"Drakengard 3", "PS3", "2013", "Role-Playing", "Square Enix", "0.05", "0.00", "0.18", "0.00"},
            {
                "Saint Seiya: Sanctuary Battle", "PS3", "2011", "Action", "Namco Bandai Games", "0.00", "0.09", "0.11",
                "0.03"
            },
            {"Pure Futbol", "PS3", "2010", "Sports", "Ubisoft", "0.06", "0.12", "0.00", "0.05"},
            {"Fuel", "PS3", "2009", "Racing", "Codemasters", "0.07", "0.11", "0.00", "0.05"},
            {"X-Men: Destiny", "PS3", "2011", "Action", "Activision", "0.14", "0.06", "0.00", "0.03"},
            {"Musou Orochi Z", "PS3", "2009", "Action", "Tecmo Koei", "0.00", "0.00", "0.23", "0.00"},
            {"Shin Dynasty Warriors Gundam", "PS3", "2013", "Action", "Tecmo Koei", "0.00", "0.00", "0.23", "0.00"},
            {"XCOM", "PS3", "2013", "Shooter", "Take-Two Interactive", "0.07", "0.10", "0.00", "0.06"},
            {
                "World Soccer Winning Eleven 2010: Aoki Samurai no Chousen", "PS3", "2010", "Sports",
                "Konami Digital Entertainment", "0.00", "0.00", "0.23", "0.00"
            },
            {"AC/DC LIVE: Rock Band Track Pack", "PS3", "2008", "Misc", "MTV Games", "0.21", "0.00", "0.00", "0.02"},
            {
                "Dragon Age: Inquisition", "PS3", "2014", "Role-Playing", "Electronic Arts", "0.10", "0.07", "0.02", "0.04"
            },
            {
                "Metal Gear Solid: The Legacy Collection", "PS3", "2013", "Adventure", "Konami Digital Entertainment",
                "0.18", "0.01", "0.03", "0.01"
            },
            {"Hasbro Family Game Night 3", "PS3", "2010", "Misc", "Electronic Arts", "0.17", "0.04", "0.00", "0.02"},
            {
                "Gekijouban Macross F: Sayonara no Tsubasa - Hybrid Pack", "PS3", "2011", "Action", "Namco Bandai Games",
                "0.00", "0.00", "0.22", "0.00"
            },
            {
                "Atelier Meruru: Alchemist of Arland 3", "PS3", "2011", "Role-Playing", "Nippon Ichi Software", "0.04",
                "0.00", "0.18", "0.00"
            },
            {"Madagascar: Escape 2 Africa", "PS3", "2008", "Action", "Activision", "0.11", "0.08", "0.00", "0.03"},
            {"Sengoku Basara 3 Utage", "PS3", "2011", "Action", "Capcom", "0.00", "0.00", "0.22", "0.00"},
            {"NASCAR 08", "PS3", "2007", "Racing", "Electronic Arts", "0.15", "0.05", "0.00", "0.03"},
            {"Singularity", "PS3", "N/A", "Shooter", "Unknown", "0.15", "0.03", "0.01", "0.02"},
            {"Risen 2: Dark Waters", "PS3", "2012", "Role-Playing", "Deep Silver", "0.04", "0.12", "0.01", "0.05"},
            {"Monster Jam: Path of Destruction", "PS3", "2010", "Racing", "Activision", "0.19", "0.02", "0.00", "0.02"},
            {"Spider-Man: Edge of Time", "PS3", "2011", "Action", "Activision", "0.13", "0.06", "0.00", "0.03"},
            {
                "Harry Potter and the Order of the Phoenix", "PS3", "2007", "Adventure", "Electronic Arts", "0.17", "0.03",
                "0.00", "0.03"
            },
            {
                "Ben 10 Ultimate Alien: Cosmic Destruction", "PS3", "2010", "Platform", "D3Publisher", "0.11", "0.08",
                "0.00", "0.03"
            },
            {"Bakugan: Battle Brawlers", "PS3", "2009", "Action", "Activision", "0.18", "0.02", "0.00", "0.02"},
            {
                "Hannah Montana: The Movie", "PS3", "2009", "Adventure", "Disney Interactive Studios", "0.14", "0.05",
                "0.00", "0.03"
            },
            {
                "Ar tonelico Qoga: Knell of Ar Ciel", "PS3", "2010", "Role-Playing", "Tecmo Koei", "0.07", "0.01", "0.13",
                "0.01"
            },
            {
                "3rd Super Robot Wars Z Jigoku Hen", "PS3", "2014", "Role-Playing", "Namco Bandai Games", "0.00", "0.00",
                "0.22", "0.00"
            },
            {
                "Family Guy: Back to the Multiverse", "PS3", "2012", "Action", "Activision", "0.09", "0.08", "0.00", "0.04"
            },
            {"MotoGP 09/10", "PS3", "2010", "Racing", "Capcom", "0.05", "0.12", "0.00", "0.04"},
            {
                "SingStar Pop Edition", "PS3", "2009", "Misc", "Sony Computer Entertainment", "0.00", "0.17", "0.00",
                "0.05"
            },
            {
                "Puppeteer", "PS3", "2013", "Platform", "Sony Computer Entertainment Europe", "0.08", "0.07", "0.02",
                "0.04"
            },
            {
                "Cabela's Outdoor Adventures (2009)", "PS3", "2009", "Sports", "Activision Value", "0.20", "0.00", "0.00",
                "0.01"
            },
            {
                "Gekijouban Macross F: Itsuwarino Utahime - Hybrid Pack", "PS3", "2010", "Action", "Namco Bandai Games",
                "0.00", "0.00", "0.21", "0.00"
            },
            {"G-Force", "PS3", "2009", "Action", "Disney Interactive Studios", "0.13", "0.06", "0.00", "0.03"},
            {"Cross Edge", "PS3", "2008", "Role-Playing", "Nippon Ichi Software", "0.12", "0.02", "0.05", "0.02"},
            {"Game of Thrones", "PS3", "2012", "Role-Playing", "Focus Home Interactive", "0.08", "0.09", "0.00", "0.04"},
            {"Just Dance Kids 2", "PS3", "2011", "Misc", "Ubisoft", "0.09", "0.08", "0.00", "0.04"},
            {"TV Superstars", "PS3", "2010", "Misc", "Sony Computer Entertainment", "0.05", "0.12", "0.00", "0.04"},
            {"Pictionary: Ultimate Edition", "PS3", "2011", "Misc", "THQ", "0.13", "0.05", "0.00", "0.03"},
            {"BlazBlue Chronophantasma", "PS3", "2013", "Fighting", "Arc System Works", "0.07", "0.00", "0.13", "0.00"},
            {
                "SBK X: Superbike World Championship", "PS3", "2010", "Racing", "Black Bean Games", "0.04", "0.12", "0.00",
                "0.04"
            },
            {"The Club", "PS3", "2008", "Shooter", "Sega", "0.12", "0.07", "0.00", "0.02"},
            {"F1 2014", "PS3", "2014", "Action", "Codemasters", "0.01", "0.12", "0.01", "0.07"},
            {"Afrika", "PS3", "2008", "Adventure", "Unknown", "0.12", "0.00", "0.08", "0.01"},
            {
                "LEGO Batman 3: Beyond Gotham", "PS3", "2014", "Action", "Warner Bros. Interactive Entertainment", "0.08",
                "0.08", "0.00", "0.05"
            },
            {"Grand Slam Tennis 2", "PS3", "2012", "Sports", "Electronic Arts", "0.08", "0.09", "0.00", "0.04"},
            {"Move Fitness", "PS3", "N/A", "Sports", "Sony Computer Entertainment", "0.00", "0.15", "0.00", "0.05"},
            {
                "Pro Yakyuu Spirits 2010", "PS3", "2010", "Sports", "Konami Digital Entertainment", "0.00", "0.00", "0.21",
                "0.00"
            },
            {
                "Jikkyou Powerful Pro Yakyuu 2012", "PS3", "2012", "Action", "Konami Digital Entertainment", "0.00", "0.00",
                "0.21", "0.00"
            },
            {"Angry Birds: Star Wars", "PS3", "2013", "Strategy", "Activision", "0.06", "0.09", "0.00", "0.05"},
            {"Cabela's Big Game Hunter 2012", "PS3", "2011", "Sports", "Activision", "0.15", "0.03", "0.00", "0.02"},
            {"Star Trek: The Game", "PS3", "2013", "Action", "Namco Bandai Games", "0.08", "0.08", "0.00", "0.04"},
            {"Child of Eden", "PS3", "2011", "Shooter", "Ubisoft", "0.07", "0.09", "0.00", "0.04"},
            {"G.I. Joe: The Rise of Cobra", "PS3", "2009", "Action", "Electronic Arts", "0.11", "0.06", "0.00", "0.03"},
            {
                "Middle-Earth: Shadow of Mordor", "PS3", "2014", "Action", "Warner Bros. Interactive Entertainment", "0.07",
                "0.08", "0.00", "0.05"
            },
            {"Enchanted Arms", "PS3", "2007", "Role-Playing", "Ubisoft", "0.17", "0.01", "0.00", "0.02"},
            {
                "SingStar: Back to the 80s", "PS3", "2011", "Misc", "Sony Computer Entertainment", "0.00", "0.14", "0.00",
                "0.06"
            },
            {
                "Rune Factory: Tides of Destiny", "PS3", "2011", "Role-Playing", "Marvelous Interactive", "0.13", "0.00",
                "0.07", "0.01"
            },
            {"The Amazing Spider-Man 2 (2014)", "PS3", "2014", "Action", "Activision", "0.04", "0.09", "0.01", "0.05"},
            {
                "Pro Yakyuu Spirits 2013", "PS3", "2013", "Sports", "Konami Digital Entertainment", "0.00", "0.00", "0.20",
                "0.00"
            },
            {
                "WRC: FIA World Rally Championship", "PS3", "N/A", "Racing", "Black Bean Games", "0.00", "0.13", "0.01",
                "0.05"
            },
            {
                "One Piece Unlimited World: Red", "PS3", "2014", "Action", "Namco Bandai Games", "0.04", "0.07", "0.05",
                "0.04"
            },
            {
                "Pinball Hall of Fame: The Williams Collection", "PS3", "2009", "Misc", "Crave Entertainment", "0.18",
                "0.00", "0.00", "0.01"
            },
            {"Killer is Dead", "PS3", "2013", "Action", "Deep Silver", "0.10", "0.03", "0.05", "0.02"},
            {"Baja: Edge of Control", "PS3", "2008", "Racing", "THQ", "0.09", "0.07", "0.00", "0.03"},
            {"Clive Barker's Jericho", "PS3", "2007", "Shooter", "Codemasters", "0.16", "0.01", "0.00", "0.02"},
            {"Way of the Samurai 4", "PS3", "2011", "Action", "Nippon Ichi Software", "0.00", "0.03", "0.16", "0.01"},
            {"Kung Fu Rider", "PS3", "2010", "Action", "Sony Computer Entertainment", "0.06", "0.09", "0.01", "0.04"},
            {
                "Mobile Suit Gundam: Crossfire", "PS3", "2006", "Simulation", "Namco Bandai Games", "0.05", "0.00", "0.14",
                "0.01"
            },
            {
                "Ratchet & Clank: Full Frontal Assault", "PS3", "2012", "Action", "Sony Computer Entertainment", "0.16",
                "0.01", "0.00", "0.02"
            },
            {"Kamen Rider: Battride War", "PS3", "2013", "Action", "Namco Bandai Games", "0.00", "0.00", "0.19", "0.00"},
            {"Project Versus J", "PS3", "2014", "Action", "Namco Bandai Games", "0.00", "0.00", "0.19", "0.00"},
            {"Sniper Elite 3", "PS3", "2014", "Action", "505 Games", "0.03", "0.10", "0.00", "0.06"},
            {
                "Champion Jockey: G1 Jockey & Gallop Racer", "PS3", "2011", "Sports", "Tecmo Koei", "0.05", "0.04", "0.08",
                "0.02"
            },
            {"Alien: Isolation", "PS3", "2014", "Shooter", "Sega", "0.05", "0.09", "0.00", "0.05"},
            {"Afro Samurai", "PS3", "2009", "Action", "Atari", "0.11", "0.05", "0.00", "0.03"},
            {"Quantum Theory", "PS3", "2010", "Shooter", "Tecmo Koei", "0.05", "0.09", "0.02", "0.03"},
            {
                "Untold Legends: Dark Kingdom", "PS3", "2006", "Role-Playing", "Electronic Arts", "0.13", "0.02", "0.02",
                "0.02"
            },
            {
                "Pro Yakyuu Spirits 2012", "PS3", "2012", "Action", "Konami Digital Entertainment", "0.00", "0.00", "0.19",
                "0.00"
            },
            {"Rock Band Country Track Pack", "PS3", "2009", "Misc", "MTV Games", "0.17", "0.00", "0.00", "0.01"},
            {"Armored Core 4", "PS3", "2006", "Simulation", "505 Games", "0.08", "0.00", "0.09", "0.01"},
            {"International Cricket 2010", "PS3", "2010", "Sports", "Codemasters", "0.00", "0.14", "0.00", "0.05"},
            {"Anarchy Reigns", "PS3", "2012", "Action", "Sega", "0.08", "0.02", "0.06", "0.01"},
            {"Rise of the Argonauts", "PS3", "2008", "Role-Playing", "Codemasters", "0.05", "0.11", "0.00", "0.03"},
            {
                "Major League Baseball 2K11", "PS3", "2011", "Sports", "Take-Two Interactive", "0.14", "0.03", "0.00",
                "0.02"
            },
            {"Bolt", "PS3", "2008", "Adventure", "Disney Interactive Studios", "0.12", "0.04", "0.00", "0.02"},
            {"Armored Core: For Answer", "PS3", "2008", "Simulation", "Ubisoft", "0.05", "0.02", "0.10", "0.01"},
            {
                "Castlevania: Lords of Shadow 2", "PS3", "2014", "Action", "Konami Digital Entertainment", "0.03", "0.09",
                "0.01", "0.05"
            },
            {
                "Birds of Steel", "PS3", "2012", "Simulation", "Konami Digital Entertainment", "0.07", "0.07", "0.02",
                "0.03"
            },
            {
                "Major League Baseball 2K10", "PS3", "2010", "Sports", "Take-Two Interactive", "0.17", "0.00", "0.00",
                "0.01"
            },
            {"Conflict: Denied Ops", "PS3", "2008", "Shooter", "Eidos Interactive", "0.05", "0.10", "0.00", "0.03"},
            {
                "Pro Yakyuu Spirits 2011", "PS3", "2011", "Sports", "Konami Digital Entertainment", "0.00", "0.00", "0.18",
                "0.00"
            },
            {"Disgaea D2", "PS3", "2013", "Action", "Nippon Ichi Software", "0.07", "0.00", "0.10", "0.01"},
            {"50 Cent: Blood on the Sand", "PS3", "2009", "Shooter", "THQ", "0.09", "0.06", "0.01", "0.03"},
            {"Apache: Air Assault", "PS3", "2010", "Simulation", "Activision", "0.10", "0.05", "0.00", "0.03"},
            {"Biohazard: Revival Selection", "PS3", "2011", "Action", "Capcom", "0.00", "0.00", "0.18", "0.00"},
            {"Carnival Island", "PS3", "2011", "Misc", "Sony Computer Entertainment", "0.09", "0.06", "0.00", "0.03"},
            {"de Blob 2", "PS3", "2011", "Platform", "THQ", "0.08", "0.06", "0.00", "0.03"},
            {"Full Auto 2: Battlelines", "PS3", "2006", "Racing", "Sega", "0.13", "0.02", "0.00", "0.02"},
            {"Lost Planet 3", "PS3", "2013", "Action", "Capcom", "0.05", "0.04", "0.06", "0.02"},
            {"Hitman: HD Trilogy", "PS3", "2013", "Action", "Square Enix", "0.05", "0.08", "0.00", "0.04"},
            {"Cars: Race-O-Rama", "PS3", "2009", "Racing", "THQ", "0.13", "0.02", "0.00", "0.02"},
            {
                "Earth Defense Force: Insect Armageddon", "PS3", "2011", "Shooter", "D3Publisher", "0.04", "0.04", "0.08",
                "0.02"
            },
            {"Rapala Fishing Frenzy 2009", "PS3", "2008", "Sports", "Activision", "0.16", "0.00", "0.00", "0.01"},
            {"Captain America: Super Soldier", "PS3", "2011", "Action", "Sega", "0.09", "0.06", "0.00", "0.03"},
            {"Shrek: Forever After", "PS3", "2010", "Platform", "Activision", "0.14", "0.01", "0.00", "0.01"},
            {"Warriors: Legends of Troy", "PS3", "2011", "Action", "Tecmo Koei", "0.05", "0.04", "0.07", "0.02"},
            {"Major League Baseball 2K9", "PS3", "2009", "Sports", "Spike", "0.16", "0.00", "0.00", "0.01"},
            {
                "Major League Baseball 2K12", "PS3", "2012", "Sports", "Take-Two Interactive", "0.16", "0.00", "0.00",
                "0.01"
            },
            {
                "LittleBigPlanet 3", "PS3", "2014", "Platform", "Sony Computer Entertainment", "0.05", "0.07", "0.00",
                "0.04"
            },
            {"Ice Age: Dawn of the Dinosaurs", "PS3", "2009", "Platform", "Activision", "0.12", "0.03", "0.00", "0.02"},
            {"FaceBreaker", "PS3", "2008", "Fighting", "Electronic Arts", "0.13", "0.02", "0.00", "0.02"},
            {
                "Saw II: Flesh & Blood", "PS3", "2010", "Action", "Konami Digital Entertainment", "0.09", "0.05", "0.00",
                "0.03"
            },
            {"Trinity Universe", "PS3", "2009", "Role-Playing", "Nippon Ichi Software", "0.07", "0.05", "0.03", "0.02"},
            {
                "No More Heroes: Heroes' Paradise", "PS3", "2010", "Action", "Konami Digital Entertainment", "0.09", "0.03",
                "0.04", "0.02"
            },
            {"Plants vs. Zombies", "PS3", "2011", "Strategy", "PopCap Games", "0.16", "0.00", "0.00", "0.01"},
            {"Rango: The Video Game", "PS3", "2011", "Action", "Electronic Arts", "0.05", "0.08", "0.00", "0.03"},
            {"SingStar Motown", "PS3", "2009", "Misc", "Sony Computer Entertainment", "0.00", "0.15", "0.00", "0.02"},
            {"College Hoops 2K7", "PS3", "2007", "Sports", "Take-Two Interactive", "0.16", "0.00", "0.00", "0.01"},
            {
                "Atelier Escha & Logy: Alchemist of Dusk Sky", "PS3", "2013", "Role-Playing", "Tecmo Koei", "0.03", "0.02",
                "0.10", "0.01"
            },
            {
                "Buzz! Brain of the UK", "PS3", "2009", "Misc", "Sony Computer Entertainment", "0.00", "0.15", "0.00",
                "0.02"
            },
            {"MotoGP 10/11", "PS3", "2011", "Racing", "Capcom", "0.04", "0.09", "0.00", "0.04"},
            {"CSI: Fatal Conspiracy", "PS3", "2010", "Adventure", "Ubisoft", "0.10", "0.04", "0.00", "0.02"},
            {"Brunswick Pro Bowling", "PS3", "2010", "Sports", "505 Games", "0.09", "0.05", "0.00", "0.03"},
            {"Ashes Cricket 2009", "PS3", "2009", "Sports", "Codemasters", "0.00", "0.15", "0.00", "0.02"},
            {
                "Farming Simulator 2013", "PS3", "2013", "Action", "Focus Home Interactive", "0.00", "0.09", "0.02", "0.05"
            },
            {
                "Journey", "PS3", "2012", "Adventure", "Sony Computer Entertainment Europe", "0.00", "0.11", "0.00", "0.06"
            },
            {"Stormrise", "PS3", "2009", "Strategy", "Sega", "0.13", "0.02", "0.00", "0.02"},
            {"Marvel Super Hero Squad: Comic Combat", "PS3", "2011", "Action", "THQ", "0.10", "0.04", "0.00", "0.02"},
            {"How to Train Your Dragon", "PS3", "2010", "Action", "Activision", "0.12", "0.03", "0.00", "0.02"},
            {
                "UFC Personal Trainer: The Ultimate Fitness System", "PS3", "2011", "Sports", "THQ", "0.06", "0.07", "0.00",
                "0.03"
            },
            {"The BIGS", "PS3", "2007", "Sports", "Take-Two Interactive", "0.15", "0.00", "0.00", "0.01"},
            {
                "The Witch and the Hundred Soldiers", "PS3", "2013", "Role-Playing", "Nippon Ichi Software", "0.04", "0.01",
                "0.10", "0.01"
            },
            {"Jurassic: The Hunted", "PS3", "2009", "Shooter", "Activision", "0.15", "0.00", "0.00", "0.01"},
            {
                "The Chronicles of Narnia: Prince Caspian", "PS3", "2008", "Action", "Disney Interactive Studios", "0.13",
                "0.01", "0.00", "0.02"
            },
            {
                "Cabela's Survival: Shadows of Katmai", "PS3", "2011", "Sports", "Activision", "0.09", "0.04", "0.00",
                "0.02"
            },
            {"DiRT Showdown", "PS3", "2012", "Action", "Codemasters", "0.02", "0.10", "0.00", "0.04"},
            {
                "DanceDanceRevolution", "PS3", "2010", "Simulation", "Konami Digital Entertainment", "0.11", "0.03", "0.00",
                "0.02"
            },
            {"WRC 2: FIA World Rally Championship", "PS3", "2011", "Racing", "Ubisoft", "0.00", "0.12", "0.00", "0.04"},
            {"Backbreaker", "PS3", "N/A", "Sports", "Unknown", "0.15", "0.00", "0.00", "0.01"},
            {"Heavy Fire: Afghanistan", "PS3", "2011", "Shooter", "Unknown", "0.15", "0.00", "0.00", "0.01"},
            {"NCAA Basketball 09", "PS3", "2008", "Sports", "Electronic Arts", "0.15", "0.00", "0.00", "0.01"},
            {"You Don't Know Jack", "PS3", "2011", "Misc", "THQ", "0.15", "0.00", "0.00", "0.01"},
            {"The Idolm@ster 2", "PS3", "2011", "Misc", "Namco Bandai Games", "0.00", "0.00", "0.16", "0.00"},
            {"Beowulf: The Game", "PS3", "2007", "Action", "Ubisoft", "0.14", "0.01", "0.00", "0.01"},
            {"The Cursed Crusade", "PS3", "2011", "Action", "DTP Entertainment", "0.06", "0.06", "0.01", "0.03"},
            {"Ridge Racer Unbounded", "PS3", "2012", "Racing", "Namco Bandai Games", "0.04", "0.08", "0.00", "0.03"},
            {"TimeShift", "PS3", "2007", "Shooter", "Vivendi Games", "0.14", "0.00", "0.00", "0.01"},
            {
                "Air Conflicts: Secret Wars", "PS3", "2011", "Simulation", "bitComposer Games", "0.07", "0.05", "0.00",
                "0.03"
            },
            {
                "EyePet & Friends", "PS3", "2011", "Simulation", "Sony Computer Entertainment", "0.05", "0.08", "0.00",
                "0.03"
            },
            {"Arcana Heart 3", "PS3", "2011", "Fighting", "PQube", "0.01", "0.04", "0.09", "0.02"},
            {
                "Tokitowa: Time and Eternity", "PS3", "2012", "Action", "Nippon Ichi Software", "0.05", "0.02", "0.06",
                "0.01"
            },
            {"Fracture", "PS3", "2008", "Shooter", "LucasArts", "0.10", "0.03", "0.00", "0.02"},
            {"MindJack", "PS3", "2011", "Shooter", "Square Enix", "0.05", "0.07", "0.00", "0.03"},
            {"Heroes over Europe", "PS3", "2009", "Simulation", "Ubisoft", "0.11", "0.02", "0.00", "0.02"},
            {"Shaun White Skateboarding", "PS3", "2010", "Sports", "Ubisoft", "0.09", "0.04", "0.00", "0.02"},
            {"All-Pro Football 2K8", "PS3", "2007", "Sports", "Take-Two Interactive", "0.14", "0.00", "0.00", "0.01"},
            {"Mugen Souls", "PS3", "2012", "Action", "Nippon Ichi Software", "0.04", "0.02", "0.08", "0.01"},
            {
                "The Lord of the Rings: Aragorn's Quest", "PS3", "2010", "Action", "Warner Bros. Interactive Entertainment",
                "0.09", "0.04", "0.00", "0.02"
            },
            {
                "NPPL Championship Paintball 2009", "PS3", "2008", "Shooter", "Activision Value", "0.14", "0.00", "0.00",
                "0.01"
            },
            {
                "The King of Fighters XII", "PS3", "2009", "Fighting", "Ignition Entertainment", "0.10", "0.00", "0.03",
                "0.01"
            },
            {
                "Pro Yakyuu Spirits 6", "PS3", "2009", "Sports", "Konami Digital Entertainment", "0.00", "0.00", "0.15",
                "0.00"
            },
            {"Splatterhouse", "PS3", "N/A", "Action", "Namco Bandai Games", "0.12", "0.02", "0.00", "0.01"},
            {
                "Metal Gear Solid: Peace Walker HD Edition", "PS3", "2011", "Action", "Konami Digital Entertainment",
                "0.00", "0.00", "0.15", "0.00"
            },
            {
                "PlayStation Move Heroes", "PS3", "2011", "Platform", "Sony Computer Entertainment", "0.06", "0.06", "0.00",
                "0.02"
            },
            {
                "Hyperdimension Neptunia Victory", "PS3", "2012", "Role-Playing", "Compile Heart", "0.04", "0.03", "0.06",
                "0.02"
            },
            {
                "Marvel Super Hero Squad: The Infinity Gauntlet", "PS3", "2010", "Action", "THQ", "0.10", "0.03", "0.00",
                "0.02"
            },
            {"Hatsune Miku: Project Diva F 2nd", "PS3", "2014", "Misc", "Sega", "0.02", "0.02", "0.09", "0.01"},
            {"NHL 15", "PS3", "2014", "Action", "Electronic Arts", "0.07", "0.04", "0.00", "0.03"},
            {"Sengoku Musou 3 Empires", "PS3", "2011", "Action", "Tecmo Koei", "0.00", "0.00", "0.14", "0.00"},
            {
                "Hellboy: The Science of Evil", "PS3", "2008", "Action", "Konami Digital Entertainment", "0.11", "0.02",
                "0.00", "0.01"
            },
            {"NHL 2K10", "PS3", "2009", "Sports", "Take-Two Interactive", "0.12", "0.01", "0.00", "0.01"},
            {
                "Fantastic Four: Rise of the Silver Surfer", "PS3", "2007", "Action", "Take-Two Interactive", "0.11",
                "0.02", "0.00", "0.02"
            },
            {"Okami", "PS3", "2012", "Adventure", "Capcom", "0.00", "0.00", "0.14", "0.00"},
            {
                "Green Lantern: Rise of the Manhunters", "PS3", "2011", "Action", "Warner Bros. Interactive Entertainment",
                "0.08", "0.04", "0.00", "0.02"
            },
            {"Fairytale Fights", "PS3", "2009", "Action", "Playlogic Game Factory", "0.10", "0.03", "0.00", "0.02"},
            {
                "Dynasty Warriors 8: Xtreme Legends", "PS3", "2013", "Action", "Tecmo Koei", "0.01", "0.01", "0.10", "0.01"
            },
            {
                "Disney Sing It: Family Hits", "PS3", "2010", "Misc", "Disney Interactive Studios", "0.09", "0.03", "0.00",
                "0.02"
            },
            {"Dynasty Warriors 7: Empires", "PS3", "2012", "Action", "Ubisoft Annecy", "0.00", "0.00", "0.14", "0.00"},
            {
                "NBA 09: The Inside", "PS3", "2008", "Sports", "Sony Computer Entertainment", "0.13", "0.00", "0.00",
                "0.01"
            },
            {"Soldier of Fortune: Payback", "PS3", "2007", "Shooter", "Activision", "0.11", "0.01", "0.00", "0.01"},
            {"NBA Street Homecourt", "PS3", "2007", "Sports", "Electronic Arts", "0.11", "0.01", "0.00", "0.01"},
            {
                "Blazing Angels 2: Secret Missions of WWII", "PS3", "2007", "Simulation", "Ubisoft", "0.09", "0.03", "0.00",
                "0.02"
            },
            {"Megamind: Ultimate Showdown", "PS3", "2010", "Adventure", "THQ", "0.06", "0.05", "0.00", "0.02"},
            {
                "Bakugan Battle Brawlers: Defenders of the Core", "PS3", "2010", "Action", "Activision", "0.12", "0.01",
                "0.00", "0.01"
            },
            {"Blitz: The League II", "PS3", "2008", "Sports", "Midway Games", "0.10", "0.02", "0.00", "0.02"},
            {"Nobunaga no Yabou: Tendou", "PS3", "2010", "Strategy", "Tecmo Koei", "0.00", "0.00", "0.13", "0.00"},
            {"Power Gig: Rise of the SixString", "PS3", "2010", "Misc", "Unknown", "0.13", "0.00", "0.00", "0.01"},
            {"Chaotic: Shadow Warriors", "PS3", "2009", "Action", "Activision", "0.12", "0.00", "0.00", "0.01"},
            {"NFL Head Coach 09", "PS3", "2008", "Sports", "Electronic Arts", "0.12", "0.00", "0.00", "0.01"},
            {"Nobunaga no Yabou: Souzou", "PS3", "2013", "Strategy", "Tecmo Koei", "0.00", "0.00", "0.13", "0.00"},
            {
                "Jikkyou Powerful Pro Yakyuu 2014", "PS3", "2014", "Sports", "Konami Digital Entertainment", "0.00", "0.00",
                "0.13", "0.00"
            },
            {"My Fitness Coach: Club", "PS3", "2011", "Sports", "Ubisoft", "0.00", "0.09", "0.00", "0.04"},
            {"NBA 08", "PS3", "2007", "Sports", "Sony Computer Entertainment", "0.12", "0.00", "0.00", "0.01"},
            {
                "Watchmen: The End is Nigh - The Complete Experience", "PS3", "2009", "Action",
                "Warner Bros. Interactive Entertainment", "0.08", "0.03", "0.00", "0.02"
            },
            {
                "Pro Yaky? Spirits 2014", "PS3", "2014", "Sports", "Konami Digital Entertainment", "0.00", "0.00", "0.13",
                "0.00"
            },
            {"Rogue Warrior", "PS3", "2009", "Shooter", "Bethesda Softworks", "0.10", "0.01", "0.00", "0.01"},
            {"College Hoops 2K8", "PS3", "2007", "Sports", "Take-Two Interactive", "0.12", "0.00", "0.00", "0.01"},
            {"X-Blades", "PS3", "2009", "Action", "SouthPeak Games", "0.07", "0.02", "0.02", "0.02"},
            {"Alone in the Dark: Inferno", "PS3", "2008", "Adventure", "Atari", "0.08", "0.03", "0.00", "0.02"},
            {"NHL 2K9", "PS3", "2008", "Sports", "Take-Two Interactive", "0.11", "0.01", "0.00", "0.01"},
            {
                "Cabela's Dangerous Hunts 2009", "PS3", "2008", "Sports", "Activision Value", "0.12", "0.00", "0.00",
                "0.01"
            },
            {"Deadly Premonition", "PS3", "2010", "Action", "Rising Star Games", "0.06", "0.04", "0.00", "0.02"},
            {"The X-Factor", "PS3", "2010", "Misc", "Deep Silver", "0.00", "0.09", "0.00", "0.04"},
            {"Thor: God of Thunder", "PS3", "2011", "Action", "Sega", "0.06", "0.04", "0.00", "0.02"},
            {
                "Eat Lead: The Return of Matt Hazard", "PS3", "2009", "Shooter", "D3Publisher", "0.09", "0.02", "0.00",
                "0.01"
            },
            {
                "High Velocity Bowling", "PS3", "2010", "Sports", "Sony Computer Entertainment", "0.12", "0.00", "0.00",
                "0.01"
            },
            {"Create", "PS3", "2010", "Misc", "Electronic Arts", "0.08", "0.03", "0.00", "0.02"},
            {
                "TRINITY: Souls of Zill O'll", "PS3", "2010", "Role-Playing", "Ubisoft Annecy", "0.05", "0.03", "0.03",
                "0.01"
            },
            {"Fairy Fencer F", "PS3", "2013", "Role-Playing", "Nippon Ichi Software", "0.02", "0.01", "0.08", "0.01"},
            {
                "Soccer Tsuku: Pro Soccer Club o Tsukurou!", "PS3", "2013", "Sports", "Sega", "0.00", "0.00", "0.12",
                "0.00"
            },
            {"MotionSports: Adrenaline", "PS3", "2011", "Sports", "Ubisoft", "0.06", "0.05", "0.00", "0.02"},
            {"NHL 2K7", "PS3", "2006", "Sports", "Take-Two Interactive", "0.11", "0.00", "0.00", "0.01"},
            {"Syndicate", "PS3", "2012", "Shooter", "EA Games", "0.05", "0.05", "0.00", "0.02"},
            {"SingStar Vol. 3", "PS3", "2008", "Misc", "Sony Computer Entertainment", "0.00", "0.09", "0.00", "0.04"},
            {
                "Scene It? Bright Lights! Big Screen!", "PS3", "2009", "Misc", "Warner Bros. Interactive Entertainment",
                "0.10", "0.01", "0.00", "0.01"
            },
            {
                "Persona 4: The Ultimax Ultra Suplex Hold", "PS3", "2014", "Action", "Atlus", "0.00", "0.00", "0.12",
                "0.00"
            },
            {
                "The God of War Trilogy", "PS3", "2010", "Action", "Sony Computer Entertainment", "0.00", "0.07", "0.03",
                "0.02"
            },
            {"The IdolM@ster: One for All", "PS3", "2014", "Misc", "Namco Bandai Games", "0.00", "0.00", "0.12", "0.00"},
            {"The BIGS 2", "PS3", "2009", "Sports", "Take-Two Interactive", "0.11", "0.00", "0.00", "0.01"},
            {
                "Major League Baseball 2K13", "PS3", "2013", "Sports", "Take-Two Interactive", "0.11", "0.00", "0.00",
                "0.01"
            },
            {
                "The Legend of Heroes: Sen no Kiseki", "PS3", "2013", "Role-Playing", "Nihon Falcom Corporation", "0.00",
                "0.00", "0.12", "0.00"
            },
            {"GRID: Autosport", "PS3", "2014", "Racing", "Codemasters", "0.01", "0.06", "0.00", "0.04"},
            {"Yakuza", "PS3", "2012", "Adventure", "Sega", "0.00", "0.00", "0.11", "0.00"},
            {"Everybody Dance", "PS3", "2011", "Misc", "Sony Computer Entertainment", "0.11", "0.00", "0.00", "0.01"},
            {"Record of Agarest War Zero", "PS3", "N/A", "Strategy", "Ghostlight", "0.08", "0.00", "0.03", "0.00"},
            {"Bejeweled 3", "PS3", "N/A", "Puzzle", "Unknown", "0.11", "0.00", "0.00", "0.01"},
            {"Legendary", "PS3", "2008", "Shooter", "Atari", "0.07", "0.03", "0.00", "0.02"},
            {"Armored Core: Verdict Day", "PS3", "2013", "Action", "From Software", "0.00", "0.00", "0.11", "0.00"},
            {"Rock Band Track Pack Volume 2", "PS3", "2008", "Misc", "MTV Games", "0.10", "0.00", "0.00", "0.01"},
            {"Fit in Six", "PS3", "2011", "Sports", "Ubisoft", "0.11", "0.00", "0.00", "0.01"},
            {"Record of Agarest War 2", "PS3", "2010", "Role-Playing", "Compile Heart", "0.07", "0.00", "0.04", "0.00"},
            {"Venetica", "PS3", "2010", "Role-Playing", "DTP Entertainment", "0.07", "0.03", "0.00", "0.02"},
            {
                "Pro Yakyuu Spirits 5", "PS3", "2008", "Sports", "Konami Digital Entertainment", "0.00", "0.00", "0.11",
                "0.00"
            },
            {"Rock Band: Metal Track Pack", "PS3", "2009", "Misc", "MTV Games", "0.10", "0.00", "0.00", "0.01"},
            {"NBA Ballers: Chosen One", "PS3", "2008", "Sports", "Midway Games", "0.10", "0.00", "0.00", "0.01"},
            {
                "Mobile Suit Gundam Side Story: Missing Link", "PS3", "2014", "Action", "Namco Bandai Games", "0.00",
                "0.00", "0.11", "0.00"
            },
            {
                "Shin Kamaitachi no Yoru: 11 Hitome no Suspect", "PS3", "2011", "Adventure", "THQ", "0.00", "0.00", "0.11",
                "0.00"
            },
            {"NCIS", "PS3", "2011", "Adventure", "Ubisoft", "0.06", "0.03", "0.00", "0.02"},
            {"SingStar Latino", "PS3", "2009", "Misc", "Sony Computer Entertainment", "0.10", "0.00", "0.00", "0.01"},
            {"NeverDead", "PS3", "2012", "Shooter", "Konami Digital Entertainment", "0.05", "0.03", "0.01", "0.02"},
            {"Angry Birds Trilogy", "PS3", "2012", "Action", "Activision", "0.08", "0.01", "0.00", "0.01"},
            {"NFL Tour", "PS3", "2008", "Sports", "Electronic Arts", "0.09", "0.00", "0.00", "0.01"},
            {"Tom Clancy's Splinter Cell Trilogy", "PS3", "2011", "Action", "Ubisoft", "0.00", "0.08", "0.00", "0.03"},
            {
                "SBK 2011: FIM Superbike World Championship", "PS3", "2011", "Racing", "Black Bean Games", "0.00", "0.08",
                "0.00", "0.03"
            },
            {
                "Karaoke Revolution Presents American Idol Encore 2", "PS3", "2008", "Misc", "Konami Digital Entertainment",
                "0.10", "0.00", "0.00", "0.01"
            },
            {
                "Disney Sing It: Party Hits", "PS3", "2010", "Misc", "Disney Interactive Studios", "0.08", "0.01", "0.00",
                "0.01"
            },
            {"Overlord: Raising Hell", "PS3", "2008", "Adventure", "Codemasters", "0.06", "0.03", "0.00", "0.02"},
            {
                "Macross 30: Ginga o Tsunagu Utagoe", "PS3", "2013", "Shooter", "Namco Bandai Games", "0.00", "0.00",
                "0.10", "0.00"
            },
            {"Kidou Senshi Gundam UC", "PS3", "2012", "Action", "Namco Bandai Games", "0.00", "0.00", "0.10", "0.00"},
            {"DreamWorks Super Star Kartz", "PS3", "2011", "Racing", "Activision", "0.06", "0.03", "0.00", "0.02"},
            {"Planet 51", "PS3", "2009", "Action", "Sega", "0.07", "0.02", "0.00", "0.01"},
            {
                "PDC World Championship Darts: Pro Tour", "PS3", "2010", "Sports", "O-Games", "0.00", "0.07", "0.00",
                "0.03"
            },
            {
                "Where the Wild Things Are", "PS3", "2009", "Platform", "Warner Bros. Interactive Entertainment", "0.08",
                "0.01", "0.00", "0.01"
            },
            {
                "Metal Gear Solid HD Edition", "PS3", "2011", "Action", "Konami Digital Entertainment", "0.00", "0.00",
                "0.10", "0.00"
            },
            {
                "Monkey Island: Special Edition Collection", "PS3", "2011", "Adventure", "Activision", "0.00", "0.07",
                "0.00", "0.03"
            },
            {
                "Tears to Tiara II: Haou no Matsuei", "PS3", "2013", "Role-Playing", "Nippon Ichi Software", "0.03", "0.01",
                "0.05", "0.01"
            },
            {
                "JASF: Jane's Advanced Strike Fighters", "PS3", "2011", "Simulation", "Deep Silver", "0.06", "0.03", "0.00",
                "0.01"
            },
            {"John Daly's ProStroke Golf", "PS3", "2010", "Sports", "O-Games", "0.08", "0.01", "0.00", "0.01"},
            {
                "Cabela's North American Adventures", "PS3", "2010", "Sports", "Activision", "0.09", "0.00", "0.00", "0.01"
            },
            {
                "Karaoke Revolution", "PS3", "2009", "Misc", "Konami Digital Entertainment", "0.07", "0.02", "0.00", "0.01"
            },
            {"Fuse", "PS3", "2013", "Shooter", "Electronic Arts", "0.05", "0.03", "0.00", "0.02"},
            {"Rock Band Track Pack: Classic Rock", "PS3", "2009", "Misc", "MTV Games", "0.09", "0.00", "0.00", "0.01"},
            {"World Snooker Championship 2007", "PS3", "2007", "Sports", "Sega", "0.00", "0.10", "0.00", "0.00"},
            {
                "World Series of Poker 2008: Battle for the Bracelets", "PS3", "2007", "Misc", "Activision", "0.08", "0.01",
                "0.00", "0.01"
            },
            {"Wipeout 2", "PS3", "2011", "Misc", "Activision", "0.09", "0.00", "0.00", "0.01"},
            {
                "The History Channel: Civil War - Secret Missions", "PS3", "2008", "Shooter", "Activision", "0.09", "0.00",
                "0.00", "0.01"
            },
            {
                "Leisure Suit Larry: Box Office Bust", "PS3", "2009", "Adventure", "Codemasters", "0.06", "0.02", "0.00",
                "0.01"
            },
            {"Rio", "PS3", "2011", "Misc", "THQ", "0.03", "0.05", "0.00", "0.02"},
            {
                "After Hours Athletes", "PS3", "2011", "Sports", "Sony Computer Entertainment", "0.00", "0.07", "0.00",
                "0.03"
            },
            {"Ultimate Marvel vs. Capcom 3", "PS3", "2011", "Fighting", "Capcom", "0.00", "0.04", "0.04", "0.02"},
            {"Cloudy With a Chance of Meatballs", "PS3", "2009", "Adventure", "Ubisoft", "0.08", "0.01", "0.00", "0.01"},
            {"Bodycount", "PS3", "2011", "Shooter", "Codemasters", "0.04", "0.04", "0.00", "0.02"},
            {
                "Start the Party! Save the World", "PS3", "2011", "Misc", "Sony Computer Entertainment", "0.00", "0.07",
                "0.00", "0.03"
            },
            {
                "Teenage Mutant Ninja Turtles: Danger of the Ooze", "PS3", "2014", "Action", "Activision", "0.02", "0.05",
                "0.00", "0.03"
            },
            {"Ar no Surge", "PS3", "2014", "Role-Playing", "Tecmo Koei", "0.01", "0.02", "0.05", "0.01"},
            {
                "Kamen Rider: Battride War II", "PS3", "2014", "Action", "Namco Bandai Games", "0.00", "0.00", "0.09",
                "0.00"
            },
            {"Resident Evil Chronicles HD", "PS3", "2012", "Shooter", "Capcom", "0.00", "0.00", "0.09", "0.00"},
            {
                "Lucha Libre AAA: Heroes del Ring", "PS3", "2010", "Fighting", "Konami Digital Entertainment", "0.09",
                "0.00", "0.00", "0.00"
            },
            {"NHL 2K8", "PS3", "2007", "Sports", "Take-Two Interactive", "0.08", "0.01", "0.00", "0.01"},
            {"Ski-Doo Snowmobile Challenge", "PS3", "2009", "Racing", "PQube", "0.09", "0.00", "0.00", "0.01"},
            {"NatGeo Challenge! Wild Life", "PS3", "2010", "Misc", "Black Bean Games", "0.05", "0.03", "0.00", "0.01"},
            {"nail'd", "PS3", "2010", "Racing", "Deep Silver", "0.06", "0.02", "0.00", "0.01"},
            {"Murdered: Soul Suspect", "PS3", "2014", "Action", "Square Enix", "0.03", "0.03", "0.01", "0.02"},
            {"Kung Fu Panda 2", "PS3", "2011", "Action", "THQ", "0.04", "0.03", "0.00", "0.02"},
            {
                "The Legend of Heroes: Sen no Kiseki II", "PS3", "2014", "Role-Playing", "Nihon Falcom Corporation", "0.00",
                "0.00", "0.09", "0.00"
            },
            {
                "No More Heroes: Red Zone", "PS3", "2011", "Action", "Marvelous Interactive", "0.00", "0.00", "0.09",
                "0.00"
            },
            {"MySims SkyHeroes", "PS3", "2010", "Action", "Electronic Arts", "0.06", "0.02", "0.00", "0.01"},
            {"Damnation", "PS3", "2009", "Shooter", "Codemasters", "0.07", "0.01", "0.00", "0.01"},
            {"Yoostar2", "PS3", "2011", "Misc", "Unknown", "0.03", "0.04", "0.00", "0.02"},
            {
                "Romance of the Three Kingdoms XII", "PS3", "2012", "Strategy", "Tecmo Koei", "0.00", "0.00", "0.09",
                "0.00"
            },
            {"Blazblue: Continuum Shift Extend", "PS3", "2011", "Fighting", "PQube", "0.00", "0.00", "0.09", "0.00"},
            {
                "Family Game Night 4: The Game Show", "PS3", "2011", "Misc", "Electronic Arts", "0.07", "0.01", "0.00",
                "0.01"
            },
            {
                "Karaoke Revolution Presents American Idol Encore", "PS3", "2008", "Misc", "Konami Digital Entertainment",
                "0.08", "0.00", "0.00", "0.01"
            },
            {
                "Chou Jigen Game Neptune Mk-II", "PS3", "2011", "Role-Playing", "Compile Heart", "0.00", "0.00", "0.09",
                "0.00"
            },
            {"Supremacy MMA", "PS3", "2011", "Fighting", "505 Games", "0.05", "0.03", "0.00", "0.01"},
            {"NCAA March Madness 08", "PS3", "2007", "Sports", "Electronic Arts", "0.08", "0.00", "0.00", "0.01"},
            {"Beat Sketch!", "PS3", "2010", "Misc", "Sony Computer Entertainment", "0.00", "0.00", "0.08", "0.00"},
            {"Dance on Broadway", "PS3", "2011", "Misc", "Ubisoft", "0.04", "0.03", "0.00", "0.01"},
            {"Blades of Time", "PS3", "2012", "Action", "Konami Digital Entertainment", "0.03", "0.03", "0.01", "0.01"},
            {"Nascar Unleashed", "PS3", "2011", "Racing", "Activision", "0.08", "0.00", "0.00", "0.00"},
            {"Destroy All Humans! Path of the Furon", "PS3", "N/A", "Action", "THQ", "0.00", "0.07", "0.00", "0.01"},
            {
                "Tornado Outbreak", "PS3", "2009", "Action", "Konami Digital Entertainment", "0.08", "0.00", "0.00", "0.01"
            },
            {"SingStar Guitar", "PS3", "2010", "Misc", "Sony Computer Entertainment", "0.00", "0.06", "0.00", "0.02"},
            {"AquaPazza: AquaPlus Dream Match", "PS3", "2012", "Action", "Aqua Plus", "0.03", "0.00", "0.05", "0.00"},
            {"Last Rebellion", "PS3", "2010", "Role-Playing", "Nippon Ichi Software", "0.06", "0.01", "0.01", "0.01"},
            {"Truth or Lies", "PS3", "2010", "Misc", "THQ", "0.06", "0.01", "0.00", "0.01"},
            {
                "WSC Real 11: World Snooker Championship", "PS3", "2011", "Sports", "Koch Media", "0.00", "0.06", "0.00",
                "0.02"
            },
            {
                "SingStar: Made In Germany", "PS3", "2009", "Misc", "Sony Computer Entertainment", "0.00", "0.06", "0.00",
                "0.02"
            },
            {"Initial D: Extreme Stage", "PS3", "2008", "Racing", "Sega", "0.00", "0.00", "0.08", "0.00"},
            {"Brothers in Arms: Furious 4", "PS3", "2012", "Shooter", "Ubisoft", "0.01", "0.05", "0.00", "0.02"},
            {
                "ShellShock 2: Blood Trails", "PS3", "2009", "Shooter", "Eidos Interactive", "0.04", "0.03", "0.00", "0.01"
            },
            {"ESA Game Pack", "PS3", "2010", "Misc", "Sony Computer Entertainment", "0.08", "0.00", "0.00", "0.00"},
            {"Kagero: Darkside Princess", "PS3", "2014", "Action", "Tecmo Koei", "0.01", "0.01", "0.06", "0.01"},
            {
                "The Penguins of Madagascar: Dr. Blowhole Returns - Again!", "PS3", "2011", "Action", "THQ", "0.03", "0.03",
                "0.00", "0.02"
            },
            {"Blacksite: Area 51", "PS3", "2007", "Shooter", "Midway Games", "0.07", "0.01", "0.00", "0.01"},
            {"Ben 10 Galactic Racing", "PS3", "2011", "Racing", "D3Publisher", "0.05", "0.02", "0.00", "0.01"},
            {"Puss in Boots", "PS3", "2011", "Action", "THQ", "0.06", "0.01", "0.00", "0.01"},
            {"Cabela's Adventure Camp", "PS3", "2011", "Misc", "Activision", "0.04", "0.03", "0.00", "0.01"},
            {"Knights Contract", "PS3", "2011", "Action", "Namco Bandai Games", "0.04", "0.03", "0.00", "0.01"},
            {
                "Boku no Natsuyasumi 3: Hokkoku Hen: Chiisana Boku no Dai Sougen?", "PS3", "2007", "Adventure",
                "Sony Computer Entertainment", "0.00", "0.00", "0.08", "0.00"
            },
            {
                "Ratchet & Clank Future: Quest for Booty", "PS3", "2008", "Platform", "Sony Computer Entertainment", "0.00",
                "0.06", "0.00", "0.02"
            },
            {
                "AKB1/149: Love Election", "PS3", "2013", "Adventure", "Namco Bandai Games", "0.00", "0.00", "0.08", "0.00"
            },
            {
                "PAC-MAN and the Ghostly Adventures", "PS3", "2013", "Action", "Namco Bandai Games", "0.03", "0.03", "0.00",
                "0.02"
            },
            {"Tears to Tiara: Kakan no Daichi", "PS3", "2008", "Strategy", "Aqua Plus", "0.00", "0.00", "0.08", "0.00"},
            {
                "The Idolmaster: Gravure For You! Vol. 3", "PS3", "2011", "Misc", "Namco Bandai Games", "0.00", "0.00",
                "0.08", "0.00"
            },
            {
                "Deadliest Catch: Sea of Chaos", "PS3", "2010", "Sports", "Crave Entertainment", "0.07", "0.00", "0.00",
                "0.00"
            },
            {
                "Jikkyou Powerful Pro Yakyuu 2011 Ketteiban", "PS3", "2011", "Sports", "Konami Digital Entertainment",
                "0.00", "0.00", "0.07", "0.00"
            },
            {"The Smurfs 2", "PS3", "2013", "Action", "Ubisoft", "0.01", "0.04", "0.00", "0.02"},
            {
                "The Walking Dead: Season Two", "PS3", "2014", "Adventure", "Telltale Games", "0.03", "0.03", "0.00",
                "0.02"
            },
            {"Winning Post 7 2012", "PS3", "2012", "Sports", "Ackkstudios", "0.00", "0.00", "0.07", "0.00"},
            {
                "The History Channel: Battle for the Pacific", "PS3", "2008", "Shooter", "Activision", "0.06", "0.00",
                "0.00", "0.01"
            },
            {"Young Justice: Legacy", "PS3", "2013", "Adventure", "Namco Bandai Games", "0.05", "0.01", "0.00", "0.01"},
            {
                "Atelier Shallie: Alchemists of the Dusk Sea", "PS3", "2014", "Simulation", "Tecmo Koei", "0.00", "0.00",
                "0.07", "0.00"
            },
            {
                "Saint Seiya: Brave Soldiers", "PS3", "2013", "Fighting", "Namco Bandai Games", "0.00", "0.01", "0.05",
                "0.01"
            },
            {"Record of Agarest War", "PS3", "2007", "Role-Playing", "Ghostlight", "0.00", "0.03", "0.03", "0.01"},
            {
                "Super Robot Taisen OG Saga: Masou Kishin III - Pride of Justice", "PS3", "2013", "Strategy",
                "Namco Bandai Games", "0.00", "0.00", "0.07", "0.00"
            },
            {"Man vs. Wild", "PS3", "2010", "Adventure", "Abylight", "0.07", "0.00", "0.00", "0.00"},
            {"Grease Dance", "PS3", "2011", "Misc", "505 Games", "0.04", "0.02", "0.00", "0.01"},
            {"Ken to Mahou to Gakuen Mono. 3", "PS3", "2010", "Role-Playing", "Acquire", "0.00", "0.00", "0.07", "0.00"},
            {
                "SCORE International Baja 1000: The Official Game", "PS3", "2008", "Racing", "Activision", "0.06", "0.00",
                "0.00", "0.00"
            },
            {
                "SingStar Apres-Ski Party 2", "PS3", "2010", "Misc", "Sony Computer Entertainment", "0.00", "0.05", "0.00",
                "0.02"
            },
            {"Sacred 3", "PS3", "2014", "Role-Playing", "Deep Silver", "0.01", "0.03", "0.01", "0.02"},
            {
                "MLB Front Office Manager", "PS3", "2009", "Sports", "Take-Two Interactive", "0.06", "0.00", "0.00", "0.00"
            },
            {"Resident Evil", "PS3", "2006", "Action", "Capcom", "0.00", "0.00", "0.07", "0.00"},
            {"Blood Drive", "PS3", "2010", "Racing", "Activision", "0.06", "0.00", "0.00", "0.00"},
            {"Winning Post 7 2010", "PS3", "2010", "Sports", "Tecmo Koei", "0.00", "0.00", "0.07", "0.00"},
            {
                "Kamisama to Unemi Kakumei Paradox", "PS3", "2013", "Role-Playing", "Nippon Ichi Software", "0.00", "0.00",
                "0.06", "0.00"
            },
            {
                "Nobunaga no Yabou: Tendou with Power-Up Kit", "PS3", "2011", "Strategy", "Tecmo Koei", "0.00", "0.00",
                "0.07", "0.00"
            },
            {"Akiba's Trip 2", "PS3", "2013", "Action", "Nippon Ichi Software", "0.01", "0.01", "0.04", "0.00"},
            {
                "Sly 2: Band of Thieves", "PS3", "2010", "Platform", "Sony Computer Entertainment", "0.00", "0.05", "0.00",
                "0.02"
            },
            {
                "Back to the Future: The Game", "PS3", "2011", "Adventure", "Telltale Games", "0.06", "0.01", "0.00",
                "0.00"
            },
            {"Winter Stars", "PS3", "2011", "Sports", "Deep Silver", "0.01", "0.04", "0.00", "0.02"},
            {
                "Transformer: Rise of the Dark Spark", "PS3", "2014", "Action", "Activision", "0.02", "0.03", "0.00",
                "0.02"
            },
            {
                "Pro Yakyuu Spirits 4", "PS3", "2007", "Sports", "Konami Digital Entertainment", "0.00", "0.00", "0.07",
                "0.00"
            },
            {"MotoGP 14 ", "PS3", "2014", "Racing", "Milestone S.r.l.", "0.01", "0.04", "0.00", "0.02"},
            {
                "Happy Feet Two", "PS3", "N/A", "Adventure", "Warner Bros. Interactive Entertainment", "0.05", "0.00",
                "0.00", "0.00"
            },
            {"WipEout HD Fury", "PS3", "2009", "Racing", "Sony Computer Entertainment", "0.00", "0.04", "0.00", "0.02"},
            {
                "Jissen Pachislot Secrets! Fist of the North Star F - Seikimatsu Kyuuseishu Densetsu", "PS3", "2012",
                "Action", "Sega", "0.00", "0.00", "0.06", "0.00"
            },
            {
                "Cartoon Network: Punch Time Explosion XL", "PS3", "2011", "Fighting", "Crave Entertainment", "0.06",
                "0.00", "0.00", "0.00"
            },
            {"Inversion", "PS3", "2012", "Shooter", "Namco Bandai Games", "0.03", "0.02", "0.00", "0.01"},
            {"ICO", "PS3", "2011", "Adventure", "Sony Computer Entertainment", "0.00", "0.00", "0.06", "0.00"},
            {"Rock Band Country Track Pack 2", "PS3", "2011", "Misc", "MTV Games", "0.06", "0.00", "0.00", "0.00"},
            {"NASCAR The Game: Inside Line", "PS3", "2012", "Action", "Activision", "0.06", "0.00", "0.00", "0.00"},
            {
                "Jimmie Johnson's Anything With an Engine", "PS3", "2011", "Racing", "Konami Digital Entertainment", "0.05",
                "0.00", "0.00", "0.00"
            },
            {
                "Generator Rex: Agent of Providence", "PS3", "2011", "Action", "Activision", "0.04", "0.01", "0.00", "0.01"
            },
            {"Just Dance 2015", "PS3", "2014", "Misc", "Ubisoft", "0.02", "0.03", "0.00", "0.01"},
            {
                "Little League World Series Baseball 2010", "PS3", "2010", "Sports", "Activision", "0.05", "0.00", "0.00",
                "0.00"
            },
            {
                "Burnout Paradise: The Ultimate Box", "PS3", "2009", "Racing", "Electronic Arts", "0.00", "0.03", "0.01",
                "0.01"
            },
            {"EyeCreate", "PS3", "2007", "Misc", "Sony Computer Entertainment", "0.00", "0.04", "0.00", "0.02"},
            {
                "Monster Madness: Grave Danger", "PS3", "2008", "Shooter", "SouthPeak Games", "0.04", "0.00", "0.00",
                "0.01"
            },
            {
                "Vampire Rain: Altered Species", "PS3", "2008", "Action", "Ignition Entertainment", "0.05", "0.00", "0.00",
                "0.00"
            },
            {"Port Royale 3", "PS3", "N/A", "Simulation", "Kalypso Media", "0.05", "0.00", "0.00", "0.00"},
            {
                "Attouteki Yuugi: Mugen Souls Z", "PS3", "2013", "Role-Playing", "Nippon Ichi Software", "0.01", "0.01",
                "0.04", "0.00"
            },
            {
                "Choujikuu Yousai Macross: Do You Remember Love", "PS3", "2012", "Shooter", "Namco Bandai Games", "0.00",
                "0.00", "0.05", "0.00"
            },
            {
                "SingStar Mallorca Party", "PS3", "2009", "Misc", "Sony Computer Entertainment", "0.00", "0.04", "0.00",
                "0.02"
            },
            {"Risen 3: Titan Lords", "PS3", "2014", "Role-Playing", "Deep Silver", "0.00", "0.03", "0.00", "0.02"},
            {
                "The Idolmaster: Gravure For You! Vol. 2", "PS3", "2011", "Misc", "Namco Bandai Games", "0.00", "0.00",
                "0.05", "0.00"
            },
            {"Winning Post World", "PS3", "2009", "Sports", "Tecmo Koei", "0.00", "0.00", "0.05", "0.00"},
            {"Winter Sports 2011", "PS3", "2011", "Sports", "DTP Entertainment", "0.00", "0.03", "0.00", "0.02"},
            {"Winning Post 7 2013", "PS3", "2013", "Sports", "Tecmo Koei", "0.00", "0.00", "0.05", "0.00"},
            {"Yaiba: Ninja Gaiden Z", "PS3", "2014", "Action", "Tecmo Koei", "0.02", "0.02", "0.00", "0.01"},
            {
                "White Album: Tsuzurareru Fuyu no Omoide", "PS3", "2010", "Adventure", "Aqua Plus", "0.00", "0.00", "0.05",
                "0.00"
            },
            {
                "Legend of the Guardians: The Owls of Ga'Hoole", "PS3", "2010", "Action",
                "Warner Bros. Interactive Entertainment", "0.04", "0.01", "0.00", "0.00"
            },
            {"Dengeki Bunko Fighting Climax", "PS3", "2014", "Fighting", "Sega", "0.00", "0.00", "0.05", "0.00"},
            {"Dynasty Warriors 8: Empires", "PS3", "2014", "Action", "Tecmo Koei", "0.00", "0.00", "0.05", "0.00"},
            {"Winning Post 8 ", "PS3", "2014", "Action", "Tecmo Koei", "0.00", "0.00", "0.05", "0.00"},
            {"E.X. Troopers", "PS3", "2012", "Shooter", "Capcom", "0.00", "0.00", "0.05", "0.00"},
            {"How to Train Your Dragon 2", "PS3", "2014", "Adventure", "Little Orbit", "0.01", "0.02", "0.00", "0.01"},
            {"To Heart 2 DX Plus", "PS3", "2011", "Adventure", "Aqua Plus", "0.00", "0.00", "0.05", "0.00"},
            {"NASCAR '14", "PS3", "2014", "Action", "Deep Silver", "0.04", "0.00", "0.00", "0.00"},
            {"Top Gun", "PS3", "2011", "Simulation", "505 Games", "0.04", "0.00", "0.00", "0.00"},
            {"Hail to the Chimp", "PS3", "2008", "Misc", "Gamecock", "0.04", "0.00", "0.00", "0.00"},
            {"Monster Hunter Frontier Online", "PS3", "N/A", "Role-Playing", "N/A", "0.00", "0.00", "0.05", "0.00"},
            {
                "Super Robot Wars OG Saga Masou Kishin F: Coffin of the End", "PS3", "2014", "Strategy",
                "Namco Bandai Games", "0.00", "0.00", "0.04", "0.00"
            },
            {
                "White Album 2: Shiawase no Mukougawa", "PS3", "2012", "Adventure", "Aqua Plus", "0.00", "0.00", "0.04",
                "0.00"
            },
            {"Mahjong * Dream C Club", "PS3", "2012", "Action", "D3Publisher", "0.00", "0.00", "0.04", "0.00"},
            {
                "Pac-Man and the Ghostly Adventures 2", "PS3", "2014", "Action", "Namco Bandai Games", "0.01", "0.02",
                "0.00", "0.01"
            },
            {
                "Ore no Imouto ga Konna ni Kawaii Wake ga Nai Happy EnD", "PS3", "2013", "Simulation", "Namco Bandai Games",
                "0.00", "0.00", "0.04", "0.00"
            },
            {"Order Up!!", "PS3", "2011", "Action", "Funbox Media", "0.03", "0.01", "0.00", "0.01"},
            {
                "Ferrari Challenge Trofeo Pirelli", "PS3", "2008", "Racing", "System 3 Arcade Software", "0.00", "0.03",
                "0.00", "0.01"
            },
            {
                "Super Robot Taisen OG Infinite Battle", "PS3", "2013", "Fighting", "Namco Bandai Games", "0.00", "0.00",
                "0.04", "0.00"
            },
            {"Winning Post World 2010", "PS3", "2010", "Sports", "Tecmo Koei", "0.00", "0.00", "0.04", "0.00"},
            {
                "The History Channel: Great Battles - Medieval", "PS3", "N/A", "Strategy", "Slitherine Software", "0.00",
                "0.03", "0.00", "0.01"
            },
            {"Puyo Puyo Tetris", "PS3", "2014", "Puzzle", "Sega", "0.00", "0.00", "0.04", "0.00"},
            {"Imabikisou", "PS3", "2007", "Adventure", "Sega", "0.00", "0.00", "0.04", "0.00"},
            {
                "Eiyuu Densetsu: Sora no Kiseki FC", "PS3", "2012", "Role-Playing", "Falcom Corporation", "0.00", "0.00",
                "0.04", "0.00"
            },
            {"Date A Live: Rine Utopia", "PS3", "2013", "Adventure", "Compile Heart", "0.00", "0.00", "0.04", "0.00"},
            {"Enemy Front", "PS3", "2014", "Shooter", "City Interactive", "0.00", "0.02", "0.00", "0.01"},
            {
                "Shadow of the Colossus", "PS3", "2011", "Adventure", "Sony Computer Entertainment", "0.00", "0.00", "0.04",
                "0.00"
            },
            {"DuckTales: Remastered", "PS3", "2013", "Action", "Capcom", "0.00", "0.02", "0.00", "0.01"},
            {
                "Adventure Time: Explore the Dungeon Because I Don't Know!", "PS3", "2013", "Action", "D3Publisher", "0.02",
                "0.01", "0.00", "0.01"
            },
            {"Battle vs. Chess", "PS3", "N/A", "Misc", "TopWare Interactive", "0.00", "0.03", "0.00", "0.01"},
            {"Surf's Up", "PS3", "2007", "Sports", "Ubisoft", "0.03", "0.00", "0.00", "0.00"},
            {"Ape Escape", "PS3", "2010", "Platform", "Sony Computer Entertainment", "0.00", "0.03", "0.00", "0.01"},
            {
                "Aquanaut's Holiday: Kakusareta Kiroku", "PS3", "2008", "Adventure", "Sony Computer Entertainment", "0.00",
                "0.00", "0.04", "0.00"
            },
            {
                "Tears to Tiara Gaiden: Avalon no Nazo", "PS3", "2009", "Strategy", "Aqua Plus", "0.00", "0.00", "0.04",
                "0.00"
            },
            {"Legasista", "PS3", "2012", "Role-Playing", "Nippon Ichi Software", "0.00", "0.00", "0.04", "0.00"},
            {"Summer Challenge: Athletics Tournament", "PS3", "2011", "Sports", "PQube", "0.00", "0.03", "0.00", "0.01"},
            {"Enchanted Arms (JP sales)", "PS3", "2007", "Role-Playing", "Ubisoft", "0.00", "0.00", "0.04", "0.00"},
            {"Get Up and Dance", "PS3", "2011", "Misc", "O-Games", "0.03", "0.00", "0.00", "0.00"},
            {
                "National Geographic Challenge!", "PS3", "2011", "Misc", "Black Bean Games", "0.01", "0.02", "0.00", "0.01"
            },
            {
                "Greg Hastings Paintball 2", "PS3", "2010", "Shooter", "Majesco Entertainment", "0.03", "0.00", "0.00",
                "0.00"
            },
            {
                "Deadliest Warrior: Ancient Combat", "PS3", "2012", "Fighting", "Cloud Imperium Games Corporation", "0.03",
                "0.00", "0.00", "0.00"
            },
            {
                "Gekiatsu!! Pachi Game Tamashi: CR Evangelion - Hajimari no Fukuin", "PS3", "2010", "Misc", "Unknown",
                "0.00", "0.00", "0.03", "0.00"
            },
            {"Superstars V8 Racing", "PS3", "2009", "Racing", "Black Bean Games", "0.00", "0.02", "0.00", "0.01"},
            {
                "The Idolmaster: Gravure For You! Vol. 4", "PS3", "2012", "Misc", "Namco Bandai Games", "0.00", "0.00",
                "0.03", "0.00"
            },
            {
                "Gekiatsu!! Pachi Game Tamashi Max: Evangelion 7 x Seimei no Kodou", "PS3", "2012", "Misc", "Fields",
                "0.00", "0.00", "0.03", "0.00"
            },
            {"Wangan Midnight", "PS3", "2007", "Racing", "Genki", "0.00", "0.00", "0.03", "0.00"},
            {
                "Suzumiya Haruhi no Tsuisou", "PS3", "2011", "Adventure", "Namco Bandai Games", "0.00", "0.00", "0.03",
                "0.00"
            },
            {"Onechanbara Z Kagura", "PS3", "2013", "Action", "D3Publisher", "0.00", "0.00", "0.03", "0.00"},
            {
                "Makai Senki Disgaea 4: Fuuka & Desco-hen Hajime Mashita", "PS3", "2011", "Strategy",
                "Nippon Ichi Software", "0.00", "0.00", "0.03", "0.00"
            },
            {"Top Gun: Hard Lock", "PS3", "2012", "Action", "505 Games", "0.00", "0.02", "0.00", "0.01"},
            {"K-On! After School Live!! HD Ver.", "PS3", "2012", "Action", "Sega", "0.00", "0.00", "0.03", "0.00"},
            {"Clannad", "PS3", "2011", "Adventure", "Prototype", "0.00", "0.00", "0.03", "0.00"},
            {
                ".hack: Sekai no Mukou ni + Versus", "PS3", "2012", "Action", "Namco Bandai Games", "0.00", "0.00", "0.03",
                "0.00"
            },
            {"Rock of the Dead", "PS3", "2010", "Shooter", "Conspiracy Entertainment", "0.03", "0.00", "0.00", "0.00"},
            {"Fritz Chess", "PS3", "2009", "Strategy", "Deep Silver", "0.00", "0.02", "0.00", "0.01"},
            {
                "Accel World: Ginyoku no Kakusei", "PS3", "2012", "Adventure", "Namco Bandai Games", "0.00", "0.00", "0.03",
                "0.00"
            },
            {"SuperCar Challenge", "PS3", "2009", "Racing", "System 3 Arcade Software", "0.00", "0.02", "0.00", "0.01"},
            {"Hakuouki: Junsouroku", "PS3", "2010", "Adventure", "Idea Factory", "0.01", "0.00", "0.03", "0.00"},
            {"Mayhem 3D", "PS3", "2011", "Racing", "Evolved Games", "0.03", "0.00", "0.00", "0.00"},
            {
                "Pro Yakyuu Spirits 5 Kanzenban", "PS3", "2008", "Sports", "Konami Digital Entertainment", "0.00", "0.00",
                "0.03", "0.00"
            },
            {"Darkstalkers Resurrection", "PS3", "2013", "Fighting", "Capcom", "0.00", "0.00", "0.03", "0.00"},
            {
                "Shin Sangoku Musou Online: Kamishou Ranbu", "PS3", "2010", "Action", "Tecmo Koei", "0.00", "0.00", "0.03",
                "0.00"
            },
            {"Rain (PS3)", "PS3", "2013", "Platform", "Sony Computer Entertainment", "0.00", "0.00", "0.03", "0.00"},
            {"Let's Dance with Mel B", "PS3", "2011", "Sports", "Black Bean Games", "0.00", "0.02", "0.00", "0.01"},
            {
                "The Idolmaster: Gravure For You! Vol. 5", "PS3", "2012", "Misc", "Namco Bandai Games", "0.00", "0.00",
                "0.03", "0.00"
            },
            {"Muv-Luv Alternative: Total Eclipse", "PS3", "2013", "Simulation", "5pb", "0.00", "0.00", "0.03", "0.00"},
            {
                "Sherlock Holmes: Crimes & Punishments", "PS3", "2014", "Adventure", "Focus Home Interactive", "0.01",
                "0.02", "0.00", "0.01"
            },
            {
                "Mahjong Kakutou Club: Zenkoku Taisenban", "PS3", "2006", "Misc", "Konami Digital Entertainment", "0.00",
                "0.00", "0.03", "0.00"
            },
            {"Guilty Gear Xrd: Sign", "PS3", "2014", "Fighting", "Arc System Works", "0.00", "0.00", "0.03", "0.00"},
            {
                "Gekiatsu!! Pachi Game Tamashi Vol. 2: CR Evangelion - Shinjitsu no Tsubasa", "PS3", "2011", "Misc",
                "Unknown", "0.00", "0.00", "0.03", "0.00"
            },
            {
                "Winter Sports 3: The Great Tournament", "PS3", "2010", "Sports", "Tradewest", "0.00", "0.02", "0.00",
                "0.01"
            },
            {"Ride to Hell", "PS3", "2013", "Racing", "Deep Silver", "0.01", "0.01", "0.00", "0.01"},
            {"Under Night In-Birth", "PS3", "2014", "Fighting", "Nippon Ichi Software", "0.00", "0.00", "0.03", "0.00"},
            {
                "The IdolM@ster: Gravure For You! Vol. 6", "PS3", "2012", "Action", "Namco Bandai Games", "0.00", "0.00",
                "0.03", "0.00"
            },
            {
                "Super Heroine Chronicle", "PS3", "2014", "Role-Playing", "Namco Bandai Games", "0.00", "0.00", "0.03",
                "0.00"
            },
            {
                "Rugby League Live", "PS3", "2010", "Sports", "Home Entertainment Suppliers", "0.00", "0.02", "0.00",
                "0.01"
            },
            {"The Last Guy", "PS3", "2009", "Action", "Sony Computer Entertainment", "0.00", "0.00", "0.03", "0.00"},
            {
                "Eureka Seven AO: Jungfrau no Hanabanatachi", "PS3", "2012", "Action", "Namco Bandai Games", "0.00", "0.00",
                "0.03", "0.00"
            },
            {"Samurai Warriors 2", "PS3", "2013", "Action", "Tecmo Koei", "0.00", "0.00", "0.03", "0.00"},
            {
                "Touch Shot! Love Application", "PS3", "2012", "Adventure", "Compile Heart", "0.00", "0.00", "0.03", "0.00"
            },
            {
                "SingStar Chartbreaker", "PS3", "2009", "Misc", "Sony Computer Entertainment", "0.00", "0.02", "0.00",
                "0.01"
            },
            {"Infinite Stratos 2: Ignition Hearts", "PS3", "2014", "Adventure", "5pb", "0.00", "0.00", "0.03", "0.00"},
            {
                "SingStar Fussballhits", "PS3", "2010", "Misc", "Sony Computer Entertainment", "0.00", "0.02", "0.00",
                "0.01"
            },
            {
                "Daito Giken Koushiki Pachi-Slot Simulator Hihouden: Taiyou o Motomeru Monotachi", "PS3", "2013", "Misc",
                "Paon Corporation", "0.00", "0.00", "0.03", "0.00"
            },
            {"Worms", "PS3", "2009", "Strategy", "Sony Computer Entertainment", "0.00", "0.02", "0.00", "0.01"},
            {
                "The Idolmaster: Gravure For You! Vol.7", "PS3", "2012", "Action", "Namco Bandai Games", "0.00", "0.00",
                "0.02", "0.00"
            },
            {
                "Umineko no Naku Koro ni San: Shinjitsu to Gensou no Yasoukyoku", "PS3", "N/A", "Adventure", "N/A", "0.00",
                "0.00", "0.02", "0.00"
            },
            {"Painkiller: Hell & Damnation", "PS3", "2013", "Shooter", "Nordic Games", "0.01", "0.01", "0.00", "0.01"},
            {
                "Singstar: Ultimate Party", "PS3", "2014", "Misc", "Sony Computer Entertainment Europe", "0.00", "0.02",
                "0.00", "0.01"
            },
            {
                "Ken to Mahou to Gakuen Mono. 2G", "PS3", "2010", "Role-Playing", "Acquire", "0.00", "0.00", "0.02", "0.00"
            },
            {"Dunamis 15", "PS3", "2011", "Adventure", "5pb", "0.00", "0.00", "0.02", "0.00"},
            {"428: Fuusa Sareta Shibuya de", "PS3", "2009", "Adventure", "Spike", "0.00", "0.00", "0.02", "0.00"},
            {
                "Captain Morgane and the Golden Turtle", "PS3", "2012", "Adventure", "Reef Entertainment", "0.00", "0.02",
                "0.00", "0.01"
            },
            {"Test Drive: Ferrari Legends", "PS3", "2012", "Racing", "Unknown", "0.02", "0.00", "0.00", "0.00"},
            {"Escape Dead Island", "PS3", "2014", "Action", "Deep Silver", "0.01", "0.01", "0.00", "0.01"},
            {
                "Zillions of Enemy X: Zetsukai no Crusade", "PS3", "2013", "Role-Playing", "Nippon Ichi Software", "0.00",
                "0.00", "0.02", "0.00"
            },
            {"Love Once: Mermaid's Tears", "PS3", "2011", "Adventure", "Unknown", "0.00", "0.00", "0.02", "0.00"},
            {
                "PachiPara 15: Super Umi Monogatari in Okinawa 2", "PS3", "2010", "Misc", "Irem Software Engineering",
                "0.00", "0.00", "0.02", "0.00"
            },
            {
                "Umineko no Naku Koro ni: Majo to Suiri no Rinbukyoku", "PS3", "2010", "Adventure", "Alchemist", "0.00",
                "0.00", "0.02", "0.00"
            },
            {
                "The Idolmaster: Gravure For You! Vol.9", "PS3", "2012", "Action", "Namco Bandai Games", "0.00", "0.00",
                "0.02", "0.00"
            },
            {
                "Shinken de Watashi ni Koi Shinasai! R", "PS3", "2012", "Action", "Minato Station", "0.00", "0.00", "0.02",
                "0.00"
            },
            {"Natural Doctrine", "PS3", "2014", "Action", "Nippon Ichi Software", "0.01", "0.00", "0.01", "0.00"},
            {
                "Dungeons & Dragons: Shadow over Mystara", "PS3", "2013", "Role-Playing", "Capcom", "0.00", "0.00", "0.02",
                "0.00"
            },
            {"Dance! It's Your Stage", "PS3", "2011", "Misc", "DTP Entertainment", "0.00", "0.01", "0.00", "0.01"},
            {"Gal Gun", "PS3", "2012", "Shooter", "Alchemist", "0.00", "0.00", "0.02", "0.00"},
            {"Digimon All-Star Rumble", "PS3", "2014", "Fighting", "Namco Bandai Games", "0.01", "0.01", "0.00", "0.00"},
            {
                "Rinne no Lagrange: Kamogawa Days", "PS3", "2012", "Adventure", "Namco Bandai Games", "0.00", "0.00",
                "0.02", "0.00"
            },
            {
                "The Idolmaster: Gravure For You! Vol.8", "PS3", "2012", "Action", "Namco Bandai Games", "0.00", "0.00",
                "0.02", "0.00"
            },
            {
                "The Legend of Heroes VI: Sora no Kiseki Second Chapter", "PS3", "2013", "Role-Playing",
                "Falcom Corporation", "0.00", "0.00", "0.02", "0.00"
            },
            {
                "Invizimals: The Lost Kingdom", "PS3", "2013", "Action", "Sony Computer Entertainment", "0.00", "0.01",
                "0.00", "0.01"
            },
            {"New Hayarigami", "PS3", "2014", "Adventure", "Nippon Ichi Software", "0.00", "0.00", "0.02", "0.00"},
            {"Motto! SoniComi", "PS3", "2014", "Simulation", "Kadokawa Games", "0.00", "0.00", "0.02", "0.00"},
            {
                "Battle Princess of Arcadias", "PS3", "2013", "Role-Playing", "Nippon Ichi Software", "0.00", "0.00",
                "0.02", "0.00"
            },
            {
                "Super Hero Generation", "PS3", "2014", "Role-Playing", "Namco Bandai Games", "0.00", "0.00", "0.02",
                "0.00"
            },
            {"Date A Live: Arusu Install", "PS3", "2014", "Adventure", "Compile Heart", "0.00", "0.00", "0.02", "0.00"},
            {"Turbo: Super Stunt Squad", "PS3", "2013", "Sports", "D3Publisher", "0.00", "0.01", "0.00", "0.01"},
            {"Wizardry Twin Pack", "PS3", "2011", "Role-Playing", "Acquire", "0.00", "0.00", "0.02", "0.00"},
            {"Machi-ing Maker 4", "PS3", "2011", "Strategy", "D3Publisher", "0.00", "0.00", "0.02", "0.00"},
            {
                "Mato Kurenai Yuugekitai : Tokyo Twilight Ghosthunters", "PS3", "2014", "Role-Playing", "Arc System Works",
                "0.00", "0.00", "0.02", "0.00"
            },
            {"Ragnarok Odyssey", "PS3", "2014", "Role-Playing", "GungHo", "0.01", "0.00", "0.00", "0.00"},
            {"Winning Post 7: Maximum 2007", "PS3", "2007", "Sports", "Tecmo Koei", "0.00", "0.00", "0.02", "0.00"},
            {
                "Shin Sangoku Musou Online: Souten Ranbu", "PS3", "2010", "Action", "Tecmo Koei", "0.00", "0.00", "0.02",
                "0.00"
            },
            {
                "Nurarihyon no Mago: Hyakki Ryouran Taisen", "PS3", "2011", "Fighting", "Konami Digital Entertainment",
                "0.00", "0.00", "0.02", "0.00"
            },
            {
                "Accel World: Kasoku no Chouten", "PS3", "2013", "Adventure", "Namco Bandai Games", "0.00", "0.00", "0.02",
                "0.00"
            },
            {"CV Casting Voice", "PS3", "2014", "Action", "Namco Bandai Games", "0.00", "0.00", "0.02", "0.00"},
            {"Dream C Club", "PS3", "2012", "Simulation", "D3Publisher", "0.00", "0.00", "0.02", "0.00"},
            {
                "Nobunaga no Yabou Online: Houou no Shou", "PS3", "2012", "Strategy", "Ackkstudios", "0.00", "0.00", "0.01",
                "0.00"
            },
            {"Dream C Club: GoGo ", "PS3", "2014", "Adventure", "D3Publisher", "0.00", "0.00", "0.01", "0.00"},
            {"Pro Angler Moves", "PS3", "2012", "Sports", "Interworks Unlimited, Inc.", "0.01", "0.00", "0.00", "0.00"},
            {
                "The Legend of Heroes VI: Sora no Kiseki the 3rd", "PS3", "2013", "Role-Playing", "Falcom Corporation",
                "0.00", "0.00", "0.01", "0.00"
            },
            {"Winning Post 7 Maximum 2008", "PS3", "2008", "Sports", "Tecmo Koei", "0.00", "0.00", "0.01", "0.00"},
            {"Madden NFL 13", "PS3", "2012", "Sports", "Electronic Arts", "0.00", "0.01", "0.00", "0.00"},
            {
                "Sega Golf Club: Miyazato San Kyoudai Naizou", "PS3", "2006", "Sports", "Sega", "0.00", "0.00", "0.01",
                "0.00"
            },
            {"Toro to Morimori", "PS3", "2009", "Misc", "Sony Computer Entertainment", "0.00", "0.00", "0.01", "0.00"},
            {
                "Resistance Dual Pack", "PS3", "2011", "Shooter", "Sony Computer Entertainment", "0.00", "0.01", "0.00",
                "0.00"
            },
            {"Mahjong Taikai IV", "PS3", "2006", "Misc", "Tecmo Koei", "0.00", "0.00", "0.01", "0.00"},
            {
                "Agarest Senki: Re-appearance", "PS3", "N/A", "Role-Playing", "Idea Factory", "0.00", "0.00", "0.01",
                "0.00"
            },
            {
                "Makai Senki Disgaea 3 Append Disc: Raspberyl-hen Hajime Mashita", "PS3", "2009", "Role-Playing",
                "Nippon Ichi Software", "0.00", "0.00", "0.01", "0.00"
            },
            {
                "Tsukigime Ranko's Longest Day", "PS3", "2014", "Action", "Namco Bandai Games", "0.00", "0.01", "0.00",
                "0.00"
            },
            {"Strider (2014)", "PS3", "2014", "Action", "Capcom", "0.00", "0.00", "0.01", "0.00"},
            {"Railfan", "PS3", "2006", "Simulation", "Ongakukan", "0.00", "0.00", "0.01", "0.00"},
            {
                "Cabela's Big Game Hunter: Pro Hunts", "PS3", "2014", "Shooter", "Activision", "0.01", "0.00", "0.00",
                "0.00"
            },
            {
                "The Guided Fate: Cross Thesis Awakening", "PS3", "2014", "Role-Playing", "Nippon Ichi Software", "0.00",
                "0.00", "0.01", "0.00"
            },
            {
                "Sakigake!! Otokojuku - Nihon yo Kore ga Otoko Dearu!", "PS3", "2014", "Fighting", "Namco Bandai Games",
                "0.00", "0.00", "0.01", "0.00"
            },
            {"XBLAZE Code: Embryo", "PS3", "2013", "Adventure", "Arc System Works", "0.00", "0.00", "0.01", "0.00"},
            {"Muv-Luv Alternative", "PS3", "2012", "Adventure", "5pb", "0.00", "0.00", "0.01", "0.00"},
            {"The Wolf Among Us", "PS3", "2014", "Adventure", "Telltale Games", "0.00", "0.01", "0.00", "0.00"},
            {"Akatsuki no Goei Trinity", "PS3", "2012", "Adventure", "5pb", "0.00", "0.00", "0.01", "0.00"},
            {
                "Shin Koihime Musou: Otome Taisen * Sangokushi Engi", "PS3", "2014", "Adventure", "Views", "0.00", "0.00",
                "0.01", "0.00"
            },
            {
                "WSC REAL 09: World Snooker Championship", "PS3", "2009", "Sports", "Deep Silver", "0.00", "0.01", "0.00",
                "0.00"
            },
            {
                "SBK09 Superbike World Championship", "PS3", "2009", "Racing", "Black Bean Games", "0.00", "0.01", "0.00",
                "0.00"
            },
            {"Disorder 6", "PS3", "2013", "Adventure", "5pb", "0.00", "0.00", "0.01", "0.00"},
            {"Dream C Club Zero", "PS3", "2013", "Simulation", "D3Publisher", "0.00", "0.00", "0.01", "0.00"},
            {"G1 Jockey 4 2008", "PS3", "2008", "Sports", "Tecmo Koei", "0.00", "0.00", "0.00", "0.00"},
            {
                "Hyperdimension Neptunia mk2", "PS3", "2011", "Action", "Nippon Ichi Software", "0.00", "0.01", "0.00",
                "0.00"
            },
            {
                "Grand Theft Auto Online", "PS3", "2013", "Shooter", "Take-Two Interactive", "0.00", "0.01", "0.00", "0.00"
            },
            {"Muv-Luv", "PS3", "2012", "Adventure", "5pb", "0.00", "0.00", "0.01", "0.00"},
            {"Mist of Chaos", "PS3", "2007", "Action", "Idea Factory", "0.00", "0.00", "0.01", "0.00"},
            {
                "Daikoukai Jidai Online: Cruz del Sur", "PS3", "2009", "Role-Playing", "Tecmo Koei", "0.00", "0.00", "0.01",
                "0.00"
            },
            {"Jojo's Bizarre Adventure", "PS3", "N/A", "Fighting", "N/A", "0.00", "0.01", "0.00", "0.00"},
            {
                "Heartful Simulator Pachi-Slot: To Heart 2", "PS3", "2012", "Action", "Aqua Plus", "0.00", "0.00", "0.01",
                "0.00"
            },
            {"Eiyuu * Senki", "PS3", "2013", "Adventure", "5pb", "0.00", "0.00", "0.01", "0.00"},
            {"Battle Fantasia", "PS3", "2008", "Fighting", "505 Games", "0.00", "0.00", "0.01", "0.00"},
            {"Power Smash: Live Match!", "PS3", "2010", "Sports", "Sega", "0.00", "0.00", "0.01", "0.00"},
            {
                "Sengoku Hime: Senkou no Taika - Akatsuki no Haryuu", "PS3", "2012", "Action", "SystemSoft Alpha", "0.00",
                "0.00", "0.01", "0.00"
            },
            {
                "Harem Tengoku da to Omottara Yandere Jigoku Datta", "PS3", "2014", "Adventure", "Nippon Ichi Software",
                "0.00", "0.00", "0.01", "0.00"
            },
            {
                "Metal Gear Solid V: The Phantom Pain", "PS3", "2020", "Action", "Konami Digital Entertainment", "0.00",
                "0.01", "0.00", "0.00"
            },
            {"Muv-luv Photonflowers", "PS3", "2014", "Adventure", "5pb", "0.00", "0.00", "0.01", "0.00"},
            {"Putty Squad", "PS3", "2013", "Action", "System 3", "0.00", "0.00", "0.00", "0.00"},
            {"Hakuoki: Reimeiroku Nagorigusa", "PS3", "2012", "Action", "Idea Factory", "0.00", "0.00", "0.01", "0.00"},
            {"Phantom Breaker", "PS3", "2013", "Fighting", "5pb", "0.00", "0.00", "0.01", "0.00"},
            {"Bound By Flame", "PS3", "2014", "Action", "N/A", "0.00", "0.00", "0.00", "0.00"},
            {
                "Derby Time Online", "PS3", "2008", "Sports", "Sony Computer Entertainment", "0.00", "0.00", "0.01", "0.00"
            },
            {"Quantum Conundrum", "PS3", "2012", "Action", "Square Enix", "0.00", "0.01", "0.00", "0.00"},
            {
                "MotorStorm Complete", "PS3", "2008", "Racing", "Sony Computer Entertainment", "0.00", "0.00", "0.01",
                "0.00"
            },
            {"Magus", "PS3", "2014", "Role-Playing", "Aksys Games", "0.01", "0.00", "0.00", "0.00"},
            {"Muv-luv Photonmelodies", "PS3", "2014", "Adventure", "5pb", "0.00", "0.00", "0.01", "0.00"},
            {"PAIN", "PS3", "2009", "Action", "Sony Computer Entertainment", "0.00", "0.00", "0.00", "0.00"},
            {
                "Metal Gear Online", "PS3", "2008", "Action", "Konami Digital Entertainment", "0.00", "0.00", "0.00",
                "0.00"
            },
            {"Conflict: Denied Ops (JP sales)", "PS3", "N/A", "Action", "N/A", "0.00", "0.00", "0.00", "0.00"},
            {
                "Superstars V8 Next Challenge", "PS3", "2010", "Racing", "Black Bean Games", "0.00", "0.00", "0.00", "0.00"
            },
            {"Lost Dimension", "PS3", "2014", "Role-Playing", "Lancarse", "0.00", "0.00", "0.00", "0.00"},
            {"Caladrius Blaze", "PS3", "2014", "Action", "Moss", "0.00", "0.00", "0.00", "0.00"},
            {"uDraw Studio: Instant Artist", "PS3", "2011", "Misc", "THQ", "0.00", "0.00", "0.00", "0.00"},
            {"Alone in the Dark: Inferno(JP sales)", "PS3", "N/A", "Action", "N/A", "0.00", "0.00", "0.00", "0.00"},
            {"Of Orcs and Men", "PS3", "2012", "Role-Playing", "Focus Home Interactive", "0.00", "0.00", "0.00", "0.00"},
            {
                "Yamasa Digi World SP: Pachi-Slot Sengoku Musou", "PS3", "2007", "Misc", "Yamasa Entertainment", "0.00",
                "0.00", "0.00", "0.00"
            },
        };

        /// <summary>
        /// XBox360 game information
        /// </summary>
        public static string[,] XBox360Games =
        {
            {"Kinect Adventures!", "X360", "2010", "Misc", "Microsoft Game Studios", "14.63", "4.82", "0.24", "1.62"},
            {"Grand Theft Auto V", "X360", "2013", "Action", "Take-Two Interactive", "8.56", "4.81", "0.06", "1.21"},
            {"Call of Duty: Modern Warfare 3", "X360", "2011", "Shooter", "Activision", "8.81", "4.16", "0.13", "1.29"},
            {"Call of Duty: Black Ops", "X360", "2010", "Shooter", "Activision", "9.37", "3.60", "0.11", "1.08"},
            {"Call of Duty: Modern Warfare 2", "X360", "2009", "Shooter", "Activision", "8.42", "3.54", "0.08", "1.27"},
            {"Call of Duty: Black Ops II", "X360", "2012", "Shooter", "Activision", "7.92", "4.11", "0.06", "1.07"},
            {"Halo 3", "X360", "2007", "Shooter", "Microsoft Game Studios", "7.85", "2.80", "0.13", "1.19"},
            {"Grand Theft Auto IV", "X360", "2008", "Action", "Take-Two Interactive", "6.61", "3.05", "0.14", "1.00"},
            {"Halo: Reach", "X360", "2010", "Shooter", "Microsoft Game Studios", "6.90", "1.91", "0.08", "0.76"},
            {"Halo 4", "X360", "2012", "Shooter", "Microsoft Game Studios", "6.37", "2.17", "0.04", "0.69"},
            {"Call of Duty: Ghosts", "X360", "2013", "Shooter", "Activision", "6.07", "2.40", "0.04", "0.71"},
            {"Call of Duty 4: Modern Warfare", "X360", "2007", "Shooter", "Activision", "5.79", "2.33", "0.13", "0.88"},
            {
                "The Elder Scrolls V: Skyrim", "X360", "2011", "Role-Playing", "Bethesda Softworks", "4.63", "2.68", "0.10",
                "0.79"
            },
            {"Battlefield 3", "X360", "2011", "Shooter", "Electronic Arts", "4.38", "2.09", "0.06", "0.68"},
            {"Call of Duty: World at War", "X360", "2008", "Shooter", "Activision", "4.64", "1.84", "0.00", "0.67"},
            {"Gears of War 2", "X360", "2008", "Shooter", "Microsoft Game Studios", "4.11", "1.90", "0.06", "0.63"},
            {"Halo 3: ODST", "X360", "2009", "Shooter", "Microsoft Game Studios", "4.28", "1.33", "0.06", "0.60"},
            {"MineCraft", "X360", "2013", "Adventure", "Microsoft Game Studios", "3.83", "1.87", "0.02", "0.50"},
            {"Gears of War 3", "X360", "2011", "Shooter", "Microsoft Game Studios", "3.98", "1.56", "0.07", "0.48"},
            {"Red Dead Redemption", "X360", "2010", "Action", "Take-Two Interactive", "3.56", "1.88", "0.09", "0.55"},
            {"Gears of War", "X360", "2006", "Shooter", "Microsoft Game Studios", "3.52", "1.87", "0.07", "0.60"},
            {"Kinect Sports", "X360", "2010", "Sports", "Microsoft Game Studios", "3.77", "1.66", "0.03", "0.48"},
            {"Assassin's Creed", "X360", "2007", "Adventure", "Ubisoft", "3.21", "1.64", "0.07", "0.55"},
            {"Forza Motorsport 3", "X360", "2009", "Racing", "Microsoft Game Studios", "2.96", "1.88", "0.10", "0.50"},
            {"Assassin's Creed II", "X360", "2009", "Action", "Ubisoft", "3.03", "1.53", "0.08", "0.50"},
            {"FIFA Soccer 13", "X360", "2012", "Action", "Electronic Arts", "1.04", "3.46", "0.03", "0.58"},
            {"Assassin's Creed III", "X360", "2012", "Action", "Ubisoft", "2.93", "1.65", "0.03", "0.42"},
            {"Fable III", "X360", "2010", "Role-Playing", "Microsoft Game Studios", "3.52", "1.06", "0.05", "0.37"},
            {"Guitar Hero III: Legends of Rock", "X360", "2007", "Misc", "Activision", "3.15", "0.91", "0.01", "0.41"},
            {
                "Batman: Arkham City", "X360", "2011", "Action", "Warner Bros. Interactive Entertainment", "2.81", "1.23",
                "0.04", "0.39"
            },
            {"Fallout 3", "X360", "2008", "Role-Playing", "Bethesda Softworks", "3.01", "0.95", "0.09", "0.39"},
            {"Forza Motorsport 4", "X360", "2011", "Racing", "Microsoft Game Studios", "1.92", "1.90", "0.06", "0.44"},
            {
                "The Elder Scrolls IV: Oblivion", "X360", "2006", "Role-Playing", "Take-Two Interactive", "2.69", "1.02",
                "0.13", "0.38"
            },
            {"Fable II", "X360", "2008", "Role-Playing", "Microsoft Game Studios", "2.47", "1.22", "0.11", "0.41"},
            {"FIFA Soccer 14", "X360", "2013", "Sports", "Electronic Arts", "0.85", "2.84", "0.01", "0.47"},
            {"FIFA Soccer 12", "X360", "2011", "Sports", "Electronic Arts", "0.81", "2.77", "0.02", "0.53"},
            {"Assassin's Creed: Revelations", "X360", "2011", "Action", "Ubisoft", "2.17", "1.46", "0.04", "0.43"},
            {"Forza Motorsport 2", "X360", "2007", "Racing", "Microsoft Game Studios", "2.33", "1.27", "0.03", "0.41"},
            {"Left 4 Dead 2", "X360", "2009", "Shooter", "Electronic Arts", "2.57", "0.86", "0.05", "0.36"},
            {"Fallout: New Vegas", "X360", "2010", "Role-Playing", "Bethesda Softworks", "2.39", "1.00", "0.04", "0.29"},
            {
                "LEGO Indiana Jones: The Original Adventures", "X360", "2008", "Adventure", "Activision", "2.36", "0.99",
                "0.00", "0.35"
            },
            {"FIFA Soccer 11", "X360", "2010", "Sports", "Electronic Arts", "0.69", "2.39", "0.02", "0.40"},
            {"Left 4 Dead", "X360", "2008", "Shooter", "Electronic Arts", "2.62", "0.49", "0.05", "0.29"},
            {"Battlefield: Bad Company 2", "X360", "2010", "Shooter", "Electronic Arts", "2.06", "1.00", "0.04", "0.32"},
            {"Resident Evil 5", "X360", "2009", "Action", "Capcom", "2.04", "0.92", "0.12", "0.33"},
            {"Assassin's Creed: Brotherhood", "X360", "2010", "Action", "Ubisoft", "2.74", "0.37", "0.03", "0.22"},
            {"Batman: Arkham Asylum", "X360", "2009", "Action", "Eidos Interactive", "2.10", "0.93", "0.02", "0.29"},
            {"Borderlands", "X360", "2009", "Shooter", "Take-Two Interactive", "2.29", "0.70", "0.03", "0.28"},
            {
                "LEGO Batman: The Videogame", "X360", "2008", "Adventure", "Warner Bros. Interactive Entertainment", "1.95",
                "0.99", "0.00", "0.31"
            },
            {"Battlefield 4", "X360", "2013", "Shooter", "Electronic Arts", "1.99", "0.87", "0.02", "0.24"},
            {"Dance Central", "X360", "2010", "Misc", "MTV Games", "2.07", "0.75", "0.01", "0.25"},
            {"Mass Effect 2", "X360", "2010", "Role-Playing", "Electronic Arts", "1.97", "0.79", "0.03", "0.27"},
            {"Kung Fu Panda", "X360", "2008", "Platform", "Activision", "1.90", "0.84", "0.00", "0.29"},
            {"Mass Effect 3", "X360", "2012", "Role-Playing", "Electronic Arts", "1.87", "0.81", "0.03", "0.23"},
            {"Assassin's Creed IV: Black Flag", "X360", "2013", "Action", "Ubisoft", "1.62", "1.06", "0.01", "0.25"},
            {"Saints Row 2", "X360", "2008", "Action", "THQ", "1.86", "0.78", "0.02", "0.26"},
            {"NBA 2K13", "X360", "2012", "Action", "Take-Two Interactive", "2.51", "0.20", "0.01", "0.17"},
            {"Sega Superstars Tennis", "X360", "2008", "Sports", "Sega", "1.74", "0.86", "0.00", "0.28"},
            {"Borderlands 2", "X360", "2012", "Shooter", "Take-Two Interactive", "1.77", "0.84", "0.04", "0.23"},
            {"Far Cry 3", "X360", "2012", "Shooter", "Ubisoft", "1.30", "1.28", "0.02", "0.27"},
            {"Mass Effect", "X360", "2007", "Role-Playing", "Microsoft Game Studios", "1.79", "0.77", "0.03", "0.26"},
            {"Street Fighter IV", "X360", "2009", "Fighting", "Capcom", "1.73", "0.69", "0.15", "0.25"},
            {"Madden NFL 10", "X360", "2009", "Sports", "Electronic Arts", "2.50", "0.09", "0.00", "0.22"},
            {"Madden NFL 13", "X360", "2012", "Sports", "Electronic Arts", "2.47", "0.15", "0.00", "0.16"},
            {"BioShock", "X360", "2007", "Shooter", "Take-Two Interactive", "1.60", "0.84", "0.05", "0.27"},
            {"Saints Row: The Third", "X360", "2011", "Action", "THQ", "1.19", "1.13", "0.07", "0.29"},
            {"Call of Duty 3", "X360", "2006", "Shooter", "Activision", "1.47", "0.91", "0.02", "0.27"},
            {"Star Wars: The Force Unleashed", "X360", "2008", "Action", "LucasArts", "1.66", "0.75", "0.00", "0.25"},
            {"Madden NFL 12", "X360", "2011", "Sports", "Electronic Arts", "2.38", "0.11", "0.00", "0.16"},
            {"Madden NFL 11", "X360", "2010", "Sports", "Electronic Arts", "2.34", "0.12", "0.00", "0.18"},
            {"Guitar Hero: World Tour", "X360", "2008", "Misc", "Activision", "1.74", "0.63", "0.00", "0.24"},
            {"FIFA Soccer 10", "X360", "2009", "Sports", "Electronic Arts", "0.58", "1.78", "0.01", "0.23"},
            {"L.A. Noire", "X360", "2011", "Adventure", "Take-Two Interactive", "1.43", "0.90", "0.02", "0.22"},
            {"Medal of Honor", "X360", "2010", "Shooter", "Electronic Arts", "1.52", "0.80", "0.04", "0.21"},
            {"NBA 2K12", "X360", "2011", "Sports", "Take-Two Interactive", "2.25", "0.14", "0.01", "0.15"},
            {"Call of Duty: Advanced Warfare", "X360", "2014", "Shooter", "Activision", "1.64", "0.71", "0.00", "0.20"},
            {"Madden NFL 09", "X360", "2008", "Sports", "Electronic Arts", "2.20", "0.12", "0.00", "0.20"},
            {"Dragon Age: Origins", "X360", "2009", "Role-Playing", "Electronic Arts", "1.72", "0.54", "0.03", "0.21"},
            {"Marvel: Ultimate Alliance", "X360", "2006", "Role-Playing", "Activision", "2.27", "0.02", "0.00", "0.19"},
            {"Halo Wars", "X360", "2009", "Strategy", "Microsoft Game Studios", "1.42", "0.79", "0.04", "0.23"},
            {
                "Grand Theft Auto: Episodes from Liberty City", "X360", "2009", "Adventure", "Take-Two Interactive", "0.96",
                "1.20", "0.03", "0.26"
            },
            {"Pure", "X360", "2008", "Racing", "Disney Interactive Studios", "1.37", "0.84", "0.00", "0.24"},
            {"Rock Band", "X360", "N/A", "Misc", "Electronic Arts", "1.90", "0.33", "0.00", "0.21"},
            {"Tom Clancy's Rainbow Six: Vegas 2", "X360", "2008", "Shooter", "Ubisoft", "1.54", "0.60", "0.02", "0.23"},
            {"Madden NFL 08", "X360", "2007", "Sports", "Electronic Arts", "2.17", "0.01", "0.00", "0.18"},
            {"Dead Island", "X360", "2011", "Action", "Deep Silver", "1.43", "0.68", "0.00", "0.19"},
            {
                "Halo: Combat Evolved Anniversary", "X360", "2011", "Shooter", "Microsoft Game Studios", "1.37", "0.68",
                "0.04", "0.21"
            },
            {"LEGO Star Wars: The Complete Saga", "X360", "2007", "Action", "LucasArts", "1.36", "0.71", "0.00", "0.21"},
            {
                "Kinect: Disneyland Adventures", "X360", "2011", "Misc", "Microsoft Game Studios", "1.67", "0.41", "0.02",
                "0.17"
            },
            {"Zumba Fitness", "X360", "2010", "Sports", "505 Games", "1.65", "0.43", "0.00", "0.17"},
            {
                "Kinect Sports: Season Two", "X360", "2011", "Sports", "Microsoft Game Studios", "1.32", "0.70", "0.02",
                "0.21"
            },
            {"NBA 2K14", "X360", "2013", "Sports", "Take-Two Interactive", "1.91", "0.17", "0.00", "0.14"},
            {
                "Midnight Club: Los Angeles", "X360", "2008", "Racing", "Take-Two Interactive", "1.57", "0.45", "0.01",
                "0.19"
            },
            {"Rock Band 2", "X360", "2008", "Misc", "Electronic Arts", "1.76", "0.23", "0.00", "0.18"},
            {"Saints Row", "X360", "2006", "Action", "THQ", "1.16", "0.77", "0.02", "0.22"},
            {"Skate 3", "X360", "2010", "Sports", "Electronic Arts", "1.17", "0.78", "0.00", "0.20"},
            {"BioShock 2", "X360", "2010", "Shooter", "Take-Two Interactive", "1.41", "0.53", "0.02", "0.19"},
            {"Need for Speed: Hot Pursuit", "X360", "2010", "Racing", "Electronic Arts", "0.98", "0.95", "0.00", "0.20"},
            {"Guitar Hero II", "X360", "2007", "Misc", "Activision", "1.96", "0.02", "0.00", "0.16"},
            {"FIFA 15", "X360", "2014", "Sports", "Electronic Arts", "0.43", "1.44", "0.00", "0.24"},
            {"Final Fantasy XIII", "X360", "2010", "Role-Playing", "Square Enix", "1.23", "0.66", "0.01", "0.20"},
            {"Dead Rising", "X360", "2006", "Action", "Capcom", "1.13", "0.64", "0.08", "0.20"},
            {"The Sims 3", "X360", "2010", "Simulation", "Electronic Arts", "1.14", "0.72", "0.00", "0.18"},
            {"UFC 2009 Undisputed", "X360", "2009", "Fighting", "THQ", "1.47", "0.39", "0.00", "0.18"},
            {"NBA 2K11", "X360", "2010", "Sports", "Take-Two Interactive", "1.80", "0.11", "0.01", "0.12"},
            {"Need for Speed: ProStreet", "X360", "2007", "Racing", "Electronic Arts", "1.03", "0.78", "0.01", "0.21"},
            {"Madden NFL 25", "X360", "2013", "Sports", "Electronic Arts", "1.87", "0.05", "0.00", "0.11"},
            {
                "Tom Clancy's Splinter Cell: Conviction", "X360", "2010", "Action", "Ubisoft", "1.16", "0.62", "0.04",
                "0.19"
            },
            {
                "PGR4 - Project Gotham Racing 4", "X360", "2007", "Racing", "Microsoft Game Studios", "0.47", "1.27",
                "0.02", "0.25"
            },
            {"Dance Central 2", "X360", "2011", "Misc", "Microsoft Game Studios", "1.41", "0.41", "0.01", "0.16"},
            {"Just Dance 3", "X360", "2011", "Misc", "Ubisoft", "1.45", "0.38", "0.00", "0.15"},
            {"Call of Duty 2", "X360", "2005", "Shooter", "Activision", "1.75", "0.04", "0.01", "0.15"},
            {"FIFA Soccer 09", "X360", "2008", "Sports", "Electronic Arts", "0.48", "1.26", "0.01", "0.18"},
            {"Tom Clancy's Rainbow Six: Vegas", "X360", "2006", "Shooter", "Ubisoft", "1.07", "0.65", "0.02", "0.19"},
            {
                "Mortal Kombat", "X360", "2011", "Fighting", "Warner Bros. Interactive Entertainment", "1.50", "0.30",
                "0.00", "0.13"
            },
            {"Need for Speed: Shift", "X360", "2009", "Racing", "Electronic Arts", "0.71", "0.95", "0.01", "0.21"},
            {"Portal 2", "X360", "2011", "Shooter", "Valve Software", "1.26", "0.46", "0.01", "0.15"},
            {"Resident Evil 6", "X360", "2012", "Action", "Capcom", "1.04", "0.58", "0.07", "0.15"},
            {"Forza: Horizon", "X360", "2012", "Racing", "Microsoft Game Studios", "0.75", "0.86", "0.04", "0.17"},
            {"Madden NFL 07", "X360", "2006", "Sports", "Electronic Arts", "1.65", "0.00", "0.01", "0.13"},
            {"BioShock Infinite", "X360", "2013", "Shooter", "Take-Two Interactive", "1.11", "0.51", "0.02", "0.14"},
            {"The Orange Box", "X360", "2007", "Shooter", "Electronic Arts", "1.07", "0.52", "0.02", "0.17"},
            {"Tomb Raider (2013)", "X360", "2013", "Action", "Square Enix", "0.79", "0.81", "0.01", "0.17"},
            {"Mortal Kombat vs DC Universe", "X360", "2008", "Fighting", "Midway Games", "1.37", "0.23", "0.00", "0.14"},
            {"Crackdown", "X360", "2007", "Shooter", "Microsoft Game Studios", "0.99", "0.53", "0.03", "0.18"},
            {"Hitman: Absolution", "X360", "2012", "Action", "Square Enix", "0.63", "0.85", "0.01", "0.16"},
            {"Dishonored", "X360", "2012", "Shooter", "Bethesda Softworks", "1.01", "0.48", "0.01", "0.13"},
            {"Need For Speed: Undercover", "X360", "2008", "Racing", "Electronic Arts", "0.75", "0.69", "0.01", "0.18"},
            {"Need for Speed Carbon", "X360", "2006", "Racing", "Electronic Arts", "0.74", "0.69", "0.02", "0.18"},
            {"Army of Two", "X360", "2008", "Shooter", "Electronic Arts", "1.07", "0.37", "0.02", "0.15"},
            {"Kinect Star Wars", "X360", "2012", "Action", "Microsoft Game Studios", "0.97", "0.48", "0.03", "0.13"},
            {"Viva Pinata", "X360", "2006", "Simulation", "Microsoft Game Studios", "0.44", "0.94", "0.02", "0.20"},
            {
                "Batman: Arkham Origins", "X360", "2013", "Action", "Warner Bros. Interactive Entertainment", "0.96",
                "0.49", "0.00", "0.13"
            },
            {"Far Cry 2", "X360", "2008", "Shooter", "Ubisoft", "0.70", "0.68", "0.02", "0.18"},
            {"Rage", "X360", "2011", "Shooter", "Bethesda Softworks", "0.79", "0.58", "0.03", "0.15"},
            {"Max Payne 3", "X360", "2012", "Shooter", "Take-Two Interactive", "0.82", "0.59", "0.01", "0.14"},
            {"SoulCalibur IV", "X360", "2008", "Fighting", "Ubisoft", "0.90", "0.43", "0.07", "0.15"},
            {"Just Cause 2", "X360", "2010", "Action", "Square Enix", "0.55", "0.81", "0.02", "0.17"},
            {
                "Lego Marvel Super Heroes", "X360", "2013", "Action", "Warner Bros. Interactive Entertainment", "0.78",
                "0.62", "0.00", "0.14"
            },
            {"Kinectimals", "X360", "2010", "Simulation", "Microsoft Game Studios", "0.96", "0.44", "0.00", "0.13"},
            {
                "Tom Clancy's Ghost Recon Advanced Warfighter", "X360", "2006", "Shooter", "Ubisoft", "1.39", "0.02",
                "0.02", "0.10"
            },
            {
                "LEGO Batman 2: DC Super Heroes", "X360", "2012", "Action", "Warner Bros. Interactive Entertainment",
                "0.80", "0.58", "0.00", "0.13"
            },
            {
                "Gears of War: Judgment", "X360", "2013", "Shooter", "Microsoft Game Studios", "0.87", "0.47", "0.03",
                "0.12"
            },
            {"Dead Space 2", "X360", "2011", "Shooter", "Electronic Arts", "0.91", "0.43", "0.00", "0.12"},
            {"Saints Row IV", "X360", "2013", "Action", "Deep Silver", "0.89", "0.45", "0.01", "0.12"},
            {"007: Quantum of Solace", "X360", "2008", "Action", "Activision", "0.81", "0.50", "0.01", "0.14"},
            {
                "Need for Speed: Most Wanted - A Criterion Game", "X360", "2012", "Racing", "Electronic Arts", "0.55",
                "0.76", "0.01", "0.14"
            },
            {"Dead Rising 2", "X360", "2010", "Action", "Capcom", "0.72", "0.52", "0.09", "0.12"},
            {"Fight Night Round 3", "X360", "2006", "Fighting", "Electronic Arts", "1.31", "0.03", "0.01", "0.10"},
            {"Mafia II", "X360", "2010", "Action", "Take-Two Interactive", "0.77", "0.54", "0.00", "0.14"},
            {"Battlefield: Bad Company", "X360", "2008", "Shooter", "Electronic Arts", "0.80", "0.45", "0.04", "0.15"},
            {"Homefront", "X360", "2011", "Shooter", "THQ", "0.81", "0.47", "0.02", "0.12"},
            {"WWE SmackDown vs Raw 2008", "X360", "2007", "Fighting", "THQ", "0.91", "0.38", "0.00", "0.13"},
            {
                "Tom Clancy's Ghost Recon: Future Soldier", "X360", "2012", "Shooter", "Ubisoft", "0.90", "0.39", "0.02",
                "0.11"
            },
            {
                "LEGO Star Wars III: The Clone Wars", "X360", "2011", "Action", "LucasArts", "0.79", "0.47", "0.00", "0.12"
            },
            {"Fight Night Round 4", "X360", "2009", "Fighting", "Electronic Arts", "0.93", "0.33", "0.00", "0.13"},
            {"Dead Space", "X360", "2008", "Action", "Electronic Arts", "0.86", "0.38", "0.00", "0.12"},
            {
                "LEGO Harry Potter: Years 1-4", "X360", "2010", "Adventure", "Warner Bros. Interactive Entertainment",
                "0.83", "0.41", "0.00", "0.12"
            },
            {"Kinect Joy Ride", "X360", "2010", "Racing", "Microsoft Game Studios", "0.85", "0.38", "0.00", "0.11"},
            {"FIFA Soccer 08", "X360", "2007", "Sports", "Electronic Arts", "0.31", "0.89", "0.01", "0.14"},
            {"Star Wars: The Force Unleashed II", "X360", "2010", "Action", "LucasArts", "0.88", "0.35", "0.00", "0.11"},
            {"Lost Planet: Extreme Condition", "X360", "2006", "Shooter", "Capcom", "1.08", "0.04", "0.10", "0.10"},
            {"Devil May Cry 4", "X360", "2008", "Action", "Capcom", "0.78", "0.34", "0.08", "0.13"},
            {"Burnout Paradise", "X360", "2008", "Racing", "Electronic Arts", "0.61", "0.56", "0.01", "0.14"},
            {"Need for Speed: The Run", "X360", "2011", "Racing", "Electronic Arts", "0.60", "0.56", "0.00", "0.15"},
            {"Deus Ex: Human Revolution", "X360", "2011", "Shooter", "Square Enix", "0.72", "0.45", "0.02", "0.12"},
            {"The Beatles: Rock Band", "X360", "2009", "Misc", "MTV Games", "0.97", "0.22", "0.00", "0.11"},
            {"Crysis 2", "X360", "2011", "Shooter", "Electronic Arts", "0.67", "0.49", "0.02", "0.12"},
            {"UFC Undisputed 2010", "X360", "2010", "Fighting", "THQ", "0.88", "0.30", "0.00", "0.11"},
            {"Alan Wake", "X360", "2010", "Action", "Microsoft Game Studios", "0.64", "0.48", "0.05", "0.12"},
            {"[Prototype]", "X360", "2009", "Action", "Activision", "0.82", "0.34", "0.00", "0.12"},
            {"Your Shape: Fitness Evolved", "X360", "2010", "Sports", "Ubisoft", "0.76", "0.40", "0.00", "0.11"},
            {"NBA 2K9", "X360", "2008", "Sports", "Take-Two Interactive", "1.00", "0.16", "0.00", "0.11"},
            {"Tekken 6", "X360", "2009", "Fighting", "Namco Bandai Games", "0.69", "0.40", "0.05", "0.12"},
            {"Sonic's Ultimate Genesis Collection", "X360", "2009", "Misc", "Sega", "0.76", "0.38", "0.00", "0.11"},
            {"WWE '12", "X360", "2011", "Fighting", "THQ", "0.72", "0.39", "0.00", "0.12"},
            {"Disney Infinity", "X360", "2013", "Action", "Disney Interactive Studios", "0.82", "0.31", "0.00", "0.09"},
            {"Destiny", "X360", "2014", "Action", "Activision", "0.83", "0.30", "0.00", "0.09"},
            {"Skylanders Giants", "X360", "2012", "Action", "Activision", "0.70", "0.42", "0.00", "0.10"},
            {"Sonic Generations", "X360", "2011", "Platform", "Sega", "0.62", "0.47", "0.00", "0.12"},
            {"WWE '13", "X360", "2012", "Action", "THQ", "0.68", "0.43", "0.00", "0.10"},
            {"Guitar Hero: Aerosmith", "X360", "2008", "Misc", "Activision", "0.97", "0.13", "0.00", "0.10"},
            {
                "Injustice: Gods Among Us", "X360", "2013", "Fighting", "Warner Bros. Interactive Entertainment", "0.81",
                "0.27", "0.00", "0.09"
            },
            {"Madden NFL 15", "X360", "2014", "Sports", "Electronic Arts", "1.06", "0.03", "0.00", "0.07"},
            {"Need for Speed: Most Wanted", "X360", "2005", "Racing", "Electronic Arts", "0.95", "0.09", "0.02", "0.09"},
            {"Mirror's Edge", "X360", "2008", "Action", "Electronic Arts", "0.49", "0.51", "0.01", "0.12"},
            {
                "LEGO The Lord of the Rings", "X360", "2012", "Action", "Warner Bros. Interactive Entertainment", "0.56",
                "0.46", "0.00", "0.10"
            },
            {"Sniper: Ghost Warrior", "X360", "2010", "Shooter", "City Interactive", "0.51", "0.50", "0.00", "0.11"},
            {"Just Dance 4", "X360", "2012", "Misc", "Ubisoft", "0.85", "0.19", "0.00", "0.08"},
            {"Diablo III", "X360", "2013", "Role-Playing", "Activision", "0.69", "0.33", "0.00", "0.09"},
            {"Guitar Hero 5", "X360", "2009", "Misc", "Activision", "0.63", "0.36", "0.00", "0.11"},
            {"Skylanders SWAP Force", "X360", "2013", "Platform", "Activision", "0.70", "0.31", "0.00", "0.09"},
            {"Your Shape: Fitness Evolved 2012", "X360", "2011", "Sports", "Ubisoft", "0.65", "0.35", "0.00", "0.09"},
            {"Crackdown 2", "X360", "2010", "Shooter", "Microsoft Game Studios", "0.62", "0.35", "0.02", "0.10"},
            {"Medal of Honor: Airborne", "X360", "2007", "Shooter", "Electronic Arts", "0.43", "0.52", "0.01", "0.12"},
            {"Dragon Age II", "X360", "2011", "Role-Playing", "Electronic Arts", "0.69", "0.29", "0.01", "0.08"},
            {"Titanfall", "X360", "2014", "Shooter", "Electronic Arts", "0.68", "0.29", "0.02", "0.08"},
            {"Skate 2", "X360", "2009", "Sports", "Electronic Arts", "0.81", "0.16", "0.01", "0.09"},
            {
                "Pro Evolution Soccer 2008", "X360", "2007", "Sports", "Konami Digital Entertainment", "0.08", "0.90",
                "0.04", "0.05"
            },
            {"Medal of Honor: Warfighter", "X360", "2012", "Action", "Electronic Arts", "0.53", "0.43", "0.01", "0.09"},
            {
                "Tomb Raider: Underworld", "X360", "2008", "Adventure", "Eidos Interactive", "0.51", "0.42", "0.01", "0.11"
            },
            {
                "Marvel vs. Capcom 3: Fate of Two Worlds", "X360", "2011", "Fighting", "Capcom", "0.77", "0.17", "0.03",
                "0.07"
            },
            {"Rocksmith", "X360", "2011", "Misc", "Ubisoft", "0.78", "0.19", "0.01", "0.07"},
            {"Aliens vs Predator", "X360", "2010", "Shooter", "Sega", "0.54", "0.40", "0.00", "0.10"},
            {
                "Mercenaries 2: World in Flames", "X360", "2008", "Shooter", "Electronic Arts", "0.64", "0.30", "0.01",
                "0.10"
            },
            {"NCAA Football 13", "X360", "2012", "Action", "Electronic Arts", "0.98", "0.00", "0.00", "0.06"},
            {
                "Bully: Scholarship Edition", "X360", "2008", "Action", "Take-Two Interactive", "0.51", "0.39", "0.03",
                "0.10"
            },
            {"Darksiders", "X360", "2010", "Action", "THQ", "0.65", "0.28", "0.01", "0.09"},
            {"WWE SmackDown vs. Raw 2010", "X360", "2009", "Fighting", "THQ", "0.55", "0.37", "0.01", "0.10"},
            {"DJ Hero", "X360", "2009", "Misc", "Activision", "0.53", "0.39", "0.00", "0.10"},
            {"NCAA Football 14", "X360", "2013", "Sports", "Electronic Arts", "0.97", "0.00", "0.00", "0.06"},
            {"The Simpsons Game", "X360", "2007", "Action", "Electronic Arts", "0.52", "0.38", "0.00", "0.11"},
            {"Sonic Free Riders", "X360", "2010", "Racing", "Sega", "0.68", "0.25", "0.00", "0.08"},
            {"Brink", "X360", "2011", "Shooter", "Bethesda Softworks", "0.57", "0.34", "0.01", "0.09"},
            {"Watch Dogs", "X360", "2014", "Action", "Ubisoft", "0.57", "0.35", "0.00", "0.08"},
            {
                "Tom Clancy's Ghost Recon Advanced Warfighter 2", "X360", "2007", "Shooter", "Ubisoft", "0.85", "0.05",
                "0.02", "0.08"
            },
            {"Sonic the Hedgehog", "X360", "2006", "Platform", "Sega", "0.41", "0.48", "0.00", "0.11"},
            {
                "Winning Eleven: Pro Evolution Soccer 2007 (All Region sales)", "X360", "2006", "Sports",
                "Konami Digital Entertainment", "0.08", "0.90", "0.02", "0.00"
            },
            {
                "Red Dead Redemption: Undead Nightmare", "X360", "2010", "Action", "Take-Two Interactive", "0.52", "0.37",
                "0.02", "0.09"
            },
            {"Prince of Persia", "X360", "2008", "Adventure", "Ubisoft", "0.53", "0.34", "0.02", "0.10"},
            {"Ninja Gaiden II", "X360", "2008", "Action", "Tecmo Koei", "0.63", "0.21", "0.05", "0.09"},
            {
                "PES 2009: Pro Evolution Soccer", "X360", "2008", "Sports", "Konami Digital Entertainment", "0.12", "0.75",
                "0.03", "0.09"
            },
            {"Bulletstorm", "X360", "2011", "Shooter", "Electronic Arts", "0.59", "0.31", "0.01", "0.08"},
            {"WWE 2K14", "X360", "2013", "Sports", "Take-Two Interactive", "0.56", "0.35", "0.00", "0.08"},
            {"Ace Combat 6: Fires of Liberation", "X360", "2007", "Simulation", "Atari", "0.67", "0.03", "0.22", "0.06"},
            {
                "LEGO Indiana Jones 2: The Adventure Continues", "X360", "2009", "Adventure", "Activision", "0.60", "0.29",
                "0.00", "0.09"
            },
            {"NCAA Football 12", "X360", "2011", "Sports", "Electronic Arts", "0.92", "0.00", "0.00", "0.05"},
            {"Brutal Legend", "X360", "2009", "Action", "Electronic Arts", "0.61", "0.26", "0.00", "0.09"},
            {"UFC Undisputed 3", "X360", "2012", "Fighting", "THQ", "0.69", "0.19", "0.00", "0.07"},
            {
                "LEGO Pirates of the Caribbean: The Video Game", "X360", "2011", "Action", "Disney Interactive Studios",
                "0.48", "0.36", "0.00", "0.09"
            },
            {"NCAA Football 10", "X360", "2009", "Sports", "Electronic Arts", "0.86", "0.00", "0.00", "0.07"},
            {"NBA 2K10", "X360", "2009", "Sports", "Take-Two Interactive", "0.83", "0.01", "0.00", "0.07"},
            {
                "Operation Flashpoint: Dragon Rising", "X360", "2009", "Shooter", "Codemasters", "0.36", "0.44", "0.02",
                "0.10"
            },
            {"Dead Space 3", "X360", "2013", "Shooter", "Electronic Arts", "0.60", "0.25", "0.00", "0.07"},
            {"Dark Souls", "X360", "2011", "Role-Playing", "Namco Bandai Games", "0.58", "0.26", "0.00", "0.08"},
            {"Skylanders: Spyro's Adventure", "X360", "2011", "Action", "Activision", "0.49", "0.34", "0.00", "0.09"},
            {"Sonic Unleashed", "X360", "2008", "Platform", "Sega", "0.50", "0.32", "0.00", "0.09"},
            {
                "The LEGO Movie Videogame", "X360", "2014", "Action", "Warner Bros. Interactive Entertainment", "0.48",
                "0.34", "0.00", "0.08"
            },
            {"WWE SmackDown vs. Raw 2009", "X360", "2008", "Fighting", "THQ", "0.57", "0.26", "0.00", "0.08"},
            {"Bayonetta", "X360", "2009", "Action", "Sega", "0.49", "0.24", "0.09", "0.08"},
            {"NCAA Football 11", "X360", "2010", "Sports", "Electronic Arts", "0.84", "0.00", "0.00", "0.06"},
            {
                "Tom Clancy's Splinter Cell: Blacklist", "X360", "2013", "Action", "Ubisoft", "0.52", "0.30", "0.01",
                "0.07"
            },
            {"Army of Two: The 40th Day", "X360", "2010", "Shooter", "Electronic Arts", "0.58", "0.24", "0.00", "0.08"},
            {"Blue Dragon", "X360", "2006", "Role-Playing", "Microsoft Game Studios", "0.29", "0.32", "0.21", "0.07"},
            {"Tom Clancy's EndWar", "X360", "2008", "Strategy", "Ubisoft", "0.56", "0.24", "0.01", "0.08"},
            {"Dante's Inferno", "X360", "2010", "Action", "Electronic Arts", "0.61", "0.19", "0.02", "0.07"},
            {
                "Marvel: Ultimate Alliance 2", "X360", "2009", "Role-Playing", "Activision", "0.66", "0.15", "0.00", "0.07"
            },
            {"Lost Odyssey", "X360", "2007", "Role-Playing", "Microsoft Game Studios", "0.43", "0.26", "0.11", "0.08"},
            {
                "LEGO Harry Potter: Years 5-7", "X360", "N/A", "Action", "Warner Bros. Interactive Entertainment", "0.45",
                "0.33", "0.00", "0.08"
            },
            {"F1 2010", "X360", "2010", "Racing", "Codemasters", "0.17", "0.59", "0.01", "0.10"},
            {"The Biggest Loser: Ultimate Workout", "X360", "2010", "Sports", "THQ", "0.71", "0.09", "0.00", "0.06"},
            {"DiRT", "X360", "2007", "Racing", "Codemasters", "0.37", "0.40", "0.00", "0.09"},
            {"GRID", "X360", "2008", "Racing", "Codemasters", "0.33", "0.43", "0.01", "0.09"},
            {"WWE SmackDown vs. Raw 2011", "X360", "2010", "Fighting", "THQ", "0.43", "0.35", "0.00", "0.08"},
            {"Brothers in Arms: Hell's Highway", "X360", "2008", "Shooter", "Ubisoft", "0.46", "0.30", "0.00", "0.09"},
            {"Just Dance 2014", "X360", "2013", "Misc", "Ubisoft", "0.64", "0.16", "0.00", "0.06"},
            {"Wipeout: In The Zone", "X360", "2011", "Misc", "Activision", "0.80", "0.00", "0.00", "0.05"},
            {"Crysis 3", "X360", "2013", "Shooter", "Electronic Arts", "0.47", "0.30", "0.01", "0.07"},
            {"NBA 2K8", "X360", "2007", "Sports", "Take-Two Interactive", "0.78", "0.00", "0.00", "0.06"},
            {"Red Faction: Guerrilla", "X360", "2009", "Shooter", "THQ", "0.46", "0.29", "0.01", "0.08"},
            {"Guitar Hero: Warriors of Rock", "X360", "2010", "Misc", "Activision", "0.45", "0.31", "0.00", "0.07"},
            {
                "2010 FIFA World Cup South Africa", "X360", "2010", "Sports", "Electronic Arts", "0.31", "0.42", "0.02",
                "0.09"
            },
            {
                "Kingdoms of Amalur: Reckoning", "X360", "2012", "Role-Playing", "Electronic Arts", "0.52", "0.23", "0.01",
                "0.06"
            },
            {"Sleeping Dogs", "X360", "2012", "Action", "Square Enix", "0.34", "0.39", "0.01", "0.08"},
            {"Rock Band 3", "X360", "2010", "Misc", "MTV Games", "0.68", "0.09", "0.00", "0.05"},
            {"Michael Jackson: The Experience", "X360", "2011", "Misc", "Ubisoft", "0.58", "0.17", "0.00", "0.06"},
            {"FIFA Street", "X360", "2012", "Sports", "Electronic Arts", "0.12", "0.59", "0.00", "0.10"},
            {"Duke Nukem Forever", "X360", "2011", "Shooter", "Take-Two Interactive", "0.50", "0.24", "0.00", "0.07"},
            {
                "Pro Evolution Soccer 2010", "X360", "2009", "Sports", "Konami Digital Entertainment", "0.11", "0.58",
                "0.03", "0.08"
            },
            {"Shaun White Snowboarding", "X360", "N/A", "Sports", "Ubisoft", "0.47", "0.25", "0.00", "0.08"},
            {
                "The Witcher 2: Assassins of Kings", "X360", "2012", "Role-Playing", "Namco Bandai Games", "0.41", "0.29",
                "0.02", "0.07"
            },
            {"Stranglehold", "X360", "2007", "Shooter", "Midway Games", "0.38", "0.33", "0.01", "0.08"},
            {"Sniper Elite V2", "X360", "2012", "Shooter", "505 Games", "0.43", "0.27", "0.02", "0.07"},
            {"DiRT 2", "X360", "2009", "Racing", "Codemasters", "0.31", "0.39", "0.00", "0.09"},
            {
                "Sid Meier's Civilization Revolution", "X360", "2008", "Strategy", "Take-Two Interactive", "0.55", "0.17",
                "0.00", "0.06"
            },
            {"DJ Hero 2", "X360", "2010", "Misc", "Activision", "0.60", "0.12", "0.00", "0.06"},
            {"Guitar Hero: Metallica", "X360", "2009", "Misc", "Activision", "0.50", "0.20", "0.00", "0.07"},
            {"The Godfather II", "X360", "2009", "Action", "Electronic Arts", "0.46", "0.23", "0.01", "0.08"},
            {"Too Human", "X360", "2008", "Role-Playing", "Microsoft Game Studios", "0.37", "0.29", "0.03", "0.08"},
            {"Star Ocean: The Last Hope", "X360", "2009", "Role-Playing", "Square Enix", "0.31", "0.19", "0.21", "0.06"},
            {
                "Tom Clancy's Splinter Cell: Double Agent", "X360", "2006", "Action", "Ubisoft", "0.65", "0.04", "0.01",
                "0.06"
            },
            {"Lips", "X360", "2008", "Misc", "Microsoft Game Studios", "0.11", "0.55", "0.00", "0.10"},
            {"James Cameron's Avatar: The Game", "X360", "2009", "Action", "Ubisoft", "0.33", "0.35", "0.00", "0.08"},
            {"Perfect Dark Zero", "X360", "2005", "Shooter", "Microsoft Game Studios", "0.65", "0.02", "0.03", "0.06"},
            {
                "Naruto Shippuden: Ultimate Ninja Storm 2", "X360", "2010", "Fighting", "Namco Bandai Games", "0.41",
                "0.27", "0.01", "0.07"
            },
            {"Dance Central 3", "X360", "2012", "Misc", "Microsoft Game Studios", "0.53", "0.17", "0.00", "0.06"},
            {"Kane & Lynch: Dead Men", "X360", "2007", "Shooter", "Eidos Interactive", "0.36", "0.30", "0.01", "0.08"},
            {"Band Hero", "X360", "2009", "Misc", "Activision", "0.48", "0.20", "0.00", "0.07"},
            {"Darksiders II", "X360", "2012", "Action", "THQ", "0.42", "0.26", "0.00", "0.06"},
            {
                "Rockstar Games presents Table Tennis", "X360", "2006", "Sports", "Take-Two Interactive", "0.28", "0.38",
                "0.00", "0.08"
            },
            {"Prototype 2", "X360", "2012", "Action", "Activision", "0.44", "0.23", "0.00", "0.06"},
            {"Dead Island: Riptide", "X360", "2013", "Action", "Deep Silver", "0.41", "0.25", "0.01", "0.06"},
            {
                "Banjo-Kazooie: Nuts & Bolts", "X360", "2008", "Platform", "Microsoft Game Studios", "0.31", "0.34", "0.00",
                "0.08"
            },
            {
                "The Lord of the Rings: War in the North", "X360", "N/A", "Action",
                "Warner Bros. Interactive Entertainment", "0.44", "0.22", "0.00", "0.06"
            },
            {"Lost Planet 2", "X360", "2010", "Shooter", "Capcom", "0.37", "0.23", "0.08", "0.06"},
            {"Dragon's Dogma", "X360", "2012", "Adventure", "Capcom", "0.38", "0.22", "0.07", "0.06"},
            {"Turok", "X360", "2008", "Shooter", "Touchstone", "0.45", "0.20", "0.01", "0.07"},
            {
                "UFC Personal Trainer: The Ultimate Fitness System", "X360", "2011", "Sports", "THQ", "0.50", "0.17",
                "0.00", "0.06"
            },
            {"Fight Night Champion", "X360", "2011", "Fighting", "Electronic Arts", "0.37", "0.29", "0.00", "0.07"},
            {"Rayman Origins", "X360", "2011", "Platform", "Ubisoft", "0.35", "0.31", "0.00", "0.07"},
            {
                "Resident Evil: Operation Raccoon City", "X360", "2012", "Shooter", "Capcom", "0.51", "0.14", "0.03",
                "0.05"
            },
            {"NCAA Football 07", "X360", "2006", "Sports", "Electronic Arts", "0.66", "0.00", "0.00", "0.05"},
            {"Final Fantasy XIII-2", "X360", "2011", "Role-Playing", "Square Enix", "0.36", "0.28", "0.02", "0.06"},
            {"NHL 11", "X360", "2010", "Sports", "Electronic Arts", "0.60", "0.07", "0.00", "0.05"},
            {"Aliens: Colonial Marines", "X360", "2013", "Shooter", "Sega", "0.33", "0.31", "0.00", "0.07"},
            {"Major League Baseball 2K7", "X360", "2007", "Sports", "Spike", "0.66", "0.00", "0.00", "0.05"},
            {"NBA 2K15", "X360", "2014", "Sports", "Take-Two Interactive", "0.61", "0.05", "0.00", "0.04"},
            {"Skate", "X360", "2007", "Sports", "Electronic Arts", "0.61", "0.03", "0.00", "0.06"},
            {
                "Toy Story 3: The Video Game", "X360", "2010", "Action", "Disney Interactive Studios", "0.38", "0.26",
                "0.00", "0.07"
            },
            {"Tales of Vesperia", "X360", "2008", "Role-Playing", "Atari", "0.30", "0.17", "0.19", "0.05"},
            {"F1 2011", "X360", "2011", "Racing", "Codemasters", "0.10", "0.49", "0.01", "0.09"},
            {"Two Worlds", "X360", "2007", "Role-Playing", "SouthPeak Games", "0.41", "0.22", "0.00", "0.07"},
            {"NCAA Football 09", "X360", "2008", "Sports", "Electronic Arts", "0.64", "0.00", "0.00", "0.05"},
            {"NCAA Football 08", "X360", "2007", "Sports", "Electronic Arts", "0.64", "0.00", "0.00", "0.05"},
            {"NBA Live 09", "X360", "2008", "Sports", "Electronic Arts", "0.48", "0.14", "0.00", "0.06"},
            {"DiRT 3", "X360", "2011", "Racing", "Codemasters", "0.21", "0.39", "0.01", "0.08"},
            {"Infinite Undiscovery", "X360", "2008", "Role-Playing", "Square Enix", "0.33", "0.18", "0.12", "0.06"},
            {
                "X-Men Origins: Wolverine - Uncaged Edition", "X360", "2009", "Action", "Activision", "0.42", "0.20",
                "0.00", "0.06"
            },
            {
                "Plants vs Zombies: Garden Warfare", "X360", "2014", "Action", "Electronic Arts", "0.28", "0.33", "0.00",
                "0.07"
            },
            {
                "The Walking Dead: A Telltale Games Series", "X360", "2012", "Adventure", "Avanquest Software", "0.52",
                "0.11", "0.00", "0.05"
            },
            {"NHL 12", "X360", "2011", "Sports", "Electronic Arts", "0.53", "0.09", "0.00", "0.05"},
            {"The Last Remnant", "X360", "2008", "Role-Playing", "Square Enix", "0.24", "0.20", "0.18", "0.06"},
            {"Test Drive Unlimited 2", "X360", "N/A", "Racing", "Atari", "0.29", "0.31", "0.00", "0.07"},
            {"MotionSports", "X360", "2010", "Sports", "Ubisoft", "0.36", "0.25", "0.00", "0.06"},
            {"SSX", "X360", "2012", "Sports", "Electronic Arts", "0.35", "0.24", "0.00", "0.06"},
            {"MX vs. ATV Reflex", "X360", "2009", "Racing", "THQ", "0.47", "0.13", "0.00", "0.05"},
            {
                "Sonic & SEGA All-Stars Racing with Banjo-Kazooie", "X360", "2010", "Racing", "Sega", "0.32", "0.27",
                "0.00", "0.06"
            },
            {"Driver: San Francisco", "X360", "2011", "Racing", "Ubisoft", "0.22", "0.35", "0.00", "0.07"},
            {"Shrek the Third", "X360", "2007", "Action", "Activision", "0.52", "0.08", "0.00", "0.05"},
            {
                "South Park: The Stick of Truth", "X360", "2014", "Role-Playing", "Ubisoft", "0.38", "0.22", "0.00", "0.05"
            },
            {"NHL 10", "X360", "2009", "Sports", "Electronic Arts", "0.50", "0.10", "0.00", "0.06"},
            {
                "The Amazing Spider-Man (Console Version)", "X360", "2012", "Action", "Activision", "0.37", "0.22", "0.00",
                "0.05"
            },
            {"Tiger Woods PGA Tour 09", "X360", "2008", "Sports", "Electronic Arts", "0.35", "0.23", "0.00", "0.07"},
            {
                "Scene It? Box Office Smash", "X360", "2008", "Misc", "Microsoft Game Studios", "0.32", "0.25", "0.00",
                "0.06"
            },
            {"Tiger Woods PGA Tour 10", "X360", "2009", "Sports", "Electronic Arts", "0.38", "0.20", "0.00", "0.06"},
            {
                "Omerta: City of Gangsters", "X360", "2011", "Simulation", "Konami Digital Entertainment", "0.38", "0.20",
                "0.00", "0.05"
            },
            {"Stuntman: Ignition", "X360", "2007", "Racing", "THQ", "0.24", "0.31", "0.00", "0.07"},
            {"NHL 13", "X360", "2012", "Sports", "Electronic Arts", "0.48", "0.10", "0.00", "0.04"},
            {"Rocksmith 2014", "X360", "2013", "Misc", "Ubisoft", "0.44", "0.13", "0.00", "0.05"},
            {"Juiced 2: Hot Import Nights", "X360", "2007", "Racing", "THQ", "0.21", "0.34", "0.00", "0.07"},
            {
                "Castlevania: Lords of Shadow", "X360", "2010", "Action", "Konami Digital Entertainment", "0.39", "0.17",
                "0.01", "0.05"
            },
            {
                "LEGO Star Wars II: The Original Trilogy", "X360", "2006", "Action", "LucasArts", "0.54", "0.03", "0.00",
                "0.05"
            },
            {
                "Transformers: Revenge of the Fallen", "X360", "2009", "Action", "Activision", "0.33", "0.23", "0.00",
                "0.06"
            },
            {"MX vs. ATV Untamed", "X360", "2007", "Racing", "THQ", "0.49", "0.07", "0.00", "0.05"},
            {"Wall-E", "X360", "2008", "Platform", "THQ", "0.29", "0.26", "0.00", "0.06"},
            {
                "The Lord of the Rings: Conquest", "X360", "2009", "Action", "Electronic Arts", "0.36", "0.19", "0.00",
                "0.06"
            },
            {"Condemned 2: Bloodshot", "X360", "2008", "Shooter", "Sega", "0.37", "0.19", "0.00", "0.06"},
            {"Need for Speed Rivals", "X360", "2013", "Racing", "Electronic Arts", "0.24", "0.30", "0.01", "0.06"},
            {"Ghostbusters: The Video Game", "X360", "2009", "Action", "Atari", "0.42", "0.14", "0.00", "0.05"},
            {
                "pro evolution soccer 2011", "X360", "2010", "Sports", "Konami Digital Entertainment", "0.09", "0.44",
                "0.00", "0.07"
            },
            {
                "Prince of Persia: The Forgotten Sands", "X360", "2010", "Action", "Ubisoft", "0.28", "0.25", "0.00",
                "0.06"
            },
            {"Major League Baseball 2K9", "X360", "2009", "Sports", "Spike", "0.55", "0.00", "0.00", "0.04"},
            {
                "Major League Baseball 2K8", "X360", "2008", "Sports", "Bethesda Softworks", "0.55", "0.00", "0.00", "0.04"
            },
            {"Call of Juarez: Bound in Blood", "X360", "2009", "Shooter", "Ubisoft", "0.29", "0.24", "0.00", "0.06"},
            {"Tony Hawk: RIDE", "X360", "2009", "Sports", "Activision", "0.44", "0.10", "0.00", "0.05"},
            {
                "Tiger Woods PGA Tour 12: The Masters", "X360", "2011", "Sports", "Electronic Arts", "0.39", "0.16", "0.00",
                "0.05"
            },
            {"Madden NFL 06", "X360", "N/A", "Sports", "Electronic Arts", "0.54", "0.00", "0.01", "0.03"},
            {"Beijing 2008", "X360", "2008", "Sports", "Sega", "0.14", "0.37", "0.00", "0.07"},
            {"Transformers: The Game", "X360", "2007", "Action", "Activision", "0.50", "0.04", "0.00", "0.05"},
            {
                "PGR3 - Project Gotham Racing 3", "X360", "2005", "Racing", "Microsoft Game Studios", "0.48", "0.03",
                "0.03", "0.05"
            },
            {"Monopoly", "X360", "2008", "Misc", "Electronic Arts", "0.33", "0.19", "0.00", "0.06"},
            {"Fighters Uncaged", "X360", "2010", "Fighting", "Ubisoft", "0.29", "0.23", "0.00", "0.06"},
            {"Split/Second", "X360", "2010", "Racing", "Disney Interactive Studios", "0.30", "0.22", "0.00", "0.06"},
            {"XCOM: Enemy Unknown", "X360", "2012", "Strategy", "Take-Two Interactive", "0.33", "0.20", "0.00", "0.05"},
            {"Naruto: The Broken Bond", "X360", "2008", "Action", "Ubisoft", "0.23", "0.28", "0.00", "0.06"},
            {"Lost: Via Domus", "X360", "2008", "Action", "Ubisoft", "0.17", "0.34", "0.00", "0.07"},
            {"NBA 2K7", "X360", "2006", "Sports", "Take-Two Interactive", "0.53", "0.00", "0.00", "0.04"},
            {"Tom Clancy's HAWX", "X360", "2009", "Action", "Ubisoft", "0.30", "0.19", "0.02", "0.06"},
            {"Blur", "X360", "2010", "Racing", "Activision", "0.24", "0.27", "0.00", "0.06"},
            {"Blacksite: Area 51", "X360", "2007", "Shooter", "Midway Games", "0.28", "0.22", "0.00", "0.06"},
            {
                "Dragon Ball: Raging Blast 2", "X360", "2010", "Fighting", "Namco Bandai Games", "0.43", "0.08", "0.01",
                "0.04"
            },
            {"Top Spin 3", "X360", "2008", "Sports", "Take-Two Interactive", "0.09", "0.40", "0.00", "0.07"},
            {"Spider-Man 3", "X360", "2007", "Platform", "Activision", "0.48", "0.03", "0.00", "0.04"},
            {"Iron Man", "X360", "2008", "Action", "Sega", "0.26", "0.23", "0.00", "0.06"},
            {
                "London 2012: The Official Video Game of the Olympic Games", "X360", "2012", "Sports", "Sega", "0.06",
                "0.43", "0.00", "0.07"
            },
            {"Tony Hawk's Proving Ground", "X360", "2007", "Sports", "Activision", "0.49", "0.02", "0.00", "0.04"},
            {"SoulCalibur V", "X360", "2012", "Fighting", "Namco Bandai Games", "0.36", "0.13", "0.02", "0.04"},
            {"Transformers: War for Cybertron", "X360", "2010", "Action", "Activision", "0.35", "0.15", "0.00", "0.05"},
            {"Warhammer 40,000: Space Marine", "X360", "2011", "Shooter", "THQ", "0.23", "0.25", "0.00", "0.06"},
            {"Frontlines: Fuel of War", "X360", "2008", "Shooter", "THQ", "0.33", "0.15", "0.01", "0.05"},
            {"Wolfenstein", "X360", "2009", "Shooter", "Activision", "0.27", "0.22", "0.00", "0.06"},
            {
                "LEGO Rock Band", "X360", "2009", "Misc", "Warner Bros. Interactive Entertainment", "0.38", "0.11", "0.00",
                "0.05"
            },
            {"Tiger Woods PGA Tour 08", "X360", "2007", "Sports", "Electronic Arts", "0.48", "0.01", "0.00", "0.04"},
            {"DEFIANCE", "X360", "2013", "Action", "Trion Worlds", "0.36", "0.14", "0.00", "0.04"},
            {
                "Game Party in Motion", "X360", "2010", "Misc", "Warner Bros. Interactive Entertainment", "0.32", "0.17",
                "0.00", "0.05"
            },
            {"Disney Universe", "X360", "2011", "Action", "Disney Interactive Studios", "0.35", "0.14", "0.00", "0.05"},
            {
                "Enslaved: Odyssey to the West", "X360", "2010", "Action", "Namco Bandai Games", "0.29", "0.18", "0.00",
                "0.05"
            },
            {"MX vs. ATV: Alive", "X360", "2011", "Racing", "THQ", "0.35", "0.13", "0.00", "0.04"},
            {"Sacred 2: Fallen Angel", "X360", "2009", "Role-Playing", "Deep Silver", "0.28", "0.16", "0.04", "0.05"},
            {"METRO 2033", "X360", "2010", "Shooter", "THQ", "0.20", "0.23", "0.03", "0.05"},
            {"Lips: Number One Hits", "X360", "2009", "Misc", "Microsoft Game Studios", "0.13", "0.33", "0.00", "0.06"},
            {"Two Worlds II", "X360", "2011", "Role-Playing", "Unknown", "0.38", "0.07", "0.03", "0.03"},
            {
                "F.E.A.R. 2: Project Origin", "X360", "2009", "Shooter", "Warner Bros. Interactive Entertainment", "0.31",
                "0.14", "0.00", "0.05"
            },
            {"IL-2 Sturmovik: Birds of Prey", "X360", "2009", "Simulation", "505 Games", "0.22", "0.23", "0.00", "0.05"},
            {
                "Dragon Ball Z: Ultimate Tenkaichi", "X360", "2011", "Fighting", "Namco Bandai Games", "0.36", "0.09",
                "0.01", "0.04"
            },
            {"Tiger Woods PGA Tour 11", "X360", "2010", "Sports", "Electronic Arts", "0.27", "0.19", "0.00", "0.05"},
            {"NBA Live 08", "X360", "2007", "Sports", "Electronic Arts", "0.46", "0.00", "0.00", "0.04"},
            {"NHL 09", "X360", "2008", "Sports", "Electronic Arts", "0.45", "0.01", "0.00", "0.04"},
            {"Dark Souls II", "X360", "2014", "Action", "Namco Bandai Games", "0.29", "0.16", "0.01", "0.04"},
            {
                "Pro Evolution Soccer 2012", "X360", "2011", "Sports", "Konami Digital Entertainment", "0.09", "0.34",
                "0.00", "0.06"
            },
            {
                "The Walking Dead: Survival Instinct", "X360", "2013", "Misc", "Activision", "0.36", "0.10", "0.00", "0.04"
            },
            {"Sonic & All-Stars Racing Transformed", "X360", "2012", "Racing", "Sega", "0.17", "0.27", "0.00", "0.05"},
            {
                "Major League Baseball 2K10", "X360", "2010", "Sports", "Take-Two Interactive", "0.46", "0.00", "0.00",
                "0.03"
            },
            {
                "Sesame Street: Once Upon A Monster", "X360", "2011", "Misc", "Warner Bros. Interactive Entertainment",
                "0.37", "0.08", "0.00", "0.04"
            },
            {"NBA Street Homecourt", "X360", "2007", "Sports", "Electronic Arts", "0.44", "0.01", "0.00", "0.04"},
            {"The Saboteur", "X360", "2009", "Action", "Electronic Arts", "0.25", "0.20", "0.00", "0.05"},
            {
                "Dance Dance Revolution Universe 2", "X360", "2007", "Simulation", "Konami Digital Entertainment", "0.45",
                "0.00", "0.00", "0.04"
            },
            {"WWE SmackDown vs. RAW 2007", "X360", "2006", "Fighting", "THQ", "0.43", "0.02", "0.00", "0.04"},
            {"Wet", "X360", "N/A", "Shooter", "Bethesda Softworks", "0.22", "0.20", "0.01", "0.05"},
            {"Skylanders: Trap Team", "X360", "2014", "Action", "Activision", "0.29", "0.15", "0.00", "0.04"},
            {
                "Dragon Ball: Raging Blast", "X360", "2009", "Fighting", "Namco Bandai Games", "0.34", "0.08", "0.02",
                "0.04"
            },
            {"Payday 2", "X360", "2013", "Action", "505 Games", "0.27", "0.18", "0.00", "0.04"},
            {"F1 2012", "X360", "2012", "Racing", "Codemasters", "0.09", "0.33", "0.00", "0.06"},
            {
                "Disney Infinity 2.0: Marvel Super Heroes", "X360", "2014", "Action", "Disney Interactive Studios", "0.27",
                "0.17", "0.00", "0.04"
            },
            {
                "Scene It? Lights Camera Action", "X360", "2007", "Misc", "Microsoft Game Studios", "0.43", "0.01", "0.00",
                "0.04"
            },
            {"You're in the Movies", "X360", "2008", "Misc", "Microsoft Game Studios", "0.26", "0.17", "0.00", "0.05"},
            {"Tony Hawk's Project 8", "X360", "2006", "Sports", "Activision", "0.42", "0.02", "0.00", "0.04"},
            {"Tiger Woods PGA Tour 13", "X360", "2012", "Sports", "Electronic Arts", "0.27", "0.17", "0.00", "0.04"},
            {"Alone in the Dark", "X360", "2008", "Adventure", "Atari", "0.13", "0.30", "0.00", "0.05"},
            {"Dragon Ball Z: Burst Limit", "X360", "2008", "Fighting", "Atari", "0.23", "0.17", "0.03", "0.05"},
            {"FIFA World Cup Germany 2006", "X360", "2006", "Sports", "Electronic Arts", "0.19", "0.27", "0.01", "0.00"},
            {"Dark Sector", "X360", "2008", "Shooter", "D3Publisher", "0.21", "0.19", "0.01", "0.05"},
            {"Burnout Revenge", "X360", "2006", "Racing", "Electronic Arts", "0.40", "0.04", "0.00", "0.04"},
            {"TMNT", "X360", "2007", "Action", "Ubisoft", "0.41", "0.03", "0.00", "0.03"},
            {"Kane & Lynch 2: Dog Days", "X360", "2010", "Shooter", "Square Enix", "0.19", "0.22", "0.01", "0.05"},
            {"Tiger Woods PGA Tour 07", "X360", "2006", "Sports", "Electronic Arts", "0.43", "0.00", "0.00", "0.04"},
            {
                "Major League Baseball 2K12", "X360", "2012", "Sports", "Take-Two Interactive", "0.44", "0.00", "0.00",
                "0.03"
            },
            {"Goldeneye 007: Reloaded", "X360", "2011", "Shooter", "Activision", "0.23", "0.19", "0.00", "0.05"},
            {
                "Ace Combat: Assault Horizon", "X360", "2011", "Action", "Namco Bandai Games", "0.28", "0.12", "0.03",
                "0.04"
            },
            {"NHL 14", "X360", "2013", "Sports", "Electronic Arts", "0.36", "0.07", "0.00", "0.03"},
            {"Shadowrun", "X360", "2007", "Role-Playing", "Microsoft Game Studios", "0.41", "0.02", "0.00", "0.03"},
            {"Dead or Alive 4", "X360", "2005", "Fighting", "Tecmo Koei", "0.29", "0.03", "0.10", "0.03"},
            {"Crash: Mind Over Mutant", "X360", "2008", "Platform", "Vivendi Games", "0.21", "0.20", "0.00", "0.05"},
            {
                "Viva Pinata: Trouble in Paradise", "X360", "2008", "Simulation", "Microsoft Game Studios", "0.15", "0.24",
                "0.01", "0.05"
            },
            {"Unreal Tournament III", "X360", "2008", "Shooter", "Midway Games", "0.23", "0.17", "0.01", "0.04"},
            {
                "Disney Epic Mickey 2: The Power of Two", "X360", "2012", "Action", "Disney Interactive Studios", "0.29",
                "0.13", "0.00", "0.04"
            },
            {"Vin Diesel: Wheelman", "X360", "2009", "Racing", "Ubisoft", "0.24", "0.17", "0.00", "0.05"},
            {
                "Borderlands: The Pre-Sequel", "X360", "2014", "Shooter", "Take-Two Interactive", "0.29", "0.12", "0.00",
                "0.03"
            },
            {
                "Dragon Age Origins: Awakening", "X360", "2010", "Role-Playing", "Electronic Arts", "0.31", "0.10", "0.00",
                "0.04"
            },
            {"The Golden Compass", "X360", "2007", "Action", "Sega", "0.29", "0.12", "0.00", "0.04"},
            {"James Bond 007: Blood Stone", "X360", "2010", "Action", "Activision", "0.18", "0.22", "0.00", "0.04"},
            {"Rise of Nightmares", "X360", "2011", "Action", "Sega", "0.27", "0.13", "0.01", "0.04"},
            {"Alice: Madness Returns", "X360", "2011", "Adventure", "Electronic Arts", "0.23", "0.14", "0.04", "0.04"},
            {"TNA iMPACT!", "X360", "2008", "Fighting", "Midway Games", "0.25", "0.15", "0.00", "0.04"},
            {
                "Naruto Shippuden: Ultimate Ninja Storm 3", "X360", "2013", "Fighting", "Namco Bandai Games", "0.25",
                "0.15", "0.01", "0.04"
            },
            {"Sega Rally Revo", "X360", "2007", "Racing", "Sega", "0.11", "0.28", "0.00", "0.05"},
            {
                "Command & Conquer: Red Alert 3", "X360", "2008", "Strategy", "Electronic Arts", "0.17", "0.22", "0.00",
                "0.05"
            },
            {
                "Lollipop Chainsaw", "X360", "2012", "Action", "Warner Bros. Interactive Entertainment", "0.28", "0.11",
                "0.02", "0.03"
            },
            {"NBA Live 10", "X360", "2009", "Sports", "Electronic Arts", "0.39", "0.01", "0.00", "0.03"},
            {"Viking: Battle for Asgard", "X360", "2008", "Action", "Sega", "0.16", "0.22", "0.00", "0.05"},
            {"Enemy Territory: Quake Wars", "X360", "2008", "Shooter", "Activision", "0.28", "0.11", "0.00", "0.04"},
            {"Brunswick Pro Bowling", "X360", "2010", "Sports", "505 Games", "0.37", "0.03", "0.00", "0.03"},
            {"NBA Live 07", "X360", "2006", "Sports", "Electronic Arts", "0.40", "0.00", "0.00", "0.03"},
            {
                "Harry Potter and the Deathly Hallows - Part 1", "X360", "2010", "Action", "Electronic Arts", "0.20",
                "0.19", "0.00", "0.04"
            },
            {
                "Silent Hill: Homecoming", "X360", "N/A", "Action", "Konami Digital Entertainment", "0.23", "0.15", "0.00",
                "0.04"
            },
            {"Doom 3 BFG Edition", "X360", "2012", "Shooter", "Bethesda Softworks", "0.25", "0.14", "0.00", "0.04"},
            {
                "Major League Baseball 2K11", "X360", "2011", "Sports", "Take-Two Interactive", "0.38", "0.02", "0.00",
                "0.03"
            },
            {
                "Need for Speed: Shift 2 Unleashed", "X360", "2011", "Racing", "Electronic Arts", "0.18", "0.20", "0.00",
                "0.04"
            },
            {
                "Naruto Shippuden: Ultimate Ninja STORM Generations", "X360", "2012", "Fighting", "Namco Bandai Games",
                "0.24", "0.14", "0.01", "0.03"
            },
            {"Street Fighter X Tekken", "X360", "2012", "Fighting", "Capcom", "0.28", "0.09", "0.03", "0.03"},
            {"The Darkness", "X360", "2007", "Shooter", "Take-Two Interactive", "0.34", "0.03", "0.01", "0.03"},
            {"Cars 2", "X360", "2011", "Platform", "Disney Interactive Studios", "0.24", "0.14", "0.00", "0.04"},
            {
                "Kinect Rush: A Disney Pixar Adventure", "X360", "2012", "Adventure", "Microsoft Game Studios", "0.25",
                "0.13", "0.00", "0.03"
            },
            {
                "Robert Ludlum's The Bourne Conspiracy", "X360", "N/A", "Action", "Vivendi Games", "0.24", "0.13", "0.00",
                "0.04"
            },
            {
                "F.E.A.R. 3", "X360", "2011", "Shooter", "Warner Bros. Interactive Entertainment", "0.28", "0.10", "0.01",
                "0.03"
            },
            {"Child of Eden", "X360", "2011", "Shooter", "Ubisoft", "0.26", "0.12", "0.00", "0.03"},
            {
                "Command & Conquer 3: Tiberium Wars", "X360", "2007", "Strategy", "Electronic Arts", "0.34", "0.04", "0.00",
                "0.03"
            },
            {
                "Blazing Angels: Squadrons of WWII", "X360", "2006", "Simulation", "Ubisoft", "0.35", "0.02", "0.00",
                "0.03"
            },
            {"Disney Sing It", "X360", "2008", "Misc", "Disney Interactive Studios", "0.37", "0.01", "0.00", "0.03"},
            {"Vanquish", "X360", "2010", "Adventure", "Sega", "0.18", "0.16", "0.03", "0.04"},
            {"Spider-Man: Web of Shadows", "X360", "2008", "Action", "Activision", "0.36", "0.01", "0.00", "0.03"},
            {"Beowulf: The Game", "X360", "2007", "Action", "Ubisoft", "0.36", "0.01", "0.00", "0.03"},
            {"TimeShift", "X360", "2007", "Shooter", "Vivendi Games", "0.34", "0.02", "0.00", "0.03"},
            {"Guitar Hero: Smash Hits", "X360", "2009", "Misc", "Activision", "0.21", "0.14", "0.00", "0.04"},
            {"Condemned: Criminal Origins", "X360", "2005", "Action", "Sega", "0.34", "0.02", "0.00", "0.03"},
            {
                "Battlefield 2: Modern Combat", "X360", "2006", "Shooter", "Electronic Arts", "0.34", "0.02", "0.01",
                "0.03"
            },
            {"Overlord", "X360", "2007", "Strategy", "Codemasters", "0.33", "0.03", "0.01", "0.03"},
            {"Transformers: Fall of Cybertron", "X360", "2012", "Action", "Activision", "0.24", "0.12", "0.00", "0.03"},
            {
                "Major League Baseball 2K13", "X360", "2013", "Sports", "Take-Two Interactive", "0.37", "0.00", "0.00",
                "0.02"
            },
            {"Devil May Cry HD Collection", "X360", "2012", "Action", "Capcom", "0.26", "0.09", "0.01", "0.03"},
            {"Top Spin 4", "X360", "2011", "Sports", "Take-Two Interactive", "0.14", "0.21", "0.00", "0.04"},
            {"Green Day: Rock Band", "X360", "2010", "Misc", "MTV Games", "0.23", "0.12", "0.00", "0.03"},
            {"Spec Ops: The Line", "X360", "2012", "Shooter", "Take-Two Interactive", "0.18", "0.16", "0.00", "0.04"},
            {
                "Metal Gear Rising: Revengeance", "X360", "2013", "Action", "Konami Digital Entertainment", "0.23", "0.12",
                "0.00", "0.03"
            },
            {"Naughty Bear", "X360", "2010", "Action", "505 Games", "0.20", "0.15", "0.00", "0.04"},
            {"Legends of WrestleMania", "X360", "2009", "Fighting", "THQ", "0.20", "0.15", "0.00", "0.04"},
            {"Tomb Raider: Anniversary", "X360", "2007", "Action", "Eidos Interactive", "0.12", "0.22", "0.00", "0.05"},
            {"The Gunstringer", "X360", "2011", "Shooter", "Microsoft Game Studios", "0.24", "0.10", "0.00", "0.03"},
            {"Alpha Protocol", "X360", "2010", "Role-Playing", "Sega", "0.22", "0.12", "0.00", "0.03"},
            {"DMC", "X360", "2013", "Action", "Capcom", "0.21", "0.12", "0.01", "0.03"},
            {"Fantastic Pets", "X360", "2011", "Simulation", "THQ", "0.27", "0.07", "0.00", "0.03"},
            {"Hitman: Blood Money", "X360", "2006", "Action", "Eidos Interactive", "0.28", "0.05", "0.01", "0.03"},
            {"Major League Baseball 2K6", "X360", "2006", "Sports", "Spike", "0.34", "0.00", "0.00", "0.03"},
            {"EA Sports Active 2", "X360", "2010", "Sports", "Electronic Arts", "0.17", "0.16", "0.00", "0.04"},
            {"Assassin's Creed: Rogue", "X360", "2014", "Action", "Ubisoft", "0.18", "0.15", "0.00", "0.03"},
            {
                "Star Wars The Clone Wars: Republic Heroes", "X360", "2009", "Action", "LucasArts", "0.17", "0.16", "0.00",
                "0.04"
            },
            {"2014 FIFA World Cup Brazil", "X360", "2014", "Sports", "Electronic Arts", "0.12", "0.21", "0.00", "0.04"},
            {"Just Dance Kids 2", "X360", "2011", "Misc", "Ubisoft", "0.26", "0.08", "0.00", "0.03"},
            {"Rapala Pro Bass Fishing 2010", "X360", "2010", "Sports", "Activision", "0.30", "0.04", "0.00", "0.02"},
            {"Trivial Pursuit", "X360", "2009", "Misc", "Electronic Arts", "0.11", "0.21", "0.00", "0.04"},
            {"Red Faction: Armageddon", "X360", "2011", "Shooter", "THQ", "0.16", "0.16", "0.01", "0.04"},
            {
                "Wanted: Weapons of Fate", "X360", "2009", "Shooter", "Warner Bros. Interactive Entertainment", "0.17",
                "0.15", "0.00", "0.04"
            },
            {
                "Kingdom Under Fire: Circle of Doom", "X360", "2007", "Role-Playing", "Microsoft Game Studios", "0.17",
                "0.12", "0.04", "0.03"
            },
            {"Quake 4", "X360", "2005", "Shooter", "Activision", "0.31", "0.02", "0.00", "0.03"},
            {"BlazBlue: Calamity Trigger", "X360", "2009", "Fighting", "PQube", "0.21", "0.08", "0.04", "0.03"},
            {"The Darkness II", "X360", "2012", "Shooter", "Take-Two Interactive", "0.22", "0.11", "0.00", "0.03"},
            {"Spider-Man: Shattered Dimensions", "X360", "2010", "Action", "Activision", "0.24", "0.08", "0.00", "0.03"},
            {"Tom Clancy's HAWX 2", "X360", "2010", "Action", "Ubisoft", "0.22", "0.09", "0.01", "0.03"},
            {"Dungeon Siege III", "X360", "2011", "Role-Playing", "Square Enix", "0.19", "0.11", "0.01", "0.03"},
            {"NBA Jam", "X360", "2010", "Sports", "Electronic Arts", "0.23", "0.08", "0.00", "0.03"},
            {"Tomb Raider: Legend", "X360", "2006", "Action", "Eidos Interactive", "0.25", "0.05", "0.01", "0.03"},
            {"MotoGP 08", "X360", "2008", "Racing", "Capcom", "0.11", "0.20", "0.00", "0.04"},
            {"Def Jam Icon", "X360", "2007", "Action", "Electronic Arts", "0.30", "0.01", "0.00", "0.03"},
            {
                "Terminator Salvation", "X360", "2009", "Shooter", "Warner Bros. Interactive Entertainment", "0.12", "0.17",
                "0.00", "0.04"
            },
            {
                "UEFA Euro 2008 Austria-Switzerland", "X360", "2008", "Sports", "Electronic Arts", "0.08", "0.23", "0.00",
                "0.03"
            },
            {"Forza Horizon 2", "X360", "2014", "Action", "Microsoft Game Studios", "0.13", "0.17", "0.00", "0.03"},
            {"Tenchu Z", "X360", "2006", "Action", "Microsoft Game Studios", "0.27", "0.02", "0.02", "0.03"},
            {
                "Kameo: Elements of Power", "X360", "2005", "Adventure", "Microsoft Game Studios", "0.27", "0.03", "0.00",
                "0.03"
            },
            {"Virtua Tennis 2009", "X360", "2009", "Sports", "Sega", "0.12", "0.18", "0.00", "0.03"},
            {
                "Kinectimals: Now with Bears!", "X360", "2011", "Misc", "Microsoft Game Studios", "0.25", "0.05", "0.00",
                "0.02"
            },
            {"WWE All Stars", "X360", "2011", "Fighting", "THQ", "0.16", "0.13", "0.00", "0.03"},
            {"Fracture", "X360", "2008", "Shooter", "LucasArts", "0.15", "0.14", "0.00", "0.04"},
            {"Mass Effect Trilogy", "X360", "2012", "Action", "Electronic Arts", "0.22", "0.08", "0.00", "0.02"},
            {"F.E.A.R.", "X360", "2006", "Shooter", "Vivendi Games", "0.27", "0.03", "0.00", "0.03"},
            {
                "Pirates of the Caribbean: At World's End", "X360", "2007", "Action", "Disney Interactive Studios", "0.28",
                "0.02", "0.00", "0.03"
            },
            {"Tropico 4", "X360", "N/A", "Strategy", "Kalypso Media", "0.18", "0.11", "0.00", "0.03"},
            {"Rayman Legends", "X360", "2013", "Platform", "Ubisoft", "0.12", "0.16", "0.00", "0.03"},
            {"Supreme Commander 2", "X360", "2010", "Strategy", "Square Enix", "0.21", "0.08", "0.00", "0.03"},
            {
                "The King of Fighters XIII", "X360", "2011", "Fighting", "Rising Star Games", "0.22", "0.06", "0.01",
                "0.02"
            },
            {"Resonance of Fate", "X360", "2010", "Role-Playing", "Sega", "0.11", "0.12", "0.06", "0.03"},
            {"Minute to Win It", "X360", "2011", "Misc", "Zoo Games", "0.30", "0.00", "0.00", "0.02"},
            {"Naruto: Rise of a Ninja", "X360", "2007", "Action", "Ubisoft", "0.28", "0.01", "0.00", "0.02"},
            {"Ninja Blade", "X360", "2009", "Action", "Microsoft Game Studios", "0.13", "0.13", "0.02", "0.03"},
            {"Golden Axe: Beast Rider", "X360", "2008", "Action", "Sega", "0.18", "0.10", "0.00", "0.03"},
            {"Deadpool", "X360", "2013", "Action", "Activision", "0.19", "0.10", "0.00", "0.03"},
            {"Overlord II", "X360", "2009", "Action", "Codemasters", "0.14", "0.14", "0.00", "0.03"},
            {
                "Tekken Tag Tournament 2", "X360", "2012", "Fighting", "Namco Bandai Games", "0.17", "0.10", "0.01", "0.03"
            },
            {"Metro: Last Light", "X360", "2013", "Shooter", "Deep Silver", "0.14", "0.14", "0.00", "0.03"},
            {"Tony Hawk's American Wasteland", "X360", "2005", "Sports", "Activision", "0.27", "0.01", "0.00", "0.02"},
            {"Battlestations: Pacific", "X360", "2009", "Strategy", "Eidos Interactive", "0.16", "0.11", "0.01", "0.03"},
            {
                "Harry Potter and the Deathly Hallows - Part 2", "X360", "2011", "Action", "Electronic Arts", "0.18",
                "0.10", "0.00", "0.03"
            },
            {"Clive Barker's Jericho", "X360", "2007", "Shooter", "Codemasters", "0.27", "0.01", "0.00", "0.02"},
            {
                "Dance Dance Revolution Universe", "X360", "2007", "Simulation", "Konami Digital Entertainment", "0.29",
                "0.00", "0.00", "0.02"
            },
            {"Fable", "X360", "2014", "Role-Playing", "Microsoft Game Studios", "0.17", "0.11", "0.01", "0.03"},
            {"EA Sports MMA", "X360", "2010", "Fighting", "Electronic Arts", "0.22", "0.06", "0.00", "0.02"},
            {"Prey", "X360", "2006", "Shooter", "Take-Two Interactive", "0.26", "0.02", "0.00", "0.02"},
            {"Test Drive Unlimited", "X360", "2006", "Racing", "Atari", "0.23", "0.03", "0.02", "0.02"},
            {"Tiger Woods PGA Tour 14", "X360", "2013", "Sports", "Electronic Arts", "0.17", "0.11", "0.00", "0.03"},
            {"F1 2013", "X360", "2013", "Action", "Codemasters", "0.01", "0.26", "0.00", "0.04"},
            {"Crash of the Titans", "X360", "2007", "Action", "Vivendi Games", "0.27", "0.01", "0.00", "0.02"},
            {"NCAA Basketball 10", "X360", "2009", "Sports", "Electronic Arts", "0.28", "0.00", "0.00", "0.02"},
            {"The Black Eyed Peas Experience", "X360", "2011", "Misc", "Ubisoft", "0.18", "0.09", "0.00", "0.03"},
            {"Eternal Sonata", "X360", "2007", "Role-Playing", "Atari", "0.17", "0.03", "0.08", "0.02"},
            {"Tiger Woods PGA Tour 06", "X360", "2005", "Sports", "Electronic Arts", "0.28", "0.00", "0.00", "0.02"},
            {"Singularity", "X360", "N/A", "Shooter", "Unknown", "0.23", "0.05", "0.00", "0.02"},
            {"Fuel", "X360", "2009", "Racing", "Codemasters", "0.08", "0.18", "0.00", "0.04"},
            {"Cabela's Dangerous Hunts 2011", "X360", "2010", "Sports", "Activision", "0.27", "0.01", "0.00", "0.02"},
            {
                "Harry Potter and the Half-Blood Prince", "X360", "2009", "Action", "Electronic Arts", "0.16", "0.11",
                "0.00", "0.03"
            },
            {"Beautiful Katamari", "X360", "2007", "Puzzle", "Namco Bandai Games", "0.12", "0.01", "0.15", "0.01"},
            {
                "The Legend of Spyro: Dawn of the Dragon", "X360", "2008", "Platform", "Vivendi Games", "0.15", "0.12",
                "0.00", "0.03"
            },
            {
                "Dance Dance Revolution Universe 3", "X360", "2008", "Simulation", "Konami Digital Entertainment", "0.27",
                "0.00", "0.00", "0.02"
            },
            {
                "Farming Simulator 2013", "X360", "2013", "Action", "Focus Home Interactive", "0.15", "0.11", "0.00",
                "0.03"
            },
            {"Dynasty Warriors 6", "X360", "2007", "Action", "Tecmo Koei", "0.15", "0.06", "0.06", "0.02"},
            {"Namco Museum: Virtual Arcade", "X360", "2008", "Misc", "Atari", "0.26", "0.01", "0.01", "0.02"},
            {
                "Silent Hill: Downpour", "X360", "2012", "Adventure", "Konami Digital Entertainment", "0.20", "0.07",
                "0.00", "0.02"
            },
            {"DECA Sports Freedom", "X360", "2010", "Sports", "Hudson Soft", "0.24", "0.03", "0.00", "0.02"},
            {"BlazBlue: Continuum Shift", "X360", "2010", "Fighting", "PQube", "0.22", "0.04", "0.02", "0.02"},
            {"Dark Void", "X360", "2010", "Action", "Capcom", "0.17", "0.09", "0.00", "0.03"},
            {
                "Lord of the Rings: Battle for Middle-Earth", "X360", "2006", "Strategy", "Electronic Arts", "0.27", "0.00",
                "0.00", "0.02"
            },
            {"Magna Carta 2", "X360", "2009", "Role-Playing", "Banpresto", "0.13", "0.07", "0.07", "0.02"},
            {"NBA Live 06", "X360", "2005", "Sports", "Electronic Arts", "0.27", "0.00", "0.00", "0.02"},
            {"NASCAR 2011: The Game", "X360", "2011", "Racing", "Activision", "0.27", "0.00", "0.00", "0.02"},
            {
                "Carnival Games: Monkey See, Monkey Do!", "X360", "2011", "Misc", "Take-Two Interactive", "0.11", "0.14",
                "0.00", "0.03"
            },
            {
                "Pro Evolution Soccer 2013", "X360", "2012", "Sports", "Konami Digital Entertainment", "0.06", "0.19",
                "0.00", "0.03"
            },
            {
                "LEGO The Hobbit", "X360", "2014", "Action", "Warner Bros. Interactive Entertainment", "0.12", "0.14",
                "0.00", "0.03"
            },
            {"Spider-Man: Friend or Foe", "X360", "2007", "Action", "Activision", "0.25", "0.01", "0.00", "0.02"},
            {
                "N3: Ninety-Nine Nights", "X360", "2006", "Action", "Microsoft Game Studios", "0.19", "0.02", "0.05",
                "0.02"
            },
            {
                "LEGO Batman 3: Beyond Gotham", "X360", "2014", "Action", "Warner Bros. Interactive Entertainment", "0.14",
                "0.11", "0.00", "0.03"
            },
            {"Turning Point: Fall of Liberty", "X360", "2008", "Shooter", "Codemasters", "0.22", "0.04", "0.00", "0.02"},
            {"TRON: Evolution", "X360", "2010", "Action", "Disney Interactive Studios", "0.22", "0.04", "0.00", "0.02"},
            {
                "The Chronicles of Riddick: Assault on Dark Athena", "X360", "2009", "Shooter", "Atari", "0.16", "0.10",
                "0.00", "0.03"
            },
            {"Catherine", "X360", "2011", "Adventure", "Deep Silver", "0.17", "0.05", "0.03", "0.02"},
            {"Up", "X360", "2009", "Adventure", "THQ", "0.19", "0.07", "0.00", "0.02"},
            {
                "Harry Potter and the Order of the Phoenix", "X360", "2007", "Adventure", "Electronic Arts", "0.23", "0.03",
                "0.00", "0.02"
            },
            {"Mini Ninjas", "X360", "2009", "Action", "Eidos Interactive", "0.11", "0.14", "0.00", "0.03"},
            {"Chromehounds", "X360", "2006", "Simulation", "Sega", "0.24", "0.00", "0.01", "0.02"},
            {"SAW", "X360", "2009", "Action", "Konami Digital Entertainment", "0.13", "0.12", "0.00", "0.03"},
            {"FIFA 07 Soccer", "X360", "2006", "Sports", "Electronic Arts", "0.24", "0.01", "0.00", "0.02"},
            {"Bionic Commando", "X360", "2009", "Platform", "Capcom", "0.12", "0.12", "0.01", "0.03"},
            {"Rabbids: Alive & Kicking", "X360", "2011", "Misc", "Ubisoft", "0.14", "0.10", "0.00", "0.03"},
            {"PowerUp Heroes", "X360", "2011", "Fighting", "Ubisoft", "0.15", "0.09", "0.00", "0.03"},
            {
                "Final Fantasy XI: Wings of the Goddess", "X360", "2007", "Role-Playing", "Square Enix", "0.23", "0.00",
                "0.02", "0.02"
            },
            {"Far Cry 4", "X360", "2014", "Shooter", "Ubisoft", "0.11", "0.13", "0.00", "0.03"},
            {"NieR", "X360", "2010", "Role-Playing", "Square Enix", "0.11", "0.09", "0.04", "0.02"},
            {"Virtua Fighter 5 Online", "X360", "2007", "Fighting", "Sega", "0.20", "0.02", "0.03", "0.02"},
            {"NHL 07", "X360", "2006", "Sports", "Electronic Arts", "0.24", "0.00", "0.00", "0.02"},
            {"Monopoly Streets", "X360", "2010", "Misc", "Electronic Arts", "0.15", "0.09", "0.00", "0.02"},
            {"DeathSmiles", "X360", "2009", "Shooter", "Rising Star Games", "0.14", "0.06", "0.05", "0.02"},
            {"Dead or Alive 5", "X360", "2012", "Fighting", "Ubisoft Annecy", "0.15", "0.07", "0.03", "0.02"},
            {
                "Final Fantasy XI: Ultimate Collection", "X360", "2009", "Role-Playing", "Square Enix", "0.25", "0.00",
                "0.00", "0.02"
            },
            {"Cabela's Big Game Hunter 2012", "X360", "2011", "Sports", "Activision", "0.22", "0.02", "0.00", "0.02"},
            {"Rugby World Cup 2011", "X360", "2011", "Sports", "505 Games", "0.02", "0.20", "0.00", "0.04"},
            {"The Club", "X360", "2008", "Shooter", "Sega", "0.14", "0.10", "0.00", "0.02"},
            {
                "Operation Flashpoint: Red River", "X360", "2011", "Shooter", "Codemasters", "0.08", "0.14", "0.01", "0.03"
            },
            {"Transformers: Dark of the Moon", "X360", "2011", "Action", "Activision", "0.12", "0.12", "0.00", "0.03"},
            {"NASCAR 08", "X360", "2007", "Racing", "Electronic Arts", "0.24", "0.00", "0.00", "0.02"},
            {
                "Cabela's Big Game Hunter 2010", "X360", "2009", "Sports", "Activision Value", "0.24", "0.00", "0.00",
                "0.02"
            },
            {"Section 8", "X360", "2009", "Shooter", "SouthPeak Games", "0.15", "0.08", "0.00", "0.03"},
            {
                "Jonah Lomu Rugby Challenge", "X360", "2011", "Sports", "Home Entertainment Suppliers", "0.08", "0.15",
                "0.00", "0.03"
            },
            {
                "Wolfenstein: The New Order", "X360", "2014", "Shooter", "Bethesda Softworks", "0.11", "0.13", "0.00",
                "0.03"
            },
            {"The BIGS", "X360", "2007", "Sports", "Take-Two Interactive", "0.18", "0.08", "0.00", "0.00"},
            {"Def Jam Rapstar", "X360", "2010", "Misc", "Konami Digital Entertainment", "0.22", "0.02", "0.00", "0.02"},
            {"FIFA Street 3", "X360", "2008", "Sports", "Electronic Arts", "0.09", "0.14", "0.00", "0.03"},
            {"Gun", "X360", "N/A", "Shooter", "Activision", "0.23", "0.01", "0.00", "0.02"},
            {"Iron Man 2", "X360", "2010", "Action", "Sega", "0.14", "0.09", "0.00", "0.02"},
            {"Guitar Hero: Van Halen", "X360", "2009", "Misc", "Activision", "0.13", "0.10", "0.00", "0.02"},
            {"Ratatouille", "X360", "2007", "Platform", "THQ", "0.22", "0.02", "0.00", "0.02"},
            {"All-Pro Football 2K8", "X360", "2007", "Sports", "Take-Two Interactive", "0.24", "0.00", "0.00", "0.02"},
            {"James Bond 007: Legends", "X360", "2012", "Shooter", "Activision", "0.11", "0.12", "0.00", "0.02"},
            {"R.U.S.E.", "X360", "2010", "Strategy", "Ubisoft", "0.12", "0.11", "0.00", "0.02"},
            {"The Incredible Hulk", "X360", "2008", "Action", "Sega", "0.21", "0.02", "0.00", "0.02"},
            {"Call of Juarez: The Cartel", "X360", "2011", "Shooter", "Ubisoft", "0.13", "0.10", "0.00", "0.02"},
            {"Dead Rising 2: Off the Record", "X360", "2011", "Action", "Capcom", "0.15", "0.08", "0.00", "0.02"},
            {"Deadly Premonition", "X360", "2010", "Action", "Rising Star Games", "0.17", "0.06", "0.00", "0.02"},
            {"Rock Revolution", "X360", "2008", "Misc", "Konami Digital Entertainment", "0.23", "0.00", "0.00", "0.02"},
            {"MotoGP '07", "X360", "2007", "Racing", "THQ", "0.23", "0.00", "0.00", "0.02"},
            {"NASCAR 09", "X360", "2008", "Racing", "Electronic Arts", "0.23", "0.00", "0.00", "0.02"},
            {"Battlestations: Midway", "X360", "2007", "Strategy", "Eidos Interactive", "0.20", "0.02", "0.00", "0.02"},
            {
                "Don King Presents: Prizefighter", "X360", "2008", "Sports", "Take-Two Interactive", "0.14", "0.08", "0.00",
                "0.02"
            },
            {"Tony Hawk: Shred", "X360", "2010", "Sports", "Activision", "0.16", "0.06", "0.00", "0.02"},
            {
                "Peter Jackson's King Kong: The Official Game of the Movie", "X360", "2005", "Action", "Ubisoft", "0.20",
                "0.03", "0.00", "0.02"
            },
            {"SpongeBob's Truth or Square (US sales)", "X360", "2009", "Action", "THQ", "0.24", "0.00", "0.00", "0.00"},
            {"Legendary", "X360", "2008", "Shooter", "Atari", "0.07", "0.15", "0.00", "0.03"},
            {"WWE 2K15", "X360", "2014", "Sports", "Take-Two Interactive", "0.14", "0.09", "0.00", "0.02"},
            {"Superman Returns", "X360", "2006", "Action", "Electronic Arts", "0.21", "0.01", "0.00", "0.02"},
            {"Wipeout 2", "X360", "2011", "Misc", "Activision", "0.23", "0.00", "0.00", "0.01"},
            {"F1 Race Stars", "X360", "2012", "Racing", "Codemasters", "0.05", "0.17", "0.00", "0.03"},
            {"Spider-Man: Edge of Time", "X360", "2011", "Action", "Activision", "0.17", "0.05", "0.00", "0.02"},
            {"GRID 2", "X360", "2013", "Racing", "Codemasters", "0.06", "0.15", "0.00", "0.03"},
            {"The Outfit", "X360", "2006", "Action", "THQ", "0.20", "0.02", "0.00", "0.02"},
            {"Dreamworks Madagascar Kartz", "X360", "2009", "Racing", "Activision", "0.13", "0.09", "0.00", "0.02"},
            {"Terraria", "X360", "2013", "Action", "505 Games", "0.11", "0.11", "0.00", "0.02"},
            {"The Evil Within", "X360", "2014", "Action", "Bethesda Softworks", "0.13", "0.09", "0.00", "0.02"},
            {"MotionSports: Adrenaline", "X360", "2011", "Sports", "Ubisoft", "0.12", "0.09", "0.00", "0.02"},
            {
                "Fable: The Journey", "X360", "2012", "Role-Playing", "Microsoft Game Studios", "0.15", "0.07", "0.00",
                "0.02"
            },
            {"Bolt", "X360", "2008", "Adventure", "Disney Interactive Studios", "0.17", "0.05", "0.00", "0.02"},
            {"Armored Core 4", "X360", "2007", "Simulation", "505 Games", "0.19", "0.00", "0.03", "0.02"},
            {"Cars", "X360", "2006", "Racing", "THQ", "0.21", "0.01", "0.00", "0.02"},
            {"Madagascar: Escape 2 Africa", "X360", "2008", "Action", "Activision", "0.11", "0.10", "0.00", "0.02"},
            {"NHL 08", "X360", "2007", "Action", "Electronic Arts", "0.21", "0.01", "0.00", "0.02"},
            {
                "Fallout 3 Game Add-On Pack: Broken Steel and Point Lookout", "X360", "2009", "Role-Playing",
                "Bethesda Softworks", "0.16", "0.06", "0.00", "0.02"
            },
            {"Dead or Alive Xtreme 2", "X360", "2006", "Sports", "Tecmo Koei", "0.14", "0.02", "0.06", "0.01"},
            {
                "Cabela's Outdoor Adventures (2009)", "X360", "2009", "Sports", "Activision Value", "0.22", "0.00", "0.00",
                "0.01"
            },
            {
                "Command & Conquer 3: Kane's Wrath", "X360", "2008", "Strategy", "Electronic Arts", "0.15", "0.06", "0.00",
                "0.02"
            },
            {"X-Men: Destiny", "X360", "2011", "Action", "Activision", "0.17", "0.04", "0.00", "0.02"},
            {"Dynasty Warriors 6 Empires", "X360", "2009", "Action", "Tecmo Koei", "0.16", "0.01", "0.04", "0.02"},
            {"Far Cry Instincts Predator", "X360", "2006", "Shooter", "Ubisoft", "0.19", "0.02", "0.00", "0.02"},
            {
                "Divinity II: Ego Draconis", "X360", "2009", "Role-Playing", "DTP Entertainment", "0.18", "0.03", "0.00",
                "0.02"
            },
            {"G.I. Joe: The Rise of Cobra", "X360", "2009", "Action", "Electronic Arts", "0.16", "0.05", "0.00", "0.02"},
            {"NBA 2K6", "X360", "2005", "Action", "Take-Two Interactive", "0.21", "0.00", "0.00", "0.02"},
            {"Kung Fu Panda 2", "X360", "2011", "Action", "THQ", "0.15", "0.06", "0.00", "0.02"},
            {"Ninja Gaiden 3", "X360", "2012", "Action", "Tecmo Koei", "0.14", "0.04", "0.03", "0.01"},
            {
                "Family Guy: Back to the Multiverse", "X360", "2012", "Action", "Activision", "0.12", "0.09", "0.00",
                "0.02"
            },
            {"Bakugan: Battle Brawlers", "X360", "2009", "Action", "Activision", "0.19", "0.02", "0.00", "0.02"},
            {"Afro Samurai", "X360", "2009", "Action", "Atari", "0.15", "0.05", "0.00", "0.02"},
            {"Dynasty Warriors 7", "X360", "2011", "Action", "Tecmo Koei", "0.15", "0.06", "0.00", "0.02"},
            {"The Adventures of Tintin: The Game", "X360", "2011", "Action", "Ubisoft", "0.06", "0.13", "0.00", "0.03"},
            {
                "The Godfather (US & Others sales)", "X360", "2006", "Action", "Electronic Arts", "0.19", "0.02", "0.00",
                "0.02"
            },
            {
                "Viva Pinata: Party Animals", "X360", "2007", "Misc", "Microsoft Game Studios", "0.18", "0.02", "0.00",
                "0.02"
            },
            {"Rock Band Country Track Pack", "X360", "2009", "Misc", "MTV Games", "0.20", "0.00", "0.00", "0.02"},
            {"Resident Evil: Revelations", "X360", "2013", "Action", "Capcom", "0.09", "0.09", "0.02", "0.02"},
            {"DiRT Showdown", "X360", "2012", "Action", "Codemasters", "0.07", "0.13", "0.00", "0.02"},
            {"Dreamcast Collection", "X360", "2011", "Misc", "Sega", "0.14", "0.06", "0.00", "0.02"},
            {"Thief (2014)", "X360", "2014", "Action", "Square Enix", "0.10", "0.10", "0.00", "0.02"},
            {
                "Game of Thrones", "X360", "2012", "Role-Playing", "Focus Home Interactive", "0.12", "0.08", "0.00", "0.02"
            },
            {
                "Vancouver 2010 - The Official Video Game of the Olympic Winter Games", "X360", "2010", "Sports", "Sega",
                "0.07", "0.12", "0.00", "0.02"
            },
            {
                "Army of Two: The Devil's Cartel", "X360", "2013", "Shooter", "Electronic Arts", "0.13", "0.07", "0.00",
                "0.02"
            },
            {"Tropico 3", "X360", "2009", "Strategy", "Kalypso Media", "0.15", "0.02", "0.03", "0.02"},
            {"AC/DC LIVE: Rock Band Track Pack", "X360", "2008", "Misc", "MTV Games", "0.20", "0.00", "0.00", "0.01"},
            {
                "Ben 10 Alien Force: Vilgax Attacks", "X360", "2009", "Action", "D3Publisher", "0.10", "0.08", "0.00",
                "0.02"
            },
            {
                "Pro Evolution Soccer 2014", "X360", "2013", "Action", "Konami Digital Entertainment", "0.04", "0.14",
                "0.00", "0.02"
            },
            {"Over G Fighters", "X360", "2006", "Simulation", "Ubisoft", "0.19", "0.01", "0.00", "0.02"},
            {"Plants vs. Zombies", "X360", "2010", "Strategy", "PopCap Games", "0.20", "0.00", "0.00", "0.01"},
            {"Pictionary: Ultimate Edition", "X360", "2011", "Misc", "THQ", "0.14", "0.05", "0.00", "0.02"},
            {
                "Hannah Montana: The Movie", "X360", "2009", "Adventure", "Disney Interactive Studios", "0.13", "0.05",
                "0.00", "0.02"
            },
            {"50 Cent: Blood on the Sand", "X360", "2009", "Shooter", "THQ", "0.12", "0.06", "0.00", "0.02"},
            {"Full Auto", "X360", "2006", "Shooter", "Sega", "0.18", "0.01", "0.00", "0.02"},
            {
                "Hunted: The Demon's Forge", "X360", "2011", "Role-Playing", "Bethesda Softworks", "0.12", "0.06", "0.00",
                "0.02"
            },
            {
                "SBK Superbike World Championship", "X360", "2008", "Racing", "Black Bean Games", "0.06", "0.14", "0.00",
                "0.01"
            },
            {"NCAA Basketball 09", "X360", "2008", "Sports", "Electronic Arts", "0.19", "0.00", "0.00", "0.02"},
            {"Dynasty Warriors: Strikeforce", "X360", "2009", "Action", "Tecmo Koei", "0.11", "0.06", "0.02", "0.02"},
            {"Yoostar2", "X360", "2011", "Misc", "Unknown", "0.10", "0.08", "0.00", "0.02"},
            {"StokEd", "X360", "2009", "Sports", "Zushi Games", "0.18", "0.01", "0.00", "0.01"},
            {"Virtua Tennis 4", "X360", "2011", "Sports", "Sega", "0.08", "0.09", "0.01", "0.02"},
            {"NCAA March Madness 08", "X360", "2007", "Sports", "Electronic Arts", "0.19", "0.00", "0.00", "0.01"},
            {"Bass Pro Shops: The Strike", "X360", "2009", "Sports", "XS Games", "0.19", "0.00", "0.00", "0.01"},
            {
                "Lightning Returns: Final Fantasy XIII", "X360", "2013", "Role-Playing", "Square Enix", "0.11", "0.07",
                "0.01", "0.02"
            },
            {"The BIGS 2", "X360", "2009", "Sports", "Take-Two Interactive", "0.18", "0.01", "0.00", "0.01"},
            {"Hasbro Family Game Night 3", "X360", "2010", "Misc", "Electronic Arts", "0.16", "0.03", "0.00", "0.01"},
            {"Puss in Boots", "X360", "2011", "Action", "THQ", "0.17", "0.02", "0.00", "0.01"},
            {"Vampire Rain", "X360", "2007", "Action", "Microsoft Game Studios", "0.17", "0.00", "0.01", "0.01"},
            {"Rayman Raving Rabbids", "X360", "2007", "Misc", "Ubisoft", "0.17", "0.01", "0.00", "0.01"},
            {"Ridge Racer 6", "X360", "2005", "Racing", "Namco Bandai Games", "0.10", "0.02", "0.07", "0.01"},
            {
                "Dragon Age: Inquisition", "X360", "2014", "Role-Playing", "Electronic Arts", "0.13", "0.05", "0.00",
                "0.02"
            },
            {"Way of the Samurai 3", "X360", "2009", "Action", "Gamebridge", "0.12", "0.05", "0.02", "0.02"},
            {"Ashes Cricket 2009", "X360", "2009", "Sports", "Codemasters", "0.00", "0.18", "0.00", "0.01"},
            {"Angry Birds: Star Wars", "X360", "2013", "Strategy", "Activision", "0.10", "0.08", "0.00", "0.02"},
            {"Prison Break: The Conspiracy", "X360", "2010", "Adventure", "Deep Silver", "0.06", "0.11", "0.00", "0.02"},
            {"CSI: Deadly Intent", "X360", "2009", "Adventure", "Ubisoft", "0.10", "0.08", "0.00", "0.02"},
            {
                "Dead to Rights: Retribution", "X360", "2010", "Shooter", "Namco Bandai Games", "0.10", "0.08", "0.00",
                "0.02"
            },
            {"Asura's Wrath", "X360", "2012", "Action", "Capcom", "0.11", "0.05", "0.01", "0.01"},
            {
                "Dark Messiah of Might and Magic Elements", "X360", "2008", "Role-Playing", "Ubisoft", "0.15", "0.02",
                "0.01", "0.01"
            },
            {"College Hoops 2K7", "X360", "2006", "Sports", "Take-Two Interactive", "0.18", "0.00", "0.00", "0.01"},
            {"XCOM", "X360", "2013", "Shooter", "Take-Two Interactive", "0.09", "0.08", "0.00", "0.02"},
            {"Big League Sports", "X360", "2011", "Sports", "Activision", "0.17", "0.01", "0.00", "0.01"},
            {"Final Fantasy XI: Online", "X360", "2006", "Role-Playing", "Square Enix", "0.17", "0.01", "0.00", "0.01"},
            {
                "Dynasty Warriors: Gundam 2", "X360", "2008", "Action", "Namco Bandai Games", "0.07", "0.02", "0.08",
                "0.01"
            },
            {"Warriors Orochi", "X360", "2007", "Action", "Tecmo Koei", "0.17", "0.01", "0.00", "0.01"},
            {"Monster Jam", "X360", "2007", "Racing", "Activision", "0.17", "0.00", "0.00", "0.01"},
            {"Soldier of Fortune: Payback", "X360", "2007", "Shooter", "Activision", "0.17", "0.00", "0.00", "0.01"},
            {"Front Mission Evolved", "X360", "2010", "Shooter", "Square Enix", "0.09", "0.06", "0.02", "0.01"},
            {"Jillian Michaels' Fitness Adventure", "X360", "2011", "Misc", "505 Games", "0.16", "0.02", "0.00", "0.01"},
            {"NCAA March Madness 07", "X360", "2007", "Sports", "Electronic Arts", "0.17", "0.00", "0.00", "0.01"},
            {"Conflict: Denied Ops", "X360", "2008", "Shooter", "Eidos Interactive", "0.08", "0.09", "0.00", "0.02"},
            {"Record of Agarest War", "X360", "2008", "Role-Playing", "Compile Heart", "0.17", "0.00", "0.01", "0.01"},
            {"Baja: Edge of Control", "X360", "2008", "Racing", "THQ", "0.11", "0.06", "0.00", "0.02"},
            {
                "Middle-Earth: Shadow of Mordor", "X360", "2014", "Action", "Warner Bros. Interactive Entertainment",
                "0.11", "0.06", "0.00", "0.02"
            },
            {"Armored Core V", "X360", "2012", "Simulation", "Namco Bandai Games", "0.10", "0.03", "0.04", "0.01"},
            {"Body and Brain Connection", "X360", "2010", "Misc", "Namco Bandai Games", "0.08", "0.08", "0.00", "0.02"},
            {
                "Greg Hastings Paintball 2", "X360", "2010", "Shooter", "Majesco Entertainment", "0.17", "0.00", "0.00",
                "0.01"
            },
            {"Angry Birds Trilogy", "X360", "2012", "Action", "Activision", "0.12", "0.05", "0.00", "0.01"},
            {"Dynasty Warriors Gundam", "X360", "2007", "Action", "Namco Bandai Games", "0.15", "0.01", "0.02", "0.01"},
            {"FaceBreaker", "X360", "2008", "Fighting", "Electronic Arts", "0.15", "0.02", "0.00", "0.01"},
            {"Enchanted Arms", "X360", "2006", "Role-Playing", "Ubisoft", "0.15", "0.02", "0.00", "0.01"},
            {
                "Majin and the Forsaken Kingdom", "X360", "2010", "Adventure", "Namco Bandai Games", "0.14", "0.03", "0.00",
                "0.01"
            },
            {"Conan", "X360", "2007", "Action", "THQ", "0.15", "0.02", "0.00", "0.01"},
            {
                "DarkStar One: Broken Alliance", "X360", "2010", "Simulation", "Kalypso Media", "0.09", "0.07", "0.00",
                "0.02"
            },
            {"Call of Juarez", "X360", "2007", "Shooter", "Ubisoft", "0.14", "0.02", "0.00", "0.01"},
            {"Star Trek: The Game", "X360", "2013", "Action", "Namco Bandai Games", "0.09", "0.07", "0.00", "0.02"},
            {"Zumba Fitness Rush", "X360", "2012", "Sports", "505 Games", "0.00", "0.15", "0.00", "0.02"},
            {"You Don't Know Jack", "X360", "2011", "Misc", "THQ", "0.17", "0.00", "0.00", "0.01"},
            {"NHL 15", "X360", "2014", "Action", "Electronic Arts", "0.14", "0.03", "0.00", "0.01"},
            {"NBA Ballers: Chosen One", "X360", "2008", "Sports", "Midway Games", "0.16", "0.00", "0.00", "0.01"},
            {"SpongeBob's Surf & Skate Roadtrip", "X360", "2011", "Action", "THQ", "0.14", "0.03", "0.00", "0.01"},
            {
                "Earth Defense Force: Insect Armageddon", "X360", "2011", "Shooter", "D3Publisher", "0.09", "0.04", "0.03",
                "0.01"
            },
            {"Risen", "X360", "2009", "Role-Playing", "Deep Silver", "0.06", "0.10", "0.00", "0.01"},
            {"DanceMasters", "X360", "2010", "Misc", "Konami Digital Entertainment", "0.13", "0.01", "0.02", "0.01"},
            {"WipeOut 3 The Game", "X360", "2012", "Action", "Activision", "0.16", "0.00", "0.00", "0.01"},
            {
                "The Chronicles of Narnia: Prince Caspian", "X360", "2008", "Action", "Disney Interactive Studios", "0.15",
                "0.01", "0.00", "0.01"
            },
            {"Pure Futbol", "X360", "2010", "Sports", "Ubisoft", "0.08", "0.08", "0.00", "0.02"},
            {
                "High School Musical 3: Senior Year DANCE!", "X360", "2008", "Misc", "Disney Interactive Studios", "0.16",
                "0.00", "0.00", "0.01"
            },
            {"NHL 2K9", "X360", "2008", "Sports", "Take-Two Interactive", "0.15", "0.01", "0.00", "0.01"},
            {"World of Outlaws: Sprint Cars", "X360", "2010", "Racing", "THQ", "0.16", "0.00", "0.00", "0.01"},
            {
                "Ben 10 Ultimate Alien: Cosmic Destruction", "X360", "2010", "Platform", "D3Publisher", "0.10", "0.06",
                "0.00", "0.01"
            },
            {"Star Trek: Legacy", "X360", "N/A", "Simulation", "Ubisoft", "0.13", "0.02", "0.00", "0.01"},
            {"Top Spin 2", "X360", "2006", "Sports", "Take-Two Interactive", "0.15", "0.00", "0.00", "0.01"},
            {"Race Pro", "X360", "2009", "Racing", "Atari", "0.06", "0.09", "0.00", "0.02"},
            {"Sniper Elite 3", "X360", "2014", "Action", "505 Games", "0.06", "0.09", "0.00", "0.02"},
            {"X-Men: The Official Game", "X360", "2006", "Action", "Activision", "0.15", "0.00", "0.00", "0.01"},
            {"Velvet Assassin", "X360", "2009", "Shooter", "DTP Entertainment", "0.13", "0.02", "0.01", "0.01"},
            {"Lips: Party Classics", "X360", "2010", "Misc", "Microsoft Game Studios", "0.05", "0.10", "0.00", "0.02"},
            {"G-Force", "X360", "2009", "Action", "Disney Interactive Studios", "0.11", "0.05", "0.00", "0.01"},
            {"Shadows of the Damned", "X360", "2011", "Action", "Electronic Arts", "0.09", "0.05", "0.01", "0.01"},
            {"MotoGP 09/10", "X360", "2010", "Racing", "Capcom", "0.06", "0.08", "0.00", "0.02"},
            {
                "Country Dance: All Stars", "X360", "2012", "Action", "GameMill Entertainment", "0.16", "0.00", "0.00",
                "0.01"
            },
            {"Binary Domain", "X360", "2012", "Action", "Sega", "0.07", "0.06", "0.02", "0.01"},
            {"Sniper: Ghost Warrior 2", "X360", "2013", "Shooter", "City Interactive", "0.04", "0.11", "0.00", "0.02"},
            {"Splatterhouse", "X360", "2010", "Action", "Namco Bandai Games", "0.13", "0.03", "0.00", "0.01"},
            {
                "SBK X: Superbike World Championship", "X360", "2010", "Racing", "Black Bean Games", "0.08", "0.07", "0.00",
                "0.02"
            },
            {"Rise of the Argonauts", "X360", "2008", "Role-Playing", "Codemasters", "0.03", "0.12", "0.00", "0.01"},
            {
                "N3 II: Ninety-Nine Nights", "X360", "2010", "Action", "Microsoft Game Studios", "0.05", "0.06", "0.04",
                "0.01"
            },
            {"Backbreaker", "X360", "N/A", "Sports", "Unknown", "0.15", "0.00", "0.00", "0.01"},
            {"College Hoops 2K8", "X360", "2007", "Sports", "Take-Two Interactive", "0.15", "0.00", "0.00", "0.01"},
            {"Dynasty Warriors: Gundam 3", "X360", "2010", "Action", "Tecmo Koei", "0.10", "0.03", "0.02", "0.01"},
            {
                "Naval Assault: The Killing Tide", "X360", "2010", "Simulation", "505 Games", "0.08", "0.07", "0.00",
                "0.02"
            },
            {
                "Cabela's Survival: Shadows of Katmai", "X360", "2011", "Sports", "Activision", "0.12", "0.03", "0.00",
                "0.01"
            },
            {"Grand Slam Tennis 2", "X360", "2012", "Sports", "Electronic Arts", "0.09", "0.06", "0.00", "0.01"},
            {"Bee Movie Game", "X360", "2007", "Action", "Activision", "0.15", "0.00", "0.00", "0.01"},
            {"CSI: Fatal Conspiracy", "X360", "2010", "Adventure", "Ubisoft", "0.11", "0.04", "0.00", "0.01"},
            {"Culdcept SAGA", "X360", "2006", "Role-Playing", "Namco Bandai Games", "0.11", "0.00", "0.03", "0.01"},
            {"Fairytale Fights", "X360", "2009", "Action", "Playlogic Game Factory", "0.13", "0.02", "0.00", "0.01"},
            {
                "Leisure Suit Larry: Box Office Bust", "X360", "2009", "Adventure", "Codemasters", "0.14", "0.01", "0.00",
                "0.01"
            },
            {"Marvel Super Hero Squad: Comic Combat", "X360", "2011", "Action", "THQ", "0.11", "0.03", "0.00", "0.01"},
            {"The Amazing Spider-Man 2 (2014)", "X360", "2014", "Action", "Activision", "0.06", "0.08", "0.00", "0.02"},
            {"Rock Band Track Pack Volume 2", "X360", "2008", "Misc", "MTV Games", "0.14", "0.00", "0.00", "0.01"},
            {"Captain America: Super Soldier", "X360", "2011", "Action", "Sega", "0.10", "0.04", "0.00", "0.01"},
            {
                "Silent Hill HD Collection", "X360", "2012", "Action", "Konami Digital Entertainment", "0.08", "0.05",
                "0.01", "0.01"
            },
            {
                "World Series of Poker: Tournament of Champions 2007 Edition", "X360", "2006", "Misc", "Activision", "0.14",
                "0.00", "0.00", "0.01"
            },
            {"Thrillville: Off the Rails", "X360", "2007", "Strategy", "LucasArts", "0.12", "0.02", "0.00", "0.01"},
            {"Monsters vs. Aliens", "X360", "2009", "Platform", "Activision", "0.11", "0.03", "0.00", "0.01"},
            {"Fuzion Frenzy 2", "X360", "2007", "Misc", "Microsoft Game Studios", "0.13", "0.01", "0.00", "0.01"},
            {"Apache: Air Assault", "X360", "2010", "Simulation", "Activision", "0.11", "0.03", "0.00", "0.01"},
            {"Syndicate", "X360", "2012", "Shooter", "Electronic Arts", "0.08", "0.06", "0.00", "0.01"},
            {
                "Final Fantasy XI: Vana'diel Collection 2008", "X360", "2007", "Role-Playing", "Square Enix", "0.13",
                "0.00", "0.01", "0.01"
            },
            {"Just Dance 2015", "X360", "2014", "Misc", "Ubisoft", "0.09", "0.04", "0.00", "0.01"},
            {"Blitz: The League", "X360", "2006", "Sports", "Midway Games", "0.14", "0.00", "0.00", "0.01"},
            {
                "El Shaddai: Ascension of the Metatron", "X360", "2011", "Action", "Ignition Entertainment", "0.06", "0.04",
                "0.03", "0.01"
            },
            {
                "Fist of the North Star: Ken's Rage", "X360", "2010", "Action", "Ubisoft Annecy", "0.07", "0.02", "0.06",
                "0.01"
            },
            {"Hot Wheels: Beat That!", "X360", "2007", "Racing", "Activision", "0.14", "0.00", "0.00", "0.01"},
            {"Shaun White Skateboarding", "X360", "2010", "Sports", "Ubisoft", "0.09", "0.04", "0.00", "0.01"},
            {"Otomedius Excellent", "X360", "N/A", "Shooter", "Unknown", "0.10", "0.00", "0.04", "0.01"},
            {
                "FIFA 06: Road to FIFA World Cup", "X360", "2005", "Sports", "Electronic Arts", "0.11", "0.02", "0.01",
                "0.01"
            },
            {"Blood Bowl", "X360", "2009", "Sports", "Focus Home Interactive", "0.11", "0.02", "0.00", "0.01"},
            {"Amped 3", "X360", "2005", "Sports", "Take-Two Interactive", "0.12", "0.02", "0.00", "0.01"},
            {"Cars: Race-O-Rama", "X360", "2009", "Racing", "THQ", "0.13", "0.01", "0.00", "0.01"},
            {"Hitman: HD Trilogy", "X360", "2013", "Action", "Square Enix", "0.05", "0.08", "0.00", "0.01"},
            {"Anarchy Reigns", "X360", "2012", "Action", "Sega", "0.10", "0.02", "0.02", "0.01"},
            {"Cars: Mater-National Championship", "X360", "2007", "Racing", "THQ", "0.13", "0.00", "0.00", "0.01"},
            {"Warriors Orochi 3", "X360", "2011", "Action", "Ubisoft Annecy", "0.07", "0.03", "0.03", "0.01"},
            {"Chaotic: Shadow Warriors", "X360", "2009", "Action", "Activision", "0.14", "0.00", "0.00", "0.01"},
            {"NHL 2K10", "X360", "2009", "Sports", "Take-Two Interactive", "0.11", "0.02", "0.00", "0.01"},
            {
                "BCFX: The Black College Football Xperience, The Doug Williams Edition", "X360", "2009", "Sports", "Aspyr",
                "0.13", "0.00", "0.00", "0.01"
            },
            {"Armored Core: For Answer", "X360", "2008", "Simulation", "Ubisoft", "0.05", "0.01", "0.07", "0.01"},
            {
                "Saw II: Flesh & Blood", "X360", "2010", "Action", "Konami Digital Entertainment", "0.09", "0.04", "0.00",
                "0.01"
            },
            {
                "Clash of the Titans: The Videogame", "X360", "2010", "Action", "Namco Bandai Games", "0.07", "0.06",
                "0.00", "0.01"
            },
            {
                "Zone of the Enders HD Collection", "X360", "2012", "Simulation", "Konami Digital Entertainment", "0.09",
                "0.03", "0.01", "0.01"
            },
            {"Alien: Isolation", "X360", "2014", "Shooter", "Sega", "0.07", "0.06", "0.00", "0.01"},
            {"Grease Dance", "X360", "2011", "Misc", "505 Games", "0.10", "0.03", "0.00", "0.01"},
            {"The Cursed Crusade", "X360", "2011", "Action", "DTP Entertainment", "0.08", "0.05", "0.00", "0.01"},
            {
                "Project Sylpheed: Arc of Deception", "X360", "2006", "Shooter", "Microsoft Game Studios", "0.11", "0.00",
                "0.02", "0.01"
            },
            {"Jurassic Park: The Game", "X360", "N/A", "Action", "Unknown", "0.13", "0.00", "0.00", "0.01"},
            {"Lips: I Love The 80s", "X360", "2010", "Misc", "Microsoft Game Studios", "0.00", "0.12", "0.00", "0.02"},
            {"Stormrise", "X360", "2009", "Strategy", "Sega", "0.10", "0.03", "0.00", "0.01"},
            {"Remember Me", "X360", "2013", "Action", "Capcom", "0.07", "0.06", "0.00", "0.01"},
            {"X-Blades", "X360", "2009", "Action", "SouthPeak Games", "0.10", "0.01", "0.02", "0.01"},
            {"MotoGP '06", "X360", "2006", "Racing", "THQ", "0.11", "0.01", "0.00", "0.01"},
            {"Risen 2: Dark Waters", "X360", "2012", "Role-Playing", "Deep Silver", "0.05", "0.07", "0.00", "0.01"},
            {"NHL 2K8", "X360", "2007", "Sports", "Take-Two Interactive", "0.11", "0.01", "0.00", "0.01"},
            {
                "Sherlock Holmes vs. Jack the Ripper", "X360", "2009", "Adventure", "Focus Home Interactive", "0.09",
                "0.03", "0.00", "0.01"
            },
            {"Heroes over Europe", "X360", "2009", "Simulation", "Ubisoft", "0.10", "0.02", "0.00", "0.01"},
            {"International Cricket 2010", "X360", "2010", "Sports", "Codemasters", "0.00", "0.11", "0.00", "0.02"},
            {
                "History Civil War: Secret Missions", "X360", "2008", "Shooter", "Activision", "0.12", "0.00", "0.00",
                "0.01"
            },
            {"Cabela's African Safari", "X360", "2006", "Sports", "Activision Value", "0.12", "0.00", "0.00", "0.01"},
            {"de Blob 2", "X360", "2011", "Platform", "THQ", "0.08", "0.04", "0.00", "0.01"},
            {
                "Adrenalin Misfits", "X360", "2010", "Racing", "Konami Digital Entertainment", "0.11", "0.02", "0.00",
                "0.01"
            },
            {"Cabela's Dangerous Hunts 2009", "X360", "2008", "Sports", "Activision", "0.12", "0.00", "0.00", "0.01"},
            {
                "Marvel Super Hero Squad: The Infinity Gauntlet", "X360", "2010", "Action", "THQ", "0.10", "0.02", "0.00",
                "0.01"
            },
            {"Rock Band: Metal Track Pack", "X360", "2009", "Misc", "MTV Games", "0.12", "0.00", "0.00", "0.01"},
            {
                "Borderlands: Double Game Add-On Pack", "X360", "2010", "Shooter", "Take-Two Interactive", "0.10", "0.02",
                "0.00", "0.01"
            },
            {"Thor: God of Thunder", "X360", "2011", "Action", "Sega", "0.08", "0.04", "0.00", "0.01"},
            {
                "Bakugan Battle Brawlers: Defenders of the Core", "X360", "2010", "Action", "Activision", "0.10", "0.02",
                "0.00", "0.01"
            },
            {"Monster Hunter Frontier Online", "X360", "2010", "Role-Playing", "Capcom", "0.00", "0.00", "0.13", "0.00"},
            {"Just Dance: Disney Party", "X360", "2012", "Misc", "Ubisoft", "0.11", "0.01", "0.00", "0.01"},
            {"Just Cause", "X360", "2006", "Action", "Eidos Interactive", "0.09", "0.02", "0.01", "0.01"},
            {
                "Cabela's Big Game Hunter: Hunting Party", "X360", "2011", "Sports", "Activision", "0.12", "0.00", "0.00",
                "0.01"
            },
            {"Fatal Inertia", "X360", "2007", "Racing", "Tecmo Koei", "0.11", "0.00", "0.00", "0.01"},
            {"Bejeweled 3", "X360", "N/A", "Puzzle", "Unknown", "0.12", "0.00", "0.00", "0.01"},
            {
                "Blazing Angels 2: Secret Missions of WWII", "X360", "2007", "Simulation", "Ubisoft", "0.10", "0.02",
                "0.00", "0.01"
            },
            {"Dynasty Warriors 8", "X360", "2013", "Action", "Tecmo Koei", "0.07", "0.04", "0.00", "0.01"},
            {
                "History Channel: Civil War - A Nation Divided", "X360", "2006", "Shooter", "Activision", "0.12", "0.00",
                "0.00", "0.01"
            },
            {"How to Train Your Dragon", "X360", "2010", "Action", "Activision", "0.10", "0.02", "0.00", "0.01"},
            {
                "Avatar: The Last Airbender - The Burning Earth", "X360", "2007", "Action", "THQ", "0.11", "0.01", "0.00",
                "0.01"
            },
            {"Hulk Hogan's Main Event", "X360", "2011", "Fighting", "505 Games", "0.10", "0.02", "0.00", "0.01"},
            {
                "Scene It? Bright Lights! Big Screen!", "X360", "2009", "Misc", "Warner Bros. Interactive Entertainment",
                "0.11", "0.00", "0.00", "0.01"
            },
            {"Hour of Victory", "X360", "2007", "Shooter", "Midway Games", "0.10", "0.01", "0.00", "0.01"},
            {
                "Eat Lead: The Return of Matt Hazard", "X360", "2009", "Shooter", "D3Publisher", "0.10", "0.01", "0.00",
                "0.01"
            },
            {"Rango: The Video Game", "X360", "2011", "Action", "Electronic Arts", "0.05", "0.06", "0.00", "0.01"},
            {
                "Rumble Roses XX", "X360", "2006", "Fighting", "Konami Digital Entertainment", "0.06", "0.01", "0.04",
                "0.01"
            },
            {
                "Divinity II: The Dragon Knight Saga", "X360", "2010", "Role-Playing", "Focus Home Interactive", "0.10",
                "0.01", "0.00", "0.01"
            },
            {"Dynasty Warriors 5 Empires", "X360", "2006", "Action", "Tecmo Koei", "0.10", "0.01", "0.00", "0.01"},
            {"Eragon", "X360", "2006", "Action", "Vivendi Games", "0.10", "0.01", "0.00", "0.01"},
            {"Create", "X360", "2010", "Misc", "Electronic Arts", "0.09", "0.02", "0.00", "0.01"},
            {"Destroy All Humans! Path of the Furon", "X360", "2008", "Action", "THQ", "0.07", "0.04", "0.00", "0.01"},
            {"NCIS", "X360", "2011", "Adventure", "Ubisoft", "0.09", "0.02", "0.00", "0.01"},
            {"Venetica", "X360", "2010", "Role-Playing", "DTP Entertainment", "0.08", "0.03", "0.00", "0.01"},
            {
                "SCORE International Baja 1000: The Official Game", "X360", "2008", "Racing", "Activision", "0.10", "0.01",
                "0.00", "0.01"
            },
            {
                "Are You Smarter than a 5th Grader? Game Time", "X360", "2009", "Puzzle", "THQ", "0.11", "0.00", "0.00",
                "0.01"
            },
            {
                "WRC: FIA World Rally Championship", "X360", "N/A", "Racing", "Black Bean Games", "0.00", "0.10", "0.00",
                "0.02"
            },
            {"Megamind: Ultimate Showdown", "X360", "2010", "Adventure", "THQ", "0.06", "0.04", "0.00", "0.01"},
            {
                "Karaoke Revolution", "X360", "2009", "Misc", "Konami Digital Entertainment", "0.11", "0.00", "0.00",
                "0.01"
            },
            {"College Hoops 2K6", "X360", "2006", "Sports", "Take-Two Interactive", "0.11", "0.00", "0.00", "0.01"},
            {"Cabela's Alaskan Adventure", "X360", "2006", "Sports", "Activision", "0.10", "0.00", "0.00", "0.01"},
            {"Jurassic: The Hunted", "X360", "2009", "Shooter", "Activision", "0.11", "0.00", "0.00", "0.01"},
            {
                "NPPL Championship Paintball 2009", "X360", "2008", "Shooter", "Activision Value", "0.10", "0.01", "0.00",
                "0.01"
            },
            {"Ice Age: Dawn of the Dinosaurs", "X360", "2009", "Platform", "Activision", "0.08", "0.02", "0.00", "0.01"},
            {
                "Green Lantern: Rise of the Manhunters", "X360", "2011", "Action", "Warner Bros. Interactive Entertainment",
                "0.06", "0.04", "0.00", "0.01"
            },
            {
                "Onechanbara: Bikini Samurai Squad", "X360", "2006", "Action", "D3Publisher", "0.10", "0.01", "0.00",
                "0.01"
            },
            {"Persona 4: Arena", "X360", "2012", "Fighting", "Atlus", "0.07", "0.01", "0.03", "0.01"},
            {"Raiden IV", "X360", "2008", "Shooter", "Moss", "0.10", "0.00", "0.01", "0.01"},
            {"Dance Paradise", "X360", "2010", "Misc", "Mindscape", "0.10", "0.01", "0.00", "0.01"},
            {
                "The History Channel: Great Battles - Medieval", "X360", "2010", "Strategy", "Slitherine Software", "0.07",
                "0.04", "0.00", "0.01"
            },
            {"Steel Battalion: Heavy Armor", "X360", "2012", "Simulation", "Capcom", "0.07", "0.02", "0.02", "0.01"},
            {"Blackwater", "X360", "2011", "Shooter", "505 Games", "0.08", "0.02", "0.00", "0.01"},
            {"Twister Mania", "X360", "2011", "Misc", "505 Games", "0.09", "0.01", "0.00", "0.01"},
            {"Let's Cheer", "X360", "2011", "Misc", "Take-Two Interactive", "0.10", "0.00", "0.00", "0.01"},
            {"Open Season", "X360", "2006", "Platform", "Ubisoft", "0.10", "0.00", "0.00", "0.01"},
            {"Power Gig: Rise of the SixString", "X360", "2010", "Misc", "Unknown", "0.10", "0.00", "0.00", "0.01"},
            {"Phantasy Star Universe", "X360", "2006", "Role-Playing", "Sega", "0.09", "0.01", "0.00", "0.01"},
            {"The Smurfs 2", "X360", "2013", "Action", "Ubisoft", "0.02", "0.07", "0.00", "0.01"},
            {
                "Night at the Museum: Battle of the Smithsonian", "X360", "2009", "Action", "Majesco Entertainment", "0.07",
                "0.03", "0.00", "0.01"
            },
            {"Monster Jam: Path of Destruction", "X360", "2010", "Racing", "Activision", "0.10", "0.00", "0.00", "0.01"},
            {
                "Hellboy: The Science of Evil", "X360", "2008", "Action", "Konami Digital Entertainment", "0.10", "0.00",
                "0.00", "0.01"
            },
            {
                "Birds of Steel", "X360", "2012", "Simulation", "Konami Digital Entertainment", "0.07", "0.03", "0.00",
                "0.01"
            },
            {
                "Pinball Hall of Fame: The Williams Collection", "X360", "2009", "Misc", "Crave Entertainment", "0.10",
                "0.00", "0.00", "0.01"
            },
            {
                "Karaoke Revolution Glee: Volume 3", "X360", "2011", "Misc", "Konami Digital Entertainment", "0.10", "0.00",
                "0.00", "0.01"
            },
            {"Pimp My Ride", "X360", "2006", "Racing", "Activision", "0.09", "0.00", "0.00", "0.01"},
            {"Victorious: Time to Shine", "X360", "2011", "Action", "D3Publisher", "0.10", "0.00", "0.00", "0.01"},
            {
                "Karaoke Revolution Presents American Idol Encore", "X360", "2008", "Misc", "Konami Digital Entertainment",
                "0.10", "0.00", "0.00", "0.01"
            },
            {"Space Chimps", "X360", "2008", "Platform", "Brash Entertainment", "0.10", "0.00", "0.00", "0.01"},
            {
                "Where the Wild Things Are", "X360", "2009", "Platform", "Warner Bros. Interactive Entertainment", "0.10",
                "0.00", "0.00", "0.01"
            },
            {"The Spiderwick Chronicles", "X360", "2008", "Action", "Vivendi Games", "0.09", "0.01", "0.00", "0.01"},
            {
                "Monster Madness: Battle for Suburbia", "X360", "2007", "Shooter", "SouthPeak Games", "0.10", "0.00",
                "0.00", "0.01"
            },
            {"Lost Planet 3", "X360", "2013", "Action", "Capcom", "0.06", "0.03", "0.01", "0.01"},
            {"NFL Head Coach 09", "X360", "2008", "Sports", "Electronic Arts", "0.10", "0.00", "0.00", "0.01"},
            {
                "Metal Gear Solid: Ground Zeroes", "X360", "2014", "Action", "Konami Digital Entertainment", "0.04", "0.05",
                "0.01", "0.01"
            },
            {"Kung-Fu: High Impact", "X360", "2011", "Action", "Black Bean Games", "0.06", "0.03", "0.00", "0.01"},
            {
                "The King of Fighters XII", "X360", "2009", "Fighting", "Ignition Entertainment", "0.09", "0.00", "0.01",
                "0.01"
            },
            {"Nascar Unleashed", "X360", "2011", "Racing", "Activision", "0.10", "0.00", "0.00", "0.01"},
            {"Truth or Lies", "X360", "2010", "Misc", "THQ", "0.07", "0.03", "0.00", "0.01"},
            {
                "Winning Eleven: Pro Evolution Soccer 2007", "X360", "2006", "Sports", "Konami Digital Entertainment",
                "0.09", "0.00", "0.00", "0.01"
            },
            {"Rogue Warrior", "X360", "2009", "Shooter", "Bethesda Softworks", "0.08", "0.01", "0.00", "0.01"},
            {"Smash Court Tennis 3", "X360", "2007", "Sports", "Atari", "0.07", "0.02", "0.00", "0.01"},
            {"Backyard NFL Football '10", "X360", "2009", "Sports", "Atari", "0.10", "0.00", "0.00", "0.01"},
            {"Planet 51", "X360", "2009", "Action", "Sega", "0.06", "0.03", "0.00", "0.01"},
            {"Blood Drive", "X360", "2010", "Racing", "Activision", "0.08", "0.01", "0.00", "0.01"},
            {"Surf's Up", "X360", "2007", "Sports", "Ubisoft", "0.09", "0.00", "0.00", "0.01"},
            {"Warhammer: Battle March", "X360", "2008", "Strategy", "Deep Silver", "0.08", "0.02", "0.00", "0.01"},
            {
                "Cabela's North American Adventures", "X360", "2010", "Sports", "Activision", "0.09", "0.00", "0.00",
                "0.01"
            },
            {"NFL Tour", "X360", "2008", "Sports", "Electronic Arts", "0.09", "0.00", "0.00", "0.01"},
            {
                "Fantastic Four: Rise of the Silver Surfer", "X360", "2007", "Action", "Take-Two Interactive", "0.08",
                "0.01", "0.00", "0.01"
            },
            {"Earth Defense Force 2025", "X360", "2013", "Shooter", "D3Publisher", "0.02", "0.02", "0.05", "0.00"},
            {"Nicktoons MLB", "X360", "2011", "Sports", "Take-Two Interactive", "0.09", "0.00", "0.00", "0.01"},
            {"NHL 2K6", "X360", "2005", "Sports", "Take-Two Interactive", "0.09", "0.00", "0.00", "0.01"},
            {
                "FlatOut: Ultimate Carnage", "X360", "2007", "Racing", "Empire Interactive", "0.07", "0.02", "0.00", "0.01"
            },
            {"Hole in the Wall: Deluxe Edition", "X360", "2011", "Misc", "Ubisoft", "0.09", "0.00", "0.00", "0.01"},
            {"Ridge Racer Unbounded", "X360", "2012", "Racing", "Namco Bandai Games", "0.05", "0.04", "0.00", "0.01"},
            {"Universe at War: Earth Assault", "X360", "2008", "Strategy", "Sega", "0.09", "0.00", "0.00", "0.01"},
            {"Bullet Witch", "X360", "2006", "Shooter", "Atari", "0.07", "0.01", "0.02", "0.01"},
            {"The Price is Right: Decades", "X360", "2011", "Misc", "Ubisoft", "0.09", "0.00", "0.00", "0.01"},
            {
                "Watchmen: The End is Nigh Part 1 & 2", "X360", "2009", "Action", "Warner Bros. Interactive Entertainment",
                "0.09", "0.00", "0.00", "0.01"
            },
            {"Self-Defense Training Camp", "X360", "2011", "Sports", "Ubisoft", "0.06", "0.02", "0.00", "0.01"},
            {"Fuse", "X360", "2013", "Shooter", "Electronic Arts", "0.06", "0.03", "0.00", "0.01"},
            {
                "The Penguins of Madagascar: Dr. Blowhole Returns - Again!", "X360", "2011", "Action", "THQ", "0.06",
                "0.03", "0.00", "0.01"
            },
            {
                "Disney Sing It! High School Musical 3: Senior Year", "X360", "2009", "Misc", "Disney Interactive Studios",
                "0.09", "0.00", "0.00", "0.01"
            },
            {
                "Bladestorm: The Hundred Years' War", "X360", "2007", "Action", "Tecmo Koei", "0.08", "0.01", "0.00",
                "0.01"
            },
            {"Darkest of Days", "X360", "2009", "Shooter", "Phantom EFX", "0.09", "0.00", "0.00", "0.01"},
            {"Blitz: The League II", "X360", "2008", "Sports", "Midway Games", "0.07", "0.01", "0.00", "0.01"},
            {
                "Fallout 3 Game Add-On Pack: The Pitt and Operation: Anchorage", "X360", "2009", "Role-Playing",
                "Bethesda Softworks", "0.08", "0.00", "0.00", "0.01"
            },
            {"Tetris Evolution", "X360", "2007", "Puzzle", "THQ", "0.07", "0.01", "0.00", "0.01"},
            {"Cabela's Adventure Camp", "X360", "2011", "Misc", "Activision", "0.07", "0.02", "0.00", "0.01"},
            {"F1 2014", "X360", "2014", "Action", "Codemasters", "0.01", "0.07", "0.00", "0.01"},
            {"Killer is Dead", "X360", "2013", "Action", "Deep Silver", "0.06", "0.02", "0.01", "0.01"},
            {"NeverDead", "X360", "2012", "Shooter", "Konami Digital Entertainment", "0.05", "0.03", "0.00", "0.01"},
            {"Michael Phelps: Push the Limit", "X360", "2011", "Sports", "505 Games", "0.07", "0.01", "0.00", "0.01"},
            {"nail'd", "X360", "2010", "Racing", "Deep Silver", "0.07", "0.02", "0.00", "0.01"},
            {"The First Templar", "X360", "2011", "Action", "Kalypso Media", "0.05", "0.03", "0.00", "0.01"},
            {"Man vs. Wild", "X360", "2011", "Adventure", "Crave Entertainment", "0.08", "0.00", "0.00", "0.00"},
            {
                "Alvin and the Chipmunks: Chipwrecked", "X360", "2011", "Misc", "505 Games", "0.08", "0.01", "0.00", "0.01"
            },
            {"CSI: Hard Evidence", "X360", "2007", "Adventure", "Ubisoft", "0.07", "0.01", "0.00", "0.01"},
            {"Backyard Sports Football: Rookie Rush", "X360", "2010", "Sports", "Atari", "0.08", "0.00", "0.00", "0.00"},
            {"NASCAR '14", "X360", "2014", "Action", "Deep Silver", "0.08", "0.00", "0.00", "0.00"},
            {
                "Raven Squad: Operation Hidden Dagger", "X360", "2009", "Shooter", "Evolved Games", "0.08", "0.00", "0.00",
                "0.01"
            },
            {"MySims SkyHeroes", "X360", "2010", "Action", "Electronic Arts", "0.08", "0.00", "0.00", "0.01"},
            {
                "Import Tuner Challenge (American sales)", "X360", "2006", "Racing", "Ubisoft", "0.07", "0.01", "0.00",
                "0.01"
            },
            {"Record of Agarest War Zero", "X360", "2010", "Strategy", "Compile Heart", "0.08", "0.00", "0.00", "0.00"},
            {"Bodycount", "X360", "2011", "Shooter", "Codemasters", "0.05", "0.03", "0.00", "0.01"},
            {"The X-Factor", "X360", "2010", "Misc", "Deep Silver", "0.00", "0.08", "0.00", "0.01"},
            {"Nickelodeon Dance", "X360", "2011", "Misc", "Take-Two Interactive", "0.07", "0.01", "0.00", "0.01"},
            {"Zoids Assault", "X360", "2007", "Strategy", "Takara Tomy", "0.08", "0.00", "0.00", "0.01"},
            {
                "Karaoke Revolution Presents American Idol Encore 2", "X360", "2008", "Misc",
                "Konami Digital Entertainment", "0.08", "0.00", "0.00", "0.01"
            },
            {"Family Feud: 2012 Edition", "X360", "2011", "Misc", "Ubisoft", "0.08", "0.00", "0.00", "0.00"},
            {
                "ShellShock 2: Blood Trails", "X360", "2009", "Shooter", "Eidos Interactive", "0.05", "0.03", "0.00",
                "0.01"
            },
            {"Quantum Theory", "X360", "2010", "Shooter", "Tecmo Koei", "0.05", "0.02", "0.00", "0.01"},
            {"America's Army: True Soldiers", "X360", "2007", "Shooter", "Ubisoft", "0.08", "0.00", "0.00", "0.01"},
            {"Backyard Sports: Sandlot Sluggers", "X360", "2010", "Sports", "Atari", "0.08", "0.00", "0.00", "0.00"},
            {"Spectral Force 3", "X360", "2006", "Role-Playing", "Idea Factory", "0.08", "0.00", "0.00", "0.01"},
            {"Shrek: Forever After", "X360", "2010", "Platform", "Activision", "0.08", "0.00", "0.00", "0.00"},
            {
                "Field & Stream: Total Outdoorsman Challenge", "X360", "2010", "Sports", "505 Games", "0.08", "0.00",
                "0.00", "0.00"
            },
            {"Ben 10 Galactic Racing", "X360", "2011", "Racing", "D3Publisher", "0.06", "0.02", "0.00", "0.01"},
            {"NHL 2K7", "X360", "2006", "Sports", "Take-Two Interactive", "0.07", "0.00", "0.00", "0.01"},
            {"Arcania: Gothic 4", "X360", "2010", "Role-Playing", "JoWood Productions", "0.03", "0.04", "0.01", "0.01"},
            {
                "JASF: Jane's Advanced Strike Fighters", "X360", "2011", "Simulation", "Deep Silver", "0.05", "0.02",
                "0.00", "0.01"
            },
            {"Battle Fantasia", "X360", "2008", "Fighting", "505 Games", "0.07", "0.00", "0.01", "0.00"},
            {"Winter Stars", "X360", "2011", "Sports", "Deep Silver", "0.04", "0.03", "0.00", "0.01"},
            {
                "Castlevania: Lords of Shadow 2", "X360", "2014", "Action", "Konami Digital Entertainment", "0.02", "0.05",
                "0.00", "0.01"
            },
            {
                "Looney Tunes: Acme Arsenal", "X360", "2007", "Action", "Warner Bros. Interactive Entertainment", "0.06",
                "0.01", "0.00", "0.01"
            },
            {"NASCAR The Game: Inside Line", "X360", "2012", "Action", "Activision", "0.07", "0.00", "0.00", "0.00"},
            {"Deepak Chopra's Leela", "X360", "2011", "Misc", "THQ", "0.05", "0.02", "0.00", "0.01"},
            {"MindJack", "X360", "2011", "Shooter", "Square Enix", "0.05", "0.02", "0.00", "0.01"},
            {"Blades of Time", "X360", "2012", "Action", "Konami Digital Entertainment", "0.05", "0.02", "0.00", "0.01"},
            {"Get Fit with Mel B", "X360", "N/A", "Sports", "Black Bean Games", "0.00", "0.06", "0.00", "0.01"},
            {
                "Little League World Series Baseball 2010", "X360", "2010", "Sports", "Activision", "0.07", "0.00", "0.00",
                "0.00"
            },
            {"The Idolm@ster", "X360", "2007", "Simulation", "Namco Bandai Games", "0.00", "0.00", "0.08", "0.00"},
            {
                "Infernal: Hell's Vengeance", "X360", "2009", "Shooter", "Playlogic Game Factory", "0.06", "0.01", "0.00",
                "0.01"
            },
            {"How to Train Your Dragon 2", "X360", "2014", "Adventure", "Little Orbit", "0.02", "0.05", "0.00", "0.01"},
            {"Samurai Warriors 2", "X360", "2006", "Action", "Tecmo Koei", "0.06", "0.01", "0.00", "0.01"},
            {"F.E.A.R. Files", "X360", "2007", "Shooter", "Vivendi Games", "0.06", "0.01", "0.00", "0.01"},
            {"Supremacy MMA", "X360", "2011", "Fighting", "505 Games", "0.05", "0.02", "0.00", "0.01"},
            {"Qubed", "X360", "2009", "Puzzle", "Atari", "0.07", "0.00", "0.00", "0.00"},
            {
                "World Series of Poker 2008: Battle for the Bracelets", "X360", "2007", "Misc", "Activision", "0.06",
                "0.01", "0.00", "0.01"
            },
            {"Rio", "X360", "2011", "Misc", "THQ", "0.04", "0.03", "0.00", "0.01"},
            {
                "Naruto Shippuden: Ultimate Ninja Storm Revolution", "X360", "2014", "Fighting", "Namco Bandai Games",
                "0.02", "0.05", "0.00", "0.01"
            },
            {"Knights Contract", "X360", "2011", "Action", "Namco Bandai Games", "0.04", "0.02", "0.00", "0.01"},
            {
                "Transformer: Rise of the Dark Spark", "X360", "2014", "Action", "Activision", "0.03", "0.04", "0.00",
                "0.01"
            },
            {
                "The Idolm@ster: Live for You!", "X360", "2008", "Misc", "Namco Bandai Games", "0.00", "0.00", "0.07",
                "0.00"
            },
            {"Who Wants to Be A Millionaire?", "X360", "2011", "Misc", "Ubisoft", "0.07", "0.00", "0.00", "0.00"},
            {
                "Adventure Time: Explore the Dungeon Because I Don't Know!", "X360", "2013", "Action", "D3Publisher",
                "0.03", "0.04", "0.00", "0.01"
            },
            {
                "Deadliest Catch: Sea of Chaos", "X360", "2010", "Sports", "Crave Entertainment", "0.07", "0.00", "0.00",
                "0.00"
            },
            {
                "Air Conflicts: Secret Wars", "X360", "2011", "Simulation", "bitComposer Games", "0.05", "0.02", "0.00",
                "0.01"
            },
            {
                "Kengo: Legend of The 9", "X360", "2006", "Fighting", "Majesco Entertainment", "0.06", "0.01", "0.00",
                "0.01"
            },
            {
                "Disney's Meet the Robinsons", "X360", "2007", "Action", "Disney Interactive Studios", "0.06", "0.00",
                "0.00", "0.00"
            },
            {"WRC 2: FIA World Rally Championship", "X360", "2011", "Racing", "Ubisoft", "0.00", "0.06", "0.00", "0.01"},
            {
                "Bass Pro Shops: The Hunt", "X360", "2010", "Sports", "Griffin International", "0.07", "0.00", "0.00",
                "0.00"
            },
            {
                "PAC-MAN and the Ghostly Adventures", "X360", "2013", "Action", "Namco Bandai Games", "0.04", "0.03",
                "0.00", "0.01"
            },
            {"Damnation", "X360", "2009", "Shooter", "Codemasters", "0.06", "0.01", "0.00", "0.01"},
            {"Samurai Shodown Sen", "X360", "2009", "Fighting", "Rising Star Games", "0.06", "0.01", "0.00", "0.00"},
            {"SpongeBob's Truth or Square", "X360", "2009", "Action", "THQ", "0.03", "0.04", "0.00", "0.00"},
            {
                "Cloudy With a Chance of Meatballs", "X360", "2009", "Adventure", "Ubisoft", "0.06", "0.00", "0.00", "0.01"
            },
            {"Earth Defense Force 2017", "X360", "2006", "Shooter", "D3Publisher", "0.03", "0.00", "0.03", "0.00"},
            {"Winter Sports 2: The Next Challenge", "X360", "2008", "Sports", "RTL", "0.05", "0.01", "0.00", "0.01"},
            {"Bionicle Heroes", "X360", "2006", "Shooter", "Eidos Interactive", "0.05", "0.01", "0.00", "0.01"},
            {
                "Jimmie Johnson's Anything With an Engine", "X360", "2011", "Racing", "Konami Digital Entertainment",
                "0.06", "0.00", "0.00", "0.00"
            },
            {
                "Xbox Live Arcade Unplugged Volume 1", "X360", "2006", "Misc", "Microsoft Game Studios", "0.05", "0.01",
                "0.00", "0.01"
            },
            {
                "Happy Feet Two", "X360", "N/A", "Adventure", "Warner Bros. Interactive Entertainment", "0.05", "0.01",
                "0.00", "0.00"
            },
            {"Ultimate Marvel vs. Capcom 3", "X360", "2011", "Fighting", "Capcom", "0.00", "0.03", "0.04", "0.00"},
            {
                "Tornado Outbreak", "X360", "2009", "Action", "Konami Digital Entertainment", "0.06", "0.00", "0.00",
                "0.00"
            },
            {"Rock Band Track Pack: Classic Rock", "X360", "2009", "Misc", "MTV Games", "0.06", "0.00", "0.00", "0.00"},
            {"Dream C Club", "X360", "2009", "Simulation", "D3Publisher", "0.00", "0.00", "0.07", "0.00"},
            {
                "Hasbro Family Game Night Fun Pack", "X360", "2011", "Misc", "Electronic Arts", "0.06", "0.00", "0.00",
                "0.00"
            },
            {"Supreme Commander", "X360", "2008", "Strategy", "505 Games", "0.05", "0.01", "0.00", "0.01"},
            {
                "Konami Classics Vol. 1", "X360", "2009", "Misc", "Konami Digital Entertainment", "0.06", "0.00", "0.00",
                "0.00"
            },
            {"Operation Darkness", "X360", "2007", "Role-Playing", "Success", "0.06", "0.00", "0.00", "0.00"},
            {"Murdered: Soul Suspect", "X360", "2014", "Action", "Square Enix", "0.03", "0.02", "0.00", "0.01"},
            {"Raiden Fighters Aces", "X360", "2008", "Shooter", "Valcon Games", "0.06", "0.00", "0.00", "0.00"},
            {
                "MLB Front Office Manager", "X360", "2009", "Sports", "Take-Two Interactive", "0.06", "0.00", "0.00",
                "0.00"
            },
            {"Zoo Tycoon (2013)", "X360", "2013", "Action", "Microsoft Game Studios", "0.01", "0.04", "0.00", "0.01"},
            {
                "Cartoon Network: Punch Time Explosion XL", "X360", "2011", "Fighting", "Crave Entertainment", "0.06",
                "0.00", "0.00", "0.00"
            },
            {
                "DanceDanceRevolution", "X360", "2011", "Simulation", "Konami Digital Entertainment", "0.06", "0.00",
                "0.00", "0.00"
            },
            {"MotoGP 10/11", "X360", "2011", "Racing", "Capcom", "0.00", "0.05", "0.00", "0.01"},
            {
                "Generator Rex: Agent of Providence", "X360", "2011", "Action", "Activision", "0.05", "0.01", "0.00",
                "0.00"
            },
            {
                "SBK 2011: FIM Superbike World Championship", "X360", "2011", "Racing", "Black Bean Games", "0.00", "0.05",
                "0.00", "0.01"
            },
            {
                "Family Game Night 4: The Game Show", "X360", "2011", "Misc", "Electronic Arts", "0.05", "0.00", "0.00",
                "0.00"
            },
            {
                "Fist of the North Star: Ken's Rage 2", "X360", "2012", "Fighting", "Tecmo Koei", "0.02", "0.01", "0.02",
                "0.00"
            },
            {
                "Mobile Ops: The One Year War", "X360", "N/A", "Simulation", "Namco Bandai Games", "0.00", "0.00", "0.06",
                "0.00"
            },
            {"Warriors Orochi 2", "X360", "2008", "Action", "Tecmo Koei", "0.04", "0.00", "0.01", "0.00"},
            {
                "Legend of the Guardians: The Owls of Ga'Hoole", "X360", "2010", "Action",
                "Warner Bros. Interactive Entertainment", "0.05", "0.01", "0.00", "0.00"
            },
            {
                "Teenage Mutant Ninja Turtles: Danger of the Ooze", "X360", "2014", "Action", "Activision", "0.02", "0.03",
                "0.00", "0.01"
            },
            {"Jumper: Griffin's Story", "X360", "2008", "Action", "Eidos Interactive", "0.05", "0.00", "0.00", "0.00"},
            {"Motion Explosion!", "X360", "2011", "Misc", "505 Games", "0.04", "0.01", "0.00", "0.00"},
            {"GRID: Autosport", "X360", "2014", "Racing", "Codemasters", "0.01", "0.04", "0.00", "0.01"},
            {"DreamWorks Super Star Kartz", "X360", "2011", "Racing", "Activision", "0.04", "0.01", "0.00", "0.00"},
            {"National Geographic Challenge!", "X360", "N/A", "Misc", "Unknown", "0.05", "0.00", "0.00", "0.00"},
            {"Warriors: Legends of Troy", "X360", "2011", "Action", "Tecmo Koei", "0.00", "0.04", "0.01", "0.01"},
            {
                "Monkey Island: Special Edition Collection", "X360", "2011", "Adventure", "Activision", "0.00", "0.05",
                "0.00", "0.01"
            },
            {"Brave: A Warrior's Tale", "X360", "2009", "Action", "SouthPeak Games", "0.05", "0.00", "0.00", "0.00"},
            {
                "Champion Jockey: G1 Jockey & Gallop Racer", "X360", "2011", "Sports", "Tecmo Koei", "0.00", "0.04", "0.00",
                "0.01"
            },
            {"Top Gun: Hard Lock", "X360", "2012", "Action", "505 Games", "0.03", "0.02", "0.00", "0.00"},
            {"The Idolmaster 2", "X360", "2011", "Simulation", "Namco Bandai Games", "0.00", "0.00", "0.05", "0.00"},
            {
                "UEFA Champions League 2006-2007", "X360", "2007", "Sports", "Electronic Arts", "0.04", "0.01", "0.00",
                "0.00"
            },
            {"Mayhem 3D", "X360", "2011", "Racing", "Evolved Games", "0.05", "0.00", "0.00", "0.00"},
            {"DoDonPachi Resurrection", "X360", "2010", "Shooter", "Rising Star Games", "0.00", "0.04", "0.00", "0.01"},
            {
                "Cabela's Big Game Hunter (2008)", "X360", "2007", "Sports", "Activision Value", "0.05", "0.00", "0.00",
                "0.00"
            },
            {
                "Pac-Man and the Ghostly Adventures 2", "X360", "2014", "Action", "Namco Bandai Games", "0.02", "0.03",
                "0.00", "0.01"
            },
            {
                "History Channel: Battle for the Pacific", "X360", "2007", "Shooter", "Activision", "0.05", "0.00", "0.00",
                "0.00"
            },
            {
                "Dragon Ball Z: Battle of Z", "X360", "2014", "Fighting", "Namco Bandai Games", "0.00", "0.04", "0.00",
                "0.01"
            },
            {
                "2 in 1 Combo Pack: Sonic Heroes / Super Monkey Ball Deluxe", "X360", "2013", "Misc", "Ubisoft", "0.04",
                "0.01", "0.00", "0.00"
            },
            {"Yoostar on MTV", "X360", "N/A", "Misc", "Unknown", "0.05", "0.00", "0.00", "0.00"},
            {
                "Pro Evolution Soccer 2015", "X360", "2014", "Sports", "Konami Digital Entertainment", "0.00", "0.04",
                "0.00", "0.01"
            },
            {"Port Royale 3", "X360", "N/A", "Simulation", "Kalypso Media", "0.05", "0.00", "0.00", "0.00"},
            {
                "Call of Duty: The War Collection", "X360", "2010", "Shooter", "Activision", "0.05", "0.00", "0.00", "0.00"
            },
            {
                "Lucha Libre AAA: Heroes del Ring", "X360", "2010", "Fighting", "Konami Digital Entertainment", "0.05",
                "0.00", "0.00", "0.00"
            },
            {"Tour de France 2011", "X360", "N/A", "Racing", "Focus Home Interactive", "0.00", "0.04", "0.00", "0.01"},
            {"Inversion", "X360", "2012", "Shooter", "Namco Bandai Games", "0.02", "0.02", "0.00", "0.00"},
            {"Arcana Heart 3", "X360", "2011", "Fighting", "PQube", "0.00", "0.02", "0.02", "0.00"},
            {"Hail to the Chimp", "X360", "2008", "Misc", "Gamecock", "0.04", "0.00", "0.00", "0.00"},
            {"Secret Service", "X360", "2008", "Action", "Activision Value", "0.04", "0.00", "0.00", "0.00"},
            {"MorphX", "X360", "2010", "Shooter", "505 Games", "0.04", "0.00", "0.00", "0.00"},
            {
                "World Championship Poker: Featuring Howard Lederer - All In", "X360", "2006", "Misc", "Oxygen Interactive",
                "0.04", "0.00", "0.00", "0.00"
            },
            {
                "Forza Motorsport 3: Ultimate Edition", "X360", "2010", "Racing", "Microsoft Game Studios", "0.00", "0.04",
                "0.00", "0.01"
            },
            {"Rapala Fishing Frenzy 2009", "X360", "2008", "Sports", "Activision", "0.04", "0.00", "0.00", "0.00"},
            {"Cabela's Trophy Bucks", "X360", "2007", "Sports", "Activision Value", "0.04", "0.00", "0.00", "0.00"},
            {"Rock of the Dead", "X360", "2010", "Shooter", "Conspiracy Entertainment", "0.04", "0.00", "0.00", "0.00"},
            {
                "Lips: Deutsche Partyknaller", "X360", "2009", "Misc", "Microsoft Game Studios", "0.00", "0.04", "0.00",
                "0.01"
            },
            {
                "The Lord of the Rings: The Battle for Middle-Earth II", "X360", "2006", "Strategy", "Electronic Arts",
                "0.00", "0.04", "0.00", "0.01"
            },
            {"Akai Katana Shin", "X360", "2011", "Shooter", "Cave", "0.03", "0.00", "0.01", "0.00"},
            {
                "Damage Inc.: Pacific Squadron WWII", "X360", "2012", "Simulation", "Mad Catz", "0.04", "0.00", "0.00",
                "0.00"
            },
            {"Deadliest Catch: Alaskan Storm", "X360", "2008", "Sports", "Navarre Corp", "0.04", "0.00", "0.00", "0.00"},
            {"Gal*Gun", "X360", "2011", "Shooter", "Alchemist", "0.00", "0.00", "0.04", "0.00"},
            {
                "Attack of the Movies 3D", "X360", "2010", "Shooter", "Majesco Entertainment", "0.04", "0.00", "0.00",
                "0.00"
            },
            {"Phantom Breaker", "X360", "2011", "Fighting", "5pb", "0.02", "0.00", "0.02", "0.00"},
            {"WarTech: Senko no Ronde", "X360", "2006", "Fighting", "Ubisoft", "0.04", "0.00", "0.00", "0.00"},
            {"Gray Matter", "X360", "2011", "Adventure", "DTP Entertainment", "0.00", "0.03", "0.00", "0.01"},
            {
                "Bomberman: Act Zero", "X360", "2006", "Puzzle", "Konami Digital Entertainment", "0.03", "0.00", "0.00",
                "0.00"
            },
            {"Stoked: Big Air Edition", "X360", "2009", "Sports", "Namco Bandai Games", "0.02", "0.02", "0.00", "0.00"},
            {"Ski-Doo Snowmobile Challenge", "X360", "2009", "Racing", "Valcon Games", "0.03", "0.00", "0.00", "0.00"},
            {"Rock Band Country Track Pack 2", "X360", "2011", "Misc", "MTV Games", "0.04", "0.00", "0.00", "0.00"},
            {
                "Monster Hunter Frontier Online: Season 9.0", "X360", "2010", "Role-Playing", "Capcom", "0.00", "0.00",
                "0.04", "0.00"
            },
            {
                "WSC Real 11: World Snooker Championship", "X360", "2011", "Sports", "Koch Media", "0.00", "0.03", "0.00",
                "0.00"
            },
            {"Espgaluda II Black Label", "X360", "2010", "Shooter", "Cave", "0.00", "0.00", "0.04", "0.00"},
            {
                "The Walking Dead: Season Two", "X360", "2014", "Adventure", "Telltale Games", "0.01", "0.02", "0.00",
                "0.00"
            },
            {
                "Deadliest Warrior: Ancient Combat", "X360", "2012", "Fighting", "Cloud Imperium Games Corporation", "0.03",
                "0.00", "0.00", "0.00"
            },
            {"Dream C Club Zero", "X360", "2011", "Simulation", "D3Publisher", "0.00", "0.00", "0.03", "0.00"},
            {"Samurai Warriors 2: Empires", "X360", "2007", "Action", "Tecmo Koei", "0.02", "0.00", "0.01", "0.00"},
            {"Crash Time: Autobahn Pusuit", "X360", "2008", "Racing", "RTL", "0.03", "0.00", "0.00", "0.00"},
            {"PopCap Arcade Vol 1", "X360", "2007", "Puzzle", "PopCap Games", "0.03", "0.00", "0.00", "0.00"},
            {"Risen 3: Titan Lords", "X360", "2014", "Role-Playing", "Deep Silver", "0.01", "0.02", "0.00", "0.00"},
            {"Test Drive: Ferrari Legends", "X360", "2012", "Racing", "Atari", "0.03", "0.00", "0.00", "0.00"},
            {"Virtua Tennis 3", "X360", "2007", "Sports", "Sega", "0.02", "0.01", "0.00", "0.00"},
            {"Ride to Hell", "X360", "2013", "Racing", "Deep Silver", "0.02", "0.01", "0.00", "0.00"},
            {
                "Majesty 2: The Fantasy Kingdom Sim", "X360", "N/A", "Simulation", "Unknown", "0.03", "0.00", "0.00",
                "0.00"
            },
            {"PopCap Arcade Vol 2", "X360", "2009", "Misc", "PopCap Games", "0.03", "0.00", "0.00", "0.00"},
            {
                "Burnout Paradise: The Ultimate Box", "X360", "2009", "Racing", "Electronic Arts", "0.00", "0.02", "0.00",
                "0.00"
            },
            {"Zumba Fitness Core", "X360", "2012", "Misc", "505 Games", "0.00", "0.03", "0.00", "0.00"},
            {"Mushihimesama Futari Ver 1.5", "X360", "2009", "Shooter", "Cave", "0.00", "0.00", "0.03", "0.00"},
            {
                "Otomedius Gorgeous", "X360", "2008", "Shooter", "Konami Digital Entertainment", "0.00", "0.00", "0.03",
                "0.00"
            },
            {"Dennou Senki Virtual-On Force", "X360", "2010", "Fighting", "Sega", "0.00", "0.00", "0.03", "0.00"},
            {"Senko no Ronde DUO", "X360", "2010", "Fighting", "G.Rev", "0.00", "0.00", "0.03", "0.00"},
            {
                "Summer Athletics: The Ultimate Challenge", "X360", "2008", "Sports", "DTP Entertainment", "0.02", "0.01",
                "0.00", "0.00"
            },
            {"DuckTales: Remastered", "X360", "2013", "Action", "Capcom", "0.03", "0.00", "0.00", "0.00"},
            {
                "Monster Hunter Frontier Online: Season 10", "X360", "2011", "Role-Playing", "Capcom", "0.00", "0.00",
                "0.03", "0.00"
            },
            {"MotoGP 14 ", "X360", "2014", "Racing", "Milestone S.r.l.", "0.00", "0.02", "0.00", "0.00"},
            {"Enemy Front", "X360", "2014", "Shooter", "Namco Bandai Games", "0.01", "0.02", "0.00", "0.00"},
            {
                "MLB 2K12 / NBA 2K12 Combo Pack", "X360", "2012", "Sports", "Take-Two Interactive", "0.03", "0.00", "0.00",
                "0.00"
            },
            {"Yaiba: Ninja Gaiden Z", "X360", "2014", "Action", "Tecmo Koei", "0.02", "0.01", "0.00", "0.00"},
            {"DeathSmiles II X", "X360", "2010", "Shooter", "Cave", "0.00", "0.00", "0.03", "0.00"},
            {"Onechanbara Z Kagura", "X360", "2012", "Action", "D3Publisher", "0.00", "0.00", "0.03", "0.00"},
            {"The Crew", "X360", "2014", "Racing", "Ubisoft", "0.01", "0.02", "0.00", "0.00"},
            {"Biohazard: Revival Selection", "X360", "2011", "Action", "Capcom", "0.00", "0.00", "0.03", "0.00"},
            {
                "Monster Hunter Frontier Online: Forward 1", "X360", "2011", "Role-Playing", "Capcom", "0.00", "0.00",
                "0.03", "0.00"
            },
            {"Clannad", "X360", "2008", "Adventure", "Prototype", "0.00", "0.00", "0.03", "0.00"},
            {"NatGeo Challenge! Wild Life", "X360", "2010", "Misc", "Black Bean Games", "0.00", "0.02", "0.00", "0.00"},
            {"Sacred 3", "X360", "2014", "Role-Playing", "Deep Silver", "0.01", "0.01", "0.00", "0.00"},
            {
                "Rugby League Live", "X360", "2010", "Sports", "Home Entertainment Suppliers", "0.00", "0.02", "0.00",
                "0.00"
            },
            {
                "Monster Hunter Frontier Online: Forward 2", "X360", "2011", "Role-Playing", "Capcom", "0.00", "0.00",
                "0.03", "0.00"
            },
            {"Battle vs. Chess", "X360", "2011", "Misc", "TopWare Interactive", "0.00", "0.02", "0.00", "0.00"},
            {
                "Triple Pack: Xbox Live Arcade Compilation", "X360", "2011", "Misc", "Microsoft Game Studios", "0.02",
                "0.00", "0.00", "0.00"
            },
            {"Brothers in Arms: Furious 4", "X360", "2012", "Shooter", "Ubisoft", "0.01", "0.01", "0.00", "0.00"},
            {
                "DoDonPachi Dai-Oujou: Black Label Extra", "X360", "2009", "Shooter", "5pb", "0.00", "0.00", "0.02", "0.00"
            },
            {"Alien Breed Trilogy", "X360", "2011", "Shooter", "Mastertronic", "0.00", "0.02", "0.00", "0.00"},
            {
                "No More Heroes: Heroes' Paradise", "X360", "2010", "Action", "Marvelous Interactive", "0.00", "0.00",
                "0.02", "0.00"
            },
            {"Rapala for Kinect", "X360", "2011", "Sports", "Activision", "0.00", "0.02", "0.00", "0.00"},
            {"11eyes: CrossOver", "X360", "2009", "Adventure", "5pb", "0.00", "0.00", "0.02", "0.00"},
            {
                "Cross Channel: In Memory of All People", "X360", "2011", "Adventure", "CyberFront", "0.00", "0.00", "0.02",
                "0.00"
            },
            {"Rapala Tournament Fishing!", "X360", "2006", "Sports", "Activision", "0.02", "0.00", "0.00", "0.00"},
            {"Enchanted Arms (JP sales)", "X360", "2006", "Role-Playing", "Ubisoft", "0.00", "0.00", "0.02", "0.00"},
            {"Summer Athletics 2009", "X360", "2009", "Sports", "49Games", "0.00", "0.02", "0.00", "0.00"},
            {"Serious Sam HD: Gold Edition", "X360", "2011", "Shooter", "Mastertronic", "0.00", "0.02", "0.00", "0.00"},
            {
                "Persona 4: The Ultimax Ultra Suplex Hold", "X360", "2014", "Action", "Atlus", "0.02", "0.00", "0.00",
                "0.00"
            },
            {"PopCap Hits! Vol 2", "X360", "2011", "Misc", "Mastertronic", "0.00", "0.02", "0.00", "0.00"},
            {"Indianapolis 500 Evolution", "X360", "2009", "Racing", "Zushi Games", "0.02", "0.00", "0.00", "0.00"},
            {
                "Ore no Yome: Anata Dake no Hanayome", "X360", "2010", "Adventure", "Idea Factory", "0.00", "0.00", "0.02",
                "0.00"
            },
            {"Tropico 5", "X360", "2014", "Action", "Kalypso Media", "0.01", "0.01", "0.00", "0.00"},
            {"Meikyuu Cross Blood: Reloaded", "X360", "2011", "Action", "Unknown", "0.00", "0.00", "0.02", "0.00"},
            {"Winter Sports 2011", "X360", "2011", "Sports", "DTP Entertainment", "0.00", "0.02", "0.00", "0.00"},
            {"Muchi Muchi Pork & Pink Sweets", "X360", "2011", "Shooter", "Cave", "0.00", "0.00", "0.02", "0.00"},
            {"Mushihimesama", "X360", "2012", "Action", "Cave", "0.00", "0.00", "0.02", "0.00"},
            {"Escape Dead Island", "X360", "2014", "Action", "Deep Silver", "0.01", "0.01", "0.00", "0.00"},
            {"Ketsui: Kizuna Jigoku Tachi Extra", "X360", "2010", "Shooter", "5pb", "0.00", "0.00", "0.02", "0.00"},
            {
                "PDC World Championship Darts: Pro Tour", "X360", "2010", "Sports", "O-Games", "0.00", "0.02", "0.00",
                "0.00"
            },
            {
                "The Testament of Sherlock Holmes", "X360", "2012", "Adventure", "Focus Home Interactive", "0.00", "0.01",
                "0.00", "0.00"
            },
            {"Memories Off: Yubikiri no Kioku", "X360", "2010", "Adventure", "5pb", "0.00", "0.00", "0.02", "0.00"},
            {"Let's Dance with Mel B", "X360", "2011", "Sports", "Black Bean Games", "0.00", "0.01", "0.00", "0.00"},
            {
                "Strike Witches: Shirogane no Tsubasa", "X360", "2010", "Strategy", "CyberFront", "0.00", "0.00", "0.02",
                "0.00"
            },
            {"Worms", "X360", "2007", "Strategy", "Microsoft Game Studios", "0.00", "0.01", "0.00", "0.00"},
            {"Dunamis 15", "X360", "2011", "Adventure", "5pb", "0.00", "0.00", "0.02", "0.00"},
            {"PopCap Hits!", "X360", "2011", "Misc", "PopCap Games", "0.00", "0.01", "0.00", "0.00"},
            {"W.L.O. Sekai Renai Kikousen", "X360", "2010", "Adventure", "5pb", "0.00", "0.00", "0.02", "0.00"},
            {
                "Final Fantasy XI: All-In-One Pack 2006", "X360", "2006", "Role-Playing", "Square Enix", "0.00", "0.00",
                "0.02", "0.00"
            },
            {"Painkiller: Hell & Damnation", "X360", "2013", "Shooter", "Nordic Games", "0.00", "0.01", "0.00", "0.00"},
            {
                "Earth Defense Force 2017 (old JP sales)", "X360", "2006", "Shooter", "D3Publisher", "0.00", "0.00", "0.02",
                "0.00"
            },
            {"World of Tanks", "X360", "2020", "Shooter", "Wargaming.net", "0.00", "0.01", "0.00", "0.00"},
            {"Sharin no Kuni, Himawari no Shoujo", "X360", "2010", "Adventure", "5pb", "0.00", "0.00", "0.02", "0.00"},
            {
                "Sherlock Holmes: Crimes & Punishments", "X360", "2014", "Adventure", "Focus Home Interactive", "0.01",
                "0.01", "0.00", "0.00"
            },
            {
                "Tom Clancy's Ghost Recon Advanced Warfighter (weekly JP sales)", "X360", "2006", "Shooter", "Ubisoft",
                "0.00", "0.00", "0.01", "0.00"
            },
            {"Instant Brain", "X360", "2011", "Adventure", "Cave", "0.00", "0.00", "0.01", "0.00"},
            {"Football Manager 2007", "X360", "N/A", "Sports", "Sega", "0.00", "0.01", "0.00", "0.00"},
            {"Super Robot Taisen XO", "X360", "2006", "Strategy", "Banpresto", "0.00", "0.00", "0.01", "0.00"},
            {
                "Winter Sports 3: The Great Tournament", "X360", "2010", "Sports", "Tradewest", "0.00", "0.01", "0.00",
                "0.00"
            },
            {
                "Konami Classics Vol. 2", "X360", "2009", "Misc", "Konami Digital Entertainment", "0.01", "0.00", "0.00",
                "0.00"
            },
            {"DoDonPachi Saidaioujou", "X360", "2013", "Shooter", "Cave", "0.00", "0.00", "0.01", "0.00"},
            {
                "Entaku no Seito: Students of Round", "X360", "2011", "Role-Playing", "ChunSoft", "0.00", "0.00", "0.01",
                "0.00"
            },
            {
                "Adventure Time: The Secret of the Nameless Kingdom", "X360", "2014", "Action", "Little Orbit", "0.00",
                "0.01", "0.00", "0.00"
            },
            {"AKB1/48: Idol to Guam de Koishitara...", "X360", "N/A", "Misc", "N/A", "0.00", "0.00", "0.01", "0.00"},
            {"Caladrius", "X360", "2013", "Shooter", "Moss", "0.00", "0.00", "0.01", "0.00"},
            {"Banjo-Kazooie", "X360", "2008", "Platform", "Microsoft Game Studios", "0.00", "0.01", "0.00", "0.00"},
            {
                "No Fate! Only the Power of Will", "X360", "2010", "Adventure", "Alchemist", "0.00", "0.00", "0.01", "0.00"
            },
            {"Mamoru-kun wa Norowarete Shimatta!", "X360", "2009", "Shooter", "G.Rev", "0.00", "0.00", "0.01", "0.00"},
            {"Turbo: Super Stunt Squad", "X360", "2013", "Sports", "D3Publisher", "0.00", "0.01", "0.00", "0.00"},
            {"Root Double: Before Crime After Days", "X360", "2012", "Action", "Yeti", "0.00", "0.00", "0.01", "0.00"},
            {
                "Cabela's Big Game Hunter: Pro Hunts", "X360", "2014", "Shooter", "Activision", "0.01", "0.00", "0.00",
                "0.00"
            },
            {"Cross Edge Dash", "X360", "2009", "Role-Playing", "Compile Heart", "0.00", "0.00", "0.01", "0.00"},
            {"John Daly's ProStroke Golf", "X360", "2010", "Sports", "O-Games", "0.01", "0.00", "0.00", "0.00"},
            {"Young Justice: Legacy", "X360", "2013", "Adventure", "Namco Bandai Games", "0.00", "0.01", "0.00", "0.00"},
            {"Time Leap", "X360", "2009", "Adventure", "Prototype", "0.00", "0.00", "0.01", "0.00"},
            {"The Godfather (JP sales)", "X360", "2006", "Action", "Electronic Arts", "0.00", "0.00", "0.01", "0.00"},
            {"Shin Sangoku Musou 4 Special", "X360", "2005", "Action", "Tecmo Koei", "0.00", "0.00", "0.01", "0.00"},
            {"Bullet Soul: Tama Tamashii", "X360", "2011", "Shooter", "5pb", "0.00", "0.00", "0.01", "0.00"},
            {"DoDonPachi Daifukkatsu: Black Label", "X360", "2011", "Shooter", "Cave", "0.00", "0.00", "0.01", "0.00"},
            {"Bound By Flame", "X360", "2014", "Action", "N/A", "0.00", "0.01", "0.00", "0.00"},
            {
                "Metal Gear Solid HD Edition", "X360", "2011", "Action", "Konami Digital Entertainment", "0.00", "0.00",
                "0.01", "0.00"
            },
            {"World Snooker Championship 2007", "X360", "2007", "Sports", "Sega", "0.00", "0.01", "0.00", "0.00"},
            {
                "Metal Gear Solid: Peace Walker HD Edition", "X360", "2011", "Action", "Konami Digital Entertainment",
                "0.00", "0.00", "0.01", "0.00"
            },
            {"Import Tuner Challenge (JP sales)", "X360", "2006", "Racing", "Ubisoft", "0.00", "0.00", "0.01", "0.00"},
            {
                "Teenage Mutant Ninja Turtles: Out of the Shadows", "X360", "2013", "Action", "Activision", "0.00", "0.01",
                "0.00", "0.00"
            },
            {
                "SpongeBob SquarePants: Plankton's Robotic Revenge", "X360", "2013", "Action", "Activision", "0.01", "0.00",
                "0.00", "0.00"
            },
            {
                "Digimon All-Star Rumble", "X360", "2014", "Fighting", "Namco Bandai Games", "0.01", "0.00", "0.00", "0.00"
            },
            {"Superstars V8 Racing", "X360", "2009", "Racing", "Black Bean Games", "0.00", "0.01", "0.00", "0.00"},
            {"Eschatos", "X360", "2011", "Shooter", "Qute", "0.00", "0.00", "0.01", "0.00"},
            {"LMA Manager 2007", "X360", "2006", "Sports", "Codemasters", "0.00", "0.01", "0.00", "0.00"},
            {"WarTech: Senko no Ronde(JP sales)", "X360", "N/A", "Action", "N/A", "0.00", "0.00", "0.01", "0.00"},
            {"Tayutama: Kiss on my Deity", "X360", "2009", "Adventure", "5pb", "0.00", "0.00", "0.01", "0.00"},
            {"Armored Core: Verdict Day", "X360", "2013", "Action", "From Software", "0.00", "0.00", "0.01", "0.00"},
            {"Shooting Love, 200X", "X360", "2009", "Shooter", "Triangle Service", "0.00", "0.00", "0.01", "0.00"},
            {
                "Akatsuki no Amaneka to Aoi Kyojin", "X360", "2010", "Strategy", "CyberFront", "0.00", "0.00", "0.01",
                "0.00"
            },
            {"Darkstalkers Resurrection", "X360", "2013", "Fighting", "Capcom", "0.00", "0.00", "0.01", "0.00"},
            {
                "Stranger of Sword City", "X360", "2014", "Role-Playing", "Experience Inc.", "0.00", "0.00", "0.01", "0.00"
            },
            {"Guilty Gear 2: Overture", "X360", "2007", "Fighting", "505 Games", "0.00", "0.00", "0.01", "0.00"},
            {
                "WSC REAL 09: World Snooker Championship", "X360", "2009", "Sports", "Deep Silver", "0.00", "0.01", "0.00",
                "0.00"
            },
            {
                "Superstars V8 Next Challenge", "X360", "2010", "Racing", "Black Bean Games", "0.00", "0.01", "0.00",
                "0.00"
            },
            {"uDraw Studio: Instant Artist", "X360", "2011", "Misc", "THQ", "0.00", "0.01", "0.00", "0.00"},
            {"Phantom: Phantom of Inferno", "X360", "N/A", "Adventure", "Unknown", "0.00", "0.00", "0.01", "0.00"},
            {
                "Fantasia: Music Evolved", "X360", "2014", "Misc", "Disney Interactive Studios", "0.00", "0.00", "0.00",
                "0.00"
            },
            {"Deadfall Adventures", "X360", "2020", "Action", "Unknown", "0.00", "0.01", "0.00", "0.00"},
            {"Castle of Shikigami III", "X360", "2007", "Shooter", "Arc System Works", "0.00", "0.00", "0.01", "0.00"},
            {"Mahjong * Dream C Club", "X360", "2012", "Action", "D3Publisher", "0.00", "0.00", "0.01", "0.00"},
            {"Muv-Luv Alternative: Total Eclipse", "X360", "2013", "Simulation", "5pb", "0.00", "0.00", "0.01", "0.00"},
            {
                "Brian Lara International Cricket 2007", "X360", "2007", "Sports", "Codemasters", "0.00", "0.01", "0.00",
                "0.00"
            },
            {"The Idolm@ster Twins", "X360", "2009", "Misc", "Namco Bandai Games", "0.00", "0.00", "0.01", "0.00"},
            {"The Wolf Among Us", "X360", "2011", "Adventure", "Telltale Games", "0.00", "0.01", "0.00", "0.00"},
            {"Championship Manager 2007", "X360", "2007", "Sports", "Eidos Interactive", "0.00", "0.01", "0.00", "0.00"},
            {"Football Manager 2008", "X360", "2008", "Sports", "Sega", "0.00", "0.01", "0.00", "0.00"},
            {
                "Nike+ Kinect Training", "X360", "2012", "Sports", "Microsoft Game Studios", "0.00", "0.01", "0.00", "0.00"
            },
            {
                "PDC World Championship Darts 2008", "X360", "N/A", "Sports", "Oxygen Interactive", "0.00", "0.01", "0.00",
                "0.00"
            },
            {"MX vs. ATV Supercross", "X360", "2014", "Racing", "Nordic Games", "0.01", "0.00", "0.00", "0.00"},
            {"Soul Calibur IV", "X360", "2008", "Fighting", "Namco Bandai Games", "0.00", "0.00", "0.00", "0.00"},
            {"Memories Off 6: Next Relation", "X360", "2009", "Adventure", "5pb", "0.00", "0.00", "0.01", "0.00"},
            {"Bullet Soul Infinite Burst", "X360", "2014", "Shooter", "5pb", "0.00", "0.00", "0.01", "0.00"},
            {
                "SBK09 Superbike World Championship", "X360", "2009", "Racing", "Black Bean Games", "0.00", "0.00", "0.00",
                "0.00"
            },
            {"Capcom Digital Collection", "X360", "2012", "Action", "Capcom", "0.00", "0.00", "0.00", "0.00"},
            {"Machi-ing Maker 4", "X360", "2011", "Strategy", "D3Publisher", "0.00", "0.00", "0.00", "0.00"},
        };

        /// <summary>
        /// Wii game information
        /// </summary>
        public static string[,] WiiGames =
        {
            {"Wii Sports", "Wii", "2006", "Sports", "Nintendo", "41.24", "28.83", "3.77", "8.42"},
            {"Mario Kart Wii", "Wii", "2008", "Racing", "Nintendo", "15.34", "12.53", "3.75", "3.22"},
            {"Wii Sports Resort", "Wii", "2009", "Sports", "Nintendo", "15.51", "10.82", "3.26", "2.92"},
            {"Wii Play", "Wii", "2006", "Misc", "Nintendo", "13.93", "9.16", "2.93", "2.84"},
            {"New Super Mario Bros. Wii", "Wii", "2009", "Platform", "Nintendo", "14.10", "6.72", "4.69", "2.18"},
            {"Wii Fit", "Wii", "2007", "Sports", "Nintendo", "8.92", "8.03", "3.60", "2.14"},
            {"Wii Fit Plus", "Wii", "2009", "Sports", "Nintendo", "8.96", "8.35", "2.53", "1.76"},
            {"Super Smash Bros. Brawl", "Wii", "2008", "Fighting", "Nintendo", "6.38", "2.42", "2.62", "0.96"},
            {"Super Mario Galaxy", "Wii", "2007", "Platform", "Nintendo", "5.97", "3.27", "1.20", "0.72"},
            {"Just Dance 3", "Wii", "2011", "Misc", "Ubisoft", "5.88", "3.09", "0.00", "1.04"},
            {"Just Dance 2", "Wii", "2010", "Misc", "Ubisoft", "5.78", "2.83", "0.01", "0.77"},
            {"Wii Party", "Wii", "2010", "Misc", "Nintendo", "1.73", "3.38", "2.48", "0.67"},
            {"Mario Party 8", "Wii", "2007", "Misc", "Nintendo", "3.72", "2.14", "1.58", "0.71"},
            {"Mario & Sonic at the Olympic Games", "Wii", "2007", "Sports", "Sega", "2.56", "3.83", "0.66", "0.91"},
            {"Super Mario Galaxy 2", "Wii", "2010", "Platform", "Nintendo", "3.49", "2.23", "0.98", "0.61"},
            {"Just Dance", "Wii", "2009", "Misc", "Ubisoft", "3.46", "2.95", "0.00", "0.72"},
            {
                "The Legend of Zelda: Twilight Princess", "Wii", "2006", "Action", "Nintendo", "3.69", "2.06", "0.60",
                "0.67"
            },
            {"Just Dance 4", "Wii", "2012", "Misc", "Ubisoft", "4.01", "2.10", "0.00", "0.54"},
            {"Zumba Fitness", "Wii", "2010", "Sports", "505 Games", "3.42", "2.54", "0.00", "0.66"},
            {"Donkey Kong Country Returns", "Wii", "2010", "Platform", "Nintendo", "3.10", "1.69", "1.03", "0.45"},
            {"LEGO Star Wars: The Complete Saga", "Wii", "2007", "Action", "LucasArts", "3.47", "1.46", "0.00", "0.49"},
            {"Link's Crossbow Training", "Wii", "2007", "Shooter", "Nintendo", "3.04", "1.16", "0.29", "0.46"},
            {"Guitar Hero III: Legends of Rock", "Wii", "2007", "Misc", "Activision", "3.03", "1.11", "0.00", "0.43"},
            {"Animal Crossing: City Folk", "Wii", "2008", "Simulation", "Nintendo", "1.80", "1.10", "1.32", "0.36"},
            {
                "Mario & Sonic at the Olympic Winter Games", "Wii", "2009", "Sports", "Sega", "1.86", "1.92", "0.22",
                "0.48"
            },
            {"Michael Jackson: The Experience", "Wii", "2010", "Misc", "Ubisoft", "2.62", "1.30", "0.01", "0.38"},
            {"Carnival Games", "Wii", "2007", "Misc", "Take-Two Interactive", "2.11", "1.45", "0.05", "0.41"},
            {"EA Sports Active", "Wii", "2009", "Sports", "Electronic Arts", "2.08", "1.35", "0.06", "0.40"},
            {"The Legend of Zelda: Skyward Sword", "Wii", "2011", "Action", "Nintendo", "1.96", "1.11", "0.37", "0.37"},
            {"Big Brain Academy: Wii Degree", "Wii", "2007", "Misc", "Nintendo", "1.04", "1.90", "0.41", "0.42"},
            {"Super Paper Mario", "Wii", "2007", "Platform", "Nintendo", "1.94", "0.83", "0.59", "0.31"},
            {
                "Mario & Sonic at the London 2012 Olympic Games", "Wii", "2011", "Sports", "Sega", "1.11", "1.82", "0.27",
                "0.45"
            },
            {"Guitar Hero: World Tour", "Wii", "2008", "Misc", "Activision", "2.31", "0.95", "0.00", "0.34"},
            {"Just Dance 2014", "Wii", "2013", "Misc", "Ubisoft", "1.77", "1.26", "0.00", "0.29"},
            {"Wii Music", "Wii", "2008", "Misc", "Nintendo", "1.34", "1.11", "0.46", "0.32"},
            {
                "Disney Epic Mickey", "Wii", "2010", "Platform", "Disney Interactive Studios", "2.02", "0.61", "0.12",
                "0.21"
            },
            {
                "LEGO Batman: The Videogame", "Wii", "N/A", "Adventure", "Warner Bros. Interactive Entertainment", "1.76",
                "0.92", "0.00", "0.27"
            },
            {"Mario Party 9", "Wii", "2012", "Misc", "Nintendo", "1.00", "0.95", "0.74", "0.21"},
            {"Cooking Mama: Cook Off", "Wii", "2007", "Simulation", "505 Games", "1.41", "1.11", "0.05", "0.30"},
            {"WarioWare: Smooth Moves", "Wii", "2006", "Puzzle", "Nintendo", "0.85", "1.03", "0.73", "0.26"},
            {"Zumba Fitness 2", "Wii", "2011", "Sports", "Majesco Entertainment", "1.49", "0.99", "0.00", "0.27"},
            {"Skylanders: Spyro's Adventure", "Wii", "2011", "Action", "Activision", "1.32", "1.11", "0.00", "0.30"},
            {"Sonic and the Secret Rings", "Wii", "2007", "Platform", "Sega", "1.18", "1.18", "0.04", "0.29"},
            {"Mario Strikers Charged", "Wii", "2007", "Sports", "Nintendo", "1.04", "1.03", "0.24", "0.24"},
            {
                "Super Mario All-Stars: Limited Edition", "Wii", "2010", "Platform", "Nintendo", "0.98", "0.51", "0.92",
                "0.13"
            },
            {"Deca Sports", "Wii", "2008", "Sports", "Konami Digital Entertainment", "1.10", "0.84", "0.29", "0.25"},
            {"Game Party", "Wii", "2007", "Misc", "Midway Games", "1.46", "0.76", "0.00", "0.24"},
            {"Skylanders Giants", "Wii", "2012", "Action", "Activision", "1.43", "0.77", "0.00", "0.20"},
            {"uDraw Studio", "Wii", "2010", "Misc", "THQ", "1.63", "0.57", "0.00", "0.20"},
            {
                "LEGO Harry Potter: Years 1-4", "Wii", "2010", "Adventure", "Warner Bros. Interactive Entertainment",
                "1.26", "0.88", "0.00", "0.22"
            },
            {
                "LEGO Indiana Jones: The Original Adventures", "Wii", "N/A", "Adventure", "LucasArts", "1.50", "0.60",
                "0.00", "0.21"
            },
            {"My Fitness Coach", "Wii", "2008", "Sports", "Ubisoft", "1.18", "0.90", "0.00", "0.24"},
            {"Call of Duty 3", "Wii", "N/A", "Shooter", "Activision", "1.17", "0.83", "0.00", "0.23"},
            {"Super Monkey Ball: Banana Blitz", "Wii", "2006", "Misc", "Sega", "1.03", "0.91", "0.04", "0.23"},
            {"Monster Hunter Tri", "Wii", "2009", "Role-Playing", "Nintendo", "0.65", "0.39", "1.05", "0.11"},
            {"Resident Evil 4", "Wii", "2007", "Action", "Capcom", "1.31", "0.55", "0.14", "0.20"},
            {"Just Dance Kids", "Wii", "2010", "Misc", "Ubisoft", "1.49", "0.50", "0.00", "0.18"},
            {"Sonic Unleashed", "Wii", "2008", "Platform", "Sega", "1.21", "0.67", "0.02", "0.20"},
            {"Your Shape featuring Jenny McCarthy", "Wii", "2009", "Sports", "Ubisoft", "1.46", "0.46", "0.00", "0.17"},
            {"Rock Band", "Wii", "N/A", "Misc", "MTV Games", "1.32", "0.55", "0.00", "0.20"},
            {
                "Dance Dance Revolution: Hottest Party", "Wii", "2007", "Simulation", "Konami Digital Entertainment",
                "1.35", "0.52", "0.00", "0.20"
            },
            {"Mario Sports Mix", "Wii", "2010", "Sports", "Nintendo", "0.87", "0.43", "0.63", "0.12"},
            {"Kirby's Epic Yarn", "Wii", "2010", "Platform", "Nintendo", "1.39", "0.09", "0.45", "0.10"},
            {"Wipeout: The Game", "Wii", "2009", "Misc", "Mindscape", "1.91", "0.00", "0.00", "0.11"},
            {"Rayman Raving Rabbids: TV Party", "Wii", "2008", "Misc", "Ubisoft", "0.72", "1.07", "0.00", "0.23"},
            {"Call of Duty: World at War", "Wii", "2008", "Shooter", "Activision", "1.16", "0.57", "0.00", "0.18"},
            {"Skylanders SWAP Force", "Wii", "2013", "Platform", "Activision", "1.09", "0.63", "0.00", "0.16"},
            {"Mario Super Sluggers", "Wii", "2008", "Sports", "Nintendo", "1.46", "0.00", "0.29", "0.12"},
            {"Monopoly", "Wii", "2008", "Misc", "Electronic Arts", "0.85", "0.81", "0.00", "0.20"},
            {"Game Party 2", "Wii", "2008", "Misc", "Midway Games", "1.26", "0.43", "0.00", "0.17"},
            {"Toy Story Mania!", "Wii", "2009", "Misc", "Disney Interactive Studios", "1.02", "0.65", "0.00", "0.18"},
            {"Star Wars: The Force Unleashed", "Wii", "2008", "Action", "LucasArts", "1.10", "0.55", "0.00", "0.18"},
            {"Rayman Raving Rabbids 2", "Wii", "2007", "Misc", "Ubisoft", "0.82", "0.81", "0.00", "0.20"},
            {"GoldenEye 007 (2010)", "Wii", "2010", "Action", "Activision", "0.83", "0.69", "0.13", "0.16"},
            {"Metroid Prime 3: Corruption", "Wii", "2007", "Shooter", "Nintendo", "0.89", "0.73", "0.07", "0.09"},
            {
                "High School Musical: Sing It!", "Wii", "2007", "Misc", "Disney Interactive Studios", "1.15", "0.45",
                "0.00", "0.16"
            },
            {"The Beatles: Rock Band", "Wii", "2009", "Misc", "MTV Games", "1.16", "0.38", "0.00", "0.15"},
            {
                "Cabela's Big Game Hunter 2010", "Wii", "2009", "Sports", "Activision Value", "1.57", "0.00", "0.00",
                "0.12"
            },
            {"We Ski", "Wii", "2008", "Sports", "Namco Bandai Games", "0.97", "0.39", "0.14", "0.15"},
            {"Big Beach Sports", "Wii", "2008", "Sports", "THQ", "0.44", "1.01", "0.00", "0.20"},
            {"Shaun White Snowboarding: Road Trip", "Wii", "2008", "Sports", "Ubisoft", "0.93", "0.56", "0.00", "0.16"},
            {"LEGO Star Wars III: The Clone Wars", "Wii", "2011", "Action", "LucasArts", "0.96", "0.53", "0.00", "0.14"},
            {
                "Star Wars The Clone Wars: Lightsaber Duels", "Wii", "2008", "Action", "LucasArts", "1.21", "0.29", "0.00",
                "0.14"
            },
            {
                "Game Party 3", "Wii", "2009", "Puzzle", "Warner Bros. Interactive Entertainment", "1.37", "0.15", "0.00",
                "0.11"
            },
            {"MySims", "Wii", "2007", "Simulation", "Electronic Arts", "0.89", "0.53", "0.04", "0.17"},
            {"Sonic Colors", "Wii", "2010", "Platform", "Sega", "0.89", "0.58", "0.01", "0.15"},
            {"Kirby's Return to Dreamland", "Wii", "2011", "Platform", "Nintendo", "0.56", "0.20", "0.79", "0.07"},
            {
                "Dance Dance Revolution: Hottest Party 2", "Wii", "2008", "Simulation", "Konami Digital Entertainment",
                "0.94", "0.47", "0.01", "0.15"
            },
            {"Pok�mon Battle Revolution", "Wii", "2006", "Role-Playing", "Nintendo", "0.78", "0.35", "0.30", "0.13"},
            {
                "Carnival Games: Mini Golf", "Wii", "2008", "Sports", "Take-Two Interactive", "0.86", "0.53", "0.00",
                "0.15"
            },
            {"Active Life: Outdoor Challenge", "Wii", "2008", "Sports", "Atari", "0.78", "0.43", "0.19", "0.14"},
            {"Guitar Hero 5", "Wii", "2009", "Misc", "Activision", "0.91", "0.47", "0.00", "0.15"},
            {
                "Resident Evil: The Umbrella Chronicles", "Wii", "2007", "Shooter", "Capcom", "0.66", "0.42", "0.29",
                "0.14"
            },
            {"MySims Kingdom", "Wii", "2008", "Simulation", "Electronic Arts", "0.70", "0.63", "0.01", "0.16"},
            {
                "Call of Duty: Modern Warfare: Reflex Edition", "Wii", "2009", "Shooter", "Activision", "0.94", "0.42",
                "0.00", "0.14"
            },
            {
                "LEGO Pirates of the Caribbean: The Video Game", "Wii", "2011", "Action", "Disney Interactive Studios",
                "0.71", "0.62", "0.00", "0.15"
            },
            {
                "Disney Sing It: Pop Hits", "Wii", "2009", "Misc", "Disney Interactive Studios", "1.06", "0.28", "0.00",
                "0.13"
            },
            {
                "New Play Control! Mario Power Tennis", "Wii", "2009", "Sports", "Nintendo", "0.35", "0.68", "0.28", "0.14"
            },
            {"The House of the Dead 2 & 3 Return", "Wii", "2008", "Shooter", "Sega", "0.76", "0.49", "0.03", "0.14"},
            {"Go Vacation", "Wii", "2011", "Misc", "Namco Bandai Games", "0.37", "0.58", "0.33", "0.14"},
            {"Smarty Pants", "Wii", "2007", "Misc", "Electronic Arts", "0.51", "0.75", "0.00", "0.16"},
            {"Hasbro Family Game Night", "Wii", "2008", "Puzzle", "Electronic Arts", "0.96", "0.33", "0.00", "0.13"},
            {
                "Tiger Woods PGA Tour 09 All-Play", "Wii", "2008", "Sports", "Electronic Arts", "0.80", "0.47", "0.00",
                "0.14"
            },
            {"Rayman Raving Rabbids", "Wii", "2006", "Misc", "Ubisoft", "1.21", "0.05", "0.02", "0.11"},
            {
                "Hannah Montana: Spotlight World Tour", "Wii", "2007", "Action", "Disney Interactive Studios", "0.87",
                "0.38", "0.00", "0.13"
            },
            {
                "LEGO Indiana Jones 2: The Adventure Continues", "Wii", "2009", "Adventure", "Activision", "0.89", "0.37",
                "0.00", "0.12"
            },
            {"Disney Infinity", "Wii", "2013", "Action", "Disney Interactive Studios", "0.94", "0.33", "0.00", "0.10"},
            {"Sonic & SEGA All-Stars Racing", "Wii", "2010", "Racing", "Sega", "0.57", "0.65", "0.00", "0.14"},
            {
                "Toy Story 3: The Video Game", "Wii", "2010", "Action", "Disney Interactive Studios", "0.62", "0.60",
                "0.00", "0.13"
            },
            {"Call of Duty: Black Ops", "Wii", "2010", "Shooter", "Activision", "0.79", "0.44", "0.00", "0.12"},
            {"Hasbro Family Game Night 2", "Wii", "2009", "Misc", "Electronic Arts", "0.69", "0.51", "0.00", "0.13"},
            {"The Sims 3", "Wii", "2010", "Simulation", "Electronic Arts", "0.53", "0.66", "0.00", "0.13"},
            {
                "Disney Princess: Enchanted Journey", "Wii", "2007", "Adventure", "Disney Interactive Studios", "1.21",
                "0.02", "0.00", "0.09"
            },
            {
                "High School Musical 3: Senior Year DANCE!", "Wii", "2008", "Misc", "Disney Interactive Studios", "0.67",
                "0.49", "0.00", "0.13"
            },
            {"Metroid: Other M", "Wii", "2010", "Action", "Nintendo", "0.83", "0.23", "0.13", "0.09"},
            {
                "LEGO Batman 2: DC Super Heroes", "Wii", "2012", "Action", "Warner Bros. Interactive Entertainment", "0.86",
                "0.32", "0.00", "0.10"
            },
            {"EA Playground", "Wii", "2007", "Sports", "Electronic Arts", "0.68", "0.46", "0.00", "0.13"},
            {"Deal or No Deal", "Wii", "2009", "Misc", "Zoo Games", "1.19", "0.00", "0.00", "0.08"},
            {"Gold's Gym: Cardio Workout", "Wii", "2008", "Sports", "Ubisoft", "1.09", "0.03", "0.06", "0.09"},
            {
                "Jillian Michaels' Fitness Ultimatum 2009", "Wii", "2008", "Sports", "Deep Silver", "0.96", "0.20", "0.00",
                "0.11"
            },
            {"Need for Speed Carbon", "Wii", "2006", "Racing", "Electronic Arts", "0.45", "0.65", "0.02", "0.15"},
            {"Guitar Hero: Aerosmith", "Wii", "2008", "Misc", "Activision", "1.02", "0.14", "0.00", "0.10"},
            {
                "Rockstar Games presents Table Tennis", "Wii", "2007", "Sports", "Take-Two Interactive", "0.39", "0.72",
                "0.00", "0.15"
            },
            {"EA Sports Active 2", "Wii", "2010", "Sports", "Electronic Arts", "0.75", "0.38", "0.00", "0.11"},
            {"Winter Sports: The Ultimate Challenge", "Wii", "2007", "Sports", "RTL", "0.45", "0.67", "0.00", "0.12"},
            {"Ben 10: Protector of Earth", "Wii", "2007", "Action", "D3Publisher", "0.54", "0.55", "0.00", "0.13"},
            {"Boom Blox", "Wii", "2008", "Puzzle", "Electronic Arts", "0.71", "0.37", "0.00", "0.12"},
            {"The Sims 2: Castaway", "Wii", "2007", "Simulation", "Electronic Arts", "0.43", "0.62", "0.00", "0.14"},
            {
                "Pro Evolution Soccer 2008", "Wii", "2008", "Sports", "Konami Digital Entertainment", "0.09", "0.84",
                "0.11", "0.15"
            },
            {"Disney Sing It", "Wii", "2008", "Misc", "Disney Interactive Studios", "0.77", "0.30", "0.00", "0.11"},
            {
                "Pok�Park Wii: Pikachu's Adventure", "Wii", "2009", "Adventure", "Nintendo", "0.52", "0.16", "0.42", "0.06"
            },
            {"Wario Land: Shake It!", "Wii", "2008", "Platform", "Nintendo", "0.58", "0.30", "0.15", "0.10"},
            {
                "LEGO Harry Potter: Years 5-7", "Wii", "N/A", "Action", "Warner Bros. Interactive Entertainment", "0.66",
                "0.36", "0.00", "0.11"
            },
            {"Rabbids Go Home", "Wii", "2009", "Platform", "Ubisoft", "0.24", "0.73", "0.00", "0.14"},
            {
                "EA Sports Active: More Workouts", "Wii", "2009", "Sports", "Electronic Arts", "0.75", "0.26", "0.00",
                "0.10"
            },
            {"Need for Speed: ProStreet", "Wii", "2007", "Racing", "Electronic Arts", "0.53", "0.45", "0.00", "0.11"},
            {"NERF N-Strike", "Wii", "2008", "Shooter", "Electronic Arts", "0.91", "0.09", "0.00", "0.09"},
            {"FIFA Soccer 11", "Wii", "2010", "Sports", "Electronic Arts", "0.26", "0.68", "0.00", "0.12"},
            {"The Biggest Loser", "Wii", "2009", "Sports", "THQ", "0.86", "0.12", "0.00", "0.09"},
            {"Tiger Woods PGA Tour 10", "Wii", "2009", "Sports", "Electronic Arts", "0.60", "0.36", "0.00", "0.11"},
            {"Sega Superstars Tennis", "Wii", "2008", "Sports", "Sega", "0.28", "0.64", "0.00", "0.13"},
            {"Endless Ocean", "Wii", "2007", "Adventure", "Nintendo", "0.42", "0.45", "0.09", "0.09"},
            {
                "Resident Evil: The Darkside Chronicles", "Wii", "2009", "Shooter", "Capcom", "0.45", "0.30", "0.20",
                "0.08"
            },
            {"Sonic and the Black Knight", "Wii", "2009", "Platform", "Sega", "0.59", "0.33", "0.01", "0.10"},
            {
                "Guinness World Records: The Videogame", "Wii", "2008", "Action", "Warner Bros. Interactive Entertainment",
                "0.45", "0.46", "0.00", "0.11"
            },
            {"Tiger Woods PGA Tour 08", "Wii", "2007", "Sports", "Electronic Arts", "0.93", "0.01", "0.00", "0.08"},
            {"FIFA Soccer 08", "Wii", "2007", "Sports", "Electronic Arts", "0.31", "0.59", "0.01", "0.11"},
            {
                "Naruto: Clash of Ninja Revolution", "Wii", "2007", "Fighting", "Tomy Corporation", "0.44", "0.46", "0.00",
                "0.11"
            },
            {"Wall-E", "Wii", "2008", "Platform", "THQ", "0.51", "0.40", "0.00", "0.11"},
            {"Rock Band 2", "Wii", "2008", "Misc", "MTV Games", "0.93", "0.01", "0.00", "0.08"},
            {"MySims Agents", "Wii", "2009", "Adventure", "Electronic Arts", "0.60", "0.31", "0.00", "0.09"},
            {"Dragon Ball Z: Budokai Tenkaichi 3", "Wii", "2007", "Fighting", "Atari", "0.32", "0.35", "0.26", "0.09"},
            {"The Simpsons Game", "Wii", "2007", "Action", "Electronic Arts", "0.44", "0.45", "0.00", "0.11"},
            {"NERF N-Strike Elite", "Wii", "2009", "Shooter", "Electronic Arts", "0.93", "0.00", "0.00", "0.07"},
            {"Dance on Broadway", "Wii", "2010", "Misc", "Ubisoft", "0.25", "0.63", "0.00", "0.12"},
            {"Cars: Race-O-Rama", "Wii", "2009", "Racing", "THQ", "0.60", "0.29", "0.00", "0.09"},
            {"FIFA Soccer 10", "Wii", "2009", "Sports", "Electronic Arts", "0.23", "0.64", "0.00", "0.11"},
            {"WWE SmackDown vs Raw 2008", "Wii", "2007", "Fighting", "THQ", "0.37", "0.50", "0.00", "0.11"},
            {"Disney Universe", "Wii", "2011", "Action", "Disney Interactive Studios", "0.62", "0.25", "0.00", "0.09"},
            {"Band Hero", "Wii", "2009", "Misc", "Activision", "0.58", "0.28", "0.00", "0.09"},
            {"de Blob", "Wii", "2008", "Platform", "THQ", "0.49", "0.36", "0.00", "0.10"},
            {"Tony Hawk: RIDE", "Wii", "2009", "Sports", "Activision", "0.69", "0.16", "0.00", "0.08"},
            {"Wheel of Fortune", "Wii", "2010", "Misc", "THQ", "0.83", "0.04", "0.00", "0.05"},
            {"Guitar Hero: Metallica", "Wii", "2009", "Misc", "Activision", "0.40", "0.42", "0.00", "0.10"},
            {"Cars", "Wii", "2006", "Racing", "THQ", "0.82", "0.02", "0.00", "0.07"},
            {
                "Club Penguin: Game Day!", "Wii", "2010", "Misc", "Disney Interactive Studios", "0.53", "0.31", "0.00",
                "0.08"
            },
            {"Guitar Hero: Warriors of Rock", "Wii", "2010", "Misc", "Activision", "0.46", "0.36", "0.00", "0.09"},
            {"Kung Fu Panda", "Wii", "2008", "Platform", "Activision", "0.50", "0.32", "0.00", "0.09"},
            {
                "Scooby-Doo! First Frights", "Wii", "2009", "Adventure", "Warner Bros. Interactive Entertainment", "0.81",
                "0.04", "0.00", "0.06"
            },
            {"AMF Bowling Pinbusters!", "Wii", "2007", "Sports", "Bethesda Softworks", "0.84", "0.00", "0.00", "0.07"},
            {"EA Sports Grand Slam Tennis", "Wii", "2009", "Sports", "Electronic Arts", "0.27", "0.50", "0.02", "0.11"},
            {"Nickelodeon Fit", "Wii", "2010", "Sports", "Take-Two Interactive", "0.75", "0.09", "0.00", "0.06"},
            {"Wii Play: Motion", "Wii", "2011", "Misc", "Nintendo", "0.22", "0.41", "0.18", "0.09"},
            {"CSI: Hard Evidence", "Wii", "2008", "Adventure", "Ubisoft", "0.36", "0.43", "0.00", "0.10"},
            {"FIFA Soccer 09 All-Play", "Wii", "2008", "Sports", "Electronic Arts", "0.28", "0.51", "0.00", "0.09"},
            {"We Ski & Snowboard", "Wii", "2008", "Sports", "Atari", "0.37", "0.28", "0.15", "0.08"},
            {"Sonic Riders: Zero Gravity", "Wii", "2008", "Racing", "Sega", "0.46", "0.31", "0.02", "0.09"},
            {"Xenoblade Chronicles", "Wii", "2010", "Role-Playing", "Nintendo", "0.41", "0.24", "0.16", "0.07"},
            {"Samba De Amigo", "Wii", "2008", "Misc", "Sega", "0.41", "0.36", "0.01", "0.09"},
            {"Monster 4X4: World Circuit", "Wii", "2006", "Racing", "Ubisoft", "0.80", "0.00", "0.01", "0.07"},
            {
                "Disney Epic Mickey 2: The Power of Two", "Wii", "2012", "Action", "Disney Interactive Studios", "0.62",
                "0.18", "0.00", "0.06"
            },
            {"Madden NFL 08", "Wii", "2007", "Sports", "Electronic Arts", "0.80", "0.00", "0.00", "0.07"},
            {"F1 2009", "Wii", "2009", "Racing", "Codemasters", "0.15", "0.61", "0.00", "0.11"},
            {"Cooking Mama: World Kitchen", "Wii", "2008", "Simulation", "505 Games", "0.50", "0.27", "0.01", "0.08"},
            {"Rhythm Heaven", "Wii", "N/A", "Misc", "Unknown", "0.09", "0.00", "0.77", "0.01"},
            {"Endless Ocean: Blue World", "Wii", "2009", "Simulation", "Nintendo", "0.46", "0.21", "0.12", "0.06"},
            {"Ghostbusters: The Video Game", "Wii", "2009", "Action", "Atari", "0.58", "0.20", "0.00", "0.07"},
            {"Pictionary", "Wii", "2010", "Puzzle", "THQ", "0.59", "0.18", "0.00", "0.07"},
            {"Tomb Raider: Anniversary", "Wii", "2007", "Action", "Eidos Interactive", "0.12", "0.62", "0.00", "0.11"},
            {"The House of the Dead: Overkill", "Wii", "2009", "Shooter", "Sega", "0.44", "0.29", "0.02", "0.08"},
            {"Dragon Quest X", "Wii", "2012", "Role-Playing", "Square Enix", "0.00", "0.00", "0.83", "0.00"},
            {"Gold's Gym: Dance Workout", "Wii", "2010", "Sports", "Ubisoft", "0.68", "0.10", "0.00", "0.06"},
            {"WWE SmackDown vs. Raw 2009", "Wii", "2008", "Fighting", "THQ", "0.43", "0.31", "0.00", "0.08"},
            {"Cars 2", "Wii", "2011", "Platform", "Disney Interactive Studios", "0.40", "0.34", "0.00", "0.09"},
            {
                "Blazing Angels: Squadrons of WWII", "Wii", "2007", "Simulation", "Ubisoft", "0.73", "0.03", "0.00", "0.06"
            },
            {"Madden NFL 09 All-Play", "Wii", "2008", "Sports", "Electronic Arts", "0.76", "0.01", "0.00", "0.06"},
            {"The Price is Right", "Wii", "2008", "Misc", "Ubisoft", "0.75", "0.00", "0.00", "0.06"},
            {
                "Harvest Moon: Tree of Tranquility", "Wii", "2007", "Simulation", "Rising Star Games", "0.67", "0.03",
                "0.06", "0.05"
            },
            {
                "LEGO The Lord of the Rings", "Wii", "2012", "Action", "Warner Bros. Interactive Entertainment", "0.45",
                "0.29", "0.00", "0.07"
            },
            {"Need for Speed: Nitro", "Wii", "2009", "Racing", "Electronic Arts", "0.44", "0.28", "0.00", "0.08"},
            {
                "Karaoke Revolution Glee", "Wii", "2010", "Misc", "Konami Digital Entertainment", "0.50", "0.24", "0.00",
                "0.07"
            },
            {"Ben 10: Alien Force", "Wii", "2008", "Action", "Koch Media", "0.52", "0.21", "0.00", "0.07"},
            {"All Star Cheer Squad", "Wii", "2008", "Sports", "THQ", "0.42", "0.29", "0.00", "0.08"},
            {"Deca Sports 2", "Wii", "2009", "Sports", "Hudson Soft", "0.30", "0.33", "0.09", "0.07"},
            {"Hasbro Family Game Night 3", "Wii", "2010", "Misc", "Electronic Arts", "0.45", "0.26", "0.00", "0.07"},
            {
                "EA Sports Active NFL Training Camp", "Wii", "2010", "Sports", "Electronic Arts", "0.73", "0.00", "0.00",
                "0.04"
            },
            {
                "Star Wars The Clone Wars: Republic Heroes", "Wii", "2009", "Action", "LucasArts", "0.43", "0.27", "0.00",
                "0.08"
            },
            {"Call of Duty: Modern Warfare 3", "Wii", "2011", "Shooter", "Activision", "0.51", "0.19", "0.00", "0.07"},
            {"Ghost Squad", "Wii", "2007", "Shooter", "Sega", "0.41", "0.20", "0.08", "0.07"},
            {"MadWorld", "Wii", "2009", "Action", "Sega", "0.44", "0.22", "0.02", "0.07"},
            {"ABBA: You Can Dance", "Wii", "2011", "Misc", "Ubisoft", "0.17", "0.47", "0.00", "0.11"},
            {"FIFA Soccer 12", "Wii", "2011", "Sports", "Electronic Arts", "0.15", "0.49", "0.00", "0.11"},
            {
                "Harry Potter and the Half-Blood Prince", "Wii", "2009", "Action", "Electronic Arts", "0.27", "0.39",
                "0.00", "0.08"
            },
            {"Deer Drive", "Wii", "2009", "Sports", "Big Ben Interactive", "0.66", "0.03", "0.00", "0.05"},
            {"DJ Hero", "Wii", "2009", "Misc", "Activision", "0.44", "0.23", "0.00", "0.07"},
            {"Drawn to Life: The Next Chapter", "Wii", "2009", "Puzzle", "THQ", "0.27", "0.39", "0.00", "0.08"},
            {"Raving Rabbids: Travel in Time", "Wii", "2010", "Adventure", "Ubisoft", "0.21", "0.45", "0.00", "0.08"},
            {"Namco Museum Remix", "Wii", "2007", "Misc", "Atari", "0.68", "0.00", "0.00", "0.05"},
            {"PokePark 2: Wonders Beyond", "Wii", "2011", "Action", "Nintendo", "0.25", "0.17", "0.27", "0.04"},
            {"Just Dance Wii", "Wii", "2011", "Misc", "Nintendo", "0.00", "0.00", "0.72", "0.00"},
            {"Star Wars: The Force Unleashed II", "Wii", "2010", "Action", "LucasArts", "0.49", "0.17", "0.00", "0.06"},
            {"We Sing", "Wii", "2009", "Misc", "Nordic Games", "0.00", "0.63", "0.00", "0.09"},
            {"Madden NFL 10", "Wii", "2009", "Sports", "Electronic Arts", "0.62", "0.04", "0.00", "0.06"},
            {
                "Indiana Jones and the Staff of Kings", "Wii", "2009", "Action", "Activision", "0.35", "0.29", "0.00",
                "0.07"
            },
            {
                "Harvest Moon: Animal Parade", "Wii", "2008", "Simulation", "Rising Star Games", "0.57", "0.07", "0.02",
                "0.05"
            },
            {"WWE SmackDown vs. Raw 2010", "Wii", "2009", "Fighting", "THQ", "0.48", "0.17", "0.00", "0.06"},
            {"James Cameron's Avatar: The Game", "Wii", "2009", "Action", "Ubisoft", "0.32", "0.31", "0.00", "0.08"},
            {"Madden NFL 11", "Wii", "N/A", "Sports", "Unknown", "0.66", "0.00", "0.00", "0.04"},
            {
                "Dragon Quest Swords: The Masked Queen and the Tower of Mirrors", "Wii", "2007", "Role-Playing",
                "Square Enix", "0.17", "0.01", "0.50", "0.02"
            },
            {"Monopoly Streets", "Wii", "2010", "Misc", "Electronic Arts", "0.23", "0.39", "0.00", "0.08"},
            {
                "LEGO Rock Band", "Wii", "2009", "Misc", "Warner Bros. Interactive Entertainment", "0.41", "0.21", "0.00",
                "0.06"
            },
            {"Taiko no Tatsujin Wii", "Wii", "2008", "Misc", "Namco Bandai Games", "0.00", "0.00", "0.67", "0.00"},
            {"FIFA Soccer 13", "Wii", "2012", "Action", "Electronic Arts", "0.18", "0.42", "0.00", "0.07"},
            {
                "Summer Sports: Paradise Island (Others sales)", "Wii", "2008", "Sports", "Ubisoft", "0.00", "0.66", "0.00",
                "0.01"
            },
            {"Red Steel", "Wii", "2006", "Shooter", "Ubisoft", "0.54", "0.03", "0.04", "0.05"},
            {"Puzzler Brain Games", "Wii", "2012", "Misc", "Namco Bandai Games", "0.00", "0.00", "0.66", "0.00"},
            {"TV Show King Party", "Wii", "2008", "Puzzle", "Ubisoft", "0.18", "0.40", "0.00", "0.08"},
            {
                "Kirby's Dream Collection: Special Edition", "Wii", "2012", "Action", "Nintendo", "0.32", "0.00", "0.32",
                "0.02"
            },
            {"Country Dance", "Wii", "2011", "Misc", "Funbox Media", "0.57", "0.04", "0.00", "0.04"},
            {"Bakugan: Battle Brawlers", "Wii", "2009", "Action", "Activision", "0.58", "0.03", "0.00", "0.04"},
            {"The Biggest Loser: Challenge", "Wii", "2010", "Sports", "THQ", "0.48", "0.12", "0.00", "0.05"},
            {"007: Quantum of Solace", "Wii", "2008", "Action", "Activision", "0.29", "0.27", "0.01", "0.07"},
            {"Real Heroes: Firefighter", "Wii", "2009", "Action", "Rondomedia", "0.55", "0.03", "0.00", "0.05"},
            {
                "Disney Sing It: Party Hits", "Wii", "2010", "Misc", "Disney Interactive Studios", "0.48", "0.10", "0.00",
                "0.04"
            },
            {"Cabela's Big Game Hunter (2008)", "Wii", "2007", "Sports", "Activision", "0.57", "0.00", "0.00", "0.05"},
            {"New Play Control! Pikmin", "Wii", "2008", "Strategy", "Nintendo", "0.28", "0.11", "0.19", "0.04"},
            {"Disney Tangled", "Wii", "2010", "Action", "Disney Interactive Studios", "0.45", "0.13", "0.00", "0.05"},
            {"Family Feud: 2010 Edition", "Wii", "2009", "Misc", "Ubisoft", "0.58", "0.00", "0.00", "0.04"},
            {"The Last Story", "Wii", "2011", "Role-Playing", "Nintendo", "0.27", "0.12", "0.18", "0.04"},
            {"Donkey Kong Barrel Blast", "Wii", "2007", "Racing", "Nintendo", "0.19", "0.26", "0.11", "0.06"},
            {"Just Dance 2015", "Wii", "2014", "Misc", "Ubisoft", "0.32", "0.24", "0.00", "0.05"},
            {"SpongeBob's Atlantis SquarePantis", "Wii", "2007", "Adventure", "THQ", "0.56", "0.00", "0.00", "0.04"},
            {"Need For Speed: Undercover", "Wii", "2008", "Racing", "Electronic Arts", "0.26", "0.28", "0.00", "0.07"},
            {"Red Steel 2", "Wii", "2010", "Shooter", "Ubisoft", "0.34", "0.20", "0.01", "0.06"},
            {"Rock Band 3", "Wii", "2010", "Misc", "MTV Games", "0.51", "0.05", "0.00", "0.04"},
            {"DJ Hero 2", "Wii", "2010", "Misc", "Activision", "0.48", "0.09", "0.00", "0.04"},
            {"Metroid Prime: Trilogy", "Wii", "2009", "Shooter", "Nintendo", "0.42", "0.04", "0.00", "0.14"},
            {"Cabela's Monster Buck Hunter", "Wii", "2010", "Sports", "Activision", "0.57", "0.00", "0.00", "0.03"},
            {"The Golden Compass", "Wii", "N/A", "Action", "Sega", "0.26", "0.28", "0.00", "0.07"},
            {"The Black Eyed Peas Experience", "Wii", "2011", "Misc", "Ubisoft", "0.36", "0.18", "0.00", "0.06"},
            {"Pac-Man Party", "Wii", "2010", "Misc", "Namco Bandai Games", "0.47", "0.08", "0.01", "0.04"},
            {
                "Disney TH!NK Fast: The Ultimate Trivia Showdown", "Wii", "2008", "Misc", "Disney Interactive Studios",
                "0.37", "0.16", "0.01", "0.06"
            },
            {
                "New Play Control! Donkey Kong Jungle Beat", "Wii", "2008", "Platform", "Nintendo", "0.23", "0.16", "0.14",
                "0.05"
            },
            {
                "Muramasa: The Demon Blade", "Wii", "2009", "Role-Playing", "Rising Star Games", "0.31", "0.12", "0.11",
                "0.04"
            },
            {"World of Zoo", "Wii", "2009", "Simulation", "THQ", "0.39", "0.14", "0.00", "0.05"},
            {"Top Spin 3", "Wii", "2008", "Sports", "Take-Two Interactive", "0.15", "0.36", "0.00", "0.07"},
            {"Iron Man", "Wii", "2008", "Action", "Sega", "0.30", "0.22", "0.00", "0.06"},
            {"New Carnival Games", "Wii", "2010", "Misc", "Take-Two Interactive", "0.32", "0.20", "0.00", "0.05"},
            {
                "Disney Sing It: Family Hits", "Wii", "2010", "Misc", "Disney Interactive Studios", "0.37", "0.16", "0.00",
                "0.05"
            },
            {"Okami", "Wii", "2008", "Adventure", "Capcom", "0.42", "0.07", "0.04", "0.05"},
            {
                "Disney Sing It! High School Musical 3: Senior Year", "Wii", "2008", "Misc", "Disney Interactive Studios",
                "0.31", "0.22", "0.00", "0.04"
            },
            {
                "Go Diego Go! Great Dinosaur Rescue", "Wii", "2008", "Action", "Take-Two Interactive", "0.52", "0.01",
                "0.00", "0.04"
            },
            {"Petz Dogz 2", "Wii", "2007", "Simulation", "Ubisoft", "0.52", "0.01", "0.00", "0.04"},
            {"Skate it", "Wii", "2008", "Sports", "Electronic Arts", "0.49", "0.03", "0.00", "0.04"},
            {"Guitar Hero: Smash Hits", "Wii", "2009", "Misc", "Activision", "0.30", "0.20", "0.00", "0.06"},
            {"Jeopardy!", "Wii", "2010", "Misc", "THQ", "0.53", "0.00", "0.00", "0.03"},
            {"Rapala: We Fish", "Wii", "2009", "Sports", "Activision", "0.51", "0.01", "0.00", "0.04"},
            {"Bolt", "Wii", "2008", "Adventure", "Disney Interactive Studios", "0.18", "0.31", "0.00", "0.06"},
            {"Cabela's Dangerous Hunts 2011", "Wii", "2010", "Sports", "Activision", "0.51", "0.01", "0.00", "0.03"},
            {"The Conduit", "Wii", "2009", "Shooter", "Sega", "0.28", "0.22", "0.00", "0.06"},
            {"Up", "Wii", "2009", "Adventure", "THQ", "0.22", "0.28", "0.00", "0.06"},
            {"New Play Control! Pikmin 2", "Wii", "2009", "Strategy", "Nintendo", "0.10", "0.13", "0.31", "0.02"},
            {"Trivial Pursuit", "Wii", "2009", "Misc", "Electronic Arts", "0.19", "0.30", "0.00", "0.07"},
            {
                "Jillian Michaels Fitness Ultimatum 2010", "Wii", "2009", "Sports", "Majesco Entertainment", "0.51", "0.01",
                "0.00", "0.04"
            },
            {
                "The Legend of Spyro: Dawn of the Dragon", "Wii", "2008", "Platform", "Vivendi Games", "0.34", "0.16",
                "0.00", "0.05"
            },
            {"Rapala Tournament Fishing!", "Wii", "2006", "Sports", "Activision", "0.51", "0.00", "0.00", "0.04"},
            {"Tetris Party Deluxe", "Wii", "2010", "Puzzle", "Nintendo", "0.32", "0.16", "0.02", "0.05"},
            {
                "Dora The Explorer: Dora Saves the Snow Princess", "Wii", "2008", "Platform", "Take-Two Interactive",
                "0.49", "0.02", "0.00", "0.04"
            },
            {
                "Phineas and Ferb: Across the 2nd Dimension", "Wii", "2011", "Action", "Disney Interactive Studios", "0.34",
                "0.16", "0.00", "0.05"
            },
            {"No More Heroes", "Wii", "2007", "Action", "Rising Star Games", "0.29", "0.17", "0.04", "0.05"},
            {"Transformers: The Game", "Wii", "2007", "Action", "Activision", "0.48", "0.02", "0.00", "0.04"},
            {"Madagascar: Escape 2 Africa", "Wii", "2008", "Action", "Activision", "0.31", "0.18", "0.00", "0.05"},
            {
                "Are You Smarter than a 5th Grader? Make the Grade", "Wii", "2008", "Misc", "THQ", "0.50", "0.00", "0.00",
                "0.04"
            },
            {
                "System 3 presents Ferrari Challenge Trofeo Pirelli", "Wii", "2008", "Racing", "System 3 Arcade Software",
                "0.07", "0.40", "0.00", "0.07"
            },
            {"Skylanders: Trap Team", "Wii", "2014", "Action", "Activision", "0.30", "0.18", "0.00", "0.05"},
            {"Grease", "Wii", "2010", "Misc", "505 Games", "0.25", "0.23", "0.00", "0.05"},
            {"Tiger Woods PGA Tour 11", "Wii", "2010", "Sports", "Electronic Arts", "0.23", "0.25", "0.00", "0.05"},
            {"Manhunt 2", "Wii", "2007", "Action", "Take-Two Interactive", "0.24", "0.23", "0.00", "0.06"},
            {"Summer Sports: Paradise Island", "Wii", "2008", "Sports", "Ubisoft", "0.48", "0.01", "0.00", "0.04"},
            {"Excite Truck", "Wii", "2006", "Racing", "Nintendo", "0.39", "0.02", "0.08", "0.04"},
            {
                "SpongeBob SquarePants Featuring Nicktoons: Globs of Doom", "Wii", "2008", "Action", "THQ", "0.49", "0.00",
                "0.00", "0.04"
            },
            {
                "Harry Potter and the Deathly Hallows - Part 1", "Wii", "2010", "Action", "Electronic Arts", "0.21", "0.26",
                "0.00", "0.05"
            },
            {
                "Tatsunoko vs. Capcom: Ultimate All-Stars", "Wii", "2010", "Fighting", "Capcom", "0.29", "0.15", "0.03",
                "0.05"
            },
            {"Tony Hawk: Shred", "Wii", "2010", "Sports", "Activision", "0.38", "0.10", "0.00", "0.04"},
            {"GT Pro Series", "Wii", "2006", "Racing", "Ubisoft", "0.46", "0.00", "0.02", "0.04"},
            {"Rayman Origins", "Wii", "2011", "Platform", "Ubisoft", "0.20", "0.26", "0.00", "0.06"},
            {"We Cheer", "Wii", "2008", "Simulation", "505 Games", "0.47", "0.00", "0.00", "0.04"},
            {
                "Tales of Symphonia: Dawn of the New World", "Wii", "2008", "Role-Playing", "Namco Bandai Games", "0.21",
                "0.04", "0.24", "0.02"
            },
            {"Monster Jam: Path of Destruction", "Wii", "2010", "Racing", "Activision", "0.47", "0.02", "0.00", "0.03"},
            {
                "Go Diego Go! Safari Rescue", "Wii", "2008", "Action", "Take-Two Interactive", "0.47", "0.00", "0.00",
                "0.04"
            },
            {
                "Pro Evolution Soccer 2010", "Wii", "2009", "Sports", "Konami Digital Entertainment", "0.12", "0.27",
                "0.06", "0.05"
            },
            {"Monster High: Ghoul Spirit", "Wii", "2011", "Adventure", "THQ", "0.40", "0.07", "0.00", "0.04"},
            {
                "Naruto Shippuden: Clash of Ninja Revolution III", "Wii", "2009", "Fighting", "Nintendo", "0.43", "0.03",
                "0.00", "0.04"
            },
            {"My Word Coach", "Wii", "2007", "Misc", "Ubisoft", "0.45", "0.01", "0.00", "0.04"},
            {
                "Alice in Wonderland", "Wii", "2010", "Adventure", "Disney Interactive Studios", "0.25", "0.20", "0.00",
                "0.05"
            },
            {
                "Bully: Scholarship Edition", "Wii", "2008", "Action", "Take-Two Interactive", "0.16", "0.27", "0.00",
                "0.06"
            },
            {"Ratatouille", "Wii", "2007", "Platform", "THQ", "0.43", "0.02", "0.00", "0.04"},
            {"Cars Mater-National Championship", "Wii", "2007", "Racing", "THQ", "0.46", "0.00", "0.00", "0.04"},
            {"Madden NFL 07", "Wii", "2006", "Sports", "Electronic Arts", "0.45", "0.00", "0.00", "0.04"},
            {"Sega Bass Fishing", "Wii", "2008", "Sports", "Sega", "0.44", "0.01", "0.00", "0.03"},
            {
                "Cars Toon: Mater's Tall Tales", "Wii", "2010", "Misc", "Disney Interactive Studios", "0.44", "0.02",
                "0.00", "0.03"
            },
            {"Babysitting Mama", "Wii", "2010", "Simulation", "505 Games", "0.33", "0.12", "0.00", "0.04"},
            {
                "SpongeBob SquarePants: Creature from the Krusty Krab", "Wii", "2006", "Platform", "THQ", "0.44", "0.01",
                "0.00", "0.04"
            },
            {"Dreamworks Madagascar Kartz", "Wii", "2009", "Racing", "Activision", "0.28", "0.15", "0.00", "0.05"},
            {"NBA 2K11", "Wii", "2010", "Sports", "Take-Two Interactive", "0.45", "0.01", "0.00", "0.03"},
            {"Fire Emblem: Radiant Dawn", "Wii", "2007", "Strategy", "Nintendo", "0.26", "0.03", "0.17", "0.03"},
            {"Boogie", "Wii", "2007", "Misc", "Electronic Arts", "0.43", "0.01", "0.00", "0.04"},
            {"Ultimate I Spy", "Wii", "2008", "Adventure", "Scholastic Inc.", "0.44", "0.00", "0.00", "0.03"},
            {"Madden NFL 13", "Wii", "2012", "Sports", "Electronic Arts", "0.45", "0.00", "0.00", "0.03"},
            {
                "Dragon Quest 25 Shuunen Kinin: Famicom & Super Famicom Dragon Quest I-II-III", "Wii", "2011",
                "Role-Playing", "Square Enix", "0.00", "0.00", "0.47", "0.00"
            },
            {
                "Transformers: Revenge of the Fallen", "Wii", "2009", "Action", "Activision", "0.23", "0.19", "0.00",
                "0.05"
            },
            {"Ford Racing Off Road", "Wii", "2008", "Racing", "Xplosiv", "0.06", "0.39", "0.00", "0.01"},
            {"Spider-Man 3", "Wii", "2007", "Platform", "Activision", "0.42", "0.02", "0.00", "0.04"},
            {"MySims Racing", "Wii", "2009", "Racing", "Electronic Arts", "0.19", "0.23", "0.00", "0.05"},
            {"Bass Pro Shops: The Strike", "Wii", "2009", "Sports", "XS Games", "0.44", "0.00", "0.00", "0.03"},
            {"Emergency Heroes", "Wii", "2008", "Racing", "Ubisoft", "0.14", "0.27", "0.00", "0.05"},
            {"The Sims 2: Pets", "Wii", "2007", "Simulation", "Electronic Arts", "0.41", "0.02", "0.00", "0.04"},
            {"Tiger Woods PGA Tour 07", "Wii", "N/A", "Sports", "Electronic Arts", "0.42", "0.00", "0.00", "0.04"},
            {"FlingSmash", "Wii", "2010", "Action", "Nintendo", "0.36", "0.01", "0.07", "0.02"},
            {
                "Pinball Hall of Fame: The Williams Collection", "Wii", "2008", "Misc", "System 3 Arcade Software", "0.40",
                "0.03", "0.00", "0.04"
            },
            {
                "Active Life: Extreme Challenge", "Wii", "2009", "Sports", "Namco Bandai Games", "0.14", "0.27", "0.00",
                "0.06"
            },
            {"Petz Sports", "Wii", "2008", "Simulation", "Ubisoft", "0.42", "0.01", "0.00", "0.03"},
            {"Dead Space Extraction", "Wii", "2009", "Shooter", "Electronic Arts", "0.31", "0.10", "0.01", "0.04"},
            {
                "Silent Hill: Shattered Memories", "Wii", "2009", "Adventure", "Konami Digital Entertainment", "0.22",
                "0.18", "0.01", "0.05"
            },
            {"Fortune Street", "Wii", "2011", "Misc", "Nintendo", "0.24", "0.03", "0.17", "0.02"},
            {"SimCity Creator", "Wii", "2008", "Simulation", "Electronic Arts", "0.36", "0.02", "0.04", "0.04"},
            {
                "Karaoke Revolution Presents American Idol Encore", "Wii", "2008", "Misc", "Konami Digital Entertainment",
                "0.42", "0.00", "0.00", "0.03"
            },
            {"Barbie as The Island Princess", "Wii", "2007", "Adventure", "Activision", "0.42", "0.00", "0.00", "0.03"},
            {
                "Harry Potter and the Order of the Phoenix", "Wii", "2007", "Adventure", "Electronic Arts", "0.37", "0.04",
                "0.00", "0.04"
            },
            {"Boom Blox Bash Party", "Wii", "2009", "Puzzle", "Electronic Arts", "0.33", "0.08", "0.00", "0.04"},
            {"WWE SmackDown vs. Raw 2011", "Wii", "2010", "Fighting", "THQ", "0.29", "0.12", "0.00", "0.04"},
            {"Need for Speed: Hot Pursuit", "Wii", "2010", "Racing", "Electronic Arts", "0.17", "0.23", "0.00", "0.05"},
            {
                "PES 2009: Pro Evolution Soccer", "Wii", "2009", "Sports", "Konami Digital Entertainment", "0.09", "0.26",
                "0.05", "0.05"
            },
            {
                "The Princess and the Frog", "Wii", "2009", "Platform", "Disney Interactive Studios", "0.28", "0.13",
                "0.00", "0.04"
            },
            {"Country Dance 2", "Wii", "2011", "Misc", "GameMill Entertainment", "0.42", "0.00", "0.00", "0.02"},
            {
                "Scooby-Doo! and the Spooky Swamp", "Wii", "2010", "Action", "Warner Bros. Interactive Entertainment",
                "0.28", "0.12", "0.00", "0.04"
            },
            {
                "Pirates of the Caribbean: At World's End", "Wii", "2007", "Action", "Disney Interactive Studios", "0.38",
                "0.02", "0.01", "0.04"
            },
            {"iCarly", "Wii", "2009", "Adventure", "Activision", "0.42", "0.00", "0.00", "0.03"},
            {"Celebrity Sports Showdown", "Wii", "2008", "Sports", "Electronic Arts", "0.18", "0.22", "0.00", "0.05"},
            {"Crash of the Titans", "Wii", "2007", "Action", "Vivendi Games", "0.39", "0.02", "0.00", "0.04"},
            {"Tomb Raider: Underworld", "Wii", "2008", "Adventure", "Eidos Interactive", "0.13", "0.26", "0.00", "0.05"},
            {"Rock Band Country Track Pack", "Wii", "2009", "Misc", "MTV Games", "0.41", "0.00", "0.00", "0.03"},
            {"Family Fest Presents Circus Games", "Wii", "2008", "Misc", "Ubisoft", "0.10", "0.29", "0.00", "0.05"},
            {"Petz: Catz 2", "Wii", "2007", "Simulation", "Ubisoft", "0.40", "0.01", "0.00", "0.03"},
            {
                "Dance Dance Revolution: Hottest Party 3", "Wii", "2009", "Simulation", "Konami Digital Entertainment",
                "0.26", "0.14", "0.00", "0.04"
            },
            {"G-Force", "Wii", "2009", "Action", "Disney Interactive Studios", "0.19", "0.20", "0.00", "0.05"},
            {"Disney Guilty Party", "Wii", "2010", "Misc", "Disney Interactive Studios", "0.41", "0.00", "0.00", "0.02"},
            {"Jump Start Pet Rescue", "Wii", "2009", "Misc", "Knowledge Adventure", "0.40", "0.00", "0.00", "0.03"},
            {
                "Food Network: Cook or Be Cooked", "Wii", "2009", "Misc", "Namco Bandai Games", "0.40", "0.00", "0.00",
                "0.03"
            },
            {
                "Ben 10 Alien Force: Vilgax Attacks", "Wii", "2009", "Action", "D3Publisher", "0.25", "0.14", "0.00",
                "0.04"
            },
            {"Nicktoons: Attack of the Toybots", "Wii", "2007", "Platform", "THQ", "0.40", "0.00", "0.00", "0.03"},
            {
                "Karaoke Revolution", "Wii", "2009", "Misc", "Konami Digital Entertainment", "0.24", "0.15", "0.00", "0.04"
            },
            {"Samurai Warriors 3", "Wii", "2009", "Action", "Nintendo", "0.08", "0.02", "0.32", "0.01"},
            {"Thrillville: Off the Rails", "Wii", "2007", "Strategy", "LucasArts", "0.38", "0.02", "0.00", "0.03"},
            {"We Sing Encore", "Wii", "2010", "Misc", "Nordic Games", "0.00", "0.37", "0.00", "0.06"},
            {"Madden NFL 12", "Wii", "2011", "Sports", "Electronic Arts", "0.40", "0.00", "0.00", "0.02"},
            {"Walk it Out!", "Wii", "2010", "Sports", "Konami Digital Entertainment", "0.34", "0.04", "0.00", "0.03"},
            {"NASCAR Kart Racing", "Wii", "2009", "Racing", "Electronic Arts", "0.39", "0.00", "0.00", "0.03"},
            {"Petz: Horsez 2", "Wii", "2007", "Simulation", "Ubisoft", "0.39", "0.00", "0.00", "0.03"},
            {
                "2010 FIFA World Cup South Africa", "Wii", "2010", "Sports", "Electronic Arts", "0.22", "0.15", "0.01",
                "0.04"
            },
            {
                "Zack & Wiki: Quest for Barbaros' Treasure", "Wii", "2007", "Adventure", "Nintendo", "0.18", "0.16", "0.03",
                "0.04"
            },
            {"Remington Great American Bird Hunt", "Wii", "2009", "Sports", "Mastiff", "0.39", "0.00", "0.00", "0.03"},
            {"How to Train Your Dragon", "Wii", "2010", "Action", "Activision", "0.23", "0.14", "0.00", "0.04"},
            {"Sin and Punishment: Star Successor", "Wii", "2009", "Shooter", "Nintendo", "0.19", "0.13", "0.06", "0.03"},
            {
                "Monotaro Dentetsu 2010: Sengoku Ishin no Hero Daishuugou! no Maki", "Wii", "2009", "Misc", "Hudson Soft",
                "0.00", "0.00", "0.41", "0.00"
            },
            {"NHL Slapshot", "Wii", "N/A", "Sports", "Unknown", "0.39", "0.00", "0.00", "0.02"},
            {"Just Dance: Summer Party", "Wii", "2011", "Misc", "Ubisoft", "0.39", "0.00", "0.00", "0.02"},
            {
                "JumpStart: Escape from Adventure Island", "Wii", "2009", "Adventure", "Knowledge Adventure", "0.38",
                "0.00", "0.00", "0.03"
            },
            {"Crash: Mind Over Mutant", "Wii", "2008", "Platform", "Vivendi Games", "0.35", "0.03", "0.00", "0.03"},
            {"Medal of Honor Heroes 2", "Wii", "2007", "Shooter", "Electronic Arts", "0.33", "0.03", "0.01", "0.03"},
            {
                "Taiko no Tatsujin Wii: Dodon to 2 Yome!", "Wii", "2009", "Misc", "Namco Bandai Games", "0.00", "0.00",
                "0.40", "0.00"
            },
            {"Six Flags Fun Park", "Wii", "2009", "Misc", "Ubisoft", "0.27", "0.09", "0.00", "0.04"},
            {"Monster Jam: Urban Assault", "Wii", "2008", "Racing", "Activision", "0.37", "0.00", "0.00", "0.03"},
            {"NiGHTS: Journey of Dreams", "Wii", "2007", "Platform", "Sega", "0.32", "0.02", "0.04", "0.03"},
            {"Marvel: Ultimate Alliance", "Wii", "2006", "Role-Playing", "Activision", "0.36", "0.00", "0.00", "0.03"},
            {"Monster Trucks Mayhem", "Wii", "2009", "Racing", "Zoo Games", "0.37", "0.00", "0.00", "0.02"},
            {"SpongeBob SquigglePants", "Wii", "2011", "Misc", "THQ", "0.35", "0.02", "0.00", "0.02"},
            {"Winter Sports 2: The Next Challenge", "Wii", "2008", "Sports", "RTL", "0.17", "0.18", "0.00", "0.04"},
            {
                "Taiko no Tatsujin Wii: Ketteiban", "Wii", "2011", "Misc", "Namco Bandai Games", "0.00", "0.00", "0.39",
                "0.00"
            },
            {
                "Speed Racer: The Videogame", "Wii", "2008", "Racing", "Warner Bros. Interactive Entertainment", "0.35",
                "0.01", "0.00", "0.03"
            },
            {"Littlest Pet Shop", "Wii", "2008", "Simulation", "Electronic Arts", "0.33", "0.03", "0.00", "0.03"},
            {"NBA 2K13", "Wii", "2012", "Action", "Take-Two Interactive", "0.34", "0.03", "0.00", "0.02"},
            {"Spore Hero", "Wii", "2009", "Simulation", "Electronic Arts", "0.34", "0.02", "0.00", "0.03"},
            {"NBA Jam", "Wii", "2010", "Sports", "Electronic Arts", "0.35", "0.02", "0.00", "0.02"},
            {"Hooked! Again: Real Motion Fishing", "Wii", "2009", "Sports", "505 Games", "0.36", "0.00", "0.00", "0.03"},
            {
                "Final Fantasy Crystal Chronicles: The Crystal Bearers", "Wii", "2009", "Adventure", "Square Enix", "0.20",
                "0.07", "0.08", "0.03"
            },
            {
                "No More Heroes 2: Desperate Struggle", "Wii", "2010", "Action", "Rising Star Games", "0.20", "0.11",
                "0.04", "0.03"
            },
            {"SpongeBob's Truth or Square (US sales)", "Wii", "2009", "Action", "THQ", "0.37", "0.01", "0.00", "0.00"},
            {"Dance Party: Pop Hits", "Wii", "2009", "Misc", "Nordic Games", "0.00", "0.36", "0.00", "0.02"},
            {"Super Monkey Ball: Step & Roll", "Wii", "2010", "Action", "Sega", "0.15", "0.19", "0.00", "0.04"},
            {"Brunswick Pro Bowling", "Wii", "2007", "Sports", "505 Games", "0.35", "0.00", "0.00", "0.03"},
            {
                "Naruto: Clash of Ninja Revolution 2", "Wii", "2008", "Fighting", "Tomy Corporation", "0.34", "0.01",
                "0.00", "0.03"
            },
            {"The Dog Island", "Wii", "2007", "Adventure", "Ubisoft", "0.34", "0.01", "0.00", "0.03"},
            {
                "Cabela's Dangerous Hunts 2009", "Wii", "2008", "Sports", "Activision Value", "0.35", "0.00", "0.00",
                "0.03"
            },
            {"Disney Princess: Enchanting Storybooks", "Wii", "2011", "Misc", "THQ", "0.25", "0.09", "0.00", "0.03"},
            {"Fishing Resort", "Wii", "2011", "Sports", "Namco Bandai Games", "0.12", "0.00", "0.25", "0.01"},
            {"Dancing with the Stars: We Dance!", "Wii", "2008", "Misc", "Activision", "0.34", "0.00", "0.00", "0.03"},
            {"Peppa Pig: The Game", "Wii", "2009", "Misc", "Pinnacle", "0.00", "0.34", "0.00", "0.03"},
            {"Rec Room Games", "Wii", "2009", "Sports", "Destineer", "0.35", "0.00", "0.00", "0.02"},
            {"NBA 2K10", "Wii", "2009", "Sports", "Take-Two Interactive", "0.34", "0.00", "0.00", "0.03"},
            {"The BIGS", "Wii", "2007", "Sports", "Take-Two Interactive", "0.34", "0.00", "0.00", "0.03"},
            {"FIFA Soccer 14", "Wii", "2013", "Sports", "Electronic Arts", "0.00", "0.32", "0.00", "0.05"},
            {"DiRT 2", "Wii", "2009", "Racing", "Codemasters", "0.10", "0.22", "0.00", "0.04"},
            {"Imagine: Party Babyz", "Wii", "2008", "Simulation", "Ubisoft", "0.32", "0.01", "0.00", "0.03"},
            {"Overlord: Dark Legend", "Wii", "2009", "Adventure", "Codemasters", "0.10", "0.22", "0.00", "0.04"},
            {"Virtua Tennis 2009", "Wii", "2009", "Sports", "Sega", "0.12", "0.20", "0.00", "0.04"},
            {
                "Build-A-Bear Workshop: A Friend Fur All Seasons", "Wii", "2008", "Simulation", "Game Factory", "0.33",
                "0.00", "0.00", "0.03"
            },
            {"Mini Ninjas", "Wii", "2009", "Action", "Eidos Interactive", "0.16", "0.16", "0.00", "0.04"},
            {
                "Sesame Street: Elmo's A-to-Zoo Adventure", "Wii", "2010", "Misc", "Warner Bros. Interactive Entertainment",
                "0.34", "0.00", "0.00", "0.02"
            },
            {"Cabela's Big Game Hunter 2012", "Wii", "2011", "Sports", "Activision", "0.32", "0.02", "0.00", "0.02"},
            {
                "North American Hunting Extravaganza", "Wii", "2008", "Sports", "Zushi Games", "0.33", "0.00", "0.00",
                "0.03"
            },
            {
                "The Chronicles of Narnia: Prince Caspian", "Wii", "2008", "Action", "Disney Interactive Studios", "0.31",
                "0.02", "0.00", "0.03"
            },
            {"Green Day: Rock Band", "Wii", "2010", "Misc", "MTV Games", "0.21", "0.11", "0.00", "0.03"},
            {"U-Sing", "Wii", "2009", "Misc", "Mindscape", "0.00", "0.32", "0.00", "0.03"},
            {"Marvel Super Hero Squad", "Wii", "2009", "Adventure", "THQ", "0.30", "0.02", "0.00", "0.03"},
            {"Press Your Luck 2010 Edition", "Wii", "2009", "Misc", "Ubisoft", "0.33", "0.00", "0.00", "0.03"},
            {
                "Dragon Ball Z: Budokai Tenkaichi 2 (JP sales)", "Wii", "N/A", "Action", "N/A", "0.15", "0.05", "0.14",
                "0.01"
            },
            {"AMF Bowling World Lanes", "Wii", "2008", "Sports", "Bethesda Softworks", "0.32", "0.00", "0.00", "0.03"},
            {
                "Fragile Dreams: Farewell Ruins of the Moon", "Wii", "2009", "Role-Playing", "Rising Star Games", "0.16",
                "0.11", "0.06", "0.03"
            },
            {"WipeOut 3 The Game", "Wii", "2012", "Action", "Activision", "0.33", "0.00", "0.00", "0.02"},
            {
                "Rune Factory: Frontier", "Wii", "2008", "Role-Playing", "Rising Star Games", "0.15", "0.12", "0.04",
                "0.03"
            },
            {"NHL 2K10", "Wii", "2009", "Sports", "Take-Two Interactive", "0.32", "0.00", "0.00", "0.03"},
            {
                "Teenage Mutant Ninja Turtles: Smash-Up", "Wii", "2009", "Fighting", "Ubisoft", "0.32", "0.00", "0.00",
                "0.02"
            },
            {"Chicken Shoot", "Wii", "2007", "Action", "Zoo Digital Publishing", "0.32", "0.00", "0.00", "0.02"},
            {
                "Hannah Montana: The Movie", "Wii", "2009", "Adventure", "Disney Interactive Studios", "0.13", "0.17",
                "0.00", "0.04"
            },
            {"SpongeBob's Boating Bash", "Wii", "2010", "Misc", "THQ", "0.24", "0.07", "0.00", "0.03"},
            {
                "ZhuZhu Pets: Featuring The Wild Bunch", "Wii", "2010", "Simulation", "Activision", "0.28", "0.03", "0.00",
                "0.02"
            },
            {"Battalion Wars 2", "Wii", "2007", "Strategy", "Nintendo", "0.21", "0.02", "0.08", "0.02"},
            {"Trauma Center: Second Opinion", "Wii", "2006", "Simulation", "Nintendo", "0.27", "0.01", "0.03", "0.03"},
            {"WWE '12", "Wii", "2011", "Fighting", "THQ", "0.22", "0.08", "0.00", "0.03"},
            {"NBA 2K12", "Wii", "2011", "Sports", "Take-Two Interactive", "0.28", "0.03", "0.00", "0.02"},
            {"Hell's Kitchen: The Game", "Wii", "2008", "Simulation", "Ubisoft", "0.30", "0.00", "0.00", "0.03"},
            {
                "Tiger Woods PGA Tour 12: The Masters", "Wii", "2011", "Sports", "Electronic Arts", "0.19", "0.10", "0.00",
                "0.03"
            },
            {
                "Night at the Museum: Battle of the Smithsonian", "Wii", "2009", "Action", "Majesco Entertainment", "0.17",
                "0.13", "0.00", "0.03"
            },
            {
                "DanceDanceRevolution", "Wii", "2010", "Simulation", "Konami Digital Entertainment", "0.27", "0.03", "0.00",
                "0.02"
            },
            {"Bee Movie Game", "Wii", "2007", "Action", "Activision", "0.30", "0.00", "0.00", "0.03"},
            {"SSX Blur", "Wii", "2007", "Sports", "Electronic Arts", "0.29", "0.01", "0.00", "0.03"},
            {"The X-Factor", "Wii", "2010", "Misc", "Deep Silver", "0.00", "0.28", "0.00", "0.04"},
            {"Elebits", "Wii", "2006", "Action", "Konami Digital Entertainment", "0.22", "0.01", "0.08", "0.02"},
            {"Iron Man 2", "Wii", "2010", "Action", "Sega", "0.15", "0.14", "0.00", "0.03"},
            {
                "Family Party: 90 Great Games Party Pack", "Wii", "2010", "Misc", "D3Publisher", "0.30", "0.00", "0.00",
                "0.02"
            },
            {"MX vs. ATV Untamed", "Wii", "2008", "Racing", "THQ", "0.27", "0.02", "0.00", "0.02"},
            {"Marvel: Ultimate Alliance 2", "Wii", "2009", "Role-Playing", "Activision", "0.25", "0.04", "0.00", "0.03"},
            {
                "Dragon Quest Monsters: Battle Road Victory", "Wii", "2010", "Strategy", "Square Enix", "0.00", "0.00",
                "0.32", "0.00"
            },
            {"TMNT", "Wii", "2007", "Action", "Ubisoft", "0.27", "0.03", "0.00", "0.02"},
            {
                "Karaoke Revolution Presents American Idol Encore 2", "Wii", "2008", "Misc", "Konami Digital Entertainment",
                "0.29", "0.00", "0.00", "0.02"
            },
            {"Bleach: Shattered Blade", "Wii", "2006", "Fighting", "Sega", "0.21", "0.01", "0.08", "0.02"},
            {
                "Bigfoot: Collision Course", "Wii", "2008", "Racing", "Zoo Digital Publishing", "0.29", "0.00", "0.00",
                "0.02"
            },
            {
                "Harry Potter and the Deathly Hallows - Part 2", "Wii", "2011", "Action", "Electronic Arts", "0.17", "0.12",
                "0.00", "0.03"
            },
            {"Fishing Master", "Wii", "2007", "Misc", "Konami Digital Entertainment", "0.29", "0.00", "0.00", "0.02"},
            {"Monster Lab", "Wii", "2008", "Role-Playing", "Eidos Interactive", "0.27", "0.02", "0.00", "0.02"},
            {"Chicken Blaster", "Wii", "2009", "Shooter", "Zushi Games", "0.29", "0.00", "0.00", "0.02"},
            {"Wipeout 2", "Wii", "2011", "Misc", "Activision", "0.29", "0.00", "0.00", "0.02"},
            {
                "Gold's Gym: Cardio Workout (Others sales)", "Wii", "2008", "Sports", "Ubisoft", "0.00", "0.29", "0.00",
                "0.02"
            },
            {"The Adventures of Tintin: The Game", "Wii", "2011", "Action", "Ubisoft", "0.11", "0.16", "0.00", "0.04"},
            {"Def Jam Rapstar", "Wii", "2010", "Misc", "Konami Digital Entertainment", "0.27", "0.02", "0.00", "0.02"},
            {"Birthday Party Bash", "Wii", "2009", "Misc", "Take-Two Interactive", "0.29", "0.00", "0.00", "0.02"},
            {"My Horse & Me", "Wii", "2007", "Sports", "Atari", "0.27", "0.01", "0.00", "0.02"},
            {"The Incredible Hulk", "Wii", "2008", "Action", "Sega", "0.27", "0.01", "0.00", "0.02"},
            {"Shrek's Carnival Craze Party Games", "Wii", "2008", "Misc", "Activision", "0.28", "0.00", "0.00", "0.02"},
            {"SimAnimals", "Wii", "2009", "Simulation", "Electronic Arts", "0.14", "0.13", "0.00", "0.03"},
            {
                "Cabela's Outdoor Adventures (2009)", "Wii", "2009", "Sports", "Activision Value", "0.28", "0.00", "0.00",
                "0.02"
            },
            {"Calvin Tucker's Redneck Jamboree", "Wii", "2008", "Misc", "Zoo Games", "0.28", "0.00", "0.00", "0.02"},
            {"Chicken Riot", "Wii", "2010", "Action", "City Interactive", "0.14", "0.13", "0.00", "0.03"},
            {
                "Taiko no Tatsujin Wii: Minna de Party * 3-Yome!", "Wii", "2010", "Misc", "Namco Bandai Games", "0.00",
                "0.00", "0.30", "0.00"
            },
            {"Wacky Races: Crash & Dash", "Wii", "2008", "Racing", "Eidos Interactive", "0.27", "0.00", "0.00", "0.02"},
            {"Power Rangers Samurai", "Wii", "2011", "Action", "Namco Bandai Games", "0.25", "0.02", "0.00", "0.02"},
            {"Pandora's Tower", "Wii", "2011", "Role-Playing", "Nintendo", "0.10", "0.10", "0.08", "0.02"},
            {"Resident Evil Archives: Resident Evil", "Wii", "2008", "Action", "Capcom", "0.15", "0.04", "0.08", "0.02"},
            {"Prince of Persia: Rival Swords", "Wii", "2007", "Action", "Ubisoft", "0.24", "0.02", "0.00", "0.02"},
            {
                "Puzzle Quest: Challenge of the Warlords", "Wii", "2007", "Puzzle", "D3Publisher", "0.26", "0.00", "0.00",
                "0.02"
            },
            {"MLB Power Pros", "Wii", "2007", "Sports", "Konami Digital Entertainment", "0.22", "0.00", "0.04", "0.02"},
            {"MySims SkyHeroes", "Wii", "2010", "Action", "Electronic Arts", "0.16", "0.10", "0.00", "0.02"},
            {"The BIGS 2", "Wii", "2009", "Sports", "Take-Two Interactive", "0.26", "0.01", "0.00", "0.02"},
            {"We Sing Deutsche Hits", "Wii", "2011", "Misc", "Nordic Games", "0.00", "0.24", "0.00", "0.05"},
            {"Little King's Story", "Wii", "2009", "Strategy", "Rising Star Games", "0.14", "0.10", "0.02", "0.02"},
            {"Purr Pals", "Wii", "2008", "Simulation", "Deep Silver", "0.26", "0.00", "0.00", "0.02"},
            {"Dead Rising: Chop Till You Drop", "Wii", "2009", "Action", "Capcom", "0.15", "0.07", "0.05", "0.02"},
            {"Trauma Center: New Blood", "Wii", "2007", "Simulation", "Nintendo", "0.21", "0.03", "0.01", "0.02"},
            {"Just Dance Wii 2", "Wii", "2012", "Action", "Nintendo", "0.00", "0.00", "0.28", "0.00"},
            {"Shrek: Forever After", "Wii", "2010", "Platform", "Activision", "0.17", "0.09", "0.00", "0.02"},
            {"Sengoku Basara: Samurai Heroes", "Wii", "2010", "Action", "Capcom", "0.06", "0.01", "0.20", "0.01"},
            {
                "One Piece Unlimited Cruise 2: Awakening of a Hero", "Wii", "2009", "Adventure", "Namco Bandai Games",
                "0.00", "0.09", "0.17", "0.02"
            },
            {"Shrek the Third", "Wii", "2007", "Action", "Activision", "0.25", "0.01", "0.00", "0.02"},
            {"Dragon Ball Z: Budokai Tenkaichi 2", "Wii", "2006", "Fighting", "Atari", "0.23", "0.02", "0.00", "0.02"},
            {
                "Shaun White Snowboarding: World Stage", "Wii", "2009", "Sports", "Ubisoft", "0.23", "0.03", "0.00", "0.02"
            },
            {
                "Karaoke Revolution Glee: Volume 3", "Wii", "2011", "Misc", "Konami Digital Entertainment", "0.22", "0.04",
                "0.00", "0.02"
            },
            {
                "Ben 10 Ultimate Alien: Cosmic Destruction", "Wii", "2010", "Platform", "D3Publisher", "0.16", "0.09",
                "0.00", "0.02"
            },
            {"ExerBeat", "Wii", "2010", "Sports", "Namco Bandai Games", "0.10", "0.14", "0.00", "0.03"},
            {"Guitar Hero: Van Halen", "Wii", "2009", "Misc", "Activision", "0.12", "0.12", "0.00", "0.03"},
            {
                "Disney Channel: All Star Party", "Wii", "2010", "Misc", "Disney Interactive Studios", "0.17", "0.08",
                "0.00", "0.02"
            },
            {"CSI: Deadly Intent", "Wii", "2009", "Adventure", "Ubisoft", "0.12", "0.13", "0.00", "0.03"},
            {"Avatar: The Last Airbender", "Wii", "2006", "Adventure", "THQ", "0.23", "0.02", "0.00", "0.02"},
            {
                "Harvest Moon: Magical Melody", "Wii", "2008", "Simulation", "Rising Star Games", "0.22", "0.03", "0.00",
                "0.02"
            },
            {"Reel Fishing: Angler's Dream", "Wii", "2009", "Sports", "Zushi Games", "0.24", "0.01", "0.00", "0.02"},
            {"Rapala Pro Bass Fishing 2010", "Wii", "2010", "Sports", "Activision", "0.20", "0.05", "0.00", "0.02"},
            {"Ice Age: Dawn of the Dinosaurs", "Wii", "2009", "Platform", "Activision", "0.11", "0.13", "0.00", "0.03"},
            {
                "Sesame Street: Cookie's Counting Carnival", "Wii", "2010", "Misc",
                "Warner Bros. Interactive Entertainment", "0.25", "0.00", "0.00", "0.01"
            },
            {
                "One Piece Unlimited Cruise 1: The Treasure Beneath the Waves", "Wii", "2008", "Adventure",
                "Namco Bandai Games", "0.00", "0.06", "0.19", "0.01"
            },
            {
                "Transformers: Cybertron Adventures", "Wii", "2010", "Action", "Activision", "0.14", "0.10", "0.00", "0.02"
            },
            {"Remington Super Slam Hunting: Africa", "Wii", "2010", "Sports", "Mastiff", "0.25", "0.00", "0.00", "0.01"},
            {"AC/DC LIVE: Rock Band Track Pack", "Wii", "2008", "Misc", "MTV Games", "0.24", "0.00", "0.00", "0.02"},
            {
                "Are You Smarter than a 5th Grader? Game Time", "Wii", "2009", "Puzzle", "THQ", "0.24", "0.00", "0.00",
                "0.02"
            },
            {
                "Batman: The Brave and the Bold the Videogame", "Wii", "2010", "Action",
                "Warner Bros. Interactive Entertainment", "0.19", "0.05", "0.00", "0.02"
            },
            {"NHL 2K11", "Wii", "2010", "Sports", "Take-Two Interactive", "0.23", "0.02", "0.00", "0.02"},
            {"Inazuma Eleven Strikers", "Wii", "2011", "Role-Playing", "Nintendo", "0.00", "0.01", "0.25", "0.00"},
            {
                "Summer Athletics: The Ultimate Challenge (US sales)", "Wii", "2008", "Sports", "DTP Entertainment", "0.23",
                "0.03", "0.00", "0.00"
            },
            {"The Smurfs: Dance Party", "Wii", "2011", "Misc", "Ubisoft", "0.20", "0.04", "0.00", "0.02"},
            {"Need for Speed: The Run", "Wii", "2011", "Racing", "Electronic Arts", "0.11", "0.12", "0.01", "0.03"},
            {
                "Major League Baseball 2K10", "Wii", "2010", "Sports", "Take-Two Interactive", "0.24", "0.00", "0.00",
                "0.02"
            },
            {
                "Major League Baseball 2K9", "Wii", "2009", "Sports", "Take-Two Interactive", "0.24", "0.00", "0.00",
                "0.02"
            },
            {"Punch-Out!!", "Wii", "2007", "Sports", "Nintendo", "0.00", "0.21", "0.05", "0.00"},
            {"Bratz: The Movie", "Wii", "2007", "Simulation", "THQ", "0.23", "0.01", "0.00", "0.02"},
            {"Summer Sports 2: Island Sports Party", "Wii", "2008", "Sports", "Ubisoft", "0.24", "0.00", "0.00", "0.02"},
            {
                "Mystery Case Files: The Malgrave Incident", "Wii", "2011", "Adventure", "Nintendo", "0.16", "0.07", "0.00",
                "0.02"
            },
            {
                "Dora the Explorer: Dora Saves the Crystal Kingdom", "Wii", "2009", "Misc", "Take-Two Interactive", "0.23",
                "0.00", "0.00", "0.02"
            },
            {
                "Scene It? Twilight", "Wii", "2009", "Misc", "Konami Digital Entertainment", "0.16", "0.07", "0.00", "0.02"
            },
            {
                "Marvel Super Hero Squad: The Infinity Gauntlet", "Wii", "2010", "Action", "THQ", "0.20", "0.03", "0.00",
                "0.02"
            },
            {"Imagine: Fashion Party", "Wii", "2009", "Simulation", "Ubisoft", "0.24", "0.00", "0.00", "0.02"},
            {"Don King Boxing", "Wii", "2009", "Sports", "Take-Two Interactive", "0.14", "0.09", "0.00", "0.03"},
            {"We Cheer 2", "Wii", "2009", "Simulation", "Namco Bandai Games", "0.24", "0.00", "0.00", "0.02"},
            {
                "Littlest Pet Shop: Friends", "Wii", "2009", "Simulation", "Electronic Arts", "0.21", "0.02", "0.00",
                "0.02"
            },
            {"Just Dance Kids 2", "Wii", "2011", "Misc", "Ubisoft", "0.24", "0.00", "0.00", "0.01"},
            {"Monsters vs. Aliens", "Wii", "2009", "Platform", "Activision", "0.14", "0.09", "0.00", "0.02"},
            {"Reload: Target Down", "Wii", "2010", "Shooter", "Mastiff", "0.24", "0.00", "0.00", "0.01"},
            {"Spider-Man: Web of Shadows", "Wii", "2008", "Action", "Activision", "0.22", "0.01", "0.00", "0.02"},
            {
                "Final Fantasy Crystal Chronicles: Echoes of Time", "Wii", "2009", "Role-Playing", "Square Enix", "0.13",
                "0.06", "0.05", "0.02"
            },
            {"Karaoke Joysound Wii", "Wii", "2008", "Misc", "Hudson Soft", "0.00", "0.00", "0.25", "0.00"},
            {"Tony Hawk's Proving Ground", "Wii", "2007", "Sports", "Activision", "0.22", "0.01", "0.00", "0.02"},
            {"WWII Aces", "Wii", "2008", "Simulation", "Destineer", "0.23", "0.00", "0.00", "0.01"},
            {"Monster Hunter G", "Wii", "2009", "Role-Playing", "Capcom", "0.00", "0.00", "0.25", "0.00"},
            {
                "Avatar: The Last Airbender - The Burning Earth", "Wii", "2007", "Action", "THQ", "0.23", "0.00", "0.00",
                "0.02"
            },
            {"X-Men Origins: Wolverine", "Wii", "2009", "Action", "Activision", "0.19", "0.04", "0.00", "0.02"},
            {"ExciteBots: Trick Racing", "Wii", "2009", "Racing", "Nintendo", "0.23", "0.00", "0.00", "0.02"},
            {"U-Sing: Girls Night", "Wii", "2010", "Misc", "Mindscape", "0.00", "0.21", "0.00", "0.04"},
            {"Daisy Fuentes Pilates", "Wii", "2009", "Sports", "505 Games", "0.16", "0.06", "0.00", "0.02"},
            {"I Spy: Spooky Mansion", "Wii", "2010", "Puzzle", "Storm City Games", "0.23", "0.00", "0.00", "0.01"},
            {"Dancing With The Stars", "Wii", "2007", "Misc", "Activision", "0.22", "0.00", "0.00", "0.02"},
            {"The Price is Right 2010 Edition", "Wii", "2009", "Misc", "Ubisoft", "0.22", "0.00", "0.00", "0.02"},
            {"Petz: Crazy Monkeyz", "Wii", "2008", "Simulation", "Ubisoft", "0.22", "0.00", "0.00", "0.02"},
            {"Project Runway", "Wii", "2010", "Simulation", "Atari", "0.22", "0.00", "0.00", "0.01"},
            {"Boogie SuperStar", "Wii", "2008", "Misc", "Electronic Arts", "0.20", "0.02", "0.00", "0.02"},
            {"Racquet Sports", "Wii", "2010", "Sports", "Ubisoft", "0.13", "0.08", "0.00", "0.02"},
            {"Minute to Win It", "Wii", "2010", "Misc", "Zoo Games", "0.22", "0.00", "0.00", "0.01"},
            {"Big Family Games", "Wii", "2009", "Misc", "THQ", "0.00", "0.22", "0.00", "0.02"},
            {"Spider-Man: Shattered Dimensions", "Wii", "2010", "Action", "Activision", "0.12", "0.09", "0.00", "0.02"},
            {
                "PDC World Championship Darts 2008", "Wii", "2008", "Sports", "Oxygen Interactive", "0.02", "0.21", "0.00",
                "0.01"
            },
            {"Create", "Wii", "2010", "Misc", "Electronic Arts", "0.19", "0.02", "0.00", "0.02"},
            {"M&M's Kart Racing", "Wii", "2007", "Racing", "Zoo Digital Publishing", "0.21", "0.00", "0.00", "0.02"},
            {
                "Broken Sword: Shadow of the Templars - The Director's Cut", "Wii", "2009", "Adventure", "Ubisoft", "0.11",
                "0.10", "0.00", "0.02"
            },
            {"Barbie: Jet, Set & Style!", "Wii", "2011", "Misc", "THQ", "0.21", "0.01", "0.00", "0.01"},
            {"We Love Golf!", "Wii", "2007", "Sports", "Capcom", "0.18", "0.00", "0.03", "0.02"},
            {"Tony Hawk's Downhill Jam", "Wii", "N/A", "Sports", "Activision", "0.21", "0.00", "0.00", "0.02"},
            {"Nickelodeon Dance", "Wii", "2011", "Misc", "Take-Two Interactive", "0.20", "0.01", "0.00", "0.01"},
            {
                "Resident Evil Archives: Resident Evil Zero", "Wii", "2008", "Action", "Capcom", "0.13", "0.03", "0.06",
                "0.01"
            },
            {
                "Barbie and the Three Musketeers", "Wii", "2009", "Adventure", "Activision", "0.21", "0.00", "0.00", "0.02"
            },
            {"Ashes Cricket 2009", "Wii", "2009", "Sports", "Codemasters", "0.00", "0.22", "0.00", "0.01"},
            {
                "Prince of Persia: The Forgotten Sands", "Wii", "2010", "Action", "Ubisoft", "0.10", "0.11", "0.00", "0.02"
            },
            {"Hooked! Real Motion Fishing", "Wii", "2007", "Sports", "505 Games", "0.21", "0.00", "0.00", "0.02"},
            {"Despicable Me: The Game", "Wii", "2010", "Platform", "D3Publisher", "0.15", "0.06", "0.00", "0.02"},
            {"Dood's Big Adventure", "Wii", "2010", "Platform", "THQ", "0.20", "0.01", "0.00", "0.01"},
            {
                "Looney Tunes: Acme Arsenal", "Wii", "2007", "Action", "Warner Bros. Interactive Entertainment", "0.20",
                "0.00", "0.00", "0.02"
            },
            {"Rock Band Track Pack Volume 2", "Wii", "2008", "Misc", "MTV Games", "0.19", "0.01", "0.00", "0.02"},
            {"Megamind: Mega Team Unite", "Wii", "2010", "Adventure", "THQ", "0.15", "0.06", "0.00", "0.02"},
            {
                "The Lord of the Rings: Aragorn's Quest", "Wii", "2010", "Action", "Warner Bros. Interactive Entertainment",
                "0.16", "0.04", "0.00", "0.02"
            },
            {
                "TrackMania: Build to Race", "Wii", "2010", "Racing", "Focus Home Interactive", "0.09", "0.11", "0.00",
                "0.02"
            },
            {"101-in-1 Party Megamix Wii", "Wii", "2009", "Misc", "Nordcurrent", "0.19", "0.01", "0.00", "0.02"},
            {"Rapala's Fishing Frenzy", "Wii", "2008", "Sports", "Activision", "0.20", "0.00", "0.00", "0.02"},
            {
                "Family Party: 30 Great Games Winter Fun", "Wii", "2010", "Sports", "D3Publisher", "0.21", "0.00", "0.00",
                "0.01"
            },
            {
                "Ultimate Duck Hunting: Hunting & Retrieving Ducks", "Wii", "2007", "Sports", "Detn8 Games", "0.20", "0.00",
                "0.00", "0.02"
            },
            {"Tales of Graces", "Wii", "2009", "Role-Playing", "Namco Bandai Games", "0.00", "0.00", "0.22", "0.00"},
            {"FaceBreaker K.O. Party", "Wii", "2008", "Fighting", "Electronic Arts", "0.19", "0.01", "0.00", "0.02"},
            {"Hello Kitty Seasons", "Wii", "2010", "Adventure", "Namco Bandai Games", "0.14", "0.06", "0.00", "0.02"},
            {"ATV Quad Kings", "Wii", "2009", "Racing", "Zoo Digital Publishing", "0.20", "0.00", "0.00", "0.01"},
            {"Super Swing Golf", "Wii", "2006", "Sports", "Nintendo", "0.13", "0.01", "0.07", "0.01"},
            {"Deca Sports 3", "Wii", "2010", "Sports", "Hudson Soft", "0.14", "0.06", "0.00", "0.02"},
            {
                "pro evolution soccer 2011", "Wii", "2010", "Sports", "Konami Digital Entertainment", "0.07", "0.10",
                "0.03", "0.02"
            },
            {"Rock Band Track Pack: Classic Rock", "Wii", "2009", "Misc", "MTV Games", "0.20", "0.00", "0.00", "0.02"},
            {
                "Summer Athletics: The Ultimate Challenge (Others sales)", "Wii", "2008", "Sports", "DTP Entertainment",
                "0.00", "0.20", "0.00", "0.01"
            },
            {"NBA Live 09 All-Play", "Wii", "2008", "Sports", "Electronic Arts", "0.19", "0.01", "0.00", "0.02"},
            {"Bass Pro Shops: The Hunt", "Wii", "2010", "Sports", "XS Games", "0.20", "0.00", "0.00", "0.01"},
            {"Ultimate Band", "Wii", "2008", "Misc", "Disney Interactive Studios", "0.17", "0.02", "0.00", "0.02"},
            {"Mortal Kombat: Armageddon", "Wii", "2007", "Fighting", "Midway Games", "0.19", "0.01", "0.00", "0.02"},
            {"NASCAR 2011: The Game", "Wii", "2011", "Racing", "Activision", "0.20", "0.00", "0.00", "0.01"},
            {"Backyard NFL Football '09", "Wii", "2008", "Sports", "Atari", "0.20", "0.00", "0.00", "0.02"},
            {"G.I. Joe: The Rise of Cobra", "Wii", "2009", "Action", "Electronic Arts", "0.17", "0.03", "0.00", "0.02"},
            {"Big Beach Sports 2", "Wii", "N/A", "Sports", "THQ", "0.08", "0.11", "0.00", "0.02"},
            {
                "Kidz Bop Dance Party! The Video Game", "Wii", "2010", "Misc", "D3Publisher", "0.20", "0.00", "0.00",
                "0.01"
            },
            {"All Star Karate", "Wii", "2010", "Action", "THQ", "0.13", "0.07", "0.00", "0.02"},
            {"CSI: Fatal Conspiracy", "Wii", "2010", "Adventure", "Ubisoft", "0.12", "0.07", "0.00", "0.02"},
            {"Neopets Puzzle Adventure", "Wii", "2008", "Puzzle", "Capcom", "0.17", "0.02", "0.00", "0.02"},
            {"Deadly Creatures", "Wii", "2009", "Action", "THQ", "0.07", "0.11", "0.00", "0.02"},
            {"Pitfall: The Big Adventure", "Wii", "2008", "Adventure", "Activision", "0.18", "0.02", "0.00", "0.02"},
            {"Petz: Horse Club", "Wii", "2008", "Misc", "Ubisoft", "0.19", "0.00", "0.00", "0.02"},
            {"Rock Band Track Pack Volume 1", "Wii", "2008", "Misc", "MTV Games", "0.17", "0.02", "0.00", "0.02"},
            {
                "Karaoke Revolution Glee 2: Road to Regionals", "Wii", "2011", "Misc", "Konami Digital Entertainment",
                "0.14", "0.06", "0.00", "0.02"
            },
            {"Bratz: Girlz Really Rock", "Wii", "2008", "Action", "THQ", "0.19", "0.00", "0.00", "0.02"},
            {"FIFA 15", "Wii", "2014", "Sports", "Electronic Arts", "0.05", "0.14", "0.00", "0.02"},
            {"Family Fest presents: Movie Games", "Wii", "2008", "Action", "Ubisoft", "0.19", "0.01", "0.00", "0.02"},
            {"Rampage: Total Destruction", "Wii", "2006", "Action", "Midway Games", "0.18", "0.01", "0.00", "0.02"},
            {"MySims Party", "Wii", "2009", "Simulation", "Electronic Arts", "0.17", "0.02", "0.00", "0.02"},
            {"Petz Rescue: Wildlife Vet", "Wii", "2008", "Simulation", "Ubisoft", "0.19", "0.00", "0.00", "0.01"},
            {
                "Now! That's What I Call Music: Dance & Sing", "Wii", "2011", "Misc", "Unknown", "0.00", "0.17", "0.00",
                "0.04"
            },
            {"Order Up!", "Wii", "2008", "Misc", "Zoo Digital Publishing", "0.18", "0.01", "0.00", "0.02"},
            {"Worms: Battle Islands", "Wii", "2010", "Strategy", "THQ", "0.10", "0.08", "0.00", "0.02"},
            {"The Naked Brothers Band: The Video Game", "Wii", "2008", "Misc", "THQ", "0.19", "0.00", "0.00", "0.01"},
            {"Puss in Boots", "Wii", "2011", "Action", "THQ", "0.18", "0.01", "0.00", "0.01"},
            {
                "Pro Evolution Soccer 2012", "Wii", "2011", "Sports", "Konami Digital Entertainment", "0.07", "0.08",
                "0.03", "0.02"
            },
            {"Cursed Mountain", "Wii", "2009", "Adventure", "Deep Silver", "0.09", "0.10", "0.00", "0.02"},
            {
                "Final Fantasy Fables: Chocobo's Dungeon", "Wii", "2007", "Role-Playing", "Square Enix", "0.09", "0.00",
                "0.11", "0.01"
            },
            {
                "The Legend of Spyro: The Eternal Night", "Wii", "2007", "Platform", "Vivendi Games", "0.17", "0.01",
                "0.00", "0.02"
            },
            {"The Ultimate Red Ball Challenge", "Wii", "2009", "Misc", "Mindscape", "0.00", "0.19", "0.00", "0.01"},
            {"The Last Airbender", "Wii", "2010", "Action", "THQ", "0.11", "0.07", "0.00", "0.02"},
            {
                "TRON: Evolution - Battle Grids", "Wii", "2010", "Racing", "Disney Interactive Studios", "0.17", "0.02",
                "0.00", "0.01"
            },
            {"A Boy and His Blob", "Wii", "2009", "Platform", "Majesco Entertainment", "0.18", "0.01", "0.00", "0.01"},
            {"Planet 51", "Wii", "2009", "Action", "Sega", "0.17", "0.01", "0.00", "0.01"},
            {
                "Dragon Ball: Revenge of King Piccolo", "Wii", "2009", "Action", "Namco Bandai Games", "0.12", "0.03",
                "0.03", "0.02"
            },
            {"Tenchu: Shadow Assassins", "Wii", "2008", "Action", "Ubisoft", "0.15", "0.01", "0.03", "0.01"},
            {"Barbie: Groom and Glam Pups", "Wii", "2010", "Action", "THQ", "0.17", "0.02", "0.00", "0.01"},
            {"We Wish You A Merry Christmas", "Wii", "2009", "Action", "Destineer", "0.13", "0.04", "0.00", "0.02"},
            {
                "Cabela's North American Adventures", "Wii", "2010", "Sports", "Activision", "0.18", "0.00", "0.00", "0.01"
            },
            {
                "Hidden Mysteries: Titanic - Secrets of the Fateful Voyage", "Wii", "2009", "Adventure", "GSP", "0.11",
                "0.06", "0.00", "0.02"
            },
            {"Neighborhood Games", "Wii", "2009", "Misc", "THQ", "0.17", "0.02", "0.00", "0.01"},
            {
                "Avatar: The Last Airbender - Into the Inferno", "Wii", "2008", "Adventure", "THQ", "0.17", "0.01", "0.00",
                "0.01"
            },
            {"Inazuma Eleven Strikers 2012 Xtreme", "Wii", "2011", "Sports", "Level 5", "0.00", "0.00", "0.19", "0.00"},
            {
                "Spectrobes: Origins", "Wii", "2009", "Role-Playing", "Disney Interactive Studios", "0.16", "0.02", "0.00",
                "0.01"
            },
            {"You Don't Know Jack", "Wii", "2011", "Misc", "THQ", "0.18", "0.00", "0.00", "0.01"},
            {"We Sing Robbie Williams", "Wii", "2010", "Misc", "Nordic Games", "0.00", "0.16", "0.00", "0.03"},
            {"The Spiderwick Chronicles", "Wii", "2008", "Action", "Vivendi Games", "0.17", "0.00", "0.00", "0.01"},
            {"Shiren the Wanderer", "Wii", "2008", "Role-Playing", "Sega", "0.08", "0.00", "0.11", "0.01"},
            {"Just Dance 2: Extra Songs", "Wii", "2011", "Misc", "Ubisoft", "0.00", "0.16", "0.00", "0.03"},
            {
                "One Piece: Unlimited Adventure", "Wii", "2007", "Adventure", "Namco Bandai Games", "0.07", "0.00", "0.11",
                "0.01"
            },
            {"Tamagotchi Party On!", "Wii", "2006", "Misc", "Namco Bandai Games", "0.12", "0.00", "0.06", "0.01"},
            {
                "Rune Factory: Tides of Destiny", "Wii", "2011", "Role-Playing", "Marvelous Interactive", "0.12", "0.00",
                "0.06", "0.01"
            },
            {
                "Yoga: The first 100% Experience", "Wii", "2009", "Sports", "JoWood Productions", "0.13", "0.04", "0.00",
                "0.02"
            },
            {
                "Arc Rise Fantasia", "Wii", "2009", "Role-Playing", "Marvelous Interactive", "0.12", "0.00", "0.06", "0.01"
            },
            {
                "Where's Waldo? The Fantastic Journey", "Wii", "2009", "Adventure", "Ubisoft", "0.17", "0.00", "0.00",
                "0.01"
            },
            {
                "Cabela's Survival: Shadows of Katmai", "Wii", "2011", "Sports", "Activision", "0.14", "0.03", "0.00",
                "0.01"
            },
            {
                "DanceDanceRevolution II", "Wii", "N/A", "Misc", "Konami Digital Entertainment", "0.18", "0.00", "0.00",
                "0.01"
            },
            {"Chaotic: Shadow Warriors", "Wii", "2009", "Action", "Activision", "0.17", "0.00", "0.00", "0.01"},
            {
                "Dance Dance Revolution: Disney Grooves", "Wii", "2009", "Simulation", "Konami Digital Entertainment",
                "0.17", "0.00", "0.00", "0.01"
            },
            {
                "Ni Hao, Kai-lan: Super Game Day", "Wii", "2009", "Misc", "Take-Two Interactive", "0.17", "0.00", "0.00",
                "0.01"
            },
            {"Jeep Thrills", "Wii", "2008", "Racing", "Zoo Digital Publishing", "0.17", "0.00", "0.00", "0.01"},
            {
                "Disney's Meet the Robinsons", "Wii", "2007", "Action", "Disney Interactive Studios", "0.17", "0.00",
                "0.00", "0.01"
            },
            {"Dragon Blade: Wrath of Fire", "Wii", "2007", "Action", "D3Publisher", "0.17", "0.00", "0.00", "0.01"},
            {"Angry Birds: Star Wars", "Wii", "2013", "Strategy", "Activision", "0.09", "0.08", "0.00", "0.02"},
            {
                "Zumba Fitness: World Party", "Wii", "2013", "Misc", "Majesco Entertainment", "0.08", "0.09", "0.00",
                "0.02"
            },
            {"Arcade Shooting Gallery", "Wii", "2008", "Shooter", "Zoo Games", "0.17", "0.00", "0.00", "0.01"},
            {"Hot Wheels: Battle Force 5", "Wii", "2009", "Racing", "Activision", "0.17", "0.00", "0.00", "0.01"},
            {"Mathews Bowhunting", "Wii", "2010", "Sports", "Zoo Games", "0.17", "0.00", "0.00", "0.01"},
            {
                "Beyblade: Metal Fusion - Battle Fortress", "Wii", "2009", "Action", "Konami Digital Entertainment", "0.14",
                "0.00", "0.03", "0.01"
            },
            {
                "Barbie Horse Adventures: Riding Camp", "Wii", "2008", "Sports", "Activision", "0.17", "0.00", "0.00",
                "0.01"
            },
            {"The Munchables", "Wii", "2009", "Action", "Namco Bandai Games", "0.17", "0.00", "0.00", "0.01"},
            {"Rabbids Party Collection", "Wii", "2010", "Misc", "Ubisoft", "0.00", "0.16", "0.00", "0.02"},
            {"WWE All Stars", "Wii", "2011", "Fighting", "THQ", "0.10", "0.06", "0.00", "0.02"},
            {"Alone in the Dark", "Wii", "2008", "Adventure", "Atari", "0.09", "0.07", "0.00", "0.02"},
            {"Hot Wheels: Track Attack", "Wii", "2010", "Racing", "THQ", "0.14", "0.03", "0.00", "0.01"},
            {
                "Go Play: Lumberjacks", "Wii", "2009", "Simulation", "Majesco Entertainment", "0.17", "0.00", "0.00",
                "0.01"
            },
            {"MotoGP", "Wii", "2009", "Racing", "Capcom", "0.05", "0.10", "0.00", "0.02"},
            {
                "Remington Super Slam Hunting: North America", "Wii", "2010", "Sports", "Mastiff", "0.17", "0.00", "0.00",
                "0.01"
            },
            {
                "Ringling Bros. and Barnum & Bailey Circus", "Wii", "2009", "Action", "Take-Two Interactive", "0.16",
                "0.00", "0.00", "0.01"
            },
            {
                "Doctor Who: Return to Earth", "Wii", "2010", "Adventure", "Asylum Entertainment", "0.00", "0.15", "0.00",
                "0.02"
            },
            {"Mushroom Men: The Spore Wars", "Wii", "2008", "Action", "SouthPeak Games", "0.16", "0.01", "0.00", "0.01"},
            {
                "Pirates: Hunt For Blackbeard's Booty", "Wii", "2008", "Adventure", "Activision", "0.08", "0.08", "0.00",
                "0.02"
            },
            {"Dawn of Discovery", "Wii", "2009", "Simulation", "Ubisoft", "0.12", "0.04", "0.00", "0.02"},
            {"SoulCalibur Legends", "Wii", "2007", "Action", "Namco Bandai Games", "0.16", "0.01", "0.00", "0.01"},
            {"Family Feud: 2012 Edition", "Wii", "2011", "Misc", "Ubisoft", "0.16", "0.00", "0.00", "0.01"},
            {"de Blob 2", "Wii", "2011", "Platform", "THQ", "0.10", "0.05", "0.00", "0.02"},
            {"Sing4: The Hits Edition", "Wii", "2011", "Misc", "Crave Entertainment", "0.16", "0.00", "0.00", "0.01"},
            {"Schlag den Raab", "Wii", "2010", "Misc", "Namco Bandai Games", "0.00", "0.14", "0.00", "0.03"},
            {
                "Iron Chef America: Supreme Cuisine", "Wii", "2008", "Simulation", "Destineer", "0.16", "0.00", "0.00",
                "0.01"
            },
            {"Cabela's Legendary Adventures", "Wii", "2008", "Sports", "Activision", "0.16", "0.00", "0.00", "0.01"},
            {
                "Naruto Shippuden: Dragon Blade Chronicles", "Wii", "2009", "Action", "505 Games", "0.10", "0.01", "0.05",
                "0.01"
            },
            {
                "Squeeballs Party", "Wii", "2009", "Puzzle", "Performance Designed Products", "0.16", "0.00", "0.00",
                "0.01"
            },
            {"WordJong Party", "Wii", "2008", "Puzzle", "Destineer", "0.16", "0.00", "0.00", "0.01"},
            {"Battle of Giants: Dinosaurs Strike", "Wii", "2010", "Strategy", "Ubisoft", "0.13", "0.03", "0.00", "0.01"},
            {
                "UFC Personal Trainer: The Ultimate Fitness System", "Wii", "2011", "Sports", "THQ", "0.10", "0.06", "0.00",
                "0.02"
            },
            {"Monster 4x4: Stunt Racer", "Wii", "2009", "Racing", "Ubisoft", "0.16", "0.00", "0.00", "0.01"},
            {"Marvel Super Hero Squad: Comic Combat", "Wii", "2011", "Action", "THQ", "0.13", "0.02", "0.00", "0.01"},
            {"Luxor 3", "Wii", "2008", "Puzzle", "Mumbo Jumbo", "0.16", "0.00", "0.00", "0.01"},
            {"Surf's Up", "Wii", "2007", "Sports", "Ubisoft", "0.15", "0.00", "0.00", "0.01"},
            {"Professor Heinz Wolff's Gravity", "Wii", "2008", "Puzzle", "Deep Silver", "0.04", "0.12", "0.00", "0.02"},
            {"Trauma Team", "Wii", "N/A", "Simulation", "Unknown", "0.14", "0.00", "0.02", "0.01"},
            {"I'm A Celebrity: Get Me Out of Here!", "Wii", "2009", "Misc", "Mindscape", "0.00", "0.16", "0.00", "0.01"},
            {
                "Mercury Meltdown Revolution", "Wii", "2007", "Action", "Ignition Entertainment", "0.15", "0.00", "0.00",
                "0.01"
            },
            {"Bratz Kidz", "Wii", "2008", "Misc", "Game Factory", "0.15", "0.00", "0.00", "0.01"},
            {"Backyard NFL Football '10", "Wii", "2009", "Sports", "Atari", "0.15", "0.00", "0.00", "0.01"},
            {
                "Jillian Michaels Fitness Ultimatum 2011", "Wii", "2010", "Sports", "D3Publisher", "0.16", "0.00", "0.00",
                "0.01"
            },
            {"Rio", "Wii", "2011", "Misc", "THQ", "0.13", "0.03", "0.00", "0.01"},
            {"Just Dance: Best of", "Wii", "2012", "Action", "Ubisoft", "0.13", "0.03", "0.00", "0.01"},
            {"Hamster Heroes", "Wii", "2008", "Puzzle", "Popcorn Arcade", "0.16", "0.00", "0.00", "0.00"},
            {"Nascar Unleashed", "Wii", "2011", "Racing", "Activision", "0.16", "0.00", "0.00", "0.01"},
            {"Let's TAP", "Wii", "2008", "Misc", "Sega", "0.08", "0.06", "0.01", "0.02"},
            {"Bomberman Land", "Wii", "2007", "Misc", "Rising Star Games", "0.11", "0.01", "0.03", "0.01"},
            {
                "Are You Smarter Than a 5th Grader? Back to School", "Wii", "2010", "Misc", "Nintendo", "0.15", "0.00",
                "0.00", "0.01"
            },
            {
                "Brunswick Cosmic Bowling", "Wii", "2010", "Sports", "GameMill Entertainment", "0.15", "0.00", "0.00",
                "0.01"
            },
            {"Monster Jam", "Wii", "2007", "Racing", "Activision", "0.15", "0.00", "0.00", "0.01"},
            {"uDraw Studio: Instant Artist", "Wii", "2011", "Misc", "THQ", "0.05", "0.09", "0.00", "0.02"},
            {"Namco Museum Megamix", "Wii", "2010", "Misc", "Namco Bandai Games", "0.15", "0.00", "0.00", "0.01"},
            {"Transformers: Dark of the Moon", "Wii", "2011", "Action", "Activision", "0.09", "0.06", "0.00", "0.02"},
            {
                "Dewy's Adventure", "Wii", "2007", "Platform", "Konami Digital Entertainment", "0.14", "0.00", "0.01",
                "0.01"
            },
            {
                "My Fitness Coach 2: Exercise and Nutrition", "Wii", "2009", "Sports", "Black Bean Games", "0.13", "0.02",
                "0.00", "0.01"
            },
            {"Chuck E. Cheese's Party Games", "Wii", "2010", "Misc", "UFO Interactive", "0.15", "0.00", "0.00", "0.01"},
            {"Shaun White Skateboarding", "Wii", "2010", "Sports", "Ubisoft", "0.12", "0.03", "0.00", "0.01"},
            {"Cabela's Adventure Camp", "Wii", "2011", "Misc", "Activision", "0.13", "0.02", "0.00", "0.01"},
            {"Shawn Johnson Gymnastics", "Wii", "2010", "Sports", "Zoo Games", "0.15", "0.00", "0.00", "0.01"},
            {"Zoo Hospital", "Wii", "2008", "Simulation", "Majesco Entertainment", "0.13", "0.01", "0.00", "0.01"},
            {"Ready 2 Rumble Revolution", "Wii", "2009", "Sports", "Atari", "0.15", "0.00", "0.00", "0.01"},
            {"NCAA Football 09 All-Play", "Wii", "2008", "Sports", "Electronic Arts", "0.15", "0.00", "0.00", "0.01"},
            {"Family Feud Decades", "Wii", "2010", "Misc", "Ubisoft", "0.15", "0.00", "0.00", "0.01"},
            {"TNA iMPACT!", "Wii", "2008", "Fighting", "Midway Games", "0.14", "0.01", "0.00", "0.01"},
            {"Goosebumps HorrorLand", "Wii", "2008", "Adventure", "Scholastic Inc.", "0.14", "0.00", "0.00", "0.01"},
            {
                "Rudolph the Red-Nosed Reindeer", "Wii", "2010", "Action", "Crave Entertainment", "0.15", "0.00", "0.00",
                "0.01"
            },
            {
                "Family Party: 30 Great Games Outdoor Fun", "Wii", "2009", "Misc", "D3Publisher", "0.14", "0.00", "0.00",
                "0.01"
            },
            {
                "Castlevania Judgment", "Wii", "2008", "Fighting", "Konami Digital Entertainment", "0.12", "0.01", "0.01",
                "0.01"
            },
            {"Driver: San Francisco", "Wii", "2011", "Racing", "Ubisoft", "0.06", "0.08", "0.00", "0.02"},
            {"Sid Meier's Pirates!", "Wii", "2010", "Strategy", "Take-Two Interactive", "0.12", "0.02", "0.00", "0.01"},
            {"Vegas Party", "Wii", "N/A", "Misc", "Unknown", "0.14", "0.00", "0.00", "0.01"},
            {"Klonoa", "Wii", "2008", "Platform", "Namco Bandai Games", "0.10", "0.02", "0.03", "0.01"},
            {"Tak and the Guardians of Gross", "Wii", "2008", "Action", "THQ", "0.14", "0.00", "0.00", "0.01"},
            {"Godzilla Unleashed", "Wii", "2007", "Fighting", "Atari", "0.14", "0.00", "0.00", "0.01"},
            {
                "Bakugan Battle Brawlers: Defenders of the Core", "Wii", "2010", "Action", "Activision", "0.14", "0.00",
                "0.00", "0.01"
            },
            {"Medieval Games", "Wii", "2009", "Action", "Vir2L Studios", "0.14", "0.01", "0.00", "0.01"},
            {
                "The Godfather: Blackhand Edition", "Wii", "2007", "Adventure", "Electronic Arts", "0.14", "0.00", "0.00",
                "0.01"
            },
            {"Family Party: Fitness Fun", "Wii", "2010", "Sports", "D3Publisher", "0.14", "0.00", "0.00", "0.01"},
            {"Bust-A-Move Bash!", "Wii", "2007", "Puzzle", "505 Games", "0.13", "0.01", "0.00", "0.01"},
            {
                "Yu-Gi-Oh! 5D's: Duel Transer", "Wii", "2010", "Strategy", "Konami Digital Entertainment", "0.11", "0.02",
                "0.02", "0.01"
            },
            {"We Sing Pop!", "Wii", "2012", "Misc", "Nordic Games", "0.04", "0.10", "0.00", "0.02"},
            {"Burger Island", "Wii", "2009", "Action", "Destineer", "0.14", "0.00", "0.00", "0.01"},
            {
                "Little League World Series Baseball 2009", "Wii", "2009", "Sports", "Activision", "0.14", "0.00", "0.00",
                "0.01"
            },
            {"Block Party", "Wii", "2008", "Misc", "Activision", "0.14", "0.00", "0.00", "0.01"},
            {"Samurai Warriors: Katana", "Wii", "2007", "Action", "Tecmo Koei", "0.10", "0.00", "0.04", "0.01"},
            {
                "Major League Baseball 2K11", "Wii", "2011", "Sports", "Take-Two Interactive", "0.14", "0.00", "0.00",
                "0.01"
            },
            {"NBA Live 08", "Wii", "2007", "Sports", "Electronic Arts", "0.13", "0.00", "0.00", "0.01"},
            {
                "Marble Saga: Kororinpa", "Wii", "2009", "Puzzle", "Konami Digital Entertainment", "0.09", "0.04", "0.00",
                "0.01"
            },
            {"Dragon's Lair Trilogy", "Wii", "2010", "Adventure", "Destineer", "0.14", "0.00", "0.00", "0.01"},
            {
                "Cake Mania: In The Mix!", "Wii", "2008", "Puzzle", "Majesco Entertainment", "0.14", "0.00", "0.00", "0.01"
            },
            {"The Oregon Trail", "Wii", "2011", "Simulation", "Crave Entertainment", "0.14", "0.00", "0.00", "0.01"},
            {"Candace Kane's Candy Factory", "Wii", "2008", "Action", "Destineer", "0.14", "0.00", "0.00", "0.01"},
            {
                "Kamen Rider: Climax Heroes OOO", "Wii", "2010", "Fighting", "Namco Bandai Games", "0.00", "0.00", "0.15",
                "0.00"
            },
            {"Arcade Zone", "Wii", "2009", "Misc", "Activision", "0.14", "0.00", "0.00", "0.01"},
            {"Sam & Max: Season One", "Wii", "2008", "Adventure", "JoWood Productions", "0.13", "0.01", "0.00", "0.01"},
            {
                "Nancy Drew: The White Wolf of Icicle Creek", "Wii", "2008", "Adventure", "Sega", "0.13", "0.00", "0.00",
                "0.01"
            },
            {"Gunslingers", "Wii", "2010", "Shooter", "Neko Entertainment", "0.07", "0.06", "0.00", "0.01"},
            {"Baseball Blast!", "Wii", "2009", "Sports", "Take-Two Interactive", "0.13", "0.00", "0.00", "0.01"},
            {"Charm Girls Club: Pajama Party", "Wii", "2009", "Misc", "Electronic Arts", "0.13", "0.00", "0.00", "0.01"},
            {"Spider-Man: Friend or Foe", "Wii", "2007", "Action", "Activision", "0.13", "0.00", "0.00", "0.01"},
            {"Ultimate Board Game Collection", "Wii", "2007", "Misc", "Xplosiv", "0.13", "0.00", "0.00", "0.01"},
            {
                "The Amazing Spider-Man (Console Version)", "Wii", "2012", "Action", "Activision", "0.10", "0.03", "0.00",
                "0.01"
            },
            {"Victorious Boxers: Revolution", "Wii", "2007", "Fighting", "Ubisoft", "0.07", "0.00", "0.06", "0.01"},
            {"Jurassic: The Hunted", "Wii", "2009", "Shooter", "Activision", "0.13", "0.00", "0.00", "0.01"},
            {"Rubik's World", "Wii", "2008", "Puzzle", "Game Factory", "0.12", "0.01", "0.00", "0.01"},
            {"Cranium Kabookii", "Wii", "2007", "Misc", "Ubisoft", "0.13", "0.00", "0.00", "0.01"},
            {"Thor: God of Thunder", "Wii", "2011", "Action", "Sega", "0.09", "0.03", "0.00", "0.01"},
            {"Buck Fever", "Wii", "2009", "Sports", "Destineer", "0.13", "0.00", "0.00", "0.01"},
            {"Backyard Sports: Sandlot Sluggers", "Wii", "2010", "Sports", "Atari", "0.13", "0.00", "0.00", "0.01"},
            {
                "Major League Baseball 2K12", "Wii", "2012", "Sports", "Take-Two Interactive", "0.13", "0.00", "0.00",
                "0.01"
            },
            {
                "Jikkyou Powerful Pro Yakyuu Wii", "Wii", "2007", "Sports", "Konami Digital Entertainment", "0.00", "0.00",
                "0.14", "0.00"
            },
            {"MySims Collection", "Wii", "2010", "Misc", "Electronic Arts", "0.13", "0.00", "0.00", "0.01"},
            {"Our House Party!", "Wii", "N/A", "Simulation", "Unknown", "0.13", "0.00", "0.00", "0.01"},
            {"WWE '13", "Wii", "2012", "Action", "THQ", "0.11", "0.02", "0.00", "0.01"},
            {
                "NewU Fitness First Mind Body, Yoga & Pilates Workout", "Wii", "2010", "Sports", "Black Bean Games", "0.12",
                "0.01", "0.00", "0.01"
            },
            {
                "Scarface: The World is Yours", "Wii", "2007", "Adventure", "Vivendi Games", "0.12", "0.01", "0.00", "0.01"
            },
            {
                "Family Game Night 4: The Game Show", "Wii", "2011", "Misc", "Electronic Arts", "0.11", "0.02", "0.00",
                "0.01"
            },
            {"Gallop & Ride!", "Wii", "2008", "Sports", "THQ", "0.13", "0.00", "0.00", "0.01"},
            {"Dream Pinball 3D", "Wii", "2008", "Misc", "SouthPeak Games", "0.10", "0.02", "0.00", "0.01"},
            {
                "Pet Pals: Animal Doctor", "Wii", "2008", "Simulation", "JoWood Productions", "0.13", "0.00", "0.00",
                "0.01"
            },
            {"Happy Feet", "Wii", "2006", "Adventure", "Midway Games", "0.12", "0.00", "0.00", "0.01"},
            {"Hot Wheels: Beat That!", "Wii", "2007", "Racing", "Activision", "0.12", "0.00", "0.00", "0.01"},
            {"Metal Slug Anthology", "Wii", "2006", "Shooter", "Ignition Entertainment", "0.11", "0.01", "0.00", "0.01"},
            {
                "Major League Baseball 2K8", "Wii", "2008", "Sports", "Take-Two Interactive", "0.13", "0.00", "0.00",
                "0.01"
            },
            {
                "Scene It? Bright Lights! Big Screen!", "Wii", "2009", "Misc", "Warner Bros. Interactive Entertainment",
                "0.12", "0.00", "0.00", "0.01"
            },
            {"Nitrobike", "Wii", "2008", "Racing", "Ubisoft", "0.11", "0.01", "0.00", "0.01"},
            {"Top Spin 4", "Wii", "2011", "Sports", "Take-Two Interactive", "0.04", "0.08", "0.00", "0.02"},
            {
                "Valhalla Knights: Eldar Saga", "Wii", "2009", "Role-Playing", "Rising Star Games", "0.10", "0.01", "0.01",
                "0.01"
            },
            {"Active Life Explorer", "Wii", "2010", "Sports", "Namco Bandai Games", "0.13", "0.00", "0.00", "0.01"},
            {"Destroy All Humans! Big Willy Unleashed", "Wii", "2008", "Action", "THQ", "0.12", "0.00", "0.00", "0.01"},
            {"Cruise Ship Vacation Games", "Wii", "2009", "Puzzle", "Avanquest", "0.12", "0.00", "0.00", "0.01"},
            {
                "Phantom Brave: We Meet Again", "Wii", "2009", "Role-Playing", "Nippon Ichi Software", "0.12", "0.00",
                "0.01", "0.01"
            },
            {"Kororinpa: Marble Mania", "Wii", "2006", "Puzzle", "Nintendo", "0.08", "0.02", "0.03", "0.01"},
            {"Virtua Tennis 4", "Wii", "2011", "Sports", "Sega", "0.04", "0.07", "0.00", "0.01"},
            {
                "Trivial Pursuit: Bet You Know It", "Wii", "2011", "Misc", "Electronic Arts", "0.08", "0.03", "0.00",
                "0.01"
            },
            {"Horse Life Adventures", "Wii", "2008", "Simulation", "Deep Silver", "0.11", "0.01", "0.00", "0.01"},
            {
                "MLB Power Pros 2008", "Wii", "2008", "Sports", "Konami Digital Entertainment", "0.11", "0.00", "0.01",
                "0.01"
            },
            {"Kid Adventures: Sky Captain", "Wii", "2010", "Action", "Unknown", "0.09", "0.03", "0.00", "0.01"},
            {
                "Pinball Hall of Fame: The Gottlieb Collection", "Wii", "2006", "Misc", "System 3 Arcade Software", "0.12",
                "0.00", "0.00", "0.01"
            },
            {"Family Fortunes", "Wii", "2009", "Misc", "Mindscape", "0.00", "0.12", "0.00", "0.01"},
            {"Army Men: Soldiers of Misfortune", "Wii", "2008", "Shooter", "Zoo Games", "0.12", "0.00", "0.00", "0.01"},
            {"Margot's Word Brain", "Wii", "2008", "Puzzle", "Zoo Digital Publishing", "0.12", "0.00", "0.00", "0.01"},
            {"Kung Fu Panda 2", "Wii", "2011", "Action", "THQ", "0.07", "0.05", "0.00", "0.01"},
            {"All Star Cheer Squad 2", "Wii", "2009", "Sports", "THQ", "0.12", "0.00", "0.00", "0.01"},
            {"Peppa Pig: Fun and Games", "Wii", "2010", "Misc", "Ubisoft", "0.00", "0.11", "0.00", "0.02"},
            {"Haunted House", "Wii", "2010", "Adventure", "Atari", "0.12", "0.00", "0.00", "0.01"},
            {
                "Tom Clancy's Splinter Cell: Double Agent", "Wii", "2006", "Action", "Ubisoft", "0.10", "0.01", "0.00",
                "0.01"
            },
            {"Sengoku Basara 3 Utage", "Wii", "2011", "Action", "Capcom", "0.00", "0.00", "0.13", "0.00"},
            {"Space Camp", "Wii", "2009", "Action", "Activision", "0.12", "0.00", "0.00", "0.01"},
            {"428: Fuusa Sareta Shibuya de", "Wii", "2008", "Adventure", "Sega", "0.00", "0.00", "0.13", "0.00"},
            {"The Amazing Race", "Wii", "2010", "Misc", "Ubisoft", "0.12", "0.00", "0.00", "0.01"},
            {"My Baby: First Steps", "Wii", "2009", "Simulation", "SouthPeak Games", "0.11", "0.00", "0.00", "0.01"},
            {"NCIS", "Wii", "2011", "Adventure", "Ubisoft", "0.08", "0.04", "0.00", "0.01"},
            {"Science Papa", "Wii", "2009", "Misc", "Activision", "0.11", "0.01", "0.00", "0.01"},
            {"Indianapolis 500 Legends", "Wii", "2007", "Racing", "Destineer", "0.12", "0.00", "0.00", "0.01"},
            {"Dokapon Kingdom", "Wii", "2008", "Role-Playing", "Sting", "0.11", "0.00", "0.00", "0.01"},
            {"Shimano Xtreme Fishing", "Wii", "2009", "Sports", "Mastiff", "0.12", "0.00", "0.00", "0.01"},
            {
                "Obscure: The Aftermath", "Wii", "2008", "Adventure", "Playlogic Game Factory", "0.11", "0.00", "0.00",
                "0.01"
            },
            {"Brothers in Arms: Double Time", "Wii", "2008", "Shooter", "Ubisoft", "0.11", "0.00", "0.00", "0.01"},
            {"Star Trek: Conquest", "Wii", "2007", "Strategy", "Bethesda Softworks", "0.11", "0.01", "0.00", "0.01"},
            {
                "Kamen Rider: Climax Heroes Fourze", "Wii", "2011", "Fighting", "Namco Bandai Games", "0.00", "0.00",
                "0.12", "0.00"
            },
            {
                "Dodge Racing: Charger vs Challenger", "Wii", "2009", "Racing", "Zushi Games", "0.11", "0.00", "0.00",
                "0.01"
            },
            {"Geometry Wars: Galaxies", "Wii", "2007", "Shooter", "Vivendi Games", "0.11", "0.00", "0.00", "0.01"},
            {"Ninja Reflex", "Wii", "2008", "Action", "Electronic Arts", "0.11", "0.00", "0.00", "0.01"},
            {"Nicktoons MLB", "Wii", "2011", "Sports", "Take-Two Interactive", "0.11", "0.00", "0.00", "0.01"},
            {
                "NPPL Championship Paintball 2009", "Wii", "2008", "Shooter", "Activision Value", "0.11", "0.00", "0.00",
                "0.01"
            },
            {"Cruis'n", "Wii", "2007", "Racing", "Midway Games", "0.10", "0.01", "0.00", "0.01"},
            {"Deepak Chopra's Leela", "Wii", "2011", "Misc", "THQ", "0.10", "0.01", "0.00", "0.01"},
            {
                "Deadliest Catch: Sea of Chaos", "Wii", "2010", "Sports", "Crave Entertainment", "0.11", "0.00", "0.00",
                "0.01"
            },
            {"Reader Rabbit Kindergarten", "Wii", "2010", "Misc", "Graffiti", "0.11", "0.00", "0.00", "0.01"},
            {"Conduit 2", "Wii", "2011", "Shooter", "Sega", "0.07", "0.04", "0.00", "0.01"},
            {"Ben 10 Galactic Racing", "Wii", "2011", "Racing", "D3Publisher", "0.07", "0.03", "0.00", "0.01"},
            {"PBR: Out of the Chute", "Wii", "2008", "Sports", "Crave Entertainment", "0.11", "0.00", "0.00", "0.01"},
            {"DreamWorks Super Star Kartz", "Wii", "2011", "Racing", "Activision", "0.07", "0.03", "0.00", "0.01"},
            {"Solitaire & Mahjong", "Wii", "2009", "Puzzle", "Crave Entertainment", "0.11", "0.00", "0.00", "0.01"},
            {"Mountain Sports", "Wii", "2009", "Sports", "Activision", "0.11", "0.00", "0.00", "0.01"},
            {"Go Play: Circus Star", "Wii", "2009", "Action", "Majesco Entertainment", "0.11", "0.00", "0.00", "0.01"},
            {"Skate City Heroes", "Wii", "2008", "Sports", "Zoo Digital Publishing", "0.11", "0.00", "0.00", "0.01"},
            {
                "Kidz Sports: Crazy Golf", "Wii", "2008", "Sports", "Data Design Interactive", "0.11", "0.00", "0.00",
                "0.01"
            },
            {
                "Wild Earth: African Safari", "Wii", "2008", "Simulation", "Majesco Entertainment", "0.09", "0.02", "0.00",
                "0.01"
            },
            {"Puzzle Kingdoms", "Wii", "2009", "Puzzle", "Zoo Digital Publishing", "0.11", "0.00", "0.00", "0.01"},
            {"Rango: The Video Game", "Wii", "2011", "Action", "Electronic Arts", "0.06", "0.04", "0.00", "0.01"},
            {"Top Shot Arcade", "Wii", "2011", "Shooter", "Activision", "0.11", "0.00", "0.00", "0.01"},
            {"Tom Clancy's Ghost Recon", "Wii", "2010", "Shooter", "Ubisoft", "0.10", "0.01", "0.00", "0.01"},
            {"Backyard Sports Football: Rookie Rush", "Wii", "2010", "Sports", "Atari", "0.11", "0.00", "0.00", "0.01"},
            {"Merv Griffin's Crosswords", "Wii", "2008", "Puzzle", "THQ", "0.10", "0.00", "0.00", "0.01"},
            {
                "Disney's Planes", "Wii", "2013", "Simulation", "Disney Interactive Studios", "0.05", "0.06", "0.00",
                "0.01"
            },
            {"Super Swing Golf Season 2", "Wii", "2007", "Sports", "Rising Star Games", "0.08", "0.00", "0.03", "0.01"},
            {
                "The Sky Crawlers: Innocent Aces", "Wii", "2008", "Simulation", "Namco Bandai Games", "0.08", "0.02",
                "0.01", "0.01"
            },
            {"Zangeki no Reginleiv", "Wii", "2010", "Action", "Nintendo", "0.00", "0.00", "0.11", "0.00"},
            {"SimAnimals Africa", "Wii", "2009", "Simulation", "Electronic Arts", "0.09", "0.01", "0.00", "0.01"},
            {"We Sing UK Hits", "Wii", "2011", "Misc", "Nordic Games", "0.00", "0.09", "0.00", "0.02"},
            {"Pimp My Ride", "Wii", "2008", "Racing", "Activision", "0.10", "0.00", "0.00", "0.01"},
            {
                "Onechanbara: Bikini Zombie Slayers", "Wii", "2008", "Action", "D3Publisher", "0.10", "0.00", "0.00",
                "0.01"
            },
            {
                "History Channel: Battle for the Pacific", "Wii", "2007", "Shooter", "Activision", "0.10", "0.00", "0.00",
                "0.01"
            },
            {
                "Mobile Suit Gundam: MS Sensen 0079", "Wii", "2007", "Simulation", "Namco Bandai Games", "0.00", "0.00",
                "0.11", "0.00"
            },
            {
                "Lost in Shadow", "Wii", "2010", "Platform", "Konami Digital Entertainment", "0.09", "0.00", "0.01", "0.01"
            },
            {"Yogi Bear: The Video Game", "Wii", "2010", "Action", "D3Publisher", "0.05", "0.05", "0.00", "0.01"},
            {"Academy of Champions: Soccer", "Wii", "2009", "Sports", "Ubisoft", "0.09", "0.01", "0.00", "0.01"},
            {"Greg Hastings Paintball 2", "Wii", "2010", "Shooter", "505 Games", "0.10", "0.00", "0.00", "0.01"},
            {"The Price is Right: Decades", "Wii", "2011", "Misc", "Ubisoft", "0.10", "0.00", "0.00", "0.01"},
            {"Death Jr.: Root of Evil", "Wii", "2008", "Platform", "Eidos Interactive", "0.10", "0.00", "0.00", "0.01"},
            {"We Dance", "Wii", "2011", "Misc", "Nordic Games", "0.00", "0.09", "0.00", "0.02"},
            {"Just Dance: Disney Party", "Wii", "2012", "Misc", "Ubisoft", "0.00", "0.09", "0.00", "0.01"},
            {
                "Where the Wild Things Are", "Wii", "2009", "Platform", "Warner Bros. Interactive Entertainment", "0.10",
                "0.00", "0.00", "0.01"
            },
            {
                "Vacation Isle: Beach Party", "Wii", "2010", "Misc", "Warner Bros. Interactive Entertainment", "0.08",
                "0.02", "0.00", "0.01"
            },
            {"Paws & Claws: Pet Resort", "Wii", "2009", "Simulation", "THQ", "0.10", "0.00", "0.00", "0.01"},
            {"Tournament Pool", "Wii", "2009", "Sports", "Destineer", "0.10", "0.00", "0.00", "0.01"},
            {"Escape The Museum", "Wii", "2009", "Adventure", "Majesco Entertainment", "0.10", "0.00", "0.00", "0.01"},
            {"Spyborgs", "Wii", "2009", "Action", "Capcom", "0.09", "0.01", "0.00", "0.01"},
            {"Get Up and Dance", "Wii", "2011", "Misc", "O-Games", "0.06", "0.03", "0.00", "0.01"},
            {"Cloudy With a Chance of Meatballs", "Wii", "2009", "Adventure", "Ubisoft", "0.09", "0.00", "0.00", "0.01"},
            {
                "PDC World Championship Darts: Pro Tour", "Wii", "2010", "Sports", "O-Games", "0.00", "0.09", "0.00",
                "0.01"
            },
            {
                "The King of Fighters Collection: The Orochi Saga", "Wii", "2008", "Fighting", "Ignition Entertainment",
                "0.10", "0.00", "0.00", "0.01"
            },
            {"Ennichi no Tatsujin", "Wii", "2006", "Misc", "Namco Bandai Games", "0.00", "0.00", "0.10", "0.00"},
            {"Astro Boy: The Video Game", "Wii", "2009", "Action", "D3Publisher", "0.10", "0.00", "0.00", "0.01"},
            {
                "Hasbro Family Game Night Fun Pack", "Wii", "2011", "Misc", "Electronic Arts", "0.10", "0.00", "0.00",
                "0.01"
            },
            {
                "Legend of the Guardians: The Owls of Ga'Hoole", "Wii", "2010", "Action",
                "Warner Bros. Interactive Entertainment", "0.09", "0.00", "0.00", "0.01"
            },
            {"Rock Band: Metal Track Pack", "Wii", "2009", "Misc", "MTV Games", "0.10", "0.00", "0.00", "0.01"},
            {"Totally Spies! Totally Party", "Wii", "2008", "Misc", "Ubisoft", "0.09", "0.01", "0.00", "0.01"},
            {
                "Who Wants to Be a Millionaire: 3rd Edition", "Wii", "2010", "Misc", "Ubisoft", "0.10", "0.00", "0.00",
                "0.01"
            },
            {"Vacation Sports", "Wii", "2009", "Sports", "Ubisoft", "0.09", "0.01", "0.00", "0.01"},
            {"Momotarou Dentetsu 16", "Wii", "2007", "Misc", "Hudson Soft", "0.00", "0.00", "0.10", "0.00"},
            {
                "Yu-Gi-Oh! 5D's Wheelie Breakers", "Wii", "2009", "Racing", "Konami Digital Entertainment", "0.09", "0.01",
                "0.00", "0.01"
            },
            {"Inazuma Eleven GO Strikers 2013", "Wii", "2012", "Sports", "Level 5", "0.00", "0.00", "0.10", "0.00"},
            {"Fatal Frame 2: Wii Edition", "Wii", "2012", "Action", "Nintendo", "0.00", "0.00", "0.10", "0.00"},
            {
                "Kamen Rider: Climax Heroes W", "Wii", "2009", "Fighting", "Namco Bandai Games", "0.00", "0.00", "0.10",
                "0.00"
            },
            {"Hollywood Squares", "Wii", "2010", "Misc", "Ubisoft", "0.10", "0.00", "0.00", "0.01"},
            {
                "The Bachelor: The Videogame", "Wii", "2010", "Misc", "Warner Bros. Interactive Entertainment", "0.10",
                "0.00", "0.00", "0.01"
            },
            {
                "Disney's Chicken Little: Ace In Action", "Wii", "N/A", "Shooter", "Disney Interactive Studios", "0.09",
                "0.00", "0.00", "0.01"
            },
            {"Calling", "Wii", "2009", "Adventure", "Konami Digital Entertainment", "0.06", "0.03", "0.00", "0.01"},
            {"Fit in Six", "Wii", "2011", "Sports", "Ubisoft", "0.10", "0.00", "0.00", "0.01"},
            {
                "Tatsunoko vs. Capcom: Cross Generation of Heroes", "Wii", "2008", "Fighting", "Capcom", "0.00", "0.00",
                "0.10", "0.00"
            },
            {"Water Sports", "Wii", "2009", "Action", "Avanquest", "0.05", "0.04", "0.00", "0.01"},
            {
                "Sakura Wars: So Long, My Love", "Wii", "2010", "Role-Playing", "Ackkstudios", "0.05", "0.04", "0.00",
                "0.01"
            },
            {"Sniper Elite", "Wii", "2010", "Shooter", "Reef Entertainment", "0.07", "0.02", "0.00", "0.01"},
            {"The Destiny of Zorro", "Wii", "2009", "Action", "505 Games", "0.09", "0.00", "0.00", "0.01"},
            {"Dancing on Ice", "Wii", "2010", "Sports", "Ghostlight", "0.00", "0.09", "0.00", "0.01"},
            {"Igor: The Game", "Wii", "2008", "Adventure", "CDV Software Entertainment", "0.09", "0.00", "0.00", "0.01"},
            {
                "Naruto Shippuuden: Gekitou Ninja Taisen! EX", "Wii", "2007", "Fighting", "Takara Tomy", "0.00", "0.00",
                "0.10", "0.00"
            },
            {"Family Fun Football", "Wii", "2009", "Sports", "Tecmo Koei", "0.09", "0.00", "0.00", "0.01"},
            {"JU-ON: The Grudge", "Wii", "2009", "Adventure", "Rising Star Games", "0.07", "0.01", "0.01", "0.01"},
            {
                "The Hardy Boys: The Hidden Theft", "Wii", "2009", "Adventure", "The Adventure Company", "0.07", "0.02",
                "0.00", "0.01"
            },
            {"Backyard Baseball '10", "Wii", "2009", "Sports", "Atari", "0.09", "0.00", "0.00", "0.01"},
            {"Truth or Lies", "Wii", "2010", "Misc", "THQ", "0.04", "0.05", "0.00", "0.01"},
            {
                "SCORE International Baja 1000: The Official Game", "Wii", "2008", "Racing", "Activision", "0.09", "0.00",
                "0.00", "0.01"
            },
            {"Rolling Stone: Drum King", "Wii", "2009", "Misc", "505 Games", "0.09", "0.00", "0.00", "0.01"},
            {
                "Dora's Big Birthday Adventure", "Wii", "2010", "Misc", "Take-Two Interactive", "0.08", "0.01", "0.00",
                "0.01"
            },
            {
                "Sesame Street: Ready, Set, Grover!", "Wii", "2011", "Misc", "Warner Bros. Interactive Entertainment",
                "0.09", "0.00", "0.00", "0.01"
            },
            {"Big League Sports", "Wii", "2008", "Sports", "Activision", "0.09", "0.00", "0.00", "0.01"},
            {"Opoona", "Wii", "2007", "Role-Playing", "Tecmo Koei", "0.08", "0.00", "0.01", "0.01"},
            {"Monkey Mischief! Party Time", "Wii", "2008", "Misc", "Activision", "0.09", "0.00", "0.00", "0.01"},
            {"Paws & Claws: Pet Vet", "Wii", "2009", "Simulation", "THQ", "0.09", "0.00", "0.00", "0.01"},
            {"Heatseeker", "Wii", "2007", "Action", "Codemasters", "0.08", "0.00", "0.00", "0.01"},
            {
                "Attack of the Movies 3D", "Wii", "2010", "Shooter", "Majesco Entertainment", "0.09", "0.00", "0.00",
                "0.01"
            },
            {"Pajama Sam: Don't Fear The Dark", "Wii", "2008", "Adventure", "Atari", "0.09", "0.00", "0.00", "0.01"},
            {"Heavy Fire: Afghanistan", "Wii", "2011", "Shooter", "Mastiff", "0.09", "0.00", "0.00", "0.01"},
            {"Help Wanted: 50 Wacky Jobs", "Wii", "2008", "Simulation", "Hudson Soft", "0.06", "0.03", "0.00", "0.01"},
            {"Tom Clancy's HAWX 2", "Wii", "2010", "Action", "Ubisoft", "0.06", "0.03", "0.00", "0.01"},
            {"King of Clubs: Mini Golf", "Wii", "2008", "Sports", "Oxygen Interactive", "0.09", "0.00", "0.00", "0.01"},
            {
                "The Secret Saturdays: Beasts of the 5th Sun", "Wii", "2009", "Action", "D3Publisher", "0.09", "0.00",
                "0.00", "0.01"
            },
            {
                "Blast Works: Build, Trade, Destroy", "Wii", "2008", "Shooter", "Eidos Interactive", "0.09", "0.00", "0.00",
                "0.01"
            },
            {
                "Alvin and the Chipmunks: The Squeakquel", "Wii", "2009", "Misc", "Majesco Entertainment", "0.08", "0.00",
                "0.00", "0.01"
            },
            {"iCarly 2: iJoin The Click!", "Wii", "2010", "Adventure", "Activision", "0.08", "0.01", "0.00", "0.01"},
            {"Championship Foosball", "Wii", "2008", "Sports", "505 Games", "0.09", "0.00", "0.00", "0.01"},
            {
                "Little League World Series Baseball 2008", "Wii", "2008", "Sports", "Activision", "0.08", "0.00", "0.00",
                "0.01"
            },
            {"Big League Sports: Summer", "Wii", "2009", "Sports", "Activision", "0.08", "0.00", "0.00", "0.01"},
            {"U-Sing 2", "Wii", "2010", "Misc", "Mindscape", "0.00", "0.08", "0.00", "0.01"},
            {
                "NERF N-Strike: Double Blast Bundle", "Wii", "2010", "Shooter", "Electronic Arts", "0.09", "0.00", "0.00",
                "0.00"
            },
            {"Kawasaki Quad Bikes", "Wii", "2007", "Racing", "Data Design Interactive", "0.07", "0.01", "0.00", "0.01"},
            {"X-Men: Destiny", "Wii", "2011", "Action", "Activision", "0.07", "0.01", "0.00", "0.01"},
            {"Rygar: The Battle of Argus", "Wii", "2008", "Action", "Rising Star Games", "0.08", "0.00", "0.00", "0.01"},
            {
                "Karaoke Joysound Wii Super DX: Hitori de Minna de Utai Houdai!", "Wii", "2010", "Misc", "Hudson Soft",
                "0.00", "0.00", "0.09", "0.00"
            },
            {"Family Party: 30 Great Games", "Wii", "2008", "Misc", "D3Publisher", "0.08", "0.01", "0.00", "0.01"},
            {"Go Play: City Sports", "Wii", "2009", "Sports", "Majesco Entertainment", "0.08", "0.00", "0.00", "0.01"},
            {"Alien Monster Bowling League", "Wii", "2009", "Sports", "Destineer", "0.08", "0.00", "0.00", "0.01"},
            {"Code Lyoko: Quest for Infinity", "Wii", "2007", "Action", "Game Factory", "0.07", "0.01", "0.00", "0.01"},
            {"The Daring Game for Girls", "Wii", "N/A", "Adventure", "Unknown", "0.08", "0.00", "0.00", "0.01"},
            {
                "National Geographic Challenge!", "Wii", "2011", "Misc", "Black Bean Games", "0.07", "0.02", "0.00", "0.01"
            },
            {
                "Momu-chan Diet Wii: Figurobics by Chon Dayon", "Wii", "2010", "Misc", "Hudson Soft", "0.00", "0.00",
                "0.09", "0.00"
            },
            {"Animal Planet: Vet Life", "Wii", "2009", "Simulation", "Activision", "0.08", "0.00", "0.00", "0.01"},
            {
                "Tornado Outbreak", "Wii", "2009", "Action", "Konami Digital Entertainment", "0.08", "0.00", "0.00", "0.01"
            },
            {
                "Naruto Shippuuden: Gekitou Ninja Taisen! EX 2", "Wii", "2007", "Fighting", "Takara Tomy", "0.00", "0.00",
                "0.09", "0.00"
            },
            {"The Smurfs 2", "Wii", "2013", "Action", "Ubisoft", "0.00", "0.08", "0.00", "0.01"},
            {"Monopoly Collection", "Wii", "2011", "Misc", "Electronic Arts", "0.02", "0.06", "0.00", "0.01"},
            {"Space Chimps", "Wii", "2008", "Platform", "Brash Entertainment", "0.08", "0.00", "0.00", "0.01"},
            {"Medal of Honor: Vanguard", "Wii", "2007", "Shooter", "Electronic Arts", "0.06", "0.02", "0.00", "0.01"},
            {
                "Fishing Master World Tour", "Wii", "2009", "Sports", "Hudson Entertainment", "0.08", "0.00", "0.00",
                "0.01"
            },
            {"The Ant Bully", "Wii", "2006", "Platform", "Midway Games", "0.08", "0.00", "0.00", "0.01"},
            {"Karaoke Joysound Wii DX", "Wii", "2009", "Misc", "Hudson Soft", "0.00", "0.00", "0.09", "0.00"},
            {"MLB Superstars", "Wii", "2008", "Sports", "Take-Two Interactive", "0.08", "0.00", "0.00", "0.01"},
            {"Alvin and the Chipmunks: Chipwrecked", "Wii", "2011", "Misc", "505 Games", "0.07", "0.01", "0.00", "0.01"},
            {"Remington Super Slam Hunting: Alaska", "Wii", "2011", "Sports", "Mastiff", "0.08", "0.00", "0.00", "0.00"},
            {
                "The Mummy: Tomb of the Dragon Emperor", "Wii", "2008", "Action", "Vivendi Games", "0.08", "0.00", "0.00",
                "0.01"
            },
            {"Family GameShow", "Wii", "2009", "Misc", "Zushi Games", "0.08", "0.00", "0.00", "0.00"},
            {"Playmobil Circus", "Wii", "2009", "Action", "Mindscape", "0.06", "0.02", "0.00", "0.01"},
            {"Rock Band Country Track Pack 2", "Wii", "2011", "Misc", "MTV Games", "0.08", "0.00", "0.00", "0.00"},
            {"Jumper: Griffin's Story", "Wii", "2008", "Action", "Eidos Interactive", "0.08", "0.00", "0.00", "0.01"},
            {"Jambo! Safari Animal Rescue", "Wii", "2009", "Simulation", "Sega", "0.07", "0.01", "0.00", "0.01"},
            {"Busy Scissors", "Wii", "2010", "Simulation", "Little Orbit", "0.08", "0.00", "0.00", "0.00"},
            {
                "Data East Arcade Classics", "Wii", "2010", "Misc", "Majesco Entertainment", "0.08", "0.00", "0.00", "0.01"
            },
            {"Ski and Shoot", "Wii", "2008", "Sports", "RTL", "0.04", "0.04", "0.00", "0.01"},
            {"Spider-Man: Edge of Time", "Wii", "2011", "Action", "Activision", "0.06", "0.02", "0.00", "0.01"},
            {
                "Green Lantern: Rise of the Manhunters", "Wii", "2011", "Action", "Warner Bros. Interactive Entertainment",
                "0.04", "0.03", "0.00", "0.01"
            },
            {"Ski-Doo Snowmobile Challenge", "Wii", "2009", "Racing", "Valcon Games", "0.08", "0.00", "0.00", "0.00"},
            {"Wacky World of Sports", "Wii", "2009", "Sports", "Sega", "0.07", "0.00", "0.00", "0.01"},
            {"Great Party Games", "Wii", "2010", "Misc", "O-Games", "0.00", "0.07", "0.00", "0.01"},
            {
                "Kamen Rider: Ultra Climax Heroes", "Wii", "2012", "Fighting", "Namco Bandai Games", "0.00", "0.00", "0.08",
                "0.00"
            },
            {"Zero: Tsukihami no Kamen", "Wii", "N/A", "Action", "Nintendo", "0.00", "0.00", "0.08", "0.00"},
            {
                "Mad Dog McCree: Gunslinger Pack", "Wii", "2009", "Shooter", "Majesco Entertainment", "0.07", "0.00",
                "0.00", "0.01"
            },
            {
                "Jikkyou Powerful Pro Yakyuu 15", "Wii", "2008", "Sports", "Konami Digital Entertainment", "0.00", "0.00",
                "0.08", "0.00"
            },
            {"Ninjabread Man", "Wii", "2007", "Action", "Popcorn Arcade", "0.07", "0.00", "0.00", "0.01"},
            {
                "Pro Evolution Soccer 2013", "Wii", "2012", "Sports", "Konami Digital Entertainment", "0.00", "0.01",
                "0.06", "0.00"
            },
            {"Harvey Birdman: Attorney at Law", "Wii", "2008", "Adventure", "Capcom", "0.07", "0.00", "0.00", "0.01"},
            {
                "Super Sentai Battle: Ranger Cross", "Wii", "2011", "Action", "Namco Bandai Games", "0.00", "0.00", "0.08",
                "0.00"
            },
            {"Winter Stars", "Wii", "2011", "Sports", "Deep Silver", "0.04", "0.03", "0.00", "0.01"},
            {"Build 'n Race", "Wii", "2009", "Racing", "Zoo Games", "0.07", "0.00", "0.00", "0.00"},
            {"Martian Panic", "Wii", "2010", "Adventure", "Unknown", "0.07", "0.00", "0.00", "0.00"},
            {"Sengoku Musou 3: Moushouden ", "Wii", "2011", "Action", "Ackkstudios", "0.00", "0.00", "0.08", "0.00"},
            {"Rock Revolution", "Wii", "N/A", "Misc", "Unknown", "0.07", "0.00", "0.00", "0.01"},
            {"Ice Age 2: The Meltdown", "Wii", "2006", "Platform", "Vivendi Games", "0.06", "0.01", "0.00", "0.01"},
            {"Diva Girls: Divas on Ice", "Wii", "2009", "Sports", "505 Games", "0.07", "0.00", "0.00", "0.01"},
            {
                "Jaws: Ultimate Predator", "Wii", "2011", "Action", "Majesco Entertainment", "0.07", "0.00", "0.00", "0.00"
            },
            {"BIT.TRIP COMPLETE", "Wii", "2011", "Misc", "Rising Star Games", "0.05", "0.02", "0.00", "0.01"},
            {"Pop'n Music", "Wii", "2009", "Misc", "Konami Digital Entertainment", "0.07", "0.00", "0.00", "0.00"},
            {
                "Penny Racers Party: Turbo-Q Speedway", "Wii", "2008", "Racing", "Takara Tomy", "0.07", "0.00", "0.00",
                "0.01"
            },
            {
                "SafeCracker: The Ultimate Puzzle Adventure", "Wii", "2008", "Puzzle", "The Adventure Company", "0.07",
                "0.01", "0.00", "0.01"
            },
            {"Ultimate Duck Hunting", "Wii", "2009", "Sports", "Zoo Digital Publishing", "0.07", "0.00", "0.00", "0.01"},
            {"Far Cry Vengeance", "Wii", "2006", "Shooter", "Ubisoft", "0.06", "0.01", "0.00", "0.01"},
            {
                "Jikkyou Powerful Pro Yakyuu Next", "Wii", "2009", "Sports", "Konami Digital Entertainment", "0.00", "0.00",
                "0.08", "0.00"
            },
            {"Aliens in the Attic", "Wii", "2009", "Action", "Playlogic Game Factory", "0.07", "0.00", "0.00", "0.01"},
            {
                "Cartoon Network: Punch Time Explosion XL", "Wii", "2011", "Fighting", "Crave Entertainment", "0.07",
                "0.01", "0.00", "0.00"
            },
            {
                "Champion Jockey: G1 Jockey & Gallop Racer", "Wii", "2011", "Sports", "Tecmo Koei", "0.03", "0.03", "0.01",
                "0.01"
            },
            {"Get Fit with Mel B", "Wii", "2010", "Sports", "Black Bean Games", "0.03", "0.04", "0.00", "0.01"},
            {"Minna no Joushiki Ryoku TV", "Wii", "2008", "Misc", "Nintendo", "0.00", "0.00", "0.08", "0.00"},
            {"How to Train Your Dragon 2", "Wii", "2014", "Adventure", "Little Orbit", "0.03", "0.04", "0.00", "0.01"},
            {
                "Agatha Christie: Evil Under the Sun", "Wii", "2008", "Adventure", "The Adventure Company", "0.06", "0.01",
                "0.00", "0.01"
            },
            {"Worms: A Space Oddity", "Wii", "2008", "Strategy", "THQ", "0.05", "0.01", "0.00", "0.01"},
            {
                "Party Pigs: Farmyard Games", "Wii", "2009", "Misc", "Data Design Interactive", "0.07", "0.00", "0.00",
                "0.00"
            },
            {"Man vs. Wild", "Wii", "2011", "Adventure", "Crave Entertainment", "0.07", "0.00", "0.00", "0.00"},
            {
                "Naruto Shippuuden: Gekitou Ninja Taisen! EX 3", "Wii", "2008", "Fighting", "Takara Tomy", "0.00", "0.00",
                "0.07", "0.00"
            },
            {
                "Cate West: The Vanishing Files", "Wii", "2009", "Adventure", "Oxygen Interactive", "0.07", "0.00", "0.00",
                "0.01"
            },
            {
                "Ultimate Party Challenge", "Wii", "2009", "Misc", "Konami Digital Entertainment", "0.07", "0.00", "0.00",
                "0.00"
            },
            {
                "Lost in Blue: Shipwrecked", "Wii", "2008", "Adventure", "Konami Digital Entertainment", "0.07", "0.00",
                "0.00", "0.01"
            },
            {
                "Little League World Series Baseball: Double Play", "Wii", "2010", "Sports", "Activision", "0.07", "0.00",
                "0.00", "0.00"
            },
            {"Kung Fu Panda: Legendary Warriors", "Wii", "2008", "Action", "Activision", "0.07", "0.00", "0.00", "0.00"},
            {"Baroque", "Wii", "2008", "Role-Playing", "Rising Star Games", "0.07", "0.00", "0.00", "0.00"},
            {"Ultimate Shooting Collection", "Wii", "2008", "Shooter", "Milestone", "0.07", "0.00", "0.00", "0.00"},
            {"Cosmic Family", "Wii", "2007", "Misc", "Ubisoft", "0.06", "0.00", "0.00", "0.01"},
            {"My First Songs", "Wii", "2010", "Misc", "Mindscape", "0.00", "0.06", "0.00", "0.01"},
            {"The $1 Pyramid", "Wii", "2011", "Misc", "Ubisoft", "0.07", "0.00", "0.00", "0.00"},
            {
                "Winning Eleven Playmaker 2010: Aoki Samurai no Chousen", "Wii", "2010", "Sports",
                "Konami Digital Entertainment", "0.00", "0.00", "0.07", "0.00"
            },
            {"Team Elimination Games", "Wii", "2009", "Misc", "Ubisoft", "0.07", "0.00", "0.00", "0.00"},
            {
                "Agatha Christie: And Then There Were None", "Wii", "2008", "Adventure", "The Adventure Company", "0.06",
                "0.01", "0.00", "0.01"
            },
            {"America's Next Top Model", "Wii", "2010", "Action", "Crave Entertainment", "0.07", "0.00", "0.00", "0.00"},
            {
                "Happy Feet Two", "Wii", "N/A", "Adventure", "Warner Bros. Interactive Entertainment", "0.06", "0.01",
                "0.00", "0.00"
            },
            {"Speed Zone", "Wii", "2009", "Racing", "Bethesda Softworks", "0.01", "0.05", "0.00", "0.01"},
            {"World Party Games", "Wii", "2009", "Misc", "505 Games", "0.07", "0.00", "0.00", "0.00"},
            {
                "Rogue Trooper: Quartz Zone Massacre", "Wii", "2009", "Shooter", "Reef Entertainment", "0.06", "0.00",
                "0.00", "0.01"
            },
            {"Crayola: Colorful Journey", "Wii", "2009", "Misc", "Crave Entertainment", "0.07", "0.00", "0.00", "0.00"},
            {"Rugby League 3", "Wii", "2010", "Sports", "Alternative Software", "0.00", "0.06", "0.00", "0.01"},
            {
                "The Penguins of Madagascar: Dr. Blowhole Returns - Again!", "Wii", "2011", "Action", "THQ", "0.04", "0.02",
                "0.00", "0.01"
            },
            {"10 Minute Solution", "Wii", "2010", "Sports", "Activision", "0.05", "0.01", "0.00", "0.00"},
            {
                "Generator Rex: Agent of Providence", "Wii", "2011", "Action", "Activision", "0.06", "0.01", "0.00", "0.00"
            },
            {"Open Season", "Wii", "2006", "Platform", "Ubisoft", "0.06", "0.00", "0.00", "0.01"},
            {"Dave Mirra BMX Challenge", "Wii", "2007", "Sports", "505 Games", "0.06", "0.00", "0.00", "0.01"},
            {
                "Gunblade NY & L.A. Machineguns Arcade Hits Pack", "Wii", "2010", "Shooter", "Sega", "0.06", "0.01", "0.00",
                "0.00"
            },
            {"Target: Terror", "Wii", "2008", "Shooter", "Konami Digital Entertainment", "0.06", "0.00", "0.00", "0.01"},
            {"Dream Dance & Cheer", "Wii", "2009", "Misc", "Zoo Games", "0.06", "0.00", "0.00", "0.00"},
            {
                "Billy's Boot Camp: Wii de Enjoy Diet!", "Wii", "2011", "Sports", "Rocket Company", "0.00", "0.00", "0.07",
                "0.00"
            },
            {
                "Animal Kingdom: Wildlife Expedition", "Wii", "2009", "Adventure", "Natsume", "0.06", "0.00", "0.00",
                "0.00"
            },
            {
                "Suzumiya Haruhi no Gekidou", "Wii", "2009", "Adventure", "Kadokawa Shoten", "0.00", "0.00", "0.07", "0.00"
            },
            {"Let's Paint", "Wii", "2010", "Simulation", "Zoo Games", "0.06", "0.00", "0.00", "0.00"},
            {
                "SNK Arcade Classics Vol. 1", "Wii", "2008", "Misc", "Ignition Entertainment", "0.06", "0.00", "0.00",
                "0.00"
            },
            {"Disaster: Day of Crisis", "Wii", "2008", "Action", "Nintendo", "0.00", "0.02", "0.04", "0.00"},
            {"Yamaha Supercross", "Wii", "2009", "Racing", "Zoo Digital Publishing", "0.05", "0.01", "0.00", "0.01"},
            {
                "Shin Chan: Las Nuevas Aventuras Para Wii!", "Wii", "2006", "Action", "505 Games", "0.00", "0.00", "0.07",
                "0.00"
            },
            {"Mario Tennis", "Wii", "2010", "Sports", "Nintendo", "0.00", "0.06", "0.00", "0.01"},
            {
                "Freddi Fish: Kelp Seed Mystery", "Wii", "2008", "Adventure", "Majesco Entertainment", "0.06", "0.00",
                "0.00", "0.00"
            },
            {"Pizza Delivery Boy", "Wii", "2010", "Simulation", "Majesco Entertainment", "0.06", "0.00", "0.00", "0.00"},
            {"Fantasy Aquarium World", "Wii", "2009", "Simulation", "Destineer", "0.06", "0.00", "0.00", "0.00"},
            {"Heavenly Guardian", "Wii", "2007", "Shooter", "505 Games", "0.06", "0.00", "0.00", "0.00"},
            {"Anubis II", "Wii", "2007", "Platform", "Metro 3D", "0.06", "0.00", "0.00", "0.00"},
            {
                "Basketball Hall of Fame Ultimate Hoops Challenge", "Wii", "2010", "Sports", "Zoo Games", "0.06", "0.00",
                "0.00", "0.00"
            },
            {"Bleach: Versus Crusade", "Wii", "2008", "Fighting", "Sega", "0.00", "0.00", "0.06", "0.00"},
            {"Winter Sports 2011", "Wii", "2011", "Sports", "DTP Entertainment", "0.00", "0.05", "0.00", "0.01"},
            {"Cabela's Trophy Bucks", "Wii", "2008", "Sports", "Activision Value", "0.06", "0.00", "0.00", "0.00"},
            {
                "Build-A-Bear Workshop: Friendship Valley", "Wii", "N/A", "Misc", "Unknown", "0.06", "0.00", "0.00", "0.00"
            },
            {"Escape from Bug Island", "Wii", "2006", "Action", "Eidos Interactive", "0.04", "0.01", "0.01", "0.00"},
            {
                "Fishing Master (jp sales)", "Wii", "2007", "Sports", "Konami Digital Entertainment", "0.00", "0.00",
                "0.06", "0.00"
            },
            {"Legend of the Dragon", "Wii", "2007", "Fighting", "Game Factory", "0.06", "0.00", "0.00", "0.00"},
            {"Reader Rabbit 1st Grade", "Wii", "2010", "Misc", "Graffiti", "0.06", "0.00", "0.00", "0.00"},
            {"Pony Friends 2", "Wii", "2009", "Simulation", "Eidos Interactive", "0.03", "0.02", "0.00", "0.01"},
            {
                "Family Trainer: Treasure Adventure", "Wii", "2010", "Sports", "Namco Bandai Games", "0.00", "0.05", "0.00",
                "0.01"
            },
            {"Spy Games: Elevator Mission", "Wii", "2007", "Shooter", "Tommo", "0.06", "0.00", "0.00", "0.00"},
            {"Cold Stone Creamery: Scoop It Up", "Wii", "2009", "Misc", "Zoo Games", "0.06", "0.00", "0.00", "0.00"},
            {
                "Naruto Shippuden: Gekitou Ninja Taisen Special", "Wii", "2010", "Fighting", "Takara Tomy", "0.00", "0.00",
                "0.06", "0.00"
            },
            {"Tournament of Legends", "Wii", "2010", "Fighting", "Sega", "0.04", "0.02", "0.00", "0.01"},
            {"Cocoto Kart Racer", "Wii", "2008", "Racing", "Conspiracy Entertainment", "0.06", "0.00", "0.00", "0.00"},
            {"Kamen Rider: Dragon Knight", "Wii", "2009", "Fighting", "D3Publisher", "0.06", "0.00", "0.00", "0.00"},
            {"Octomania", "Wii", "2007", "Puzzle", "Midas Interactive Entertainment", "0.06", "0.00", "0.00", "0.00"},
            {"Crazy Chicken Tales", "Wii", "2009", "Action", "Conspiracy Entertainment", "0.06", "0.00", "0.00", "0.00"},
            {
                "Jimmie Johnson's Anything With an Engine", "Wii", "2011", "Racing", "Konami Digital Entertainment", "0.06",
                "0.00", "0.00", "0.00"
            },
            {"Fast Food Panic", "Wii", "2009", "Simulation", "Nobilis", "0.06", "0.00", "0.00", "0.00"},
            {"NHL 2K9", "Wii", "2008", "Sports", "Take-Two Interactive", "0.06", "0.00", "0.00", "0.00"},
            {"Grey's Anatomy: The Video Game", "Wii", "2009", "Adventure", "Ubisoft", "0.05", "0.01", "0.00", "0.00"},
            {
                "Spy Fox in Dry Cereal", "Wii", "2008", "Adventure", "Majesco Entertainment", "0.06", "0.00", "0.00",
                "0.00"
            },
            {"Alien Syndrome", "Wii", "2007", "Role-Playing", "Sega", "0.05", "0.00", "0.00", "0.00"},
            {"Chrysler Classic Racing", "Wii", "2008", "Racing", "Zoo Games", "0.06", "0.00", "0.00", "0.00"},
            {
                "Showtime Championship Boxing", "Wii", "2007", "Fighting", "Zoo Digital Publishing", "0.05", "0.00", "0.00",
                "0.00"
            },
            {"We Sing Rock!", "Wii", "2011", "Misc", "Nordic Games", "0.00", "0.05", "0.00", "0.01"},
            {"Dance Sensation!", "Wii", "2010", "Misc", "Majesco Entertainment", "0.06", "0.00", "0.00", "0.00"},
            {
                "Another Code R: A Journey into Lost Memories", "Wii", "2009", "Adventure", "Nintendo", "0.00", "0.02",
                "0.03", "0.00"
            },
            {"Puzzler Collection", "Wii", "2008", "Puzzle", "Ubisoft", "0.05", "0.00", "0.00", "0.00"},
            {"Chevrolet Camaro: Wild Ride", "Wii", "2010", "Racing", "Storm City Games", "0.05", "0.00", "0.00", "0.00"},
            {
                "Storybook Workshop", "Wii", "2009", "Misc", "Konami Digital Entertainment", "0.05", "0.00", "0.00", "0.00"
            },
            {
                "SD Gundam G Generation Wars", "Wii", "2009", "Strategy", "Namco Bandai Games", "0.00", "0.00", "0.06",
                "0.00"
            },
            {
                "Santa Claus Is Comin' to Town!", "Wii", "2011", "Puzzle", "Crave Entertainment", "0.05", "0.00", "0.00",
                "0.00"
            },
            {"Flip's Twisted World", "Wii", "N/A", "Platform", "Unknown", "0.05", "0.00", "0.00", "0.00"},
            {"Brave: A Warrior's Tale", "Wii", "2009", "Action", "SouthPeak Games", "0.05", "0.00", "0.00", "0.00"},
            {"Rooms: The Main Building", "Wii", "2010", "Adventure", "Hudson Soft", "0.05", "0.00", "0.00", "0.00"},
            {"Ivy the Kiwi?", "Wii", "2010", "Puzzle", "Rising Star Games", "0.04", "0.01", "0.00", "0.00"},
            {"Zumba Fitness Core", "Wii", "2012", "Misc", "505 Games", "0.00", "0.05", "0.00", "0.01"},
            {"Secret Files: Tunguska", "Wii", "2008", "Adventure", "Koch Media", "0.04", "0.01", "0.00", "0.00"},
            {"Kid Fit Island Resort", "Wii", "2010", "Sports", "Avanquest", "0.05", "0.00", "0.00", "0.00"},
            {
                "World Championship Athletics", "Wii", "2009", "Sports", "DTP Entertainment", "0.04", "0.01", "0.00",
                "0.00"
            },
            {"Coraline", "Wii", "2009", "Adventure", "D3Publisher", "0.05", "0.00", "0.00", "0.00"},
            {"Vertigo", "Wii", "2009", "Strategy", "Playlogic Game Factory", "0.05", "0.00", "0.00", "0.00"},
            {"Defendin' De Penguin", "Wii", "2008", "Strategy", "Zushi Games", "0.05", "0.00", "0.00", "0.00"},
            {"Puyo Puyo 7", "Wii", "2009", "Puzzle", "Sega", "0.00", "0.00", "0.05", "0.00"},
            {"Alvin and the Chipmunks", "Wii", "2007", "Misc", "Eidos Interactive", "0.05", "0.00", "0.00", "0.00"},
            {
                "Samurai Shodown Anthology", "Wii", "2008", "Fighting", "Ignition Entertainment", "0.05", "0.00", "0.00",
                "0.00"
            },
            {
                "Pretty Cure All Stars Everyone Gather ? Let's Dance!", "Wii", "2013", "Misc", "Namco Bandai Games", "0.00",
                "0.00", "0.05", "0.00"
            },
            {"Countdown: The Game", "Wii", "2009", "Puzzle", "Mindscape", "0.00", "0.05", "0.00", "0.00"},
            {"Domino Rally", "Wii", "2007", "Action", "Nordcurrent", "0.05", "0.00", "0.00", "0.00"},
            {"PopStar Guitar", "Wii", "2008", "Misc", "Midway Games", "0.03", "0.02", "0.00", "0.01"},
            {"Speed", "Wii", "2010", "Racing", "Unknown", "0.03", "0.01", "0.00", "0.00"},
            {"Roogoo Twisted Towers", "Wii", "2009", "Puzzle", "SouthPeak Games", "0.05", "0.00", "0.00", "0.00"},
            {
                "Mr Bean's Wacky World of Wii", "Wii", "2009", "Adventure", "Blast! Entertainment Ltd", "0.00", "0.05",
                "0.00", "0.00"
            },
            {"Captain America: Super Soldier", "Wii", "N/A", "Action", "Sega", "0.05", "0.00", "0.00", "0.00"},
            {"Jenga World Tour", "Wii", "2007", "Misc", "Atari", "0.05", "0.00", "0.00", "0.00"},
            {"Sam & Max: Beyond Time and Space", "Wii", "2010", "Adventure", "Atari", "0.05", "0.00", "0.00", "0.00"},
            {
                "Hysteria Hospital: Emergency Ward", "Wii", "2009", "Action", "Oxygen Interactive", "0.05", "0.00", "0.00",
                "0.00"
            },
            {"My Horse & Me: Riding for Gold", "Wii", "2008", "Sports", "Atari", "0.04", "0.01", "0.00", "0.00"},
            {"Pheasants Forever Wingshooter", "Wii", "2010", "Shooter", "Unknown", "0.03", "0.02", "0.00", "0.00"},
            {"Super Robot Taisen Neo", "Wii", "2009", "Strategy", "Namco Bandai Games", "0.00", "0.00", "0.05", "0.00"},
            {
                "Sled Shred featuring the Jamaican Bobsled Team", "Wii", "2010", "Sports", "SouthPeak Games", "0.05",
                "0.00", "0.00", "0.00"
            },
            {
                "Major Minor's Majestic March", "Wii", "2009", "Misc", "Majesco Entertainment", "0.05", "0.00", "0.00",
                "0.00"
            },
            {"Myth Makers: Orbs of Doom", "Wii", "2007", "Puzzle", "Popcorn Arcade", "0.05", "0.00", "0.00", "0.00"},
            {"Furu Furu Park", "Wii", "2007", "Misc", "Taito", "0.05", "0.00", "0.00", "0.00"},
            {"SD Gundam: Scad Hammers", "Wii", "2006", "Strategy", "Namco Bandai Games", "0.00", "0.00", "0.05", "0.00"},
            {"Dream Salon", "Wii", "2009", "Misc", "Zoo Games", "0.05", "0.00", "0.00", "0.00"},
            {
                "The Grim Adventures of Billy & Mandy", "Wii", "2006", "Action", "Midway Games", "0.04", "0.00", "0.00",
                "0.00"
            },
            {"Centipede: Infestation", "Wii", "2011", "Shooter", "Atari", "0.05", "0.00", "0.00", "0.00"},
            {"Kart Racer", "Wii", "2009", "Racing", "Nordic Games", "0.03", "0.01", "0.00", "0.00"},
            {"Hotel for Dogs", "Wii", "2009", "Simulation", "505 Games", "0.04", "0.00", "0.00", "0.00"},
            {"My Fitness Coach: Club", "Wii", "2011", "Sports", "Ubisoft", "0.00", "0.04", "0.00", "0.01"},
            {"Wii de Asobu Chibi-Robo!", "Wii", "2009", "Adventure", "Nintendo", "0.00", "0.00", "0.05", "0.00"},
            {
                "SD Gundam G Generation World", "Wii", "2011", "Strategy", "Namco Bandai Games", "0.00", "0.00", "0.05",
                "0.00"
            },
            {
                "Billy the Wizard: Rocket Broomstick Racing", "Wii", "2007", "Racing", "Metro 3D", "0.04", "0.00", "0.00",
                "0.00"
            },
            {
                "World Series of Poker: Tournament of Champions 2007 Edition", "Wii", "2006", "Misc", "Activision", "0.04",
                "0.00", "0.00", "0.00"
            },
            {"MiniCopter: Adventure Flight", "Wii", "2007", "Simulation", "505 Games", "0.04", "0.00", "0.00", "0.00"},
            {"Balloon Pop", "Wii", "2007", "Puzzle", "505 Games", "0.04", "0.00", "0.00", "0.00"},
            {"Counter Force", "Wii", "2007", "Shooter", "505 Games", "0.04", "0.00", "0.00", "0.00"},
            {"Wing Island", "Wii", "2006", "Simulation", "Konami Digital Entertainment", "0.03", "0.01", "0.01", "0.00"},
            {
                "Winter Sports 3: The Great Tournament", "Wii", "2010", "Sports", "Tradewest", "0.02", "0.02", "0.00",
                "0.00"
            },
            {"Pool Party", "Wii", "2007", "Sports", "SouthPeak Games", "0.04", "0.00", "0.00", "0.00"},
            {
                "Wonder World Amusement Park", "Wii", "2008", "Misc", "Majesco Entertainment", "0.04", "0.00", "0.00",
                "0.00"
            },
            {"Pool Hall Pro", "Wii", "2009", "Sports", "Playlogic Game Factory", "0.04", "0.00", "0.00", "0.00"},
            {
                "Back to the Future: The Game", "Wii", "2011", "Adventure", "Telltale Games", "0.04", "0.00", "0.00",
                "0.00"
            },
            {"The Tale of Despereaux", "Wii", "2008", "Platform", "Brash Entertainment", "0.04", "0.00", "0.00", "0.00"},
            {"Reader Rabbit 2nd Grade", "Wii", "N/A", "Misc", "Unknown", "0.04", "0.00", "0.00", "0.00"},
            {"Pirates vs Ninja Dodgeball", "Wii", "2009", "Sports", "SouthPeak Games", "0.04", "0.00", "0.00", "0.00"},
            {
                "Fantastic Four: Rise of the Silver Surfer", "Wii", "2007", "Action", "Take-Two Interactive", "0.04",
                "0.00", "0.00", "0.00"
            },
            {"Sushi Go-Round", "Wii", "2010", "Simulation", "Asylum Entertainment", "0.04", "0.00", "0.00", "0.00"},
            {
                "Minna ga Shuyaku no NHK Kouhaku Quiz Kassen", "Wii", "2009", "Misc", "Nintendo", "0.00", "0.00", "0.04",
                "0.00"
            },
            {"Castle of Shikigami III", "Wii", "2007", "Shooter", "PQube", "0.04", "0.00", "0.00", "0.00"},
            {
                "Monster Trux Arenas: Special Edition", "Wii", "2007", "Racing", "Popcorn Arcade", "0.04", "0.00", "0.00",
                "0.00"
            },
            {"Backyard Baseball '09", "Wii", "2008", "Sports", "Atari", "0.04", "0.00", "0.00", "0.00"},
            {"M&M's Beach Party", "Wii", "2009", "Misc", "Zoo Digital Publishing", "0.04", "0.00", "0.00", "0.00"},
            {"SPRay", "Wii", "2008", "Action", "Tecmo Koei", "0.04", "0.00", "0.00", "0.00"},
            {"Battle Rage", "Wii", "2008", "Shooter", "Popcorn Arcade", "0.04", "0.00", "0.00", "0.00"},
            {"Gem Smashers", "Wii", "2011", "Platform", "Crave Entertainment", "0.04", "0.00", "0.00", "0.00"},
            {"The Monkey King: The Legend Begins", "Wii", "2007", "Shooter", "Starfish", "0.04", "0.00", "0.00", "0.00"},
            {
                "Myth Makers: Trixie in Toyland", "Wii", "2008", "Platform", "Popcorn Arcade", "0.04", "0.00", "0.00",
                "0.00"
            },
            {"Honda ATV Fever", "Wii", "2010", "Racing", "Storm City Games", "0.04", "0.00", "0.00", "0.00"},
            {
                "Active Life: Magical Carnival", "Wii", "2011", "Misc", "Namco Bandai Games", "0.03", "0.01", "0.00",
                "0.00"
            },
            {
                "Mortimer Beckett and the Secrets of Spooky Manor", "Wii", "2008", "Puzzle", "Avanquest", "0.04", "0.00",
                "0.00", "0.00"
            },
            {"Jerry Rice and Nitus' Dog Football", "Wii", "2011", "Sports", "Tommo", "0.04", "0.00", "0.00", "0.00"},
            {"Guilty Gear XX Accent Core", "Wii", "2007", "Fighting", "505 Games", "0.03", "0.00", "0.00", "0.00"},
            {"Barnyard", "Wii", "2006", "Action", "THQ", "0.04", "0.00", "0.00", "0.00"},
            {
                "North American Hunting Extravaganza 2", "Wii", "2010", "Sports", "Unknown", "0.03", "0.00", "0.00", "0.00"
            },
            {
                "Sea Monsters: A Prehistoric Adventure", "Wii", "2007", "Adventure", "Zushi Games", "0.04", "0.00", "0.00",
                "0.00"
            },
            {
                "Daikaijuu Battle: Ultra Coliseum DX - Ultra Senshi Daishuuketsu", "Wii", "2010", "Fighting",
                "Namco Bandai Games", "0.00", "0.00", "0.04", "0.00"
            },
            {"Gummy Bears Mini Golf", "Wii", "2010", "Sports", "Unknown", "0.04", "0.00", "0.00", "0.00"},
            {"Twin Strike: Operation Thunder", "Wii", "2008", "Shooter", "Zoo Games", "0.04", "0.00", "0.00", "0.00"},
            {"The Kore Gang", "Wii", "2010", "Platform", "Flashpoint Games", "0.04", "0.00", "0.00", "0.00"},
            {"Glacier2", "Wii", "2009", "Racing", "Zoo Games", "0.04", "0.00", "0.00", "0.00"},
            {
                "Story Hour: Fairy Tales", "Wii", "2008", "Adventure", "Zoo Digital Publishing", "0.04", "0.00", "0.00",
                "0.00"
            },
            {"Arctic Tale", "Wii", "2007", "Adventure", "Zoo Digital Publishing", "0.03", "0.00", "0.00", "0.00"},
            {"Sleepover Party", "Wii", "2009", "Misc", "Ubisoft", "0.03", "0.00", "0.00", "0.00"},
            {"Free Running", "Wii", "2009", "Sports", "Reef Entertainment", "0.02", "0.01", "0.00", "0.00"},
            {
                "Jikkyou Powerful Major League 2009", "Wii", "2009", "Sports", "Konami Digital Entertainment", "0.00",
                "0.00", "0.04", "0.00"
            },
            {"NatGeo Challenge! Wild Life", "Wii", "2010", "Misc", "Black Bean Games", "0.03", "0.00", "0.00", "0.00"},
            {"Sudoku Ball Detective", "Wii", "2009", "Puzzle", "Playlogic Game Factory", "0.02", "0.01", "0.00", "0.00"},
            {
                "Sherlock Holmes: Secret of The Silver Earring", "Wii", "2010", "Adventure", "Focus Home Interactive",
                "0.00", "0.03", "0.00", "0.01"
            },
            {
                "Gormiti: The Lords of Nature!", "Wii", "2010", "Adventure", "Konami Digital Entertainment", "0.03", "0.00",
                "0.00", "0.00"
            },
            {"Cook Wars", "Wii", "2009", "Misc", "Ubisoft", "0.03", "0.00", "0.00", "0.00"},
            {"City Builder", "Wii", "2010", "Misc", "Virtual Play Games", "0.03", "0.00", "0.00", "0.00"},
            {"Luxor: Pharaoh's Challenge", "Wii", "N/A", "Puzzle", "Funsta", "0.01", "0.02", "0.00", "0.00"},
            {"Zenkoku Dekotora Matsuri", "Wii", "2008", "Racing", "Jaleco", "0.00", "0.00", "0.03", "0.00"},
            {"Bionicle Heroes", "Wii", "2007", "Shooter", "Eidos Interactive", "0.03", "0.00", "0.00", "0.00"},
            {"Marines: Modern Urban Combat", "Wii", "2010", "Shooter", "O-Games", "0.03", "0.00", "0.00", "0.00"},
            {
                "Kekkaishi: Kokubourou no Kage", "Wii", "2007", "Action", "Namco Bandai Games", "0.00", "0.00", "0.03",
                "0.00"
            },
            {
                "Jikkyou Powerful Pro Yakyuu Wii Ketteiban", "Wii", "2007", "Sports", "Konami Digital Entertainment",
                "0.00", "0.00", "0.03", "0.00"
            },
            {
                "Safari Adventures: Africa", "Wii", "2007", "Adventure", "Neko Entertainment", "0.03", "0.00", "0.00",
                "0.00"
            },
            {"Jewel Master: Cradle of Rome", "Wii", "2008", "Puzzle", "Rondomedia", "0.03", "0.00", "0.00", "0.00"},
            {"My Body Coach", "Wii", "2009", "Sports", "Big Ben Interactive", "0.00", "0.03", "0.00", "0.00"},
            {"Kevin Van Dam: Big Bass Challenge", "Wii", "2010", "Sports", "Zoo Games", "0.03", "0.00", "0.00", "0.00"},
            {
                "Eyeshield 21: Field Saikyou no Senshi Tachi", "Wii", "2007", "Role-Playing", "Nintendo", "0.00", "0.00",
                "0.03", "0.00"
            },
            {"thinkSMART FAMILY!", "Wii", "2010", "Misc", "Conspiracy Entertainment", "0.03", "0.00", "0.00", "0.00"},
            {
                "Maximum Racing: Drag & Stock Racer", "Wii", "2010", "Racing", "Nordic Games", "0.03", "0.00", "0.00",
                "0.00"
            },
            {"Swords", "Wii", "N/A", "Fighting", "Unknown", "0.03", "0.00", "0.00", "0.00"},
            {"Guilty Gear XX Accent Core Plus", "Wii", "2009", "Fighting", "PQube", "0.01", "0.02", "0.00", "0.00"},
            {
                "Maximum Racing: GP Classic Racing", "Wii", "2010", "Racing", "Nordic Games", "0.03", "0.00", "0.00",
                "0.00"
            },
            {"Challenge Me: Brain Puzzles 2", "Wii", "2010", "Puzzle", "O-Games", "0.00", "0.03", "0.00", "0.00"},
            {"Beastly", "Wii", "2011", "Misc", "Unknown", "0.03", "0.00", "0.00", "0.00"},
            {
                "Story Hour: Adventures", "Wii", "2008", "Adventure", "Zoo Digital Publishing", "0.03", "0.00", "0.00",
                "0.00"
            },
            {
                "SD Gundam: Gashapon Wars", "Wii", "2010", "Strategy", "Namco Bandai Games", "0.00", "0.00", "0.03", "0.00"
            },
            {"Boot Camp Academy", "Wii", "2010", "Action", "Zoo Games", "0.03", "0.00", "0.00", "0.00"},
            {
                "Heathcliff! The Fast and the Furriest", "Wii", "2010", "Racing", "Storm City Games", "0.03", "0.00",
                "0.00", "0.00"
            },
            {"Wicked Monster Blast!", "Wii", "2011", "Shooter", "PQube", "0.02", "0.00", "0.00", "0.00"},
            {"Pacific Liberator", "Wii", "2009", "Action", "Zoo Games", "0.03", "0.00", "0.00", "0.00"},
            {
                "Puzzle Challenge: Crosswords and More!", "Wii", "2009", "Puzzle", "Crave Entertainment", "0.03", "0.00",
                "0.00", "0.00"
            },
            {
                "The Island of Dr. Frankenstein", "Wii", "2009", "Adventure", "Storm City Games", "0.03", "0.00", "0.00",
                "0.00"
            },
            {
                "Who Wants to be a Millionaire: 1st Edition", "Wii", "2007", "Misc", "Ubisoft", "0.00", "0.02", "0.00",
                "0.00"
            },
            {
                "Gintama: Banji Oku Chuubu!", "Wii", "2007", "Action", "Namco Bandai Games", "0.00", "0.00", "0.03", "0.00"
            },
            {"101-in-1 Sports Party Megamix", "Wii", "2010", "Sports", "Nordcurrent", "0.02", "0.00", "0.00", "0.00"},
            {"The Croods: Prehistoric Party!", "Wii", "2013", "Misc", "D3Publisher", "0.01", "0.02", "0.00", "0.00"},
            {
                "Secret Files 2: Puritas Cordis", "Wii", "2009", "Adventure", "Deep Silver", "0.00", "0.02", "0.00", "0.00"
            },
            {"Driver: Parallel Lines", "Wii", "2007", "Racing", "Ubisoft", "0.01", "0.01", "0.00", "0.00"},
            {"Backyard NFL Football", "Wii", "2007", "Sports", "Atari", "0.02", "0.00", "0.00", "0.00"},
            {"My Ballet Studio", "Wii", "2009", "Simulation", "505 Games", "0.02", "0.00", "0.00", "0.00"},
            {
                "Monster Mayhem: Build and Battle", "Wii", "2009", "Simulation", "Zushi Games", "0.02", "0.00", "0.00",
                "0.00"
            },
            {"Kawasaki Snowmobiles", "Wii", "2008", "Racing", "Metro 3D", "0.02", "0.00", "0.00", "0.00"},
            {"Pro Yakyuu Family Stadium", "Wii", "2008", "Sports", "Namco Bandai Games", "0.00", "0.00", "0.03", "0.00"},
            {
                "Combat Wings: The Great Battles of WWII", "Wii", "N/A", "Simulation", "City Interactive", "0.02", "0.00",
                "0.00", "0.00"
            },
            {"Ocean Commander", "Wii", "2009", "Simulation", "Valcon Games", "0.02", "0.00", "0.00", "0.00"},
            {"Let's Play Ballerina", "Wii", "2010", "Sports", "Deep Silver", "0.02", "0.00", "0.00", "0.00"},
            {"CID The Dummy", "Wii", "2009", "Platform", "Oxygen Interactive", "0.02", "0.00", "0.00", "0.00"},
            {"Rock 'N' Roll Adventures", "Wii", "2007", "Platform", "Popcorn Arcade", "0.02", "0.00", "0.00", "0.00"},
            {"Let's Play Garden", "Wii", "2010", "Simulation", "Deep Silver", "0.02", "0.00", "0.00", "0.00"},
            {"Wii de Asobu: Metroid Prime", "Wii", "N/A", "Shooter", "Nintendo", "0.00", "0.00", "0.02", "0.00"},
            {
                "Mesaze!! Tsuri Master: Sekai ni Challenge! Hen", "Wii", "2008", "Sports", "Hudson Soft", "0.00", "0.00",
                "0.02", "0.00"
            },
            {
                "George of the Jungle and the Search for the Secret", "Wii", "2008", "Platform", "Ignition Entertainment",
                "0.02", "0.00", "0.00", "0.00"
            },
            {"Cocoto Magic Circus", "Wii", "2008", "Shooter", "Neko Entertainment", "0.02", "0.00", "0.00", "0.00"},
            {"Suzumiya Haruhi no Heiretsu", "Wii", "2009", "Adventure", "Sega", "0.00", "0.00", "0.02", "0.00"},
            {"Line Rider 2: Unbound", "Wii", "2008", "Puzzle", "Deep Silver", "0.02", "0.00", "0.00", "0.00"},
            {"Crazy Machines", "Wii", "2010", "Puzzle", "DTP Entertainment", "0.01", "0.01", "0.00", "0.00"},
            {"Let's Dance with Mel B", "Wii", "2011", "Sports", "Black Bean Games", "0.00", "0.02", "0.00", "0.00"},
            {"Kawasaki Jet Ski", "Wii", "2008", "Racing", "Metro 3D", "0.02", "0.00", "0.00", "0.00"},
            {
                "Chuck E. Cheese's Sports Games", "Wii", "2011", "Sports", "UFO Interactive", "0.02", "0.00", "0.00",
                "0.00"
            },
            {"My Animal Centre", "Wii", "2009", "Simulation", "Deep Silver", "0.00", "0.02", "0.00", "0.00"},
            {"Saint", "Wii", "N/A", "Shooter", "Unknown", "0.02", "0.00", "0.00", "0.00"},
            {"Geon Cube", "Wii", "2009", "Puzzle", "P2 Games", "0.02", "0.00", "0.00", "0.00"},
            {
                "Triple Crown Championship Snowboarding", "Wii", "2010", "Sports", "Destineer", "0.02", "0.00", "0.00",
                "0.00"
            },
            {"Jinsei Game Wii", "Wii", "2007", "Misc", "Takara Tomy", "0.00", "0.00", "0.02", "0.00"},
            {"Fritz Chess", "Wii", "2009", "Strategy", "Deep Silver", "0.02", "0.00", "0.00", "0.00"},
            {"Balls of Fury", "Wii", "2007", "Sports", "Zoo Digital Publishing", "0.02", "0.00", "0.00", "0.00"},
            {
                "Katekyoo Hitman Reborn! Dream Hyper Battle! Wii", "Wii", "2008", "Fighting", "Marvelous Interactive",
                "0.00", "0.00", "0.02", "0.00"
            },
            {
                "Who Wants to be a Millionaire: 2nd Edition", "Wii", "2008", "Misc", "Ubisoft", "0.00", "0.02", "0.00",
                "0.00"
            },
            {
                "World Championship Poker featuring Howard Lederer: All In", "Wii", "2006", "Misc", "505 Games", "0.02",
                "0.00", "0.00", "0.00"
            },
            {
                "Daikaijuu Battle: Ultra Coliseum", "Wii", "2008", "Fighting", "Namco Bandai Games", "0.00", "0.00", "0.02",
                "0.00"
            },
            {"Bigfoot King of Crush", "Wii", "2011", "Racing", "Zoo Games", "0.02", "0.00", "0.00", "0.00"},
            {"Harley-Davidson: Road Trip", "Wii", "2010", "Racing", "Destineer", "0.02", "0.00", "0.00", "0.00"},
            {
                "Casper's Scare School: Spooky Sports Day", "Wii", "2009", "Sports", "Blast! Entertainment Ltd", "0.02",
                "0.00", "0.00", "0.00"
            },
            {"G1 Jockey Wii", "Wii", "2007", "Sports", "Tecmo Koei", "0.00", "0.00", "0.02", "0.00"},
            {
                "Princess Isabella: A Witch's Curse", "Wii", "2010", "Adventure", "Destineer", "0.02", "0.00", "0.00",
                "0.00"
            },
            {"Ten Pin Alley 2", "Wii", "2008", "Sports", "XS Games", "0.02", "0.00", "0.00", "0.00"},
            {
                "Yu-Gi-Oh! 5D's Wheelie Breakers (JP sales)", "Wii", "N/A", "Racing", "Unknown", "0.00", "0.00", "0.02",
                "0.00"
            },
            {"Army Rescue", "Wii", "2009", "Shooter", "UFO Interactive", "0.02", "0.00", "0.00", "0.00"},
            {"Super Fruit Fall", "Wii", "2006", "Puzzle", "System 3 Arcade Software", "0.01", "0.00", "0.00", "0.00"},
            {"Winter Blast: 9 Snow & Ice Games", "Wii", "2010", "Sports", "Destineer", "0.02", "0.00", "0.00", "0.00"},
            {"Maximum Racing: Crash Car Racer", "Wii", "2010", "Racing", "Nordic Games", "0.01", "0.01", "0.00", "0.00"},
            {"Earth Seeker", "Wii", "2011", "Role-Playing", "Kadokawa Shoten", "0.00", "0.00", "0.02", "0.00"},
            {
                "Jelly Belly: Ballistic Beans", "Wii", "2009", "Puzzle", "Zoo Digital Publishing", "0.02", "0.00", "0.00",
                "0.00"
            },
            {
                "Ferrari Challenge Trofeo Pirelli Deluxe", "Wii", "2009", "Racing", "System 3 Arcade Software", "0.00",
                "0.02", "0.00", "0.00"
            },
            {
                "Chuck E. Cheese's Super Collection", "Wii", "2011", "Action", "UFO Interactive", "0.02", "0.00", "0.00",
                "0.00"
            },
            {"Rock Blast", "Wii", "2010", "Puzzle", "UFO Interactive", "0.02", "0.00", "0.00", "0.00"},
            {"Emergency Mayhem", "Wii", "2008", "Racing", "Codemasters", "0.02", "0.00", "0.00", "0.00"},
            {
                "Mary King's Riding School 2", "Wii", "2009", "Simulation", "Midas Interactive Entertainment", "0.00",
                "0.02", "0.00", "0.00"
            },
            {
                "Haneru no Tobira Wii: Girigirissu", "Wii", "2007", "Misc", "Namco Bandai Games", "0.00", "0.00", "0.02",
                "0.00"
            },
            {
                "Disney Planes Fire & Rescue", "Wii", "2014", "Action", "Disney Interactive Studios", "0.00", "0.01",
                "0.00", "0.00"
            },
            {"Myth Makers: Super Kart GP", "Wii", "2007", "Racing", "Popcorn Arcade", "0.01", "0.00", "0.00", "0.00"},
            {"Soul Eater: Monotone Princess", "Wii", "2008", "Action", "Square Enix", "0.00", "0.00", "0.02", "0.00"},
            {"TV Total Events", "Wii", "2011", "Misc", "7G//AMES", "0.00", "0.01", "0.00", "0.00"},
            {"Thomas & Friends: Hero of the Rails", "Wii", "2010", "Misc", "Unknown", "0.00", "0.01", "0.00", "0.00"},
            {
                "Densha de Go! Shinkansen EX: Sanyou Shinkansen-hen", "Wii", "2007", "Simulation", "Taito", "0.00", "0.00",
                "0.02", "0.00"
            },
            {"Germany's Next Topmodel 2011", "Wii", "2011", "Simulation", "7G//AMES", "0.00", "0.01", "0.00", "0.00"},
            {"Wild West Shootout", "Wii", "2010", "Shooter", "Unknown", "0.01", "0.01", "0.00", "0.00"},
            {
                "Horrid Henry: Missions of Mischief", "Wii", "2010", "Adventure", "SouthPeak Games", "0.00", "0.01", "0.00",
                "0.00"
            },
            {
                "GTI Club: Supermini Festa!", "Wii", "2010", "Racing", "Konami Digital Entertainment", "0.01", "0.00",
                "0.00", "0.00"
            },
            {"Summer Challenge: Athletics Tournament", "Wii", "2011", "Sports", "PQube", "0.00", "0.01", "0.00", "0.00"},
            {"Canada Hunt", "Wii", "2010", "Sports", "Virtual Play Games", "0.02", "0.00", "0.00", "0.00"},
            {
                "Ferrari: The Race Experience", "Wii", "N/A", "Racing", "System 3 Arcade Software", "0.00", "0.01", "0.00",
                "0.00"
            },
            {"Monster Trux Offroad", "Wii", "2007", "Racing", "Popcorn Arcade", "0.01", "0.00", "0.00", "0.00"},
            {"Titanic Mystery", "Wii", "2010", "Puzzle", "O-Games", "0.01", "0.00", "0.00", "0.00"},
            {"Dance! It's Your Stage", "Wii", "N/A", "Misc", "DTP Entertainment", "0.00", "0.01", "0.00", "0.00"},
            {"Pirates PlundArrr", "Wii", "2010", "Action", "Majesco Entertainment", "0.01", "0.00", "0.00", "0.00"},
            {"Donkey Kong Jungle Beat", "Wii", "2008", "Platform", "Nintendo", "0.00", "0.01", "0.00", "0.00"},
            {"Turbo: Super Stunt Squad", "Wii", "2013", "Sports", "D3Publisher", "0.00", "0.01", "0.00", "0.00"},
            {
                "Marvel Superheroes 3D: Grandmaster's Challenge", "Wii", "2010", "Action", "Neko Entertainment", "0.00",
                "0.01", "0.00", "0.00"
            },
            {
                "Major Dream: Major Wii Nagero! Gyroball!!", "Wii", "2008", "Sports", "Takara Tomy", "0.00", "0.00", "0.01",
                "0.00"
            },
            {"Super PickUps", "Wii", "2009", "Racing", "XS Games", "0.01", "0.00", "0.00", "0.00"},
            {"Young Justice: Legacy", "Wii", "2013", "Adventure", "Namco Bandai Games", "0.00", "0.01", "0.00", "0.00"},
            {"Pippa Funnell: Ranch Rescue", "Wii", "2007", "Adventure", "Ubisoft", "0.00", "0.01", "0.00", "0.00"},
            {
                "SoulCalibur Legends (JP sales)", "Wii", "2007", "Action", "Namco Bandai Games", "0.00", "0.00", "0.01",
                "0.00"
            },
            {
                "I Love Horses: Rider's Paradise", "Wii", "2010", "Simulation", "Destineer", "0.01", "0.00", "0.00", "0.00"
            },
            {"Satisfashion", "Wii", "2010", "Misc", "Destineer", "0.01", "0.00", "0.00", "0.00"},
            {"Turbo Trainz", "Wii", "2012", "Racing", "Mastertronic", "0.00", "0.01", "0.00", "0.00"},
            {"Groovin' Blocks", "Wii", "2009", "Puzzle", "Zoo Games", "0.01", "0.00", "0.00", "0.00"},
            {"Family Jockey", "Wii", "2008", "Sports", "Namco Bandai Games", "0.00", "0.00", "0.01", "0.00"},
            {"Sengoku Basara 2 Heroes", "Wii", "2007", "Action", "Capcom", "0.00", "0.00", "0.01", "0.00"},
            {"Doraemon Wii: Himitsu Douguou Ketteisen!", "Wii", "2007", "Misc", "Sega", "0.00", "0.00", "0.01", "0.00"},
            {
                "Dance Dance Revolution: Hottest Party 5", "Wii", "2011", "Misc", "Konami Digital Entertainment", "0.00",
                "0.01", "0.00", "0.00"
            },
            {"Happy Dance Collection", "Wii", "2008", "Misc", "Namco Bandai Games", "0.00", "0.00", "0.01", "0.00"},
            {
                "Fullmetal Alchemist: Prince of the Dawn", "Wii", "2009", "Adventure", "Square Enix", "0.00", "0.00",
                "0.01", "0.00"
            },
            {
                "Captain Morgane and the Golden Turtle", "Wii", "2012", "Adventure", "Reef Entertainment", "0.00", "0.01",
                "0.00", "0.00"
            },
            {"th!nk Logic Trainer", "Wii", "2009", "Puzzle", "Conspiracy Entertainment", "0.01", "0.00", "0.00", "0.00"},
            {"Aladdin Magic Racer", "Wii", "2011", "Racing", "Big Ben Interactive", "0.01", "0.00", "0.00", "0.00"},
            {
                "The Cages: Pro Style Batting Practice", "Wii", "2010", "Sports", "Konami Digital Entertainment", "0.01",
                "0.00", "0.00", "0.00"
            },
            {
                "Katekyoo Hitman Reborn! Kindan no Yami no Delta", "Wii", "2008", "Action", "Marvelous Interactive", "0.00",
                "0.00", "0.01", "0.00"
            },
            {"Captain Rainbow", "Wii", "2008", "Adventure", "Nintendo", "0.00", "0.00", "0.01", "0.00"},
            {"Case Closed: One Truth Prevails", "Wii", "2007", "Adventure", "Nobilis", "0.00", "0.00", "0.01", "0.00"},
            {"Bomberman", "Wii", "2008", "Puzzle", "Hudson Entertainment", "0.00", "0.00", "0.01", "0.00"},
            {"Truck Racer", "Wii", "2009", "Racing", "Nordic Games", "0.00", "0.01", "0.00", "0.00"},
            {
                "Teenage Mutant Ninja Turtles", "Wii", "2007", "Platform", "Konami Digital Entertainment", "0.00", "0.01",
                "0.00", "0.00"
            },
            {
                "PDC World Championship Darts 2009", "Wii", "2009", "Sports", "Oxygen Interactive", "0.00", "0.01", "0.00",
                "0.00"
            },
            {
                "Mahou Sensei Negima!? Neo-Pactio Fight!!", "Wii", "2007", "Fighting", "Marvelous Interactive", "0.00",
                "0.00", "0.01", "0.00"
            },
            {
                "Gummy Bears Magical Medallion", "Wii", "2011", "Platform", "Storm City Games", "0.01", "0.00", "0.00",
                "0.00"
            },
            {
                "Yattaman Wii: BikkuriDokkiri Machine de Mou Race da Koron", "Wii", "2008", "Racing", "Takara Tomy", "0.00",
                "0.00", "0.01", "0.00"
            },
            {"Offshore Tycoon", "Wii", "2009", "Strategy", "Unknown", "0.01", "0.00", "0.00", "0.00"},
            {"Mini Desktop Racing", "Wii", "2007", "Racing", "Popcorn Arcade", "0.01", "0.00", "0.00", "0.00"},
            {
                "Help Wanted: 50 Wacky Jobs (jp sales)", "Wii", "2008", "Simulation", "Hudson Soft", "0.00", "0.00", "0.01",
                "0.00"
            },
            {"Takt of Magic", "Wii", "2009", "Role-Playing", "Nintendo", "0.00", "0.00", "0.01", "0.00"},
            {
                "Anime Slot Revolution: Pachi-Slot Mobile Suit Gundam II - Ai Senshi Hen", "Wii", "2007", "Misc",
                "Yamasa Entertainment", "0.00", "0.00", "0.01", "0.00"
            },
            {
                "The Ultimate Battle of the Sexes", "Wii", "2010", "Misc", "DTP Entertainment", "0.01", "0.00", "0.00",
                "0.00"
            },
            {"Transformers: Prime", "Wii", "2012", "Action", "Activision", "0.00", "0.01", "0.00", "0.00"},
            {"Fit & Fun", "Wii", "2011", "Sports", "Unknown", "0.00", "0.01", "0.00", "0.00"},
            {
                "Smiley World: Island Challenge", "Wii", "2009", "Puzzle", "Zoo Digital Publishing", "0.01", "0.00", "0.00",
                "0.00"
            },
            {"Pirate Blast", "Wii", "2011", "Misc", "Zoo Games", "0.01", "0.00", "0.00", "0.00"},
            {
                "Brave: The Video Game", "Wii", "2012", "Action", "Disney Interactive Studios", "0.00", "0.01", "0.00",
                "0.00"
            },
            {
                "Rebel Raiders: Operation Nighthawk", "Wii", "2008", "Simulation", "Kando Games", "0.01", "0.00", "0.00",
                "0.00"
            },
            {"Max & the Magic Marker", "Wii", "2011", "Platform", "Unknown", "0.00", "0.01", "0.00", "0.00"},
            {
                "Anpanman Niko Niko Party", "Wii", "2010", "Misc", "Agatsuma Entertainment", "0.00", "0.00", "0.01", "0.00"
            },
            {"Challenge Me: Word Puzzles", "Wii", "2011", "Puzzle", "O-Games", "0.00", "0.00", "0.00", "0.00"},
            {"Winning Post World 2010", "Wii", "2010", "Sports", "Tecmo Koei", "0.00", "0.00", "0.01", "0.00"},
            {
                "Jissen Pachi-Slot Pachinko Hisshouhou! Wii Hokuto no Ken Sammy's Collection", "Wii", "2007", "Misc",
                "Sega", "0.00", "0.00", "0.01", "0.00"
            },
            {"Action Girlz Racing", "Wii", "2007", "Racing", "Metro 3D", "0.01", "0.00", "0.00", "0.00"},
            {
                "Bob the Builder: Festival of Fun", "Wii", "2009", "Action", "Blast! Entertainment Ltd", "0.00", "0.01",
                "0.00", "0.00"
            },
            {"Kidz Sports International Soccer", "Wii", "2008", "Sports", "Bold Games", "0.01", "0.00", "0.00", "0.00"},
            {"Rig Racer 2", "Wii", "2008", "Racing", "Popcorn Arcade", "0.01", "0.00", "0.00", "0.00"},
            {"Maximum Racing: Super Karts", "Wii", "2011", "Racing", "Nordic Games", "0.01", "0.00", "0.00", "0.00"},
            {"Chegger's Party Quiz", "Wii", "2008", "Misc", "Oxygen Interactive", "0.00", "0.01", "0.00", "0.00"},
            {
                "Nodame Cantabile: Dream * Orchestra", "Wii", "2007", "Misc", "Namco Bandai Games", "0.00", "0.00", "0.01",
                "0.00"
            },
            {"Bermuda Triangle: Saving the Coral", "Wii", "2009", "Puzzle", "Unknown", "0.01", "0.00", "0.00", "0.00"},
            {"Kidz Sports: Basketball", "Wii", "2008", "Sports", "Popcorn Arcade", "0.01", "0.00", "0.00", "0.00"},
            {"Maximum Racing: Super Truck Racer", "Wii", "2011", "Racing", "Unknown", "0.01", "0.00", "0.00", "0.00"},
            {"Deal or No Deal: The Banker is Back!", "Wii", "2008", "Misc", "Mindscape", "0.00", "0.01", "0.00", "0.00"},
            {"Maximum Racing: Sprint Cars", "Wii", "2011", "Racing", "Unknown", "0.01", "0.00", "0.00", "0.00"},
            {"FlatOut", "Wii", "2010", "Racing", "Zoo Games", "0.01", "0.00", "0.00", "0.00"},
            {"Pro Golfer Saru", "Wii", "2008", "Sports", "Namco Bandai Games", "0.00", "0.00", "0.01", "0.00"},
            {
                "Gegege no Kitarou: Youkai Daiundoukai", "Wii", "2007", "Action", "Namco Bandai Games", "0.00", "0.00",
                "0.01", "0.00"
            },
            {"Hyper Fighters", "Wii", "2011", "Simulation", "Zoo Games", "0.01", "0.00", "0.00", "0.00"},
            {"Once Upon A Time", "Wii", "2010", "Misc", "Storm City Games", "0.01", "0.00", "0.00", "0.00"},
            {"Radirgy Noa Wii", "Wii", "2010", "Shooter", "Milestone", "0.00", "0.00", "0.01", "0.00"},
            {"Maximum Racing: Rally Racer", "Wii", "2011", "Racing", "Unknown", "0.01", "0.00", "0.00", "0.00"},
            {
                "Simple 2000 Series Wii Vol. 2: The Party Game", "Wii", "2008", "Misc", "D3Publisher", "0.00", "0.00",
                "0.01", "0.00"
            },
            {
                "Fantastic Football Fan Party", "Wii", "2010", "Sports", "DTP Entertainment", "0.00", "0.00", "0.00",
                "0.00"
            },
            {"Harukanaru Toki no Naka de 4", "Wii", "2008", "Adventure", "Tecmo Koei", "0.00", "0.00", "0.01", "0.00"},
            {"Kidz Sports: Ice Hockey", "Wii", "2008", "Sports", "Popcorn Arcade", "0.00", "0.00", "0.00", "0.00"},
            {"Survivor", "Wii", "2010", "Adventure", "Valcon Games", "0.00", "0.00", "0.00", "0.00"},
            {"Ougon no Kizuna", "Wii", "2009", "Role-Playing", "Jaleco", "0.00", "0.00", "0.00", "0.00"},
        };
    }
}