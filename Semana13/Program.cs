// Importamos librerías necesarias
using System;                       // Permite usar la clase Console (entrada/salida de texto)
using System.Collections.Generic;   // Permite usar estructuras de datos como List<T>

// Namespace: organiza el código en un espacio lógico.
// Es recomendable usarlo siempre, incluso si el programa es pequeño.
namespace CatalogoRevistas
{
    // Clase principal del programa
    public class Program
    {
        // Lista para almacenar los títulos de las revistas
        // Se elige List<string> porque es flexible y permite recorrer o buscar fácilmente.
        static List<string> catalogo = new List<string>();

        // Método Main: punto de entrada del programa
        public static void Main()
        {
            // Inicializamos el catálogo con al menos 10 títulos de revistas
            InicializarCatalogo();

            int opcion;

            // Menú interactivo dentro de un bucle para que el usuario pueda usar varias opciones
            do
            {
                Console.WriteLine("\n===== CATÁLOGO DE REVISTAS =====");
                Console.WriteLine("1. Buscar revista (búsqueda iterativa)");
                Console.WriteLine("2. Mostrar catálogo completo");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                // Convertimos la entrada del usuario en número
                opcion = int.Parse(Console.ReadLine());

                // Controlamos las opciones con switch-case
                switch (opcion)
                {
                    case 1:
                        BuscarRevista();
                        break;

                    case 2:
                        MostrarCatalogo();
                        break;

                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }

            } while (opcion != 0);
        }

        /// <summary>
        /// Carga el catálogo con títulos iniciales de revistas.
        /// </summary>
        static void InicializarCatalogo()
        {
            catalogo.Add("National Geographic");
            catalogo.Add("Time");
            catalogo.Add("Forbes");
            catalogo.Add("Scientific American");
            catalogo.Add("Nature");
            catalogo.Add("The Economist");
            catalogo.Add("People");
            catalogo.Add("Sports Illustrated");
            catalogo.Add("Vogue");
            catalogo.Add("Harvard Business Review");
        }

        /// <summary>
        /// Muestra todos los títulos disponibles en el catálogo.
        /// </summary>
        static void MostrarCatalogo()
        {
            Console.WriteLine("\n--- Catálogo de Revistas ---");
            foreach (string revista in catalogo)
            {
                Console.WriteLine("- " + revista);
            }
        }

        /// <summary>
        /// Solicita al usuario un título y lo busca en el catálogo.
        /// La búsqueda se realiza de forma iterativa (recorriendo la lista).
        /// </summary>
        static void BuscarRevista()
        {
            Console.Write("\nIngrese el título de la revista que desea buscar: ");
            string titulo = Console.ReadLine();

            bool encontrado = false;

            // Recorremos la lista buscando coincidencias (ignorando mayúsculas/minúsculas)
            foreach (string revista in catalogo)
            {
                if (revista.Equals(titulo, StringComparison.OrdinalIgnoreCase))
                {
                    encontrado = true;
                    break; // detenemos la búsqueda si encontramos el título
                }
            }

            // Mostramos el resultado al usuario
            if (encontrado)
            {
                Console.WriteLine("Resultado: Encontrado");
            }
            else
            {
                Console.WriteLine("Resultado: No encontrado");
            }
        }
    }
}
