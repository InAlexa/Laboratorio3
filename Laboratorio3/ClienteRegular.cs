using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class ClienteRegular : Cliente
    {
        public ClienteRegular(string nombreCliente, string mailCliente, string direccionCliente,)
            :base(nombreCliente, mailCliente, direccionCliente)
        {

        }
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
        }
    }
    
}
