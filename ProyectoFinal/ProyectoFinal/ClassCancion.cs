using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class ClassCancion
    {
        string direccionCancion;
        string nombreCancion;

        public string DireccionCancion { get => direccionCancion; set => direccionCancion = value; }
        public string NombreCancion { get => nombreCancion; set => nombreCancion = value; }
    }
}
