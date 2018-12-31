using System;
using System.Collections.Generic;
using System.Text;
using Zadanie.ViewModels;
using Zadanie.Db;
using Zadanie.Db.Entities;
using System.Linq;

namespace Zadanie.Service.ShowAllBooksService
{
    //implementacja metod interfejsu serwisu pokazującego dostępne książki do wypożyczenia
    public class ShowBooksService : IShowBooksService
    {
        //metoda zwracająca listę książek wypożyczonych
        public List<ShowBooksViewModel> GetBooks()
        {
            var db = new DataContext();
            var list = new List<ShowBooksViewModel>();
            var model = db.Set<BooksEntiti>().Where(x => true);

            foreach (var item in model)
            {
                if(item.IsLent == false)
                {
                    list.Add(new ShowBooksViewModel()
                    {
                        Id = item.Id,
                        Name = item.Name,
                        YearOfPublish = item.YearOfPublish,
                        Author = item.Author,
                        IsLent = false
                    });
                }
            }
            return list;
        }

        //metoda zapisująca książki do zbioru książek wypożyczonych
        public void SaveChanges(ShowBooksViewModel model)
        {
            var db = new DataContext();

            var newBook = new BooksEntiti()
            {
                Name = model.Name,
                YearOfPublish = model.YearOfPublish,
                Author = model.Author,
                IsLent = false
            };
            db.Add<BooksEntiti>(newBook);
            db.SaveChanges();
        }

        //metoda odpowiedzalna za ustawienie książki jako wypożyczonej i dodanie jej to zbioru książek wypożyczonych
        public void LentBook(int id)
        {
            var db = new DataContext();
            var model = db.Set<BooksEntiti>().Where(x => x.Id == id);
            foreach (var item in model)
            {
                item.IsLent = true;
            }
            db.SaveChanges();
        }

        public void ReturnBook(int id)
        {
            var db = new DataContext();
            var model = db.Set<BooksEntiti>().Where(x => x.Id == id);
            foreach (var item in model)
            {
                item.IsLent = false;
            }
            db.SaveChanges();
        }
    }
}
