using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class ClienteVip : Cliente
    {
        public float Descuento { get; set; }

        public ClienteVip(string nombreCliente, string mailCliente, string direccionCliente, float descuento)
            : base(nombreCliente, mailCliente, direccionCliente)
        {
            Descuento = descuento;
        }
    }
}
