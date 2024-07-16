using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using TallerProyecto.Model;

namespace TallerProyecto.Controller
{
    public class ServicioController
    {
        private List<Servicio> servicios;

        public ServicioController()
        {
            servicios = new List<Servicio>
            {
                new Servicio { Id = 1, Nombre = "Lavado", Precio = 10.0m },
                new Servicio { Id = 2, Nombre = "Alineación", Precio = 20.0m },
                new Servicio { Id = 3, Nombre = "Cambio de Aceite", Precio = 30.0m },
                new Servicio { Id = 4, Nombre = "Revisión General", Precio = 40.0m },
                new Servicio { Id = 5, Nombre = "Cambio de Filtros", Precio = 25.0m }
            };
        }

        public List<Servicio> ObtenerServicios()
        {
            return servicios;
        }
    }
}
