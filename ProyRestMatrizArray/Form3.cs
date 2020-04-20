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
    public partial class Form3 : Form
    {
        Mesa mesa;
        Form2 form2;
        string[] comidas = new string[15] {"Espagueti a la boloñesa", "Espagueti a la cherry", "Espagueti con salsa blanca",
                "Lasaña", "Hamburguesa de la casa", "Hot dog CIJOSE", "Papas fritas", "Agua", "Coca-cola", "Fanta", "Limonada frapp",
                "Cerveza", "Pisco", "Mojito", "Cuba libre"};
     
        public Form3() {
            InitializeComponent();
        }

        public Form3(Mesa table, Form2 form_2) {
            mesa = table;
            form2 = form_2;
            InitializeComponent();

            for (int i = 0; i < comidas.Length; i++) {
                if (mesa.pedidos[i] == 0) {
                    continue;
                }
                Orden.Items.Add(mesa.pedidos[i] + "  " + comidas[i]);
            }
        }

        private void Label1_Click(object sender, EventArgs e) {

        }

        private void Orden_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void Label8_Click(object sender, EventArgs e) {

        }

        private void Label9_Click(object sender, EventArgs e) {

        }

        private void Button8_Click(object sender, EventArgs e) {
            Orden.Items.Clear();
            NumericUpDown[] cantidadComidas = new NumericUpDown[15]
            {
                numericUpDown1, numericUpDown2, numericUpDown3,
                numericUpDown4, numericUpDown5, numericUpDown6,
                numericUpDown7, numericUpDown8, numericUpDown9,
                numericUpDown10, numericUpDown11, numericUpDown12,
                numericUpDown13,numericUpDown14, numericUpDown15
            };

            for (int i = 0; i < comidas.Length; i++) {

                decimal total1 = mesa.pedidos[i] + (int)cantidadComidas[i].Value;

                if (total1 == 0) {
                    continue;
                }

                //MAGIA
                mesa.pedidos[i] = (int) total1;
                mesa.Ocupar();

                Orden.Items.Add(total1 + "  " + comidas[i]);

                cantidadComidas[i].Value = 0;
            }
                MessageBox.Show("Recepcionado en Cocina");
            }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e) {

        }

        private void Button7_Click(object sender, EventArgs e) {
            form2.ActualizarDisponible();
                Visible = false;
        }

        private void button1_Click(object sender, EventArgs e) {
        }
            

        private void Button1_Click_1(object sender, EventArgs e) {

            if (MessageBox.Show("Esta Seguro?", "CERRAR SESION", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes) {

                Form1 formulario1 = new Form1();
                formulario1.Show();
                formulario1.Visible = true;
                Visible = false;
            }
        }

        private void Button2_Click(object sender, EventArgs e) {


            if (MessageBox.Show("Estas Seguro?", "ELIMINAR", MessageBoxButtons.YesNo,
              MessageBoxIcon.Question) == DialogResult.No) {
                return;
            }

            Orden.Items.Clear();
            NumericUpDown[] cantidadComidas = new NumericUpDown[15] {
                numericUpDown1, numericUpDown2, numericUpDown3,
                numericUpDown4, numericUpDown5, numericUpDown6,
                numericUpDown7, numericUpDown8, numericUpDown9,
                numericUpDown10, numericUpDown11, numericUpDown12,
                numericUpDown13,numericUpDown14, numericUpDown15
            };

            for (int i = 0; i < comidas.Length; i++) {
                decimal total = mesa.pedidos[i] - cantidadComidas[i].Value;
                if (total < 0) {
                    MessageBox.Show("Producto no fue solicitado");
                    return;
                }
                mesa.pedidos[i] = (int)total;
                if (total == 0) {
                    continue;
                }
                Orden.Items.Add(total + "  " + comidas[i]);
                cantidadComidas[i].Value = 0;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
  }


