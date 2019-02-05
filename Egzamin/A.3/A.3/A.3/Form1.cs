using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A._3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void timerPrzesun_Tick(object sender, EventArgs e)
        {
            int x = buttonStart.Location.X;
            x += 10;
            Point point = new Point(x, buttonStart.Location.Y);
            buttonStart.Location = point;
        }
    }
}
