using System;
using System.Collections.Generic;
using System.Text;

namespace PPOO1
{
    class CD : IProducto
    {
        protected double precio;

        protected string nombre;

        protected int duracion;

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

        public void SetDuracion(int duracion)
        {
            this.duracion = duracion;
        }

        public int GetDuracion()
        {
            return duracion;
        }

    }
}
