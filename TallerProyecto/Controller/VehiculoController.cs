using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using TallerProyecto.Model;

namespace TallerProyecto.Controller
{
    public class VehiculoController
    {
        private List<Vehiculo> vehiculos = new List<Vehiculo>();
        private int siguienteId = 1;

        public void RegistrarVehiculo(Vehiculo vehiculo)
        {
            vehiculo.Id = siguienteId++;
            vehiculos.Add(vehiculo);
        }

        public List<Vehiculo> ObtenerVehiculos()
        {
            return vehiculos;
        }
    }
}