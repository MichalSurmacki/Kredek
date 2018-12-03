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
    public partial class FormMain : Form
    {
        /// <summary>
        /// Konstruktor głownego okna
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            //dodanie do comboBoxTable'a opcji wyboru tabel 
            comboBoxTables.Items.Add("Produkty na sprzedaż");
            comboBoxTables.Items.Add("Sprzedane produkty");
            //ustawienie wartości w comboBoxTable
            comboBoxTables.SelectedItem = "Produkty na sprzedaż";

        }

        /// <summary>
        /// Funkcja odpowiedzialna za zmianę danych w dataGridView - wypieranie odpowiedniej tabeli z listy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            //odświerzenie danych wyświetlanych w dataGridViewData
            this.RefreshDataGridView();
        }

        /// <summary>
        /// Przycisk odpowiedzialny za otwarcie okna słóżącego do kupowania przedmiotów ze sklepów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuy_Click(object sender, EventArgs e)
        {
            //wyświetlenie okna, w którym następuje wybór kupowanego przedmiotu
            using(FormBuyProduct form = new FormBuyProduct())
            {
                //instrukcje wykonywane po zamknięciu okna
                if(form.ShowDialog() != DialogResult.OK)
                {
                    //odświerzenie danych wyświetlanych w dataGridViewData
                    this.RefreshDataGridView();
                }
            }
        }

        /// <summary>
        /// Przycisk odpowiedzialny za otwarcie okna słóżącego do dodawania ilośc wybranego produktu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            //otwarcie okna, w którym następuje dodanie ilości do produktu, który już istnieje w bazie
            using(FormAddProduct form = new FormAddProduct())
            {
                //operacje po zamknięciu okna
                if(form.ShowDialog() != DialogResult.OK)
                {
                    //odświerzenie danych wyświetlanych w dataGridViewData
                    this.RefreshDataGridView();
                }
            }
        }

        /// <summary>
        /// Przycisk słóżący do dodawania nowego przedmiotu do sklepu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddNewProduct_Click(object sender, EventArgs e)
        {
            //wyświetlenie okna dzięku, któremu następuje możliwość dodania nowego produktu do bazy danych
            using (FormAddNewProduct form = new FormAddNewProduct())
            {
                //operacje wykonywane po zamknięciu okna
                if(form.ShowDialog() != DialogResult.OK)
                {
                    //odświerzenie danych wyświetlanych w dataGridViewData
                    this.RefreshDataGridView();
                }
            }
        }

        /// <summary>
        /// Funkcja odpowiedzialna za odświerzenie dataGridView znajdującego się w głównym okienku
        /// </summary>
        private void RefreshDataGridView()
        {
            //jeśli w comboBoxTables wartość wybranej opcji to "Produkty na sprzedaż" wyświetlenie/odświerzenie danych z tabeli - ProductsForSale
            if (comboBoxTables.Text.Equals("Produkty na sprzedaż"))
            {
                //odświerzenie tabeli - formatowanie wyświetlania w dataGridViewTables
                //użycie zmiennej context dzięki której można wyciągnąć dane z bazy
                using (MichalSurmackiLab04Zad01Entities context = new MichalSurmackiLab04Zad01Entities())
                {
                    dataGridViewData.Columns.Clear();
                    dataGridViewData.AutoGenerateColumns = false;
                    dataGridViewData.Columns.Add("Category", "Kategoria");
                    dataGridViewData.Columns["Category"].DataPropertyName = "Category";
                    dataGridViewData.Columns.Add("Product", "Produkt");
                    dataGridViewData.Columns["Product"].DataPropertyName = "Product";
                    dataGridViewData.Columns["Product"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridViewData.Columns.Add("Price", "Cena [zł]");
                    dataGridViewData.Columns["price"].DataPropertyName = "Price";
                    dataGridViewData.Columns.Add("InStock", "Ilość w magazynie");
                    dataGridViewData.Columns["InStock"].DataPropertyName = "InStock";
                    dataGridViewData.DataSource = context.ProductsForSales.ToList<ProductsForSale>();
                }
            }
            //jeśli w comboBoxTables wartość wybranej opcji to "Sprzedane produkty" wyświetlenie/odświerzenie danych z tabeli - SoldProducts
            else if (comboBoxTables.Text.Equals("Sprzedane produkty"))
            {
                //odświerzenie tabeli - formatowanie wyświetlania w dataGridViewTables
                //użycie zmiennej context dzięki której można wyciągnąć dane z bazy
                using (MichalSurmackiLab04Zad01Entities context = new MichalSurmackiLab04Zad01Entities())
                {
                    dataGridViewData.Columns.Clear();
                    dataGridViewData.AutoGenerateColumns = false;
                    dataGridViewData.Columns.Add("DateOfTransaction", "Data transakcji");
                    dataGridViewData.Columns["DateOfTransaction"].DataPropertyName = "DateOfTransaction";
                    dataGridViewData.Columns.Add("Price", "Pozyskane środki [zł]");
                    dataGridViewData.Columns["Price"].DataPropertyName = "Price";
                    dataGridViewData.DataSource = context.SoldProducts.ToList();
                }
            }
            //jeśli nie ma wybranej żadnej opcji w comboBoxTables - wyczyszczenie dataGridViewTables
            else
            {
                dataGridViewData.Columns.Clear();
            }
        }
    }
}
