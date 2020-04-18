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
        Mesa[] mesas;
        public Form2() {
            // Debe ser matriz
            mesas = new Mesa[15] {new Mesa(), new Mesa(), new Mesa(), new Mesa(), new Mesa(), new Mesa(), new Mesa(), new Mesa(), new Mesa(), new Mesa(), new Mesa(), new Mesa(), new Mesa(), new Mesa(), new Mesa()};
            InitializeComponent();
        }

        private void btnMesa1_Click(object sender, EventArgs e) {
            MessageBox.Show("hoal");
        }

        private void Horayfecha_Tick(object sender, EventArgs e) {

            hora.Text = DateTime.Now.ToString("HH:mm:ss");
            fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void BtnMesa2_Click(object sender, EventArgs e) {
            Mesa mesita = mesas[0];
            Form formulario = new Form3(mesita);

            mesas[0].ocupada
            formulario.Show();
        }

        private void Button1_Click(object sender, EventArgs e) {


            if (MessageBox.Show("Desea salir de las mesas?", "Salir", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.Yes) {


                Form1 formulario1 = new Form1();
                formulario1.Show();
                formulario1.Visible = true;
                Visible = false;
            }

        }
    }
}

