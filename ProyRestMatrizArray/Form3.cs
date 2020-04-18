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
        string[] comidas = new string[15] {"Espagueti a la boloñesa", "Espagueti a la cherry", "Espagueti con salsa blanca",
                "Lasaña", "Hamburguesa de la casa", "Hot dog CIJOSE", "Papas fritas", "Agua", "Coca-cola", "Fanta", "Limonada frapp",
                "Cerveza", "Pisco", "Mojito", "Cuba libre"};
        public Form3() {
            InitializeComponent();
        }

        public Form3(Mesa table) {
            mesa = table;
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
            NumericUpDown[] cantidadComidas = new NumericUpDown[15] {numericUpDown1, numericUpDown2, numericUpDown3, numericUpDown4, numericUpDown5, numericUpDown6,
                numericUpDown7, numericUpDown8, numericUpDown9, numericUpDown10, numericUpDown11, numericUpDown12, numericUpDown13,
                numericUpDown14, numericUpDown15};


            for (int i = 0; i < comidas.Length; i++) {

                if (cantidadComidas[i].Value == 0) {
                    continue;
                }
                Orden.Items.Add((cantidadComidas[i].Value + mesa.pedidos[i]) + "  " + comidas[i]);
                //MAGIA
                mesa.pedidos[i] = (int) cantidadComidas[i].Value;

                mesa.Ocupar();
            }


            // MessageBox.Show("Enviado para preparar");
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e) {

        }

        private void Button7_Click(object sender, EventArgs e) {

            if (MessageBox.Show("Desea salir del menú?", "Salir", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes) {

                Visible = false;


            }
        }
    }
}

