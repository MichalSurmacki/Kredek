using System;
using System.Collections.Generic;
using System.Text;
using Zadanie.ViewModels;

namespace Zadanie.Service
{
    //interfejs servisu pokazującego wszystkie książki w zbiorze
    public interface IShowBooksService
    {
        void SaveChanges(ShowBooksViewModel model);
        List<ShowBooksViewModel> GetBooks();
        void LentBook(int id);
        void ReturnBook(int id);
    }
}
