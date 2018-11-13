using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MichałSurmackiLab2
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// właściwość - lista obiektów typu Horse.
        /// </summary>
        public List<Horse> HorseList { get; set; }

        public FormMain()
        {
            InitializeComponent();
           
            //inicjalizacaj listy koni
            HorseList = new List<Horse>();
        }

        /// <summary>
        /// Funkcja obsługująca przycisk dodający konia.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //przypisanie do zmiennej myHorse wartości typu Horse zwróconej przez funkcje GetData
            Horse myHorse = GetData();

            //dodanie konia do listy
            HorseList.Add(myHorse);
        }

        /// <summary>
        /// Funkcja dodająca jednorożca do listy.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddUnicorn_Click(object sender, EventArgs e)
        {
            //utworzenie zmiennej pomocniczej typu Horse
            Horse myHorse = GetData();

            //utworzenie nowego jednorożca
            Unicorn myUnicorn = new Unicorn(myHorse);

            //pobranie wartości koloru rogu jednorozca z textboxa
            myUnicorn.HornColor = textBoxHornColor.Text;
            
            //dodanie jednorożca do listy koni
            HorseList.Add(myUnicorn);
        }

        /// <summary>
        /// Funkcja zwracająca obiekt typu Horse. Funkcja czyta wartości z textBoxów.
        /// </summary>
        /// <returns></returns>
        private Horse GetData()
        {
            //utworzenie nowego konia
            Horse myHorse = new Horse();
            
            //przypisywanie wartości do właściwości konia - imie konia
            myHorse.Name = this.textBoxHorseName.Text;
            
            //przypisywanie wartości do właściwości konia - ulubiona liczba konia
            myHorse.FavouriteNumber = Int32.Parse(this.textBoxHorseFavouriteNumber.Text);
            
            //zwracanie obiektu typu Horse
            return myHorse;
        }
    }
}
