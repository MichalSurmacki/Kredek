using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MichalSurmackiLab06.Models
{
    public class ContactForm
    {
        /// <summary>
        /// Imię
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Nazwisko
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Opis
        /// </summary>
        public string Description { get; set; }
    }
}