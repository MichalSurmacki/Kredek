using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A._1
{
    public partial class FormMain : Form
    {
        //domyślny, narzucony z góry login
        String login = "admin";
        //domyślne narzucone z góry hasło
        String haslo = "test";
        //licznik nieprawidłowych zalogowań
        int counter = 0;

        //Główne okno programu.
        public FormMain()
        {
            InitializeComponent();
        }

        //Przycisk odpowiadający za próbę zalogowania się.
        private void buttonZaloguj_Click(object sender, EventArgs e)
        {
            //Sprawdzenie  czy hasło oraz login są poprawne.
            if (textBoxLogin.Text.Equals(login) && textBoxHaslo.Text.Equals(haslo))
            {
                //wyświetlenie kontrolki
                MessageBox.Show("zalogowano");
                //wyzerowanie licznika nieprawidłowych zalogowań.
                counter = 0;
            }
            else
            {
                //dodanie do licznika nieprawidłowych zalogowań, błędne zalogowanie.
                counter++;
            }
            //jeśli licznik = 3 texboxy znikają
            if(counter >= 3)
            {
                textBoxLogin.Enabled = false;
                textBoxHaslo.Enabled = false;
            }
        }
    }
}
