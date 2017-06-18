using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    class Vecindad : IVecindad
    {
        //3. añadimos atributo vecinos
        private List<string> vecinos = new List<string>();
        public string AgregarVecino(string nombre)
        {
            vecinos.Add(nombre);
            Console.WriteLine("se intenta agregar al vecino  {0}", nombre);
            return String.Format("Hay {0} vecinos", vecinos.Count);
        }

        public List<string> ListaVecinos()
        {
            return vecinos;
        }
    }

}
