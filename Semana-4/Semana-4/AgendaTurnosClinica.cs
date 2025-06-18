using System;
using System.Collections.Generic;

namespace AgendaClinica
{
    // Clase que representa a un paciente
    public class Paciente
    {
        // Propiedades del paciente
        public string Nombre { get; set; } = string.Empty;
        public string Cedula { get; set; } = string.Empty;
        public DateTime FechaTurno { get; set; }
        public string Especialidad { get; set; } = string.Empty;
    }

    // Clase que maneja la lista de turnos de pacientes
    public class AgendaTurnos
    {
        // Lista para almacenar los pacientes con turno
        private List<Paciente> listaPacientes = new List<Paciente>();

        // Método para agregar un nuevo turno
        public void AgregarTurno(Paciente paciente)
        {
            listaPacientes.Add(paciente);
            Console.WriteLine("Turno agregado correctamente.");
        }

        // Método para mostrar todos los turnos registrados
        public void MostrarTurnos()
        {
            if (listaPacientes.Count == 0)
            {
                Console.WriteLine("\nNo hay turnos registrados.");
                return;
            }

            Console.WriteLine("\n--- Turnos registrados ---");
            foreach (var p in listaPacientes)
            {
                Console.WriteLine($"Nombre: {p.Nombre}, Cédula: {p.Cedula}, Fecha: {p.FechaTurno.ToShortDateString()}, Especialidad: {p.Especialidad}");
            }
        }

        // Método para buscar un turno por número de cédula
        public void BuscarPorCedula(string cedula)
        {
            var encontrado = listaPacientes.Find(p => p.Cedula == cedula);
            if (encontrado != null)
            {
                Console.WriteLine("\nTurno encontrado:");
                Console.WriteLine($"Nombre: {encontrado.Nombre}");
                Console.WriteLine($"Fecha del turno: {encontrado.FechaTurno.ToShortDateString()}");
                Console.WriteLine($"Especialidad: {encontrado.Especialidad}");
            }
            else
            {
                Console.WriteLine("\nNo se encontró un turno con esa cédula.");
            }
        }
    }

    // Clase principal del programa
    class Program
    {
        static void Main(string[] args)
        {
            AgendaTurnos agenda = new AgendaTurnos();
            bool salir = false;

            // Ciclo principal del menú
            while (!salir)
            {
                Console.WriteLine("\n--- Menú Agenda de Turnos ---");
                Console.WriteLine("1. Agregar turno");
                Console.WriteLine("2. Ver turnos");
                Console.WriteLine("3. Buscar por cédula");
                Console.WriteLine("4. Salir");

                Console.Write("Opción: ");
                string? opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        // Crear nuevo paciente
                        var nuevo = new Paciente();

                        Console.Write("Nombre: ");
                        nuevo.Nombre = Console.ReadLine() ?? "";

                        Console.Write("Cédula: ");
                        nuevo.Cedula = Console.ReadLine() ?? "";

                        // Captura y validación de la fecha del turno
                        Console.Write("Fecha del turno (YYYY-MM-DD): ");
                        string? entradaFecha = Console.ReadLine();
                        if (DateTime.TryParse(entradaFecha, out DateTime fechaTurno))
                        {
                            nuevo.FechaTurno = fechaTurno;
                        }
                        else
                        {
                            Console.WriteLine("Fecha inválida. Se asignará la fecha de hoy.");
                            nuevo.FechaTurno = DateTime.Today;
                        }

                        Console.Write("Especialidad: ");
                        nuevo.Especialidad = Console.ReadLine() ?? "";

                        // Agregar el paciente a la agenda
                        agenda.AgregarTurno(nuevo);
                        break;

                    case "2":
                        // Mostrar todos los turnos
                        agenda.MostrarTurnos();
                        break;

                    case "3":
                        // Buscar turno por cédula
                        Console.Write("Ingrese la cédula: ");
                        string? cedula = Console.ReadLine();
                        if (!string.IsNullOrEmpty(cedula))
                        {
                            agenda.BuscarPorCedula(cedula);
                        }
                        else
                        {
                            Console.WriteLine("Cédula no válida.");
                        }
                        break;

                    case "4":
                        // Salir del sistema
                        salir = true;
                        Console.WriteLine("Saliendo del sistema...");
                        break;

                    default:
                        // Opción inválida
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }
            }
        }
    }
}
