using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MichalSurmackiLab04
{
    public partial class FormMain : Form
    {
        //konstruktor klasy
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Przycisk służący do logowania
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //utworzenie obiektu operującego na bazie danych
            SignInAndSingUpService login = new SignInAndSingUpService();
            //jeśli tane wpisane w textboxach są w bazie danych lub nie - wyświetlenie odpowiedniego komunikatu
            if(login.SingInToSystem(textBoxUserName.Text, textBoxUserPassword.Text) == true)
            {
                MessageBox.Show("Zostałeś zalogowany", "Komunikat logowania");
            }
            else
            {
                MessageBox.Show("Nie zostałeś zalogowany", "Komunikat logowania");
            }

        }

        /// <summary>
        /// Przycisk słóżący do rejestracji użytkownika w bazie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            //czekanie programu na zamknięcie okna rejestracji nowego użytkownika
            using (FormRegister form = new FormRegister())
            {
                if(form.ShowDialog() != DialogResult.OK)
                {
                    //nic się nie dzieje
                }
            }
        }
    }
}
