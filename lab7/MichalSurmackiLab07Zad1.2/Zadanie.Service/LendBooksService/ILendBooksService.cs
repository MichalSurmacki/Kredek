using System;
using System.Collections.Generic;
using System.Text;
using Zadanie.ViewModels;

namespace Zadanie.Service.LendBooksService
{
    //interfejs servisu wypożyczania książki
    public interface ILendBooksService
    {
        void SaveChanges(LendBooksViewModel model);
        List<LendBooksViewModel> GetLendedBooks();
        void ReturnBook(int id);
    }
}
