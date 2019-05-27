using System;
using System.Collections.Generic;
using System.Text;

namespace PPOO1
{
    class DistribuidorCDs : Disquera
    {
        string distribuidor;

        string nombreCD;

        public void SetDistribuidor(string distribuidor)
        {
            this.distribuidor = distribuidor;
        }

        public string GetDistribuidor()
        {
            return distribuidor;
        }

        public void SetNombreCD(string nombreCD)
        {
            this.nombreCD = nombreCD;
        }

        public string GetNombreCD()
        {
            return nombreCD;
        }

        public override void ImprimirDatos()
        {
            Console.WriteLine("Nombre del producto: " + nombre);
            Console.WriteLine("Precio = $" + precio);
            Console.WriteLine("Duración: " + duracion + "min");
            Console.WriteLine("Distribuidor: " + distribuidor);
            Console.WriteLine("Nombre del CD: " + nombreCD);
        }

    }
}
