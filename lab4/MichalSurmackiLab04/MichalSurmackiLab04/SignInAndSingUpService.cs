using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MichalSurmackiLab04
{
    //ctrl + . skrót implementacji interfejsu
    class SignInAndSingUpService : ISignInAndSignUpService
    {
        //prop tab tab - tworzenie właściwości skrót
        /// <summary>
        /// Sprawdza czy istnieją jacyś użytkownicy 
        /// </summary>
        public bool IsTrue { get; set; }
        //ctor tab tab - tworzenie konstruktora bezargumentowego skrótem
        /// <summary>
        /// Konstruktor domyślny
        /// </summary>
        public SignInAndSingUpService()
        {
            //zainicjalizowanie zmiennej wartością początkową
            IsTrue = false;
        }

        /// <summary>
        /// Metoda rejestrująca użytkownika do systemu
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="name"></param>
        /// <param name="surnname"></param>
        /// <param name="studentIndex"></param>
        /// <param name="email"></param>
        public void SignUpToSystem(string username, string password, string name, string surnname, string studentIndex, string email)
        {
            using (RegistrationSystemApprenticeEntities context = new RegistrationSystemApprenticeEntities())
            {
                //zmienna pozwalająca na dodanie do bazy danych informacji o loginie i haśle
                var registerLoginData = context.StudentLogInSystem.FirstOrDefault();
                registerLoginData.UserName = username;
                registerLoginData.Password = password;

                //zmienna pozwalająca na dodanie do bazy danych informacji o użytkowniku
                var registerPersonalData = context.InformationAboutStudent.FirstOrDefault();
                registerPersonalData.Name = name;
                registerPersonalData.Surnname = surnname;
                registerPersonalData.StudentIndex = studentIndex;
                registerPersonalData.Email = email;

                var checkUserExist = context.StudentLogInSystem.Where(x => x.UserName == username).Count();

                if(checkUserExist < 1)
                {
                    context.StudentLogInSystem.Add(registerLoginData);
                    context.InformationAboutStudent.Add(registerPersonalData);

                    context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Istnieje już użytkownik o takim loginie!","Komunikat rejestracji");
                }
            }    
        }

        /// <summary>
        /// Logowanie się do systemu
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool SingInToSystem(string username, string password)
        {
            using(RegistrationSystemApprenticeEntities context = new RegistrationSystemApprenticeEntities())
            {
                //zliczanie uzytkowników o takim haśle i loginie jak wprowadzone do metody
                var singIn = context.StudentLogInSystem.Where(x => x.UserName == username && x.Password == password).Count();
                if(singIn >= 1)
                {
                    IsTrue = true;
                }
            }
            return IsTrue;
        }

        public bool UserExist(string username)
        {
            throw new NotImplementedException();
        }
    }
}
