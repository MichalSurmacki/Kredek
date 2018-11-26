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
    public partial class FormCompanyTakeCredit : Form
    {
        /// <summary>
        /// Połączenie z bazą danych
        /// </summary>
        SqlConnection connection;

        /// <summary>
        /// Właściwość pomocnicza decydująca o tym czy odświerzyć dataGridView w głównym oknie
        /// </summary>
        public Boolean helper { get; set; }

        /// <summary>
        /// Konstruktor klasy
        /// </summary>
        /// <param name="connection"></param>
        public FormCompanyTakeCredit(SqlConnection connection)
        {
            this.connection = connection;
            InitializeComponent();
            helper = false;
        }

        /// <summary>
        /// Przycisk odpowiedzialny za powrót do okienka głównego bez wprowadzania danych do bazy.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBack_Click(object sender, EventArgs e)
        {
            //zamknięcie okna
            this.Close();
        }

        /// <summary>
        /// Przycisk odpowiedzialny za dodanie danych o kredycie udzielonym firmie do bazy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTakeCredit_Click(object sender, EventArgs e)
        {
            //Utworzenie kwerendy
            SqlCommand command = new SqlCommand(@"INSERT INTO CompanyDebt(companyNumber, name, owner, debt) VALUES (@companyNumber, @name, @owner, @debt)", connection);
            //dodanie parametrów kwerendy
            command.Parameters.Add("@companyNumber", SqlDbType.BigInt).Value = textBoxNumber.Text;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = textBoxName.Text;
            command.Parameters.Add("@owner", SqlDbType.NVarChar).Value = textBoxOwner.Text;
            command.Parameters.Add("@debt", SqlDbType.Int).Value = textBoxCreditValue.Text;
            //otworzenie dostępu do bazy danych
            connection.Open();
            //wykonanie kwerendy
            command.ExecuteNonQuery();
            //zmienna przechowywująca aktualną datę.
            DateTime date = DateTime.Now.Date;
            //utworzenie nowej kwerendy
            command = new SqlCommand(@"INSERT INTO GivenCredits(creditAmount, creditRecipient, creditDate) VALUES (@creditAmount, @creditRecipient, @creditDate)", connection);
            //dodanie parametrów do kwerendy
            command.Parameters.Add("@creditAmount", SqlDbType.Int).Value = textBoxCreditValue.Text;
            command.Parameters.Add("@creditRecipient", SqlDbType.NVarChar).Value = textBoxName.Text + " " + textBoxNumber.Text;
            command.Parameters.Add("@creditDate", SqlDbType.Date).Value = date.Year + "-" + date.Month + "-" + date.Day;
            //wykonanie kwerendy
            command.ExecuteNonQuery();
            //ustanienie zmiennej pomocniczej w celu odświerzenia datagridview w głównym oknie
            helper = true;
            //zamknięcie dostępu do bazy danych
            connection.Close();
            //zamknięcie okna
            this.Close();
        }
    }
}
