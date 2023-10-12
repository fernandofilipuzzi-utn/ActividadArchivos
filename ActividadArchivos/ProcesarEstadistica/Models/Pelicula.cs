using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesarEstadistica.Models
{
    class Pelicula : IComparable
    {
        public string Nombre { get; set; }
        public int CantValoraciones { get; set; }


        public int AcumValoraciones 
        {
            get; set; 
        }

        public double PuntuacionPromedio 
        {
            get 
            {
                double prom = 0;
                if (CantValoraciones > 0)
                    prom = AcumValoraciones * 1d / CantValoraciones;
                return prom;
            }
        }

        public Image Imagen { get; set; }

        public int CompareTo(object obj)
        {
            int result = -1;
            Pelicula p = obj as Pelicula;
            if (p != null)
                result = Nombre.CompareTo(p.Nombre);
            return result;
        }
    }
}
