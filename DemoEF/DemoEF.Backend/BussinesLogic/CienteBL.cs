using DemoEF.Backend.BussinesEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF.Backend.BussinesLogic
{
    public class CienteBL //hacerla publica
    {
        public void InsertCliente(EPM_Clientes objcliente) {
            
            //instanciamos el contexto en el using
            using (var en = new ZuluEntities1) { 
                
                /*este permite hacer un dispose y contrala 
                 * que se abra y cierre la conexion con la BD*/

                en.EPM_Clientes.Add(objcliente);
                en.SaveChanges();

            }
        }

        public void UpdateCliente(EPM_Clientes objcliente)
        {
            using (var en = new ZuluEntities1)
            {
                //expresion lamnda con linq
                var cliente_bd = en.EPM_Clientes.FirstOrDefault(
                    x=>x.IDCliente == objcliente.IDCliente);
                en.EPM_Clientes.Add(objcliente);
                en.SaveChanges();

            }
        }
    }
}
