using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MichalSurmackiZad01.ViewsModel
{
    public class MyFilm
    {
        /// <summary>
        /// Nazwa filmu
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Producent filmu
        /// </summary>
        public string Director { get; set; }
        /// <summary>
        /// Rok produkcji filmu
        /// </summary>
        public int YearOfProduction { get; set; }
        /// <summary>
        /// Zdjęcie okładki filmu
        /// </summary>
        public string Photo { get; set; }

        // Konstruktor z parametrami
        public MyFilm(string Name, string Director, int YearOfProduction, string Photo)
        {
            this.Name = Name;
            this.Director = Director;
            this.YearOfProduction = YearOfProduction;
            this.Photo = Photo;
        }
    }
}