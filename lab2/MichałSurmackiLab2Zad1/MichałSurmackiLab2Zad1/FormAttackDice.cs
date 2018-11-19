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
    public partial class FormAttackDice : Form
    {
        //zmienna przechowywująca wynik rzutu kostką gracza
        private int playerResult = -1;
        //zmienna przechowywująca wynik rzutu kostką komputera
        private int computerResult = -1;
        //zmienna mówiąca o tym czy rzut kostką się odbył
        private Boolean diceThrow = false;

        //konstruktor klasy
        public FormAttackDice()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Funkcja imitująca rzut kostką gracza i komputera.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonThrowADice_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            playerResult = rnd.Next(1, 7);
            labelPlayersResultValue.Text = playerResult.ToString();
            computerResult = rnd.Next(1, 7);
            labelComputerResultValue.Text = computerResult.ToString();
            buttonThrowADice.Enabled = false;
        }

        /// <summary>
        /// Funkcja zwracająca wartość "wyrzuconą" przez gracza.
        /// </summary>
        /// <returns></returns>
        public int GetPlayersResult()
        {
            return playerResult;
        }

        /// <summary>
        /// Funkcja zwracająca wartość "wyrzuconą" przez komputer.
        /// </summary>
        /// <returns></returns>
        public int GetComputersResult()
        {
            return computerResult;
        }

        /// <summary>
        /// Funkcja zamykająca okno po rzucie kostką, lub powracająca do poprzedniego ekranu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBackOrClose_Click(object sender, EventArgs e)
        {
            if(playerResult != -1 && computerResult != -1)
            {
                diceThrow = true;
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        /// <summary>
        /// Funkcja zwracająca argument mówiący o tym czy rzut kostką się odbył
        /// </summary>
        /// <returns></returns>
        public Boolean GetDiceResult()
        {
            return diceThrow;
        }
    }
}
