using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MichalSurmackiLab1
{
    public partial class FormMain : Form
    {
        //Zmienna pomocnicza określająca zmianę w okienku.
        int changeCrecker = 0;
        //Zmienna przechowywujaca wartosc zrzutowaną na argument typu int z textBoxa, w celu wykonania operacji arytmetycznych.
        int counter = 0;
        //Zmienna zliczająca tiki zegara
        int timeCounter = 0;

        /// <summary>
        /// Konstruktor klasy FormMain.
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Funkcja zamykająca okienko FormMain.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            //Zamkniecie okna
            this.Close();
        }
        /// <summary>
        /// Funkcja odpowiadająca za zmiany wykonane w okienku przy przyciśnięciu przycisku "Zmień".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChange_Click(object sender, EventArgs e)
        {
            //inkrementacja zmiennej pomocniczej, pomagającej ustalić zmiany
            changeCrecker++;
            if(changeCrecker % 2 != 0)
            {
                //ustawienie koloru tła okienka na morski błękitny.
                this.BackColor = Color.Aqua;
                //ustanienie koloru tła przycisku "zamknij" na czerwony.
                this.buttonClose.BackColor = Color.Red;
                //zmiana czcionki labelu w którym znajduje się imie i nazwisko autora.
                this.labelNameSurname.Font = new Font("Comic Sans MS", this.labelNameSurname.Font.Size);
                //zmiana koloru tła przycisku "zamień" na różowy.
                this.buttonChange.BackColor = Color.Pink;
                //zmiana koloru tła textBoxa textBoxData.
                this.textBoxData.BackColor = Color.Purple;
                //zmiana koloru tła textBoxa textBoxMultiplier
                this.textBoxMultiplier.BackColor = Color.Cyan;
            }
            else
            {
                //ustawienie koloru tła okienka na zielony.
                this.BackColor = Color.Green;
                //ustanienie koloru tła przycisku "zamknij" na zielony.
                this.buttonClose.BackColor = Color.Green;
                //zmiana czcionki labelu w którym znajduje się imie i nazwisko autora.
                this.labelNameSurname.Font = new Font("Stencil", this.labelNameSurname.Font.Size);
                //zmiana koloru tła przycisku "zamień" na zielony.
                this.buttonChange.BackColor = Color.Green;
                //zmiana koloru tła textBoxData.
                this.textBoxData.BackColor = Color.Green;
                //zmiana koloru tła textBoxMultiplier
                this.textBoxMultiplier.BackColor = Color.Green;
            }

        }
        /// <summary>
        /// Zwiększanie wartości w kontrolce textBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonIncrease_Click(object sender, EventArgs e)
        {
            //Zmienna przechowywująca wartość z textBoxa.
            string dataString = "";
            //Zczytywanie wartości z textBoxa do zmiennej typu string.
            dataString = textBoxData.Text;
            //Konwertowanie wartości stringa do zmiennej typu int.
            counter = Int32.Parse(dataString);
            //Inkrementacja zmiennej counter.
            counter++;
            //Konwertowanie wastości int'a do zmiennej typu string.
            dataString = counter.ToString();
            //MessageBox.Show(counter.ToString());
            //Aktualizacja tekstu textBoxa
            this.textBoxData.Text = dataString;
        }
        /// <summary>
        /// Funkcja odpowiedzialna za pomnozenie liczb z 2 textBox'ów.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            //Wczytywanie tekstu z kontrolki textBoxData.
            string oneBox = this.textBoxData.Text;
            //Wczytywanie tekstu z kontrolki textBoxMultiplier
            string twoBox = this.textBoxMultiplier.Text;
            //Konwersja tekstu z kontrolki textBoxData na typ int.
            int oneInt = Int32.Parse(oneBox);
            //Konwersja tekstu z kontrolki textBoxMultiplier na typ int.
            int twoInt = Int32.Parse(twoBox);
            //Obliczanie mnożenia przekonwertowanych liczb z kontrolek textBoxData oraz textBoxMultiplier.
            int answer = oneInt * twoInt;
            //Wyświetlanie informacji w MessageBox o wyniku działania
            MessageBox.Show(answer.ToString());
            //Nadpisywanie tekstu w kontrolce textBoxMultiplier
            textBoxMultiplier.Text = answer.ToString();
        }
        /// <summary>
        /// Funkcja wykonywujaca operacje przy kazdym tiku zegara.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCount_Tick(object sender, EventArgs e)
        {
            //inkrementacja zmiennej timeCounter
            timeCounter++;
            //definicja i inicjalizacja zmiennej dataFromTextBox
            string dataFormTextBox = "";
            //zczytanie do zmiennej dataFromTextBox wartości wyświetlanej w textBoxTimeCounter.
            dataFormTextBox = textBoxTimerCounter.Text;
            //konwersja string na zmienną int w celu dokonania operacji arytmetycznych.
            int data = Int32.Parse(dataFormTextBox);
            //inkrementacja zmiennej data.
            data++;
            //konwersja typu int na string w celu wpisania zmiennej typu string do textBox'a.
            dataFormTextBox = data.ToString();
            //przypisanie nowej wartosci do textBoxTimeCounter
            this.textBoxTimerCounter.Text = dataFormTextBox;
            //sprawdzanie warunku, żeby co dziesięć tików zegara wykonać operacje
            if (timeCounter % 10 == 0)
            {
                //zmiana koloru labelu nad licznikiem na czerwony
                this.labelTimer.BackColor = Color.Red;
            }
            else
            {
                //zmiana koloru labelu nad licznikiem na koralowy
                this.labelTimer.BackColor = Color.Coral;
            }
        }
    }
}
