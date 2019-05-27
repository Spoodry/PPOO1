using System;
using System.Collections.Generic;
using System.Text;

namespace PPOO1
{
    class Libro : IProducto
    {
        protected double precio;

        protected string nombre;

        protected int numeroPaginas;

        public string GetNombre()
        {
            return nombre;
        }

        public double GetPrecio()
        {
            return precio;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetPrecio(double precio)
        {
            this.precio = precio;
        }

        public void SetNumeroPaginas(int numeroPaginas)
        {
            this.numeroPaginas = numeroPaginas;
        }

        public int GetNumeroPaginas()
        {
            return numeroPaginas;
        }

    }
}
