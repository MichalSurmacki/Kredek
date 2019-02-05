using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A._2
{

    public partial class FormDodaj : Form
    {
        //właściwość przechowywująca datę przy prawidłowym wpisaniu do txtBoxa.
        public String data { get; set; }
        //właściwość przechowywująca ocenę przy prawidłowym wpisaniu do txtBoxa.
        public int  ocena { get; set; }
        //właściwość przechowywująca wynik w % przy prawidłowym wpisaniu do txtBoxa.
        public int wynik { get; set; }

        //główne okno programu.
        public FormDodaj()
        {
            //ustawienie właściwości na fałszywe w celu późniejszej weryfikacji czy podczas działań w okienku zostały dobrze nadpisane
            data = "";
            ocena = 0;
            wynik = -1;
            InitializeComponent();
        }

        //przycisk cofnięcia w przypadku zdecydowania się na nie wprowadzanie danych.
        private void buttonCofnij_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //przycisk odpowiedzialny za wpisanie do zmiennych klasy w przypadku dobrego formatowania danych
        private void buttonOk_Click(object sender, EventArgs e)
        {
            if(!textBoxData.Text.Equals("") && !textBoxOcena.Text.Equals("") && !textBoxWynik.Text.Equals(""))
            {
                //wpisanie do właściwości odpowiednich danych zczytanych z txtboxów.
                data = textBoxData.Text;
                ocena = Int32.Parse(textBoxOcena.Text);
                wynik = Int32.Parse(textBoxWynik.Text);
            }
        }
    }
}
