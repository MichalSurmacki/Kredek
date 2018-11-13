using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichałSurmackiLab2
{
    /// <summary>
    /// Klasa Unicord reprezentująca jednorożca, dziedziczy po klasie Horse.
    /// </summary>
    public class Unicorn : Horse
    {
        public Unicorn(Horse horse)
        {
            //przpisanie właściwości (imienia) klasy Horse do właściwości klasy Unicorn 
            this.Name = horse.Name;
            //przpisanie właściwości (ulubionego numeru) klasy Horse do właściwości klasy Unicorn
            this.FavouriteNumber = horse.FavouriteNumber;
        }

        /// <summary>
        /// Właściwość - kolor rogu jednorożca.
        /// </summary>
        public string HornColor { get; set; }
    }
}
