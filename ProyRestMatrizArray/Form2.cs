using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyRestMatrizArray
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnMesa1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hoal");
        }

        private void Horayfecha_Tick(object sender, EventArgs e) {

            hora.Text = DateTime.Now.ToString("HH:mm:ss");
            fecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
