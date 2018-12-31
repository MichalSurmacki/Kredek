using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zadanie.Db;
using Zadanie.Db.Entities;
using Zadanie.ViewModels;

namespace Zadanie.Service.LendBooksService
{
    //implementacja metod interfejsu serwisu pokazującego wypożyczone książki
    public class LendBooksService : ILendBooksService
    {
        //metoda zwracająca listę książek dostępnych w bazie
        public List<LendBooksViewModel> GetLendedBooks()
        {
            var db = new DataContext();
            var list = new List<LendBooksViewModel>();
            var model = db.Set<LoanedBooksEntiti>().Where(x => true);

            foreach (var item in model)
            {
                list.Add(new LendBooksViewModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    DateOfLend = item.DateOfLend,
                    IdBook = item.IdBook
                });
            }
            return list;
        }

        //metoda odpowiedzialna za zwrócenie książki do zbioru książek dostępnych
        public void ReturnBook(int id)
        {
            var db = new DataContext();
            int idd = 0;
            var model1 = db.Set<LoanedBooksEntiti>().Where(x => x.Id == id);
            foreach (var item in model1)
            {
                idd = item.IdBook;
                //usuniecie z LoanedBooksEntiti
                db.Remove<LoanedBooksEntiti>(item);
            }

            var model = db.Set<BooksEntiti>().Where(x => x.Id == idd);
            foreach (var item in model)
            {
                item.IsLent = false;
            }
            db.SaveChanges();
        }

        //metoda dodająca książkę do zbioru książek w bazie
        public void SaveChanges(LendBooksViewModel model)
        {
            var db = new DataContext();

            var model1 = db.Set<BooksEntiti>().Where(x => x.Id == model.Id);
            foreach(var item in model1)
            {
                model.Name = item.Name + " (id: " + item.Id.ToString() + ")";
                model.Id = item.Id;
            }

            var newLend = new LoanedBooksEntiti()
            {
                Name = model.Name,
                DateOfLend = DateTime.Now.ToString(),
                IdBook = model.Id
            };
            db.Add<LoanedBooksEntiti>(newLend);
            db.SaveChanges();
        }
    }
}
