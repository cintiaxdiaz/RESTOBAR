using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyRestMatrizArray
{
    public class Mesa
    {
        public int[] pedidos;
        public bool ocupada;
        public Mesa() {
            pedidos = new int[15];
            ocupada = false;
        }
        public void Ocupar() {
            //ocupada = True;
        }
    }
}
