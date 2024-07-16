using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerProyecto.Model;

namespace TallerProyecto.Controller
{
    public class ClienteController
    {
        private List<Cliente> clientes;

        public ClienteController()
        {
            clientes = new List<Cliente>();
        }

        public List<Cliente> ObtenerClientes()
        {
            return clientes;
        }

        public List<Vehiculo> ObtenerVehiculosDeCliente(Cliente cliente)
        {
            return cliente.Vehiculos;
        }

        public void RegistrarCliente(Cliente cliente)
        {
            cliente.Id = clientes.Count + 1;
            clientes.Add(cliente);
        }

        public void RegistrarVehiculoACliente(int clienteId, Vehiculo vehiculo)
        {
            var cliente = clientes.FirstOrDefault(c => c.Id == clienteId);
            if (cliente != null)
            {
                vehiculo.Cliente = cliente;
                cliente.Vehiculos.Add(vehiculo);
            }
        }
    }

}