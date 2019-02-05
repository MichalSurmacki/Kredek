using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A._2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void dataGridViewDane_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            String data;
            int ocena;
            int wynik;
            using(FormDodaj dialog = new FormDodaj())
            {
                if(dialog.ShowDialog() != DialogResult.OK)
                {
                    data = dialog.data;
                    ocena = dialog.ocena;
                    wynik = dialog.wynik;
                    if (ocena != 0 && wynik != -1 && !wynik.Equals(""))
                    {
                        dataGridViewDane.Rows.Add(new DataGridViewRow ());
                    }
                }
            }
        }
    }
}

