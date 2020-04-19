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
            Mesa mesita = mesas[0];
            Form formulario = new Form3(mesita);
        }
        //mesas [2,4]
        //mesas [0,0] = btnMesa1;
        //mesas [0,1] = btnMesa2;
        //mesas [0,2] = btnMesa3;
        //mesas [0,3] = btnMesa4;
        //mesas [0,4] = btnMesa5;
        //mesas [1,0] = btnMesa6;
        //mesas [1,1] = btnMesa7;
        //mesas [1,2] = btnMesa8;
        //mesas [1,3] = btnMesa9;
        //mesas [1,4] = btnMesa10;
        //mesas [2,0] = btnMesa11;
        //mesas [2,1] = btnMesa12;
        //mesas [2,2] = btnMesa13;
        //mesas [2,3] = btnMesa14;
        //mesas [2,4] = btnMesa15;
        



        private void Horayfecha_Tick(object sender, EventArgs e) {

            hora.Text = DateTime.Now.ToString("HH:mm:ss");
            fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void BtnMesa2_Click(object sender, EventArgs e) {
            Mesa mesita = mesas[0];
            Form formulario = new Form3(mesita);

          //  mesas[0].ocupada
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

        private void btnMesa3_Click(object sender, EventArgs e)
        {
            Mesa mesita = mesas[0];
            Form formulario = new Form3(mesita);

            //  mesas[0].ocupada
            formulario.Show();
        }

        private void btnMesa4_Click(object sender, EventArgs e)
        {
            Mesa mesita = mesas[0];
            Form formulario = new Form3(mesita);

            //  mesas[0].ocupada
            formulario.Show();
        }

        private void btnMesa5_Click(object sender, EventArgs e)
        {
            Mesa mesita = mesas[0];
            Form formulario = new Form3(mesita);

            //  mesas[0].ocupada
            formulario.Show();
        }

        private void btnMesa6_Click(object sender, EventArgs e)
        {
            Mesa mesita = mesas[0];
            Form formulario = new Form3(mesita);

            //  mesas[0].ocupada
            formulario.Show();
        }

        private void btnMesa7_Click(object sender, EventArgs e)
        {
            Mesa mesita = mesas[0];
            Form formulario = new Form3(mesita);

            //  mesas[0].ocupada
            formulario.Show();
        }

        private void btnMesa8_Click(object sender, EventArgs e)
        {
            Mesa mesita = mesas[0];
            Form formulario = new Form3(mesita);

            //  mesas[0].ocupada
            formulario.Show();
        }

        private void btnMesa9_Click(object sender, EventArgs e)
        {
            Mesa mesita = mesas[0];
            Form formulario = new Form3(mesita);

            //  mesas[0].ocupada
            formulario.Show();
        }

        private void btnMesa10_Click(object sender, EventArgs e)
        {
            Mesa mesita = mesas[0];
            Form formulario = new Form3(mesita);

            //  mesas[0].ocupada
            formulario.Show();
        }

        private void btnMesa11_Click(object sender, EventArgs e)
        {
            Mesa mesita = mesas[0];
            Form formulario = new Form3(mesita);

            //  mesas[0].ocupada
            formulario.Show();
        }

        private void btnMesa12_Click(object sender, EventArgs e)
        {
            Mesa mesita = mesas[0];
            Form formulario = new Form3(mesita);

            //  mesas[0].ocupada
            formulario.Show();
        }

        private void btnMesa13_Click(object sender, EventArgs e)
        {
            Mesa mesita = mesas[0];
            Form formulario = new Form3(mesita);

            //  mesas[0].ocupada
            formulario.Show();
        }

        private void btnMesa14_Click(object sender, EventArgs e)
        {
            Mesa mesita = mesas[0];
            Form formulario = new Form3(mesita);

            //  mesas[0].ocupada
            formulario.Show();
        }

        private void btnMesa15_Click(object sender, EventArgs e)
        {
            Mesa mesita = mesas[0];
            Form formulario = new Form3(mesita);

            //  mesas[0].ocupada
            formulario.Show();
        }

        private void GroupBox1_Enter(object sender, EventArgs e) {

        }
    }
}

