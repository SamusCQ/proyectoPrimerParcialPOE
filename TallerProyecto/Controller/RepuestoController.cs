using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerProyecto.Model;

namespace TallerProyecto.Controller
{
    public class RepuestoController
    {
        private List<Repuesto> repuestos;

        public RepuestoController()
        {           
            repuestos = new List<Repuesto>
            {
                new Repuesto { Id = 1, Nombre = "Filtro de aceite", Precio = 15 },
                new Repuesto { Id = 2, Nombre = "Pastillas de freno", Precio = 50 },
                new Repuesto { Id = 3, Nombre = "Aceite de motor", Precio = 30 },
                new Repuesto { Id = 4, Nombre = "Bujías", Precio = 25 },
                new Repuesto { Id = 5, Nombre = "Filtro de aire", Precio = 20 }
            };
        }

        public List<Repuesto> ObtenerRepuestos()
        {
            return repuestos;
        }
    }
}