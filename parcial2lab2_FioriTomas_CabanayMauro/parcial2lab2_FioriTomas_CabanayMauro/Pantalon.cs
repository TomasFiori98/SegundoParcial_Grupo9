using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial2lab2_FioriTomas_CabanayMauro
{
    class Pantalon : Prenda
    {
        private bool bermuda;

        public Pantalon()
        {

        }
        public Pantalon(double precio, int cantidad, bool calidad, bool bermuda) : base (precio, cantidad, calidad)
        {
            this.bermuda = bermuda;
        }

        public bool Bermuda
        {
            get => bermuda;
            set => bermuda = value;
        }

        public override double calcularPrecio(double precio, int cantidad, bool calidad)
        {
            double precio_final = precio * cantidad;
            double x = 0;
            double y = 0;

            if (bermuda == true)
            {
                x = x - (precio_final * 20) / 100;
            }
            if (calidad == true)
            {
                y = y + (precio_final * 30) / 100;
            }

            precio_final += x + y; //aplicamos el descuento/aumento al precio final.

            return precio_final;
        }
    }
}
