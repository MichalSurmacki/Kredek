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
    public partial class FormMain : Form
    {
        /// <summary>
        /// Zmienna pomocnicza do TimerPlague.
        /// </summary>
        int plagueCounter = 0;

        /// <summary>
        /// Zmienna przechowywująca Ilość Pieniędzy Gracza
        /// </summary>
        private double money = 0;

        /// <summary>
        /// Tablica przechowywująca wartosci akcji 3 firm.
        /// </summary>
        private double[] stocksCompanyArray;

        /// <summary>
        /// Tablica przechowywujaca wartosci akcji zakupionych przez gracza.
        /// </summary>
        private double[] playersStocksCompanyArray;
        
        /// <summary>
        /// Zmienna mnożnik do dodawania pieniedzy z wzrostem czasu
        /// </summary>
        static public double multiplier = 1000;
        
        /// <summary>
        /// Zmienna przechowywująca Czas sałej gry
        /// </summary>
        private int mainTime = 0;
        
        /// <summary>
        /// zmienna przechowywująca Wszystkie akcje które kupił gracz
        /// </summary>
        private double mainResult = 0;

        /// <summary>
        /// Konstruktor głównego okna.
        /// </summary>
        public FormMain()
        {
            stocksCompanyArray = new double[5];
            stocksCompanyArray[0] = 100000;
            stocksCompanyArray[1] = 75000;
            stocksCompanyArray[2] = 50000;
            stocksCompanyArray[3] = 25000;
            stocksCompanyArray[4] = 10000;
            playersStocksCompanyArray = new double[5];
            for(int i=0; i< playersStocksCompanyArray.Length; i++)
            {
                playersStocksCompanyArray[i] = 0;
            }
            InitializeComponent();
            timerRefresh.Start();
            timerMoney.Start();
            timerCompany1.Start();
            timerCompany2.Start();
            timerCompany3.Start();
            timerCompany4.Start();
            timerCompany5.Start();
            timerPlague.Start();
            textBoxCompanyNumber1.Text = stocksCompanyArray[0].ToString();
            textBoxCompanyNumber2.Text = stocksCompanyArray[1].ToString();
            textBoxCompanyNumber3.Text = stocksCompanyArray[2].ToString();
            textBoxCompanyNumber4.Text = stocksCompanyArray[3].ToString();
            textBoxCompanyNumber5.Text = stocksCompanyArray[4].ToString();
            textBoxPlayersStocksOfCompany1.Text = playersStocksCompanyArray[0].ToString();
            textBoxPlayersStocksOfCompany2.Text = playersStocksCompanyArray[1].ToString();
            textBoxPlayersStocksOfCompany3.Text = playersStocksCompanyArray[2].ToString();
            textBoxPlayersStocksOfCompany4.Text = playersStocksCompanyArray[3].ToString();
            textBoxPlayersStocksOfCompany5.Text = playersStocksCompanyArray[4].ToString();
        }
        
        /// <summary>
        /// Okno GŁÓWNE programu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        
        /// <summary>
        /// Przycisk obsługujący dodawanie pieniędzy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddMoney_Click(object sender, EventArgs e)
        {
            money += 1000;
            textBoxMoney.Text = money.ToString();
        }
        
        /// <summary>
        /// Czasowe Dodawanie pieniędzy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerMoney_Tick(object sender, EventArgs e)
        {
            money += multiplier;
            textBoxMoney.Text = money.ToString();
        }
        
        /// <summary>
        /// TextBox wyświetlający wartość posiadanych pieniędzy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxMoney_TextChanged(object sender, EventArgs e)
        {

        }
        
        /// <summary>
        /// TextBox wyświetlający Wartość Akcji Firmy 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxCompanyNumber1_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        /// <summary>
        /// TextBox wyświetlający Wartość Akcji Firmy 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxCompanyNumber2_TextChanged(object sender, EventArgs e)
        {

        }
        
        /// <summary>
        /// TextBox wyświetlający Wartość Akcji Firmy 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxCompanyNumber3_TextChanged(object sender, EventArgs e)
        {

        }
       
        /// <summary>
        /// Przycisk do kupowania Akcji Firmy 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyCompany1_Click(object sender, EventArgs e)
        {
            if (stocksCompanyArray[0] != 0)
            {
                using (FormHowManyStocks stocksForm = new FormHowManyStocks())
                {
                    stocksForm.setMoney(money);
                    stocksForm.setCompanyStocksArray(stocksCompanyArray);
                    stocksForm.setPlayersStocksArray(playersStocksCompanyArray);
                    //liczba przekazywana do funkcje jest o jeden mniejsza ponieważ jest to indeks do tablicy
                    stocksForm.setIndexOfCompany(0);
                    if (stocksForm.ShowDialog() != DialogResult.OK)
                    {
                        money = stocksForm.getMoney();
                        playersStocksCompanyArray = stocksForm.getPlayersStocksArray();
                        stocksCompanyArray = stocksForm.getCompanyStocksArray();
                    }
                }
            }
            else
            {
                MessageBox.Show("Nie możesz kupić więcej akcji tej firmy!","Komunikat");
            }
        }
        
        /// <summary>
        /// Przycisk do kupowania Akcji Firmy 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyCompany2_Click(object sender, EventArgs e)
        {
            if (stocksCompanyArray[1] != 0)
            {
                using (FormHowManyStocks stocksForm = new FormHowManyStocks())
                {
                    stocksForm.setMoney(money);
                    stocksForm.setCompanyStocksArray(stocksCompanyArray);
                    stocksForm.setPlayersStocksArray(playersStocksCompanyArray);
                    //liczba przekazywana do funkcje jest o jeden mniejsza ponieważ jest to indeks do tablicy
                    stocksForm.setIndexOfCompany(1);
                    if (stocksForm.ShowDialog() != DialogResult.OK)
                    {
                        money = stocksForm.getMoney();
                        playersStocksCompanyArray = stocksForm.getPlayersStocksArray();
                        stocksCompanyArray = stocksForm.getCompanyStocksArray();
                    }
                }
            }
            else
            {
                MessageBox.Show("Nie możesz kupić więcej akcji tej firmy!", "Komunikat");
            }
        }
        
        /// <summary>
        /// Przycisk do kupowania Akcji Firmy 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyCompany3_Click(object sender, EventArgs e)
        {
            if (stocksCompanyArray[2] != 0)
            {
                using (FormHowManyStocks stocksForm = new FormHowManyStocks())
                {

                    stocksForm.setMoney(money);
                    stocksForm.setCompanyStocksArray(stocksCompanyArray);
                    stocksForm.setPlayersStocksArray(playersStocksCompanyArray);
                    //liczba przekazywana do funkcje jest o jeden mniejsza ponieważ jest to indeks do tablicy
                    stocksForm.setIndexOfCompany(2);
                    if (stocksForm.ShowDialog() != DialogResult.OK)
                    {
                        money = stocksForm.getMoney();
                        playersStocksCompanyArray = stocksForm.getPlayersStocksArray();
                        stocksCompanyArray = stocksForm.getCompanyStocksArray();
                    }
                }
            }
            else
            {
                MessageBox.Show("Nie możesz kupić więcej akcji tej firmy!", "Komunikat");
            }
        }
       
        /// <summary>
        /// Przycisk do kupowania Akcji Firmy 4.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyCompany4_Click(object sender, EventArgs e)
        {
            if (stocksCompanyArray[3] != 0)
            {
                using (FormHowManyStocks stocksForm = new FormHowManyStocks())
                {

                    stocksForm.setMoney(money);
                    stocksForm.setCompanyStocksArray(stocksCompanyArray);
                    stocksForm.setPlayersStocksArray(playersStocksCompanyArray);
                    //liczba przekazywana do funkcje jest o jeden mniejsza ponieważ jest to indeks do tablicy
                    stocksForm.setIndexOfCompany(3);
                    if (stocksForm.ShowDialog() != DialogResult.OK)
                    {
                        money = stocksForm.getMoney();
                        playersStocksCompanyArray = stocksForm.getPlayersStocksArray();
                        stocksCompanyArray = stocksForm.getCompanyStocksArray();
                    }
                }
            }
            else
            {
                MessageBox.Show("Nie możesz kupić więcej akcji tej firmy!", "Komunikat");
            }
        }
       
        /// <summary>
        /// Przycisk do kupowania Akcji Firmy 5.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyCompany5_Click(object sender, EventArgs e)
        {
            if (stocksCompanyArray[4] != 0)
            {
                using (FormHowManyStocks stocksForm = new FormHowManyStocks())
                {

                    stocksForm.setMoney(money);
                    stocksForm.setCompanyStocksArray(stocksCompanyArray);
                    stocksForm.setPlayersStocksArray(playersStocksCompanyArray);
                    //liczba przekazywana do funkcje jest o jeden mniejsza ponieważ jest to indeks do tablicy
                    stocksForm.setIndexOfCompany(4);
                    if (stocksForm.ShowDialog() != DialogResult.OK)
                    {
                        money = stocksForm.getMoney();
                        playersStocksCompanyArray = stocksForm.getPlayersStocksArray();
                        stocksCompanyArray = stocksForm.getCompanyStocksArray();
                    }
                }
            }
            else
            {
                MessageBox.Show("Nie możesz kupić więcej akcji tej firmy!", "Komunikat");
            }
        }
       
        /// <summary>
        /// Wyjście z programu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormEndGameAndResults endGame = new FormEndGameAndResults();
            endGame.setMoney(money);
            endGame.setMainResult(mainResult);
            endGame.setTime(mainTime);
            endGame.Show();
            this.Hide();
        }
      
        /// <summary>
        /// Timer który co jakiś czas dodaje wartość do akcji firmy 1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCompany1_Tick(object sender, EventArgs e)
        {
            if (stocksCompanyArray[0] != 0)
            {
                stocksCompanyArray[0] += 10000;
                textBoxCompanyNumber1.Text = stocksCompanyArray[0].ToString();
            }
        }
       
        /// <summary>
        /// Timer który co jakiś czas dodaje wartość do akcji firmy 2.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCompany2_Tick(object sender, EventArgs e)
        {
            if (stocksCompanyArray[1] != 0)
            {
                stocksCompanyArray[1] += 10000;
                textBoxCompanyNumber2.Text = stocksCompanyArray[1].ToString();
            }
        }
       
        /// <summary>
        /// Timer który co jakiś czas dodaje wartość do akcji firmy 3.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCompany3_Tick(object sender, EventArgs e)
        {
            if (stocksCompanyArray[2] != 0)
            {
                stocksCompanyArray[2] += 10000;
                textBoxCompanyNumber3.Text = stocksCompanyArray[2].ToString();
            }
        }
      
        /// <summary>
        /// Timer, który co jakiś czas dodaje wartość do akcji firmy 4.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCompany4_Tick(object sender, EventArgs e)
        {
            if (stocksCompanyArray[3] != 0)
            {
                stocksCompanyArray[3] += 10000;
                textBoxCompanyNumber4.Text = stocksCompanyArray[3].ToString();
            }
        }
     
        /// <summary>
        /// Timer, który co jakiś czas dodaje wartość do akcji firmy 5.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCompany5_Tick(object sender, EventArgs e)
        {
            if (stocksCompanyArray[4] != 0)
            {
                stocksCompanyArray[4] += 10000;
                textBoxCompanyNumber5.Text = stocksCompanyArray[4].ToString();
            }
        }
      
        /// <summary>
        /// Kupione Akcje (Akcje należące do gracza) w firmie 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxPlayersStocksOfCompany1_TextChanged(object sender, EventArgs e)
        {

        }
      
        /// <summary>
        /// TIMER ODŚWIERZACZ, może można było zrobić to inaczej ale narazie nie wiem, miałem taki pomysł :)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            mainTime++;
            //aktualizacje textboxów
            textBoxCompanyNumber1.Text = stocksCompanyArray[0].ToString();
            textBoxCompanyNumber2.Text = stocksCompanyArray[1].ToString();
            textBoxCompanyNumber3.Text = stocksCompanyArray[2].ToString();
            textBoxCompanyNumber4.Text = stocksCompanyArray[3].ToString();
            textBoxCompanyNumber5.Text = stocksCompanyArray[4].ToString();
            textBoxPlayersStocksOfCompany1.Text = playersStocksCompanyArray[0].ToString();
            textBoxPlayersStocksOfCompany2.Text = playersStocksCompanyArray[1].ToString();
            textBoxPlayersStocksOfCompany3.Text = playersStocksCompanyArray[2].ToString();
            textBoxPlayersStocksOfCompany4.Text = playersStocksCompanyArray[3].ToString();
            textBoxPlayersStocksOfCompany5.Text = playersStocksCompanyArray[4].ToString();
            //dodanie punktów do zmiennej przechowywujacej liczbe punktów gracza
            for(int i=0; i<playersStocksCompanyArray.Length; i++)
            {
                mainResult += playersStocksCompanyArray[i];
            }
        }
       
        /// <summary>
        /// Timer, który co jakiś czas zmienia dane akcji firm na większe albo pomniejsza ilość pieniędzy gracza.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerPlague_Tick(object sender, EventArgs e)
        {
            timerPlague.Stop();
            plagueCounter++;
            if(plagueCounter % 2 == 0)
            {
                MessageBox.Show("Wszystkie wykresy pną się w górę! Akcje firm rosną!", "Komunikat") ;
                for (int i=0; i<stocksCompanyArray.Length; i++)
                {
                    if(stocksCompanyArray[i] != 0)
                    {
                        //dodaje połowy obecnej wartości akcji firmy
                        stocksCompanyArray[i] *= 1.5;
                    }
                    else
                    {
                        //dodanie do wartości akcji gracza
                        playersStocksCompanyArray[i] += 10000;
                    }
                }
            }
            else
            {
                MessageBox.Show("Twoje firmy tracą na wartości przez niewłaściwe działania zarządu! Tracisz część swoich środków!", "Komunikat");
                //odjęcie 25% środków gracza
                money *= 0.75;
            }
            timerPlague.Start();
        }
    }
}
