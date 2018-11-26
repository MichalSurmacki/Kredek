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

namespace MichalSurmackiLab03
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
            connection = new SqlConnection(@"Data Source=LAPTOP-13MBOPF6\MICHALSQL; database=MateuszRotykiewiczLab32; Trusted_Connection=yes");

        }
        /// <summary>
        /// Wyświetlenie widoku "GradesView"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonViewGrade_Click(object sender, EventArgs e)
        {
            ShowData("gradesView");
        }

        /// <summary>
        /// Dodawnie nowego kursu do bazy danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            //Utworzenie kwerendy
            SqlCommand command = new SqlCommand(@"INSERT INTO Courses(Name, Teacher) VALUES (@Name, @Teacher)" ,connection);
            //dodanie parametrów kwerendy
            command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = textBoxCourse.Text;
            command.Parameters.Add("@Teacher", SqlDbType.NVarChar).Value = textBoxName.Text;
            connection.Open();
            //wykonanie kwerendy
            command.ExecuteNonQuery();
            connection.Close();
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
        /// Wyswietlanie tabeli "Courses"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCourses_Click(object sender, EventArgs e)
        {
            ShowData("Courses");
        }
    }
}
