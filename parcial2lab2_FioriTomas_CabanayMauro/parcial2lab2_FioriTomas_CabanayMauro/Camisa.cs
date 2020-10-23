using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial2lab2_FioriTomas_CabanayMauro
{
    class Camisa : Prenda
    {
        private bool manga_corta;

        public Camisa()
        {

        }
        public Camisa(double precio, int cantidad, bool calidad, bool manga_corta) : base (precio, cantidad, calidad)
        {
            this.manga_corta = manga_corta;
        }

        public bool Manga_corta
        {
            get => manga_corta;
            set => manga_corta = value;
        }

        public override double calcularPrecio(double precio, int cantidad, bool calidad)
        {
            double precio_final = precio * cantidad;
            double x = 0;
            double y = 0;

            if (manga_corta == true)
            {
                x = x - (precio_final * 10) / 100;
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
