using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploWCFConfig
{
    class Mensaje : IMensaje
    {
        public string Hola(string nombre)
        {
            return "Hola: " + nombre;
        }
    }
}
