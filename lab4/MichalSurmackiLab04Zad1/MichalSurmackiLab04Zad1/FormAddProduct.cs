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
    public partial class FormAddProduct : Form
    {
        /// <summary>
        /// Konstruktor klasy
        /// </summary>
        public FormAddProduct()
        {
            InitializeComponent();
            //utworzenie zmiennej do przeprowadzania operacji na bazie danych
            MichalSurmackiLab04Zad01Entities context = new MichalSurmackiLab04Zad01Entities();
            //wczytanie i zapisanie do listy wszystkich produktów znajdujących się w bazie
            List<String> list = context.ProductsForSales.Select(x => x.Product).ToList();
            //dodanie wszystkich produktów do combo boxa
            foreach (String s in list)
            {
                //dodanie obiektu do comboBoxa
                comboBoxProduct.Items.Add(s);
                //ustawienie wartości ostatniego dodanego obiektu jako aktualnie wybrany w comboBoxProduct
                comboBoxProduct.SelectedItem = s;
            }
        }

        /// <summary>
        /// Przycisk odpowiedzialny za cofnięcie do poprzedniego okna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Przycisk odpowiedzialny za dodanie ilości produktu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //zmienna której metody mogą modyfikować dane w bazie danych.
            GettingAndEditingProductsService service = new GettingAndEditingProductsService();
            //Zczytanie nazwy produktu z comboBoxa
            String product = comboBoxProduct.Text;
            if (!textBoxAmount.Text.Equals(""))
            {
                int amount = Int32.Parse(textBoxAmount.Text);
                //wywołanie metody dodającej zadaną ilość przedmiotu do bazy danych
                service.AddAmountOfProduct(product, amount);
                MessageBox.Show("Dodano");
            }
            else
            {
                MessageBox.Show("Nie dodano");
            }
            this.Close();
        }
    }
}
