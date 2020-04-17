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
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
           
            string rut = textBoxPassUsuario.Text;
            //rut = rut.Replace(".", string.Empty); ( se lo quitamos??)

            if (rut.Length == 9) {
                rut = "0" + rut;
            }

            if (rut[8] != '-') {

               // textBox2.Text = "Incorrecto, falta guión";
                return;
            }


            int n0, n1, n2, n3, n4, n5, n6, n7 = 0;

            int CONSTANTE0 = 3;
            int CONSTANTE1 = 2;
            int CONSTANTE2 = 7;
            int CONSTANTE3 = 6;
            int CONSTANTE4 = 5;
            int CONSTANTE5 = 4;
            int CONSTANTE6 = 3;
            int CONSTANTE7 = 2;

            n0 = CONSTANTE0 * Int32.Parse(rut[0].ToString());
            n1 = CONSTANTE1 * Int32.Parse(rut[1].ToString());
            n2 = CONSTANTE2 * Int32.Parse(rut[2].ToString());
            n3 = CONSTANTE3 * Int32.Parse(rut[3].ToString());
            n4 = CONSTANTE4 * Int32.Parse(rut[4].ToString());
            n5 = CONSTANTE5 * Int32.Parse(rut[5].ToString());
            n6 = CONSTANTE6 * Int32.Parse(rut[6].ToString());
            n7 = CONSTANTE7 * Int32.Parse(rut[7].ToString());

            double suma = n0 + n1 + n2 + n3 + n4 + n5 + n6 + n7;
            double divisiondecimal = suma / 11;
            Console.WriteLine(divisiondecimal);
            double divisionentero = (int)divisiondecimal;
            Console.WriteLine(divisionentero);
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

            if (digito == digitoVer) {

                Form formulario = new Form2();
                formulario.Show();

                MessageBox.Show("BIENVENIDO");

            } else {
                
                MessageBox.Show("Usuario o contraseña incorrecta"); 
            }
        }
        
    }
}
