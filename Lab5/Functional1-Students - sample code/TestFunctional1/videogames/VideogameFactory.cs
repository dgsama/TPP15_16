using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TPP.Laboratory.ObjectOriented.Practica1;

namespace TPP.Laboratory.Functional.Lab01
{
    public static class VideogameFactory
    {
        /// <summary>
        /// This method creates the specified number of videogames, using random data from the videogame list also provided
        /// </summary>
        /// <param name="numberOfVideogames">Number of videogames to be created</param>
        /// <returns>An array of Videogame instances, fully instantiated from the videogame data</returns>
        public static Videogame[] CreateRandomVideoGames(int numberOfVideogames = 100)
        {
            Videogame[] listing = new Videogame[numberOfVideogames];
            Random random = new Random();
            string[,] data = null;
            Platform platform = Platform.PS3;

            for (int i = 0; i < numberOfVideogames; i++)
            {
                int platformNumber = random.Next(0, 3);
                if (platformNumber == 0)
                {
                    data = RandomVideogameGeneratorData.Ps3Games;
                    platform = Platform.PS3;
                }

                if (platformNumber == 1)
                {
                    data = RandomVideogameGeneratorData.XBox360Games;
                    platform = Platform.Xbox360;
                }

                if (platformNumber == 2)
                {
                    data = RandomVideogameGeneratorData.WiiGames;
                    platform = Platform.Wii;
                }

                int gameNumber = random.Next(0, data.GetLength(0));

                int year = 2020;
                try
                {
                    year = int.Parse(data[gameNumber, 2]);
                }
                catch (Exception)
                {
                    //A non-valid year means that year = 2020
                }
                listing[i] = new Videogame
                {
                    Title = data[gameNumber, 0],
                    Platform = platform,
                    Year = year,
                    Genre = data[gameNumber, 3],
                    Editor = data[gameNumber, 4],
                    AmericaSales = double.Parse(data[gameNumber, 5].Replace(".", ",")),
                    EuropeSales = double.Parse(data[gameNumber, 6].Replace(".", ",")),
                    JapanSales = double.Parse(data[gameNumber, 7].Replace(".", ",")),
                    RestOfTheWorldSales = double.Parse(data[gameNumber, 8].Replace(".", ",")),
                    AvailableUnits = random.Next(10, 100),
                };
            }
            return listing;
        }

        /// <summary>
        /// Helper method to parse the videogame library of a specified platform
        /// </summary>
        /// <param name="data">Videogame data</param>
        /// <param name="platform">Destination platform (all videogames will belong to it</param>
        /// <param name="output">List to fill with the processed videogames</param>
        private static void ParseVideogameLibrary(string[,] data, Platform platform, List<Videogame> output)
        {
            Random random = new Random();

            for (int i = 0; i < data.GetLength(0); i++)
            {
                int year = 2020;
                try
                {
                    year = int.Parse(data[i, 2]);
                }
                catch (Exception)
                {
                    //A non-valid year means that year = 2020
                }
                output.Add(new Videogame
                            {
                                Title = data[i, 0],
                                Platform = platform,
                                Year = year,
                                Genre = data[i, 3],
                                Editor = data[i, 4],
                                AmericaSales = double.Parse(data[i, 5].Replace(".", ",")),
                                EuropeSales = double.Parse(data[i, 6].Replace(".", ",")),
                                JapanSales = double.Parse(data[i, 7].Replace(".", ",")),
                                RestOfTheWorldSales = double.Parse(data[i, 8].Replace(".", ",")),
                                AvailableUnits = random.Next(10, 100),
                            });
            }
        }

        /// <summary>
        /// Processes the entire videogame data lists and return it in a Videogame array.
        /// </summary>
        /// <returns>An array of videogames</returns>
        public static Videogame[] CreateFullVideoGameLibrary()
        {
            List<Videogame> listing = new List<Videogame>();

            Platform platform = Platform.PS3;
            ParseVideogameLibrary(RandomVideogameGeneratorData.Ps3Games, platform, listing);

            platform = Platform.Xbox360;
            ParseVideogameLibrary(RandomVideogameGeneratorData.XBox360Games, platform, listing);

            platform = Platform.Wii;
            ParseVideogameLibrary(RandomVideogameGeneratorData.WiiGames, platform, listing);


            return listing.ToArray();
        }
    }
}
