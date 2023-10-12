using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerarArchivo.Models
{
    class Calificacion
    {
        public string Nombre { get; set; }
        public int Puntuacion { get; set; }
        public string Contenido { get; set; }
        public Image Imagen { get; set; }

        public override string ToString()
        {
            return $"{Nombre};{Contenido};{Puntuacion}";
        }
    }
}
