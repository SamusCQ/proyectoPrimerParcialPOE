using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TallerProyecto.Model
{
    public class Vehiculo
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public Cliente Cliente { get; set; }

        public string NombreCliente => Cliente != null ? Cliente.ToString() : "Sin propietario";

        public override string ToString()
        {
            return $"{Marca} {Modelo} ({Año})";
        }
    }
}
