using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfFacturacion
{
    [ServiceContract]
    public interface IServicioFacturacion
    {
        [OperationContract]
        Producto GetProducto(string IDProducto);

        [OperationContract]
        List<Producto> GetProductos();

    }

    
}
