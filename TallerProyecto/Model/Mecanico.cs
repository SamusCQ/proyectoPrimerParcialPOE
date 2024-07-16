using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerProyecto.Model
{
    public class Mecanico : Persona
    {
        public string Especialidad { get; set; }
        public int AñosDeExperiencia { get; set; }
    }

}