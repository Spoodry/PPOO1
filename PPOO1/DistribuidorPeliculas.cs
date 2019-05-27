using System;
using System.Collections.Generic;
using System.Text;

namespace PPOO1
{
    class DistribuidorPeliculas : Cinematografica
    {

        string distribuidor;

        string nombrePelicula;

        public void SetDistribuidor(string distribuidor)
        {
            this.distribuidor = distribuidor;
        }

        public string GetDistribuidor()
        {
            return distribuidor;
        }

        public void SetNombrePelicula(string nombrePelicula)
        {
            this.nombrePelicula = nombrePelicula;
        }

        public string GetNombrePelicula()
        {
            return nombrePelicula;
        }

        public override void ImprimirDatos()
        {
            Console.WriteLine("Nombre del producto: " + nombre);
            Console.WriteLine("Precio = $" + precio);
            Console.WriteLine("Duración: " + duracion + "min");
            Console.WriteLine("Distribuidor: " + distribuidor);
            Console.WriteLine("Nombre de la película: " + nombrePelicula);
        }

    }
}
