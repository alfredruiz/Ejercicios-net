using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            VecindadClient cliente = new VecindadClient();

            //consumimos el servicio
            string texto;
            texto = cliente.AgregarVecino("Bob Marley");
            Console.WriteLine("Se ha obtenido el mensaje: {0}", texto);

            texto = cliente.AgregarVecino("Bob Esponja");
            Console.WriteLine("Se ha obtenido el mensaje: {0}", texto);

            texto = cliente.AgregarVecino("Mariano Rajoy");
            Console.WriteLine("Se ha obtenido el mensaje: {0}", texto);

            texto = cliente.AgregarVecino("Pablo Iglesias");
            Console.WriteLine("Se ha obtenido el mensaje: {0}", texto);

            texto = cliente.AgregarVecino("Albert Ribera");
            Console.WriteLine("Se ha obtenido el mensaje: {0}", texto);

            String[] vecinos = cliente.ListaVecinos();
            foreach (string vecino in vecinos) {
                Console.WriteLine("vecino: {0}", vecino);
            }

            Console.WriteLine("Presione enter para salir del cliente");
            Console.ReadLine();
        }
    }
}
