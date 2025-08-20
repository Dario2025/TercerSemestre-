using System;

namespace ParqueDiversiones
{
    class ProgramaPrincipal
    {
        static void Main(string[] args)
        {
            Atraccion atraccion = new Atraccion(30); // Instancia con 30 asientos
            string opcion;

            // Menú interactivo
            do
            {
                Console.WriteLine("\n--- Menú ---");
                Console.WriteLine("1. Ingresar persona");
                Console.WriteLine("2. Mostrar asientos asignados");
                Console.WriteLine("3. Consultar estado");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = Console.ReadLine();

                // Evaluación de opciones
                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese el nombre de la persona: ");
                        string nombre = Console.ReadLine();
                        atraccion.IngresarPersona(nombre);
                        break;
                    case "2":
                        atraccion.MostrarAsientosAsignados();
                        break;
                    case "3":
                        atraccion.ConsultarEstado();
                        break;
                    case "4":
                        Console.WriteLine("Saliendo del sistema...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            } while (opcion != "4");
        }
    }
}


