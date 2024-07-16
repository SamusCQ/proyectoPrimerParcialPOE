using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerProyecto.Model
{
    public class Cliente : Persona
    {
        public List<Vehiculo> Vehiculos { get; set; }

        public string Correo { get; set; }
        public string Telefono { get; set; }

        public Cliente()
        {
            Vehiculos = new List<Vehiculo>();
        }
    }

}
