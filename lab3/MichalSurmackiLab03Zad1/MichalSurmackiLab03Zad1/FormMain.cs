using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MichalSurmackiLab03Zad1
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// Połączenie z bazą danych
        /// </summary>
        SqlConnection connection;
        public FormMain()
        {
            InitializeComponent();
            //dodanie stringów do comboboxa, które reprezentują wybrane tabele w bazie danych.
            comboBoxData.Items.Add("Osoby zadłużone");
            comboBoxData.Items.Add("Firmy zadłużone");
            comboBoxData.Items.Add("Transakcje z osobami");
            comboBoxData.Items.Add("Transakcje z firmami");
            comboBoxData.Items.Add("Udzielone kredyty");
            //połączenie z bazą danych
            connection = new SqlConnection(@"Data Source=LAPTOP-13MBOPF6\MICHALSQL; database=MichalSurmackiLab03Zad01; Trusted_Connection=yes");
            //ustawienie początkowej wartości comboboxa zeby nie był pusty oraz zeby datagridview nie było puste.
            comboBoxData.SelectedIndex = 0;
        }

        /// <summary>
        /// Wyświetlanie
        /// </summary>
        /// <param name="table"></param>
        private void ShowData(string tableName)
        {
            //utworzenie obiektu do odczytu bazy danych
            SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT * FROM {tableName}", connection);
            DataTable table = new DataTable();
            //wypełnienie tablicy danymi z bazy
            dataAdapter.Fill(table);
            //wyswietlenie bazy danych
            dataGridViewData.DataSource = table;
        }

        /// <summary>
        /// Przycisk odpowiedzialny za dodanie kredytu na osobę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPersonTakeCredit_Click(object sender, EventArgs e)
        {
            using (FormPersonTakeCredit form = new FormPersonTakeCredit(connection))
            {
                if(form.ShowDialog() != DialogResult.OK)
                {
                    if (form.helper == true)
                    {
                        ShowData("PersonDebt");
                    }
                }
            }
        }

        /// <summary>
        /// Przycisk odpowiedzialny za dodanie kredytu na firmę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCompanyTakeCredit_Click(object sender, EventArgs e)
        {
            using (FormCompanyTakeCredit form = new FormCompanyTakeCredit(connection))
            {
                if(form.ShowDialog() != DialogResult.OK)
                {
                    if (form.helper == true)
                    {
                        ShowData("CompanyDebt");
                    }
                }
            }
        }

        /// <summary>
        /// Przycisk odpowiedzialny za wpłacanie rat kredytu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDoPayment_Click(object sender, EventArgs e)
        {
            using (FormDoPayment form = new FormDoPayment(connection))
            {
                String selected = this.comboBoxData.GetItemText(this.comboBoxData.SelectedItem);
                if (form.ShowDialog() != DialogResult.OK)
                {
                    if(form.helper == true)
                    {
                        ShowData("CompanyDebt");
                    }
                    else
                    {
                        ShowData("PersonDebt");
                    }
                    
                }
            }
        }

        private void comboBoxData_SelectedIndexChanged(object sender, EventArgs e)
        {
            //wyświetlanie piszczególnych tabeli z bazy w przypadku zmiany stanu comboboxa
            if (comboBoxData.SelectedItem.Equals("Osoby zadłużone"))
            {
                ShowData("PersonDebt");
            }
            else if (comboBoxData.SelectedItem.Equals("Firmy zadłużone"))
            {
                ShowData("CompanyDebt");
            }
            else if (comboBoxData.SelectedItem.Equals("Transakcje z osobami"))
            {
                ShowData("PersonTransaction");
            }
            else if (comboBoxData.SelectedItem.Equals("Transakcje z firmami"))
            {
                ShowData("CompanyTransaction");
            }
            else if (comboBoxData.SelectedItem.Equals("Udzielone kredyty"))
            {
                ShowData("GivenCredits");
            }
        }
    }
}
