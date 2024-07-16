using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using TallerProyecto.Model;

namespace TallerProyecto.Controller
{
    public class MantenimientoController
    {
        private List<Mantenimiento> mantenimientos;

        public MantenimientoController()
        {
            mantenimientos = new List<Mantenimiento>();
        }

        public void RegistrarMantenimiento(Mantenimiento mantenimiento)
        {
            mantenimiento.Id = mantenimientos.Count + 1; 
            mantenimientos.Add(mantenimiento);
        }

        public List<Mantenimiento> ObtenerMantenimientos()
        {
            return mantenimientos;
        }


    }
}
