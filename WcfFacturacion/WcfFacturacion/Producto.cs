using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfFacturacion
{
 
    [DataContract] //etiqueta la clase producto como datacontract que originalmente estaba en la interface
    public class Producto
    {
        private string iDProducto;//inicio en minúsculas
        private string descripcion;
        private decimal precio;
        private int stock;
        private string notas;


        [DataMember] // hace pública la clase
        public string IDProducto
        {
            get {return iDProducto;}
            set {iDProducto = value;}
        }

        [DataMember]
        public string Descripcion
        {
            get{return descripcion;}
            set{descripcion = value;}
        }

        [DataMember]
        public decimal Precio
        {
            get{return precio;}
            set{precio = value;}
        }

        [DataMember]
        public int Stock
        {
            get{return stock;}
            set{stock = value;}
        }

        [DataMember]
        public string Notas
        {
            get{return notas;}
            set{notas = value;}
        }
    }
    
}
