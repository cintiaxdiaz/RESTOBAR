using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyRestMatrizArray
{
    class USUARIO
    {
        public string rut;
        public DateTime inicioSesion;
        public DateTime finSesion;


        public USUARIO(string Rut) {
            rut = Rut;
            inicioSesion = DateTime.Now;
        } 
    }
}