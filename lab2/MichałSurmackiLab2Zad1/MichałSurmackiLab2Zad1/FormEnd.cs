using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MichałSurmackiLab2Zad1
{
    //okno kończące grę
    public partial class FormEnd : Form
    {
        //konstruktor klasy
        public FormEnd(String ans)
        {
            InitializeComponent();
            this.labelEndOfGame.Text = ans;
        }

        /// <summary>
        /// przycisk odpowiedzialny za zamknięcie okna i koniec programu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEndOfGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
