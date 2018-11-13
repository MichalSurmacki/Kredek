using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MichalSurmackiZad1
{
    public partial class FormEndGameAndResults : Form
    {
        //zmienna przechowywujaca wszystki akcje gracza
        double mainResult;
        /// <summary>
        /// Funkcja ustawiajaca wartosc zmiennej mainResult.
        /// </summary>
        /// <param name="value"></param>
        public void setMainResult(double value)
        {
            mainResult = value;
        }

        //zmienna przechowywujaca pieniadze gracza
        double money;
        /// <summary>
        /// Funkcja ustawiajaca wartosc zmiennej money.
        /// </summary>
        /// <param name="value"></param>
        public void setMoney(double value)
        {
            money = value;
        }

        //zmienna przechowywujaca Czas całej gry
        int mainTime;
        /// <summary>
        /// Funkcja ustawiająca wartość zmiennej mainTime.
        /// </summary>
        public void setTime(int value)
        {
            mainTime = value;
        }

        public FormEndGameAndResults()
        {
            InitializeComponent();
        }

        private void FormEndGameAndResults_Load(object sender, EventArgs e)
        { 
            string[] row = new string[] { mainTime/10 + " sekund", mainResult.ToString(), money.ToString() };
            dataGridViewResults.Rows.Add(row);
        }
        /// <summary>
        /// przycisk zamykający aplikację
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Tabela z wynikami
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
