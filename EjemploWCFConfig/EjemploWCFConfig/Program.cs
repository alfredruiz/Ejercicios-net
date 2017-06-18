using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EjemploWCFConfig
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Creamos el hospedaje con los parámetros typeof donde se indica el
             nombre de la clase, la url donde se publicará. La URL también podríamos
             haberla puesto enel App.Config en adresss*/
            ServiceHost hospedaje = new ServiceHost(typeof(Mensaje), 
                new Uri("http://localhost:8000/EjemploMensaje"));

            try
            {
                hospedaje.Open(); //los demás parámetros ya están en app.config
                Console.WriteLine("Dirección: {0}", hospedaje.BaseAddresses[0]);
                Console.WriteLine("Enlace   : {0}", hospedaje.Description.Endpoints[0].Binding.Name);
                Console.WriteLine("El servicio está en ejecución. Presione enter para salir");
                Console.ReadLine();
                hospedaje.Close();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("Hubo un problema: {0}", ce.Message);
                Console.ReadLine();
                hospedaje.Abort();
            }
        }
    }
}
