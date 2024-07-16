using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using TallerProyecto.Model;

namespace TallerProyecto.Controller
{
    public class MecanicoController
    {
        private List<Mecanico> mecanicos;
        private int siguienteId;

        public MecanicoController()
        {
            mecanicos = new List<Mecanico>();
            siguienteId = 1; 
        }

        public void RegistrarMecanico(Mecanico mecanico)
        {
            mecanico.Id = siguienteId;
            siguienteId++;
            mecanicos.Add(mecanico);
        }

        public List<Mecanico> ObtenerMecanicos()
        {
            return mecanicos;
        }
    }
}