using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MichalSurmackiLab04Zad1
{
    public partial class FormAddingCategory : Form
    {
        //zmienna przechowywująca nazwę nowej kategori
        String category = "";

        /// <summary>
        /// Funkcja zwracająca zmienną przechowywującą nowo utworzoną kategorię
        /// </summary>
        /// <returns></returns>
        public String GetCategory()
        {
            return category;
        }

        /// <summary>
        /// Konstruktor klasy
        /// </summary>
        public FormAddingCategory()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Przycisk odpowiedzialny za dodanie nowej kategorii
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            category = this.textBoxCategory.Text;
            this.Close();
        }

        /// <summary>
        /// Przycisk odpowiadający za zamknięcie bez wprowadzania danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
