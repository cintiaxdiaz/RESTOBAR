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
    public partial class Form1 : Form
    {
        int RUT_NUM_CHARS = 10
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            if (rutValido(textBoxPassUsuario.Text)) {
                Form formulario = new Form2();
                formulario.Show();
                Visible = false;
                MessageBox.Show("BIENVENIDO, QUE TENGAS UN EXCELENTE DÍA!");
            } else {
                MessageBox.Show("Usuario o contraseña incorrecta"); 
            }
        }
        

        private void Horayfecha_Tick(object sender, EventArgs e) {

            // Indica la hora y la fecha en tiempo real

            hora.Text = DateTime.Now.ToString("HH:mm:ss");
            fecha.Text = DateTime.Now.ToLongDateString();

        }
        
        private bool rutValido(rut string) {
            rut = rut.Replace('.', string.Empty);
            if ((rut.Length < 3) rut[rut.Length - 2] != '-') {
                MessageBox.Show("Formato inválido para Rut.");
                return;
            }
            
            int cerosFaltantes = RUT_NUM_CHARS - rut.Length;
            rut = (new String('0', cerosFaltantes)) + rut;
            int[] nums = {0, 0, 0, 0, 0, 0, 0, 0}
            int[] CONSTANTES = {3, 2, 7, 6, 5, 4, 3, 2}
            
            for (int i = 0; i < 5; i++) 
            {
                nums[i] = CONSTANTES[i] * Int32.Parse(rut[i].ToString());
            }

            double suma = n0 + n1 + n2 + n3 + n4 + n5 + n6 + n7;
            double divisiondecimal = suma / 11;
            double divisionentero = (int)divisiondecimal;
            double valordecimal = divisiondecimal - divisionentero;
            double resta11 = 11 - (11 * (valordecimal));
            resta11 = Math.Round(resta11);
            int digito = (int)resta11;

            if (digito == 11) {
                digito = 0;
            }

            int digitoVer;

            if ((rut[9] == 'k') | (rut[9] == 'K')) {
                digitoVer = 10;
            } else {
                digitoVer = Int32.Parse(rut[9].ToString());
            }

            return digito == digitoVer;
     
        }
    }
}
