using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class ClienteCorporativo : Cliente
    {
        public float DescuentoMayor { get; set; }
        public List<ClienteCorporativo> ListaDeVehiculos { get; set; }

        public ClienteCorporativo(string nombreCliente, string mailCliente, string direccionCliente, float descuentoMayor, List<ClienteCorporativo> listaDeVehiculos)
            : base(nombreCliente, mailCliente, direccionCliente)
        {
            DescuentoMayor = descuentoMayor;
            ListaDeVehiculos = new List<ClienteCorporativo>();
        }
    }
}
