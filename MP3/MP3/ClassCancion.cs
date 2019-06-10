using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MP3
{
    class ClassCancion
    {
        string nombreCancion;
        string direccionCancion;

        public string NombreCancion { get => nombreCancion; set => nombreCancion = value; }
        public string DireccionCancion { get => direccionCancion; set => direccionCancion = value; }
    }
}
