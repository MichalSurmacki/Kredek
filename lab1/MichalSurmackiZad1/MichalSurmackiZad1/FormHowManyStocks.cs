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
    public partial class FormHowManyStocks : Form
    {
        //zmienna przechowywujaca wartosc pieniedzy gracza
        double money;
        
        /// <summary>
        /// Funkcja ustawiajaca wartosc zmiennej money.
        /// </summary>
        /// <param name="value"></param>
        public void SetMoney(double value)
        {
            money = value;
        }

        /// <summary>
        /// Funkcja zwracajaca zmienna przechowywujaca wartosc pieniedzy gracza.
        /// </summary>
        /// <returns></returns>
        public double GetMoney()
        {
            return money;
        }

        //tablica prechowywujaca akcje firm
        double[] companyStocksArray = new double[3];
        
        /// <summary>
        /// Funkcja ustawiająca tablice wartości akcji firm.
        /// </summary>
        /// <param name="value"></param>
        public void SetCompanyStocksArray(double[] value)
        {
            companyStocksArray = value;
        }
        
        /// <summary>
        /// Funkcja zwracajaca tablice przechowywujaca akcje firm.
        /// </summary>
        /// <returns></returns>
        public double[] GetCompanyStocksArray()
        {
            return companyStocksArray;
        }
        
        //tablica przechowywujaca akcje które posiada gracz
        double[] playersStocksArray = new double[3];
        
        /// <summary>
        /// Funkcja ustawiajaca tablice wartosci akcji gracza.
        /// </summary>
        /// <param name="value"></param>
        public void SetPlayersStocksArray(double[] value)
        {
            playersStocksArray = value;
        }
        
        /// <summary>
        /// Funkcja zwracajaca tablicę przechowywujaca akcje zakupione przez gracza/ 
        /// </summary>
        /// <returns></returns>
        public double[] GetPlayersStocksArray()
        {
            return playersStocksArray;
        }

        //zmienna przechowywujaca indeks firmy której gracz chce kupic akcje
        int indexOfCompany;
        public void SetIndexOfCompany(int value)
        {
            indexOfCompany = value;
        }

        /// <summary>
        /// Otwiera Okno/Powiadomienie o Braku pieniędzy na zakup Akcji
        /// </summary>
        FormNotEnoughtMoney formNotEnoughtMoney;
        public FormHowManyStocks()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Przycisk powracający do Okna Głównego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHowManyStocksBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        /// <summary>
        /// Przycisk odpowiadający za kupno 100% akcji danej Firmy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHowManyStocks100_Click(object sender, EventArgs e)
        {
            if ( money < companyStocksArray[indexOfCompany])
            {
                this.Close();
                using (formNotEnoughtMoney = new FormNotEnoughtMoney())
                {
                    if (formNotEnoughtMoney.ShowDialog() != DialogResult.OK)
                    {
                        //nic sie nie dzieje :)
                    }
                }
            }
            else
            {
                money -= companyStocksArray[indexOfCompany];
                playersStocksArray[indexOfCompany] += companyStocksArray[indexOfCompany];
                companyStocksArray[indexOfCompany] = 0;
                if (indexOfCompany == 0)
                {
                    FormMain.multiplier *= 3;
                }
                else if (indexOfCompany == 1)
                {
                    FormMain.multiplier *= 2.5;
                }
                else if (indexOfCompany == 2)
                {
                    FormMain.multiplier *= 2.5;
                }     
            }
            this.Close();
        }
        /// <summary>
        /// Przycisk odpowiadający za kupno 50% Akcji danej Firmy
        /// BYŁO WCZEŚNIEJ 75 DLATEGO W NAZWIE PONIŻEJ JEST NA KOŃCU 75 :P
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHowManyStocks75_Click(object sender, EventArgs e)
        {
            if (money < 0.5 * companyStocksArray[indexOfCompany])
            {
                this.Close();
                using (formNotEnoughtMoney = new FormNotEnoughtMoney())
                {
                    if(formNotEnoughtMoney.ShowDialog() != DialogResult.OK)
                    {
                        //nic sie nie dzieje :)
                    }
                }
            }
            else
            {
                money -= 0.5 * companyStocksArray[indexOfCompany];
                playersStocksArray[indexOfCompany] += 0.5 * companyStocksArray[indexOfCompany];
                companyStocksArray[indexOfCompany] *= 0.5;
                if (indexOfCompany == 0)
                {
                    FormMain.multiplier *= 2.5;
                }
                else if (indexOfCompany == 1)
                {
                    FormMain.multiplier *= 2;
                }
                else if (indexOfCompany == 2)
                {
                    FormMain.multiplier *= 2;
                }
            }
            this.Close();
        }

        /// <summary>
        /// Przycisk odpowiadający za kupno 25 % Akcji danej Firmy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHowManyStocks25_Click(object sender, EventArgs e)
        {
            if (money < 0.25 * companyStocksArray[indexOfCompany])
            {
                this.Close();
                using (formNotEnoughtMoney = new FormNotEnoughtMoney())
                {
                    if (formNotEnoughtMoney.ShowDialog() != DialogResult.OK)
                    {
                        //nic sie nie dzieje :)
                    }
                }
            }
            else
            {
                money -= 0.25 * companyStocksArray[indexOfCompany];
                playersStocksArray[indexOfCompany] += 0.25 * companyStocksArray[indexOfCompany];
                companyStocksArray[indexOfCompany] *= 0.75;
                if (indexOfCompany == 0)
                {
                    FormMain.multiplier *= 2;
                }
                else if (indexOfCompany == 1)
                {
                    FormMain.multiplier *= 1.5;
                }
                else if (indexOfCompany == 2)
                {
                    FormMain.multiplier *= 1.5;
                }
            }
            this.Close();
        }
    }
}
