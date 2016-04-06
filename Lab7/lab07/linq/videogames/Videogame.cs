using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPP.Laboratory.Functional.Lab01
{
    public enum Platform { PS3, Xbox360, Wii }

    public class Videogame
    {
        private int _sku;

        public int SKU
        {
            get
            {
                return _sku;
            }
            set
            {
                if (value > 9000)
                {
                    _sku = value;
                }
            }
        }

        public int AvailableUnits { get; set; }
        public string Title { get; set; }
        public Platform Platform { get; set; }

        private int _year;
        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                if (value >= 1996 && value <= 2020)
                    _year = value;
                else
                {
                    throw new ArgumentException(value.ToString());
                }
            }
        }

        public override string ToString()
        {
            return string.Format("AvailableUnits: {0}, Title: {1}, Platform: {2}, Year: {3}, Genre: {4}, Editor: {5}, AmericaSales: {6}, EuropeSales: {7}, RestOfTheWorldSales: {8}\n\n", AvailableUnits, Title, Platform, Year, Genre, Editor, AmericaSales, EuropeSales, RestOfTheWorldSales);
        }

        public string Genre { get; set; }
        public string Editor { get; set; }
        public double AmericaSales { get; set; }
        public double EuropeSales { get; set; }
        public double JapanSales { get; set; }
        public double RestOfTheWorldSales { get; set; }


        public override bool Equals(object obj)
        {
            Videogame videogame = obj as Videogame;
            if (videogame == null)
                return false;
            return this.Title.Equals(videogame.Title);
        }

        public override int GetHashCode()
        {
            return this.Title.GetHashCode();
        }

        public Videogame(string Title, Platform Platform, int Year, string Genre, string Editor, double AmericaSales, double EuropeSales,
            double JapanSales, double RestOfTheWorldSales)
        {
            this.Title = Title;
            this.Platform = Platform;
            this.Year = Year;
            this.Genre = Genre;
            this.Editor = Editor;
            this.AmericaSales = AmericaSales;
            this.EuropeSales = EuropeSales;
            this.JapanSales = JapanSales;
            this.RestOfTheWorldSales = RestOfTheWorldSales;

        }
        public Videogame()
        {
        }
    }
}
