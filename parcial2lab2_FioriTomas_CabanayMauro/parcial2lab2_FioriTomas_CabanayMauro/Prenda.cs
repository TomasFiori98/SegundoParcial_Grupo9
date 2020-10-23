using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial2lab2_FioriTomas_CabanayMauro
{
    abstract class Prenda
    {
        protected double precio;
        protected int cantidad;
        protected bool calidad;

        protected Prenda()
        {

        }
        protected Prenda (double precio, int cantidad, bool calidad)
        {
            this.precio = precio;
            this.cantidad = cantidad;
            this.calidad = calidad;
        }

        public abstract double calcularPrecio(double precio, int cantidad, bool calidad);


    }
}
