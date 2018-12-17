using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MichalSurmackiZad01.Models
{
    public class GivingMark
    {
        /// <summary>
        /// Ocena filmu
        /// </summary>
        public int Mark { get; set; }

        /// <summary>
        /// Nazwa filmu
        /// </summary>
        public string FilmName { get; set; }
    }
}