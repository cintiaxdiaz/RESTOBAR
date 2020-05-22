using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyRestMatrizArray
{
    //EVENTO
    class CLASEEVALUA2CintiaDiaz
    {
        private string rut;
        private DateTime inicioSesion;
        private DateTime finSesion;
        private string Accion;
        private DateTime AccionF;

        public CLASEEVALUA2CintiaDiaz(USUARIO user, string Acciones) {
            rut = user.rut;
            inicioSesion = user.inicioSesion;
            // finSesion;
            Accion = Acciones;
            AccionF = DateTime.Now;

        }
    }
}
