using System;
using System.Collections.Generic;
using System.Text;

namespace PPOO1
{
    interface IProducto
    {

        void SetPrecio(double precio);

        double GetPrecio();

        void SetNombre(string nombre);

        string GetNombre();

    }
}
