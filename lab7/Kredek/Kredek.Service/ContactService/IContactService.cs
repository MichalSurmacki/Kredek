using Kredek.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kredek.Service.ContactService
{
    public interface IContactService
    {
        void SaveContact(SaveContactViewModel model);
        List<ShowContactViewModel> GetContacts();
    }
}
