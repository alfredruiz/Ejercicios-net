using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // declaramos la URL del servicio
            Uri uri = new Uri("Http://localhost:8000/Servicios/Servicio"); 

            //creamos el hospedaje en la dirección anterior y le provee los servicios
            //de la clase vecindad
            ServiceHost hospedaje = new ServiceHost(typeof(Vecindad), uri);

            //poner en marcha el sevicio
            try
            {
                //añadir un endpoint, por donde va a escuchar el servicio
                //añadimos un new servicio ligado por http con la interfaz como parámetro, wshttpbinding y una dirección.
                hospedaje.AddServiceEndpoint(typeof(IVecindad), new WSHttpBinding(), "ServicioVecindad");

                //definir el comportamiento del servicio
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();

                smb.HttpGetEnabled = true;  //que habilite peticiones http
                hospedaje.Description.Behaviors.Add(smb);//añadir comportamiento smb
                hospedaje.Open(); //escucha el servicio

                Console.WriteLine("el servicio está en ejecución");
                Console.WriteLine("presione entrer para detenerlo");
                Console.ReadLine();

                hospedaje.Close();

            }
            catch (CommunicationException ce)
            {

                Console.WriteLine("Hubo derrumbe: {0}", ce.Message);
                Console.WriteLine("presione entrer para continuar");
                Console.ReadLine();
                hospedaje.Abort(); //cancelar el servicio
            }
        }
    }
}
