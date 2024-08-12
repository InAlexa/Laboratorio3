using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class Cliente
    {
        public string NombreCliente { get; set; }
        public string MailCliente { get; set; }
        public string DireccionCliente { get; set; }

        public Cliente(string nombreCliente, string mailCliente, string direccionCliente)
        {
            NombreCliente = nombreCliente;
            MailCliente = mailCliente;
            DireccionCliente = direccionCliente;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine("Nombre del cliente:" + NombreCliente);
            Console.WriteLine("Email del cliente: " + MailCliente);
            Console.WriteLine("Dirección del ciente: " + DireccionCliente);
        }
    }
}
