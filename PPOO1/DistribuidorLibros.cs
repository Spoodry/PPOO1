using System;
using System.Collections.Generic;
using System.Text;

namespace PPOO1
{
    class DistribuidorLibros : Editorial
    {
        string distribuidor;

        string nombreLibro;

        public void SetDistribuidor(string distribuidor)
        {
            this.distribuidor = distribuidor;
        }

        public string GetDistribuidor()
        {
            return distribuidor;
        }

        public void SetNombreLibro(string nombreLibro)
        {
            this.nombreLibro = nombreLibro;
        }

        public string GetNombreLibro()
        {
            return nombreLibro;
        }

        public override void ImprimirDatos()
        {
            Console.WriteLine("Nombre del producto: " + nombre);
            Console.WriteLine("Precio = $" + precio);
            Console.WriteLine("Número de páginas: " + numeroPaginas);
            Console.WriteLine("Distribuidor: " + distribuidor);
            Console.WriteLine("Nombre del libro: " + nombreLibro);
        }

    }
}
