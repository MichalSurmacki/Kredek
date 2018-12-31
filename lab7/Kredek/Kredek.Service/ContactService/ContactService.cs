using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kredek.Db;
using Kredek.Db.Entities;
using Kredek.ViewModels;

namespace Kredek.Service.ContactService
{
    //implementacja metod interfejsu
    //ctrl + . wyswietlenie rozwiązań błędu
    public class ContactService : IContactService
    {
        //metoda zrwacająca listę wszystkich imion
        public List<ShowContactViewModel> GetContacts()
        {
            var db = new DataContext();
            var list = new List<ShowContactViewModel>();
            var model = db.Set<ContactEntiti>().Where(x => true);

            foreach (var item in model)
            {
                list.Add(new ShowContactViewModel()
                {
                    Id = item.Id,
                    Name = item.Name
                });
            }

            return list;
        }

        //metoda zapisująca nowe imie w bazie
        public void SaveContact(SaveContactViewModel model)
        {
            var db = new DataContext();

            var contact = new ContactEntiti()
            {
                Name = model.Name,
                IsActive = true,
            };
            db.Add<ContactEntiti>(contact);
            db.SaveChanges();
        }
    }
}
