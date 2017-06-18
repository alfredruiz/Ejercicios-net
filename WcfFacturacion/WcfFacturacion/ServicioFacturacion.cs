using CADFacturacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfFacturacion
{
    public class ServicioFacturacion : IServicioFacturacion
    {
        public Producto GetProducto(string IDProducto)
        {
            DSFacturacion.ProductoDataTable miProducto = CADProducto.GetProducto(IDProducto);

            if (miProducto.Rows.Count == 0) return null;

            DSFacturacion.ProductoRow miRegistro = (DSFacturacion.ProductoRow)miProducto.Rows[0];
            //lo casteamos para hacerlo mas manejable como datarow

            Producto producto = new Producto();
            producto.IDProducto = miRegistro.IDProducto;
            producto.Descripcion = miRegistro.Descripcion;
            producto.Precio = miRegistro.Precio;
            producto.Stock = miRegistro.Stock;
            producto.Notas = miRegistro.Notas;

            return producto;


        }

        public List<Producto> GetProductos()
        {
            DSFacturacion.ProductoDataTable misProductos = CADProducto.GetProductos();

            if (misProductos.Rows.Count == 0) return null;

            List<Producto> productos = new List<Producto>();

            foreach (DSFacturacion.ProductoRow miRegistro in misProductos.Rows) {
                Producto producto = new Producto();
                producto.IDProducto = miRegistro.IDProducto;
                producto.Descripcion = miRegistro.Descripcion;
                producto.Precio = miRegistro.Precio;
                producto.Stock = miRegistro.Stock;
                producto.Notas = miRegistro.Notas;

                productos.Add(producto);
            }
            
            return productos;
        }
    }
}
