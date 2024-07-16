using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;

namespace TallerProyecto.Model
{
    public class Mantenimiento
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public Mecanico Mecanico { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public List<Servicio> Servicios { get; set; }
        public List<Repuesto> Repuestos { get; set; }
        public decimal PrecioTotal { get; private set; }
        public DateTime Fecha { get; set; }

        public string Descripcion { get; set; }

        public Mantenimiento()
        {
            Servicios = new List<Servicio>();
            Repuestos = new List<Repuesto>();
        }

        public void CalcularPrecioTotal()
        {
            PrecioTotal = 0;
            foreach (var servicio in Servicios)
            {
                PrecioTotal += servicio.Precio;
            }
            foreach (var repuesto in Repuestos)
            {
                PrecioTotal += repuesto.Precio;
            }
        }

        public override string ToString()
        {
            return $"{Id} - {Vehiculo?.Modelo ?? "Sin Vehiculo"}";
        }


    }
}