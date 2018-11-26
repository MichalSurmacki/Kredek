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
    public partial class FormDoPayment : Form
    {
        /// <summary>
        /// Połączenie z bazą danych
        /// </summary>
        SqlConnection connection;

        /// <summary>
        /// właściwość pomocnicza przy odświerzaniu głównego datagridview w głównym oknie.
        /// </summary>
        public Boolean helper { get; set; }

        public FormDoPayment(SqlConnection connection)
        {
            this.connection = connection;
            InitializeComponent();
            //dodanie do comboboxa dwóch stringów decydujących do których tabel będą wprowadzane dane.
            comboBoxChoose.Items.Add("Firma");
            comboBoxChoose.Items.Add("Osoba");
            comboBoxChoose.SelectedIndex = 1;
        }

        /// <summary>
        /// Funkcja odpowiadajáca za działania w przypadku kiedy zmieniamy dane w comboboxie.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxChoose.SelectedItem.Equals("Osoba"))
            {
                //ustanienie wartości labeli
                labelName.Text = "Nazwisko:";
                labelNumber.Text = "PESEL:";
            }
            else if (comboBoxChoose.SelectedItem.Equals("Firma"))
            {
                //ustanienie wartości labeli
                labelName.Text = "Nazwa:";
                labelNumber.Text = "NIP:";
            }
        }

        /// <summary>
        /// Przycisk odpowiedzialny za zamknięcie okienka bez wprowadzania danych do bazy.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Przycisk odpowiedzialny za obsługę wpłacania przez osoby rat kredytu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDoPayment_Click(object sender, EventArgs e)
        {
            if (comboBoxChoose.SelectedItem.Equals("Osoba"))
            {
                //zmienna przechowywująca nazwisko osoby
                String surname = textBoxName.Text;
                //zmienna przechowywująca PESEL osoby
                String number = textBoxNumber.Text;
                //zmienna przechowywująca wartość wpłacanej raty
                String paymentValue = textBoxPaymentValue.Text;
                //Utworzenie kwerendy
                SqlCommand command = new SqlCommand($@"UPDATE PersonDebt SET debt = debt - {paymentValue} WHERE personalNumber = {number}", connection);
                //otworzenie połączenia z bazą
                connection.Open();
                //wykonanie kwerendy
                command.ExecuteNonQuery();
                //komenda wyciągająca z bazy dane na temat pozostałego zadłużenia osoby
                command = new SqlCommand($@"SELECT debt FROM PersonDebt WHERE personalNumber = {number}",connection);
                //zmienna przechowywująca wartość wpłaconych pieniędzy
                int payment = Int32.Parse(paymentValue);
                //zmienna przechowywująca wartość pozostałego dlugu osoby.
                int x = 0;
                //utworzenie sqldatareader'a
                SqlDataReader reader = command.ExecuteReader();
                //zczytywanie pozostałej ilości długu
                while (reader.Read())
                {
                    //zczytanie wartosci do zmiennej x
                    x = Int32.Parse(reader["debt"].ToString());
                }
                //zamkniecie sqldatareader'a
                reader.Close();
                //jeśli dług spłacony i występuje nadpłata - komunikat o nadpłacie
                if (x < 0)
                {
                    x = Math.Abs(x);
                    payment -= x;
                    //usunięcie dłużnika który spłacił swój dług
                    command = new SqlCommand($@"DELETE FROM PersonDebt WHERE personalNumber = {number}", connection);
                    command.ExecuteNonQuery();
                    //wyświetlenie informacji o nadpłacie
                    MessageBox.Show("Zwrot: " + x, "Nadpłata");
                }
                //zmienna reprezentująca aktualną datę.
                DateTime date = DateTime.Now.Date;
                //utworzenie nowej kwerendy
                command = new SqlCommand(@"INSERT INTO PersonTransaction(personalNumber, personPayment, personTransactionDate) VALUES (@personalNumber, @personPayment, @personTransactionDate)", connection);
                //dodanie parametrów do kwerendy
                command.Parameters.Add("@personalNumber", SqlDbType.BigInt).Value = number;
                command.Parameters.Add("@personPayment", SqlDbType.NVarChar).Value = payment.ToString();
                command.Parameters.Add("@personTransactionDate", SqlDbType.NVarChar).Value = date.Year + "-" + date.Month + "-" + date.Day;
                //wykonanie kwerendy
                command.ExecuteNonQuery();
                //zakmnięcie dostępu do bazy
                connection.Close();
                //ustawienie wartości pomocniczej
                helper = false;
                //zamknięcie okna
                this.Close();
            }
            else if (comboBoxChoose.SelectedItem.Equals("Firma"))
            {
                //zmienna przechowywująca nazwę firmy
                String name = textBoxName.Text;
                //zmienna przechowywująca NIP firmy
                String number = textBoxNumber.Text;
                //zmienna przechowywująca wartość wpłacanej raty
                String paymentValue = textBoxPaymentValue.Text;
                //Utworzenie kwerendy
                SqlCommand command = new SqlCommand($@"UPDATE CompanyDebt SET debt = debt - {paymentValue} WHERE companyNumber = {number}", connection);
                //otworzenie połączenia z bazą
                connection.Open();
                //wykonanie kwerendy
                command.ExecuteNonQuery();
                //komenda wyciągająca z bazy dane na temat pozostałego zadłużenia osoby
                command = new SqlCommand($@"SELECT debt FROM CompanyDebt WHERE companyNumber = {number}", connection);
                //zmienna przechowywująca wartość wpłaconych pieniędzy
                int payment = Int32.Parse(paymentValue);
                //zmienna przechowywująca wartość pozostałego dlugu osoby.
                int x = 0;
                //utworzenie sqldatareader'a
                SqlDataReader reader = command.ExecuteReader();
                //zczytywanie pozostałej ilości długu
                while (reader.Read())
                {
                    //zczytanie wartosci do zmiennej x
                    x = Int32.Parse(reader["debt"].ToString());
                }
                //zamknięcie sqldatareader'a
                reader.Close();
                //jeśli dług spłacony i występuje nadpłata - komunikat o nadpłacie
                if (x < 0)
                {
                    x = Math.Abs(x);
                    payment -= x;
                    //usunięcie dłużnika który spłacił swój dług
                    command = new SqlCommand($@"DELETE FROM CompanyDebt WHERE companyNumber = {number}", connection);
                    command.ExecuteNonQuery();
                    //wyświetlenie informacji o nadpłacie
                    MessageBox.Show("Zwrot: " + x, "Nadpłata");
                }
                //zmienna reprezentująca aktualną datę.
                DateTime date = DateTime.Now.Date;
                //utworzenie nowej kwerendy
                command = new SqlCommand(@"INSERT INTO CompanyTransaction(companyNumber, companyPayment, companyTransactionDate) VALUES (@companyNumber, @companyPayment, @companyTransactionDate)", connection);
                //dodanie parametrów do kwerendy
                command.Parameters.Add("@companyNumber", SqlDbType.BigInt).Value = number;
                command.Parameters.Add("@companyPayment", SqlDbType.NVarChar).Value = payment.ToString();
                command.Parameters.Add("@companyTransactionDate", SqlDbType.NVarChar).Value = date.Year + "-" + date.Month + "-" + date.Day;
                //wykonanie kwerendy
                command.ExecuteNonQuery();
                //zamknięcie dostępu do bazy danych
                connection.Close();
                //ustawienie wartości pomocniczej
                helper = true;
                //zamknięcie dostępu do bazy
                connection.Close();
                //zamknięcie okna
                this.Close();
            }
        }
    }
}
