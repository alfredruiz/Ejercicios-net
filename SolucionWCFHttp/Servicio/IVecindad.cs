using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    //1. añadimos el ServiceContract
    [ServiceContract(Namespace ="http://Servicio")]
    interface IVecindad
    {
        //2. etiquetar. Plamteamos los métodos
        [OperationContract]
        string AgregarVecino(string nombre);

        [OperationContract]
        List<string> ListaVecinos();
    }
}
