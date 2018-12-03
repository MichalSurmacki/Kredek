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
    public partial class FormRegister : Form
    {
        //konstruktor klasy
        public FormRegister()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Przycisk odpowiedzialny za wywołanie metody wprowadzającej dane do bazy danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            //utworzenie obiektu operująceno na bazie danych
            SignInAndSingUpService register = new SignInAndSingUpService();
            //wywołanie metody dodającej nowe dane do bazy
            register.SignUpToSystem(textBoxUserName.Text, textBoxUserPassword.Text, textBoxName.Text, textBoxSurname.Text, textBoxStudentsNumber.Text, textBoxEmail.Text);
        }

        /// <summary>
        /// Przycisk odpowiedzialny za zamknięcie okna - cofnięcie do okna głównego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //zamknięcie okna
            this.Close();
        }
    }
}
