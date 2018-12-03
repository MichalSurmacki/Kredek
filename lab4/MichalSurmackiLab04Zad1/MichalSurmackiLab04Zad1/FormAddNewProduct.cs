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
    public partial class FormAddNewProduct : Form
    {
        /// <summary>
        /// Konstruktor klasy
        /// </summary>
        public FormAddNewProduct()
        {
            InitializeComponent();
            //utworzenie zmiennej do przeprowadzania operacji na bazie danych
            MichalSurmackiLab04Zad01Entities context = new MichalSurmackiLab04Zad01Entities();
            //wczytanie i zapisanie do listy wszystkich kategorii produktów znajdujących się w bazie
            List<String> list = context.ProductsForSales.Select(x => x.Category).ToList();
            //utworzenie listy w której wyeliminowane będą powtórki
            List<String> goodList = new List<String>();
            //wyeliminowanie powtarzających się kategorii
            foreach (String s in list){
                bool ifAdd = true;
                for (int i=0; i<goodList.Count; i++)
                {
                    if (s.Equals(goodList[i]))
                    {
                        ifAdd = false;
                    }
                }
                if(ifAdd)
                    //dodanie kategorii do nowej listy
                    goodList.Add(s);
            }
            //dodanie do comboboxa kategorii (wyeliminowane powtórki), które już znajdują się w bazie 
            foreach (String s in goodList)
            {
                //dodanie obiektu do comboBoxCategory i ustawienie wartości początkowej w  comboBoxCategory
                comboBoxCategory.Items.Add(s);
                comboBoxCategory.SelectedItem = s;
            }
        }

        /// <summary>
        /// Przycisk zamykający okienko
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Przycisk dodający dane do bazy danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Boolean ans = false;
            //Obiekt klasy której zadaniem jest komunikacja z bazą
            GettingAndEditingProductsService service = new GettingAndEditingProductsService();
            //sprawdzenie czy uzytkownik wprowadził jakieś dane jeśli nie wprowadził nie dodawać do bazy
            if (!textBoxAmount.Text.Equals("") && !textBoxPrice.Text.Equals("") && !textBoxAmount.Text.Equals("") && !textBoxAmount.Text.Equals("0") && !textBoxProduct.Text.Equals(""))
            {
                //wywołanie metody dodającej produkt do bazy i przypisanie stanu (true - produkt dodany, false - produkt nie dodany)
                ans = service.AddProtuctToBase(Int32.Parse(textBoxPrice.Text), comboBoxCategory.Text, textBoxProduct.Text, Int32.Parse(textBoxAmount.Text));
            }
            //jeśli produkt został dodany następuje zamknięcie okna.
            if (ans)
            {
                //wyświetlenie informacji o dodaniu do bazy produktu
                MessageBox.Show("Produkt został dodany do bazy!","Komunikat");
                this.Close();
            }
            //jeśli produkt nie został dodany wyświetlenie innego komunikatu.
            else
            {
                MessageBox.Show("Produkt nie został dodany do bazy!", "Komunikat");
            }
        }

        /// <summary>
        /// Przycisk odpowiedzialny za dodanie nowej kategorii do comboboxa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            //otwirzenie nowego okienka słóżącego dodaniu nowej kategorii do już istniejących w bazie
            using(FormAddingCategory form = new FormAddingCategory())
            {
                //instrukcje wykonywane po zakmnięciu okna form
                if(form.ShowDialog() != DialogResult.OK)
                {
                    if (!form.GetCategory().Equals(""))
                    {
                        //dodanie nowej kategorii do comboboxa
                        comboBoxCategory.Items.Add(form.GetCategory());
                        comboBoxCategory.SelectedItem = form.GetCategory();
                    }
                }
            }
        }
    }
}
