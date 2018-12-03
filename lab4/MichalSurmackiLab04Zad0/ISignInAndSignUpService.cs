using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinsLab4
{
    /// <summary>
    /// Interfejs narzucający kontrakt, ułatwiający pracę na zajęciach.
    /// Interfejsy (klasy zawierający deklaracje metod bez ciała) stosuje się  w celu: narzucenia kontraktu (wymuszenie na programiście deklaracji tych metod), 
    /// mockowania - tworzenie sztucznego obiektu ( w celu przeprowadzenie testów jednostkowych), 
    /// wstrzykiwania zależności.
    /// </summary>
    public interface ISignInAndSignUpService
    {

        /// <summary>
        /// Logowanie do  systemu.
        /// </summary>
        /// <param name="username"> nazwa użytkownika </param>
        /// <param name="password"> hasło użytkownika </param>
        /// <returns> Zwraca wartość boolowską, potwierdzającą istnienie użytkownika w bazie RegistrationSystemApprentice. </returns>
        bool SingInToSystem(string username, string password);

        /// <summary>
        /// Rejestracja do systemu.
        /// </summary>
        /// <param name="username">     nazwa użytkownika  </param>
        /// <param name="password">     hasło użytkownika  </param>
        /// <param name="name">         imię studenta      </param>
        /// <param name="surnname">     nazwisko Studenta  </param>
        /// <param name="studentIndex"> index studenta     </param>
        /// <param name="email">        email studenta     </param>
        void SignUpToSystem(string username, string password, string name, string surnname, string studentIndex, string email);

        /// <summary>
        /// Sprawdzenie, czy użytkownik istnieje w systemie. Pozwala zdecydować czy formularz rejestracji powienien zostać zamknięty.
        /// </summary>
        /// <param name="username"> nazwa użytkownika </param>
        /// <returns> Zwraca wartość boolowską, stwierdzająca istnienie użytkownika w bazie  RegistrationSystemApprentice. </returns>
        bool UserExist(string username);


    }
}
