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
    public partial class FormBuyProduct : Form
    {
        /// <summary>
        /// Konstruktor klasy.
        /// </summary>
        public FormBuyProduct()
        {
            InitializeComponent();
            //utworzenie zmiennej do przeprowadzania operacji na bazie danych
            MichalSurmackiLab04Zad01Entities context = new MichalSurmackiLab04Zad01Entities();
            //wczytanie i zapisanie do listy wszystkich produktów znajdujących się w bazie
            List<String> list = context.ProductsForSales.Select(x => x.Product).ToList();
            //dodanie wszystkich produktów do combo boxa
            foreach (String s in list)
            {
                comboBoxProduct.Items.Add(s);
                comboBoxProduct.SelectedItem = s;
            }
        }

        /// <summary>
        /// Akcja odpowiedzialna za obliczanie ceny i wypisywanie jej do labela.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxAmount.Text.Equals(""))
            {
                //Pobranie nazwy produktu z comboBoxa do zmiennej
                String product = comboBoxProduct.Text;
                using (MichalSurmackiLab04Zad01Entities context = new MichalSurmackiLab04Zad01Entities())
                {
                    //pobranie ceny produktu z bazy danych
                    ProductsForSale info = new ProductsForSale();
                    //wybranie z bazy produktu o nazwie takiej jak zczytana z comboboxa
                    info = context.ProductsForSales.Where(x => x.Product.Equals(product)).FirstOrDefault();
                    //konwersja ceny wydobytej z bazy danych
                    int price = Int32.Parse(info.Price.ToString());
                    //próba konwersji typów - w przypadku nie udanej próby informacja o błędzie
                    try
                    {
                        price *= Int32.Parse(textBoxAmount.Text);
                        labelPriceValue.Text = price.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Wprowadzono niepoprawne dane!");
                        this.Close();
                    }
                }
            }
            else
            {
                //wypianie do textBoxAmount wartości 0 w celu uniknięcia błędów
                textBoxAmount.Text = "0";
            }
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            Boolean condition = false;
            //zmienna pozwalająca na komunikację z bazą danych i modyfikacje danych
            GettingAndEditingProductsService service = new GettingAndEditingProductsService();
            if (!textBoxAmount.Text.Equals(""))
            {
                //wywołanie metody i przypisanie stanu (true - usunięto zadaną ilość produktu, false - operacja odjęcia nie powiodła się)
                condition = service.DeleteProduct(comboBoxProduct.Text, Int32.Parse(textBoxAmount.Text));
            }
            //sprawdzenie wyniku działania metody
            if (condition)
            {
                //dodanie wpisu o dokonanej transakcji do tablei przechowywującej transakcje
                service.AddTransactionToBase(Int32.Parse(labelPriceValue.Text));
                //wyświetlenie komunikatu
                MessageBox.Show("Transakcja została dokonana poprawnie", "Komunikat");
                this.Close();
            }
            else
            {
                //wyświetlenie komunikatu
                MessageBox.Show("Transakcja nie została dokonana", "Komunikat");
            }
        }

        /// <summary>
        /// Przycisk odpowiedzialny za zamknięcie okna i powrót do poprzedniego okna.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
