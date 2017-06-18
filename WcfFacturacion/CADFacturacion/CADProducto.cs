using CADFacturacion.DSFacturacionTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADFacturacion
{
    public class CADProducto //siempre pública
    {
        private static ProductoTableAdapter adaptador = new ProductoTableAdapter();

        public static DSFacturacion.ProductoDataTable GetProducto(string IDProducto)
        {
            return adaptador.GetProducto(IDProducto);
        }

        public static DSFacturacion.ProductoDataTable GetProductos()
        {
            return adaptador.GetData();
        }
    }
}
