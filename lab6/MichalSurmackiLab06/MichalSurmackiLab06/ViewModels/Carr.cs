using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MichalSurmackiLab06.ViewModels
{
    public class Carr
    {
        /// <summary>
        /// Model samochodu
        /// </summary>
        public string model { get; set; }
        /// <summary>
        /// Producent
        /// </summary>
        public string manufacturer { get; set; }
        /// <summary>
        /// Cena
        /// </summary>
        public int price { get; set; }
        /// <summary>
        /// Zdjęcie samochodu
        /// </summary>
        public string photo { get; set; }

        // Konstruktor z parametrami
        public Carr(string model, string manufacturer, int price, string photo)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.photo = photo;
        }
    }
}