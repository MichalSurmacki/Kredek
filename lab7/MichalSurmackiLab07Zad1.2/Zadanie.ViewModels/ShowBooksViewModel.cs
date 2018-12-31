using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie.ViewModels
{
    public class ShowBooksViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int YearOfPublish { get; set; }
        public bool IsLent { get; set; }
    }
}
