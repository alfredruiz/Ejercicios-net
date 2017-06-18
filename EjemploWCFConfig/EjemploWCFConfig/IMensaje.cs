using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EjemploWCFConfig
{
    [ServiceContract (Namespace = "http://EjemploWCFConfig")]
    interface IMensaje
    {
        [OperationContract]
        string Hola(string nombre);
    }
}
