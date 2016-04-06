using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class Videogame
    {
        public string Title { get; }
        public long Stock { get; set; }
        public int _sku;
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

        public enum Plataforma { PS3, XBOX, WII }
        public Plataforma platform { get; set; }

        public int _year;
        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                if (value >= 1996 && value <= 2020)
                {
                    _year = value;
                }
            }
        }
        public string Genre { get; set; }
        public string Editor { get; }
        public double AmericaSales { get; set; }
        public double EuropeSales { get; set; }
        public double JapanSales { get; set; }
        public double RestOfTheWorldSales { get; set; }

        public Videogame(string Title, long Stock, int sku, Plataforma p, int Year, string Genre, string Editor)
        {
            this.Title = Title;
            this.Stock = Stock;
            this.SKU = sku;
            this.platform = p;
            this.Year = Year;
            this.Genre = Genre;
            this.Editor = Editor;

        }

        public Videogame() { }
        public override string ToString()
        {
            return Title + ", for " + platform+ ". Editor: "+  Editor;
        }
    }
}
