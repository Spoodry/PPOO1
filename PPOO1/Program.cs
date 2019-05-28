using System;
using System.Collections.Generic;

namespace PPOO1
{
    class Program
    {
        static List<DistribuidorPeliculas> listaPeliculas = new List<DistribuidorPeliculas>();
        static List<DistribuidorLibros> listaLibros = new List<DistribuidorLibros>();
        static List<DistribuidorCDs> listaCDs = new List<DistribuidorCDs>();

        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("-----Menú-----------------");
                Console.WriteLine("|1. Alta                 |");
                Console.WriteLine("|2. Baja                 |");
                Console.WriteLine("|3. Cambio               |");
                Console.WriteLine("|4. Mostrar              |");
                Console.WriteLine("|5. Salir                |");
                Console.WriteLine("--------------------------");
                Console.Write("Opción: ");

                try
                {

                    int opcion = int.Parse(Console.ReadLine());
                    bool repetir;
                    string nombre;
                    bool encontrado;
                    Console.Clear();

                    switch (opcion)
                    {
                        case 1:
                            repetir = true;
                            while (repetir)
                            {
                                Console.WriteLine("-----Dar alta-------------");
                                Console.WriteLine("|1. Pelicula             |");
                                Console.WriteLine("|2. Libro                |");
                                Console.WriteLine("|3. CD                   |");
                                Console.WriteLine("|4. Regresar             |");
                                Console.WriteLine("--------------------------");
                                Console.Write("Opción: ");
                                try
                                {
                                    opcion = int.Parse(Console.ReadLine());

                                    switch (opcion)
                                    {
                                        case 1:
                                            Console.WriteLine("\n\n---------------Peliculas---------------");
                                            DistribuidorPeliculas pelicula = new DistribuidorPeliculas();
                                            Console.Write("\nNombre producto: ");
                                            pelicula.SetNombre(Console.ReadLine());
                                            Console.Write("Precio: ");
                                            pelicula.SetPrecio(double.Parse(Console.ReadLine()));
                                            Console.Write("Duración: ");
                                            pelicula.SetDuracion(int.Parse(Console.ReadLine()));
                                            Console.Write("Distribuidor: ");
                                            pelicula.SetDistribuidor(Console.ReadLine());
                                            Console.Write("Nombre pelicula: ");
                                            pelicula.SetNombrePelicula(Console.ReadLine());

                                            listaPeliculas.Add(pelicula);
                                            repetir = false;

                                            Console.Clear();
                                            break;
                                        case 2:
                                            Console.WriteLine("\n\n---------------Libros---------------");
                                            DistribuidorLibros libro = new DistribuidorLibros();
                                            Console.Write("\nNombre producto: ");
                                            libro.SetNombre(Console.ReadLine());
                                            Console.Write("Precio: ");
                                            libro.SetPrecio(double.Parse(Console.ReadLine()));
                                            Console.Write("Número de páginas: ");
                                            libro.SetNumeroPaginas(int.Parse(Console.ReadLine()));
                                            Console.Write("Distribuidor: ");
                                            libro.SetDistribuidor(Console.ReadLine());
                                            Console.Write("Nombre libro: ");
                                            libro.SetNombreLibro(Console.ReadLine());

                                            listaLibros.Add(libro);
                                            repetir = false;

                                            Console.Clear();
                                            break;
                                        case 3:
                                            Console.WriteLine("\n\n---------------CDs---------------");
                                            DistribuidorCDs CD = new DistribuidorCDs();
                                            Console.Write("\nNombre producto: ");
                                            CD.SetNombre(Console.ReadLine());
                                            Console.Write("Precio: ");
                                            CD.SetPrecio(double.Parse(Console.ReadLine()));
                                            Console.Write("Duración: ");
                                            CD.SetDuracion(int.Parse(Console.ReadLine()));
                                            Console.Write("Distribuidor: ");
                                            CD.SetDistribuidor(Console.ReadLine());
                                            Console.Write("Nombre CD: ");
                                            CD.SetNombreCD(Console.ReadLine());

                                            listaCDs.Add(CD);
                                            repetir = false;

                                            Console.Clear();
                                            break;
                                        case 4:
                                            repetir = false;
                                            Console.Clear();
                                            break;
                                        default:
                                            throw new Exception("Opción no válida");
                                    }
                                } catch(Exception e)
                                {
                                    Console.Clear();
                                    Console.WriteLine(e.Message);
                                }
                            }
                            break;
                        case 2:
                            repetir = true;
                            while (repetir)
                            {
                                Console.WriteLine("-----Dar baja-------------");
                                Console.WriteLine("|1. Pelicula             |");
                                Console.WriteLine("|2. Libro                |");
                                Console.WriteLine("|3. CD                   |");
                                Console.WriteLine("|4. Regresar             |");
                                Console.WriteLine("--------------------------");
                                Console.Write("Opción: ");
                                try
                                {
                                    opcion = int.Parse(Console.ReadLine());
                                    encontrado = false;

                                    switch (opcion)
                                    {
                                        case 1:
                                            Console.WriteLine("\n\n---------------Peliculas---------------\n");
                                            ImprimirNombres(TipoDeProducto.DVD);
                                            Console.WriteLine("\nIngresar nombre de pelicula: ");
                                            nombre = Console.ReadLine();
                                            for (int i = 0; i < listaPeliculas.Count; i++)
                                            {
                                                if (listaPeliculas[i].GetNombrePelicula() == nombre)
                                                {
                                                    listaPeliculas.RemoveAt(i);
                                                    encontrado = true;
                                                }
                                            }

                                            repetir = false;
                                            Console.Clear();
                                            break;
                                        case 2:
                                            Console.WriteLine("\n\n---------------Libros---------------\n");
                                            ImprimirNombres(TipoDeProducto.Libro);
                                            Console.WriteLine("\nIngresar nombre del libro: ");
                                            nombre = Console.ReadLine();
                                            for (int i = 0; i < listaLibros.Count; i++)
                                            {
                                                if (listaLibros[i].GetNombreLibro() == nombre)
                                                {
                                                    listaLibros.RemoveAt(i);
                                                    encontrado = true;
                                                }
                                            }

                                            repetir = false;
                                            Console.Clear();
                                            break;
                                        case 3:
                                            Console.WriteLine("\n\n---------------CDs---------------\n");
                                            ImprimirNombres(TipoDeProducto.CD);
                                            Console.WriteLine("\nIngresar nombre del CD: ");
                                            nombre = Console.ReadLine();
                                            for (int i = 0; i < listaCDs.Count; i++)
                                            {
                                                if (listaCDs[i].GetNombreCD() == nombre)
                                                {
                                                    listaCDs.RemoveAt(i);
                                                    encontrado = true;
                                                }
                                            }

                                            repetir = false;
                                            Console.Clear();
                                            break;
                                        case 4:
                                            Console.Clear();
                                            repetir = false;
                                            break;
                                        default:
                                            throw new Exception("Opción no válida");
                                    }
                                    if (opcion != 4)
                                        if (encontrado && opcion != 4)
                                        {
                                            Console.WriteLine("Eliminación exitosa");
                                            Console.ReadKey();
                                        }
                                        else
                                        {

                                            repetir = true;
                                            throw new Exception("Elemento no encontrado");
                                        }

                                } catch (Exception e)
                                {
                                    Console.Clear();
                                    Console.WriteLine(e.Message);
                                }

                            }
                            break;
                        case 3:
                            repetir = true;
                            while (repetir)
                            {
                                Console.WriteLine("-----Cambio-----------");
                                Console.WriteLine("|1. Pelicula         |");
                                Console.WriteLine("|2. Libro            |");
                                Console.WriteLine("|3. CD               |");
                                Console.WriteLine("|4. Regresar         |");
                                Console.WriteLine("----------------------");
                                Console.Write("Opción: ");
                                try
                                {
                                    opcion = int.Parse(Console.ReadLine());
                                    int posElemento = 0;
                                    string respuesta;

                                    switch (opcion)
                                    {
                                        case 1:
                                            Console.WriteLine("\n\n---------------Peliculas---------------\n");
                                            ImprimirNombres(TipoDeProducto.DVD);
                                            Console.Write("\nIngresar nombre de pelicula: ");
                                            nombre = Console.ReadLine();
                                            Console.WriteLine();

                                            encontrado = false;
                                            for (int i = 0; i < listaPeliculas.Count; i++)
                                            {
                                                if (listaPeliculas[i].GetNombrePelicula() == nombre)
                                                {
                                                    encontrado = true;
                                                    posElemento = i;
                                                }
                                            }

                                            if (encontrado)
                                            {
                                                listaPeliculas[posElemento].ImprimirDatos();

                                                Console.WriteLine("\nModificar precio: (s/n)");
                                                respuesta = Console.ReadLine();
                                                if (respuesta == "s")
                                                {
                                                    Console.Write("Nuevo precio: ");
                                                    listaPeliculas[posElemento].SetPrecio(double.Parse(Console.ReadLine()));
                                                }
                                                Console.WriteLine("\nModificar nombre: (s/n)");
                                                respuesta = Console.ReadLine();
                                                if (respuesta == "s")
                                                {
                                                    Console.Write("Nuevo nombre: ");
                                                    listaPeliculas[posElemento].SetNombre(Console.ReadLine());
                                                }
                                                Console.WriteLine("\nModificar duracion: (s/n)");
                                                respuesta = Console.ReadLine();
                                                if (respuesta == "s")
                                                {
                                                    Console.Write("Nueva duracion: ");
                                                    listaPeliculas[posElemento].SetDuracion(int.Parse(Console.ReadLine()));
                                                }
                                                Console.WriteLine("\nModificar distribuidor: (s/n)");
                                                respuesta = Console.ReadLine();
                                                if (respuesta == "s")
                                                {
                                                    Console.Write("Nuevo distribuidor: ");
                                                    listaPeliculas[posElemento].SetDistribuidor(Console.ReadLine());
                                                }
                                                Console.WriteLine("\nModificar nombre de pelicula: (s/n)");
                                                respuesta = Console.ReadLine();
                                                if (respuesta == "s")
                                                {
                                                    Console.Write("Nuevo nombre de pelicula: ");
                                                    listaPeliculas[posElemento].SetNombrePelicula(Console.ReadLine());
                                                }

                                                Console.Clear();
                                                Console.WriteLine("Datos modificados");
                                                Console.ReadKey();
                                                repetir = false;

                                            }
                                            else
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Pelicula no encontrada");
                                                Console.ReadKey();
                                            }

                                            break;
                                        case 2:
                                            Console.WriteLine("\n\n---------------Libros---------------\n");
                                            ImprimirNombres(TipoDeProducto.Libro);
                                            Console.Write("\nIngresar nombre del libro: ");
                                            nombre = Console.ReadLine();
                                            Console.WriteLine();

                                            encontrado = false;
                                            for (int i = 0; i < listaLibros.Count; i++)
                                            {
                                                if (listaLibros[i].GetNombreLibro() == nombre)
                                                {
                                                    encontrado = true;
                                                    posElemento = i;
                                                }
                                            }

                                            if (encontrado)
                                            {
                                                listaLibros[posElemento].ImprimirDatos();

                                                Console.WriteLine("\nModificar precio: (s/n)");
                                                respuesta = Console.ReadLine();
                                                if (respuesta == "s")
                                                {
                                                    Console.Write("Nuevo precio: ");
                                                    listaLibros[posElemento].SetPrecio(double.Parse(Console.ReadLine()));
                                                }
                                                Console.WriteLine("\nModificar nombre: (s/n)");
                                                respuesta = Console.ReadLine();
                                                if (respuesta == "s")
                                                {
                                                    Console.Write("Nuevo nombre: ");
                                                    listaLibros[posElemento].SetNombre(Console.ReadLine());
                                                }
                                                Console.WriteLine("\nModificar numero de paginas: (s/n)");
                                                respuesta = Console.ReadLine();
                                                if (respuesta == "s")
                                                {
                                                    Console.Write("Nuevo numero de paginas: ");
                                                    listaLibros[posElemento].SetNumeroPaginas(int.Parse(Console.ReadLine()));
                                                }
                                                Console.WriteLine("\nModificar distribuidor: (s/n)");
                                                respuesta = Console.ReadLine();
                                                if (respuesta == "s")
                                                {
                                                    Console.Write("Nuevo distribuidor: ");
                                                    listaLibros[posElemento].SetDistribuidor(Console.ReadLine());
                                                }
                                                Console.WriteLine("\nModificar nombre del libro: (s/n)");
                                                respuesta = Console.ReadLine();
                                                if (respuesta == "s")
                                                {
                                                    Console.Write("Nuevo nombre del libro: ");
                                                    listaLibros[posElemento].SetNombreLibro(Console.ReadLine());
                                                }

                                                Console.Clear();
                                                Console.WriteLine("Datos modificados");
                                                Console.ReadKey();
                                                repetir = false;

                                            }
                                            else
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Libro no encontrado");
                                                Console.ReadKey();
                                            }
                                            break;
                                        case 3:
                                            Console.WriteLine("\n\n---------------CDs---------------\n");
                                            ImprimirNombres(TipoDeProducto.CD);
                                            Console.WriteLine("\nIngresar nombre de CD: ");
                                            nombre = Console.ReadLine();
                                            Console.WriteLine();

                                            encontrado = false;
                                            for (int i = 0; i < listaCDs.Count; i++)
                                            {
                                                if (listaCDs[i].GetNombreCD() == nombre)
                                                {
                                                    encontrado = true;
                                                    posElemento = i;
                                                }
                                            }

                                            if (encontrado)
                                            {
                                                listaCDs[posElemento].ImprimirDatos();

                                                Console.WriteLine("\nModificar precio: (s/n)");
                                                respuesta = Console.ReadLine();
                                                if (respuesta == "s")
                                                {
                                                    Console.Write("Nuevo precio: ");
                                                    listaCDs[posElemento].SetPrecio(double.Parse(Console.ReadLine()));
                                                }
                                                Console.WriteLine("\nModificar nombre: (s/n)");
                                                respuesta = Console.ReadLine();
                                                if (respuesta == "s")
                                                {
                                                    Console.Write("Nuevo nombre: ");
                                                    listaCDs[posElemento].SetNombre(Console.ReadLine());
                                                }
                                                Console.WriteLine("\nModificar duracion: (s/n)");
                                                respuesta = Console.ReadLine();
                                                if (respuesta == "s")
                                                {
                                                    Console.Write("Nueva duracion: ");
                                                    listaCDs[posElemento].SetDuracion(int.Parse(Console.ReadLine()));
                                                }
                                                Console.WriteLine("\nModificar distribuidor: (s/n)");
                                                respuesta = Console.ReadLine();
                                                if (respuesta == "s")
                                                {
                                                    Console.Write("Nuevo distribuidor: ");
                                                    listaCDs[posElemento].SetDistribuidor(Console.ReadLine());
                                                }
                                                Console.WriteLine("\nModificar nombre de CD: (s/n)");
                                                respuesta = Console.ReadLine();
                                                if (respuesta == "s")
                                                {
                                                    Console.Write("Nuevo nombre de CD: ");
                                                    listaCDs[posElemento].SetNombreCD(Console.ReadLine());
                                                }

                                                Console.Clear();
                                                Console.WriteLine("Datos modificados");
                                                Console.ReadKey();
                                                repetir = false;

                                            }
                                            else
                                            {
                                                Console.Clear();
                                                Console.WriteLine("CD no encontrado");
                                                Console.ReadKey();
                                            }
                                            break;
                                        case 4:
                                            Console.Clear();
                                            repetir = false;
                                            break;
                                        default:
                                            throw new Exception("Opción no válida");
                                    }
                                } catch(Exception e)
                                {
                                    Console.Clear();
                                    Console.WriteLine(e.Message);
                                }
                            }
                            break;
                        case 4:
                            repetir = true;
                            while (repetir)
                            {
                                Console.WriteLine("-----Mostrar--------------");
                                Console.WriteLine("|1. Pelicula             |");
                                Console.WriteLine("|2. Libro                |");
                                Console.WriteLine("|3. CD                   |");
                                Console.WriteLine("|4. Regresar             |");
                                Console.WriteLine("--------------------------");
                                Console.Write("Opción: ");
                                try
                                {
                                    opcion = int.Parse(Console.ReadLine());

                                    switch (opcion)
                                    {
                                        case 1:
                                            Console.WriteLine("Peliculas: ");
                                            ImprimirNombres(TipoDeProducto.DVD);
                                            Console.WriteLine();
                                            Console.WriteLine("Ingresar nombre de pelicula: ");
                                            nombre = Console.ReadLine();

                                            encontrado = false;
                                            for (int i = 0; i < listaPeliculas.Count; i++)
                                            {
                                                if (listaPeliculas[i].GetNombrePelicula() == nombre)
                                                {
                                                    encontrado = true;
                                                    listaPeliculas[i].ImprimirDatos();
                                                }
                                            }
                                            if (!encontrado)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Elemento no encontrado");
                                            }
                                            else
                                            {
                                                Console.ReadKey();
                                                Console.Clear();
                                                repetir = false;
                                            }

                                            break;
                                        case 2:
                                            Console.WriteLine("Libros: ");
                                            ImprimirNombres(TipoDeProducto.Libro);
                                            Console.WriteLine();
                                            Console.WriteLine("Ingresar nombre del libro: ");
                                            nombre = Console.ReadLine();

                                            encontrado = false;
                                            for (int i = 0; i < listaLibros.Count; i++)
                                            {
                                                if (listaLibros[i].GetNombreLibro() == nombre)
                                                {
                                                    encontrado = true;
                                                    listaLibros[i].ImprimirDatos();
                                                }
                                            }
                                            if (!encontrado)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Elemento no encontrado");
                                            }
                                            else
                                            {
                                                Console.ReadKey();
                                                Console.Clear();
                                                repetir = false;
                                            }
                                            break;
                                        case 3:
                                            Console.WriteLine("CDs: ");
                                            ImprimirNombres(TipoDeProducto.CD);
                                            Console.WriteLine();
                                            Console.WriteLine("Ingresar nombre de CD: ");
                                            nombre = Console.ReadLine();

                                            encontrado = false;
                                            for (int i = 0; i < listaCDs.Count; i++)
                                            {
                                                if (listaCDs[i].GetNombreCD() == nombre)
                                                {
                                                    encontrado = true;
                                                    listaCDs[i].ImprimirDatos();
                                                }
                                            }
                                            if (!encontrado)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Elemento no encontrado");
                                            }
                                            else
                                            {
                                                Console.ReadKey();
                                                Console.Clear();
                                                repetir = false;
                                            }
                                            break;
                                        case 4:
                                            Console.Clear();
                                            repetir = false;
                                            break;
                                        default:
                                            throw new Exception("Opción no válida");
                                    }
                                } catch(Exception e)
                                {
                                    Console.Clear();
                                    Console.WriteLine(e.Message);
                                }
                            }
                            break;
                        case 5:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Opción no válida");
                            break;
                    }

                } catch(Exception e)
                {
                    Console.Clear();
                    Console.WriteLine(e.Message);
                }
            }
        }

        static void ImprimirNombres(TipoDeProducto tipo)
        {
            switch(tipo)
            {
                case TipoDeProducto.DVD:
                    if (listaPeliculas.Count == 0)
                        Console.WriteLine("No hay peliculas");
                    else
                        for (int i = 0; i < listaPeliculas.Count; i++)
                            Console.WriteLine((i + 1) + ". " + listaPeliculas[i].GetNombrePelicula());
                    break;
                case TipoDeProducto.Libro:
                    if(listaLibros.Count == 0)
                        Console.WriteLine("No hay libros");
                    else
                        for (int i = 0; i < listaLibros.Count; i++)
                            Console.WriteLine((i + 1) + ". " + listaLibros[i].GetNombreLibro());
                    break;
                case TipoDeProducto.CD:
                    if(listaCDs.Count == 0)
                        Console.WriteLine("No hay CDs");
                    else
                        for (int i = 0; i < listaCDs.Count; i++)
                            Console.WriteLine((i + 1) + ". " + listaCDs[i].GetNombreCD());
                    break;
            }
        }

        enum TipoDeProducto
        {
            DVD,
            Libro,
            CD
        }

    }
}
