using System;

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

    // Clase que maneja los turnos de pacientes
    public class AgendaTurnos
    {
        // Arreglo para almacenar hasta 100 pacientes con turno
        private Paciente[] listaPacientes = new Paciente[100];

        // Variable que lleva el control de cuántos pacientes se han registrado
        private int cantidadPacientes = 0;

        // Método para agregar un nuevo turno
        public void AgregarTurno(Paciente paciente)
        {
            if (cantidadPacientes < listaPacientes.Length)
            {
                listaPacientes[cantidadPacientes] = paciente;
                cantidadPacientes++;
                Console.WriteLine("Turno agregado correctamente.");
            }
            else
            {
                Console.WriteLine("No se pueden agregar más turnos. Capacidad máxima alcanzada.");
            }
        }

        // Método para mostrar todos los turnos registrados
        public void MostrarTurnos()
        {
            if (cantidadPacientes == 0)
            {
                Console.WriteLine("\nNo hay turnos registrados.");
                return;
            }

            Console.WriteLine("\n--- Turnos registrados ---");
            for (int i = 0; i < cantidadPacientes; i++)
            {
                var p = listaPacientes[i];
                Console.WriteLine($"Nombre: {p.Nombre}, Cédula: {p.Cedula}, Fecha: {p.FechaTurno.ToShortDateString()}, Especialidad: {p.Especialidad}");
            }
        }

        // Método para buscar un turno por número de cédula
        public void BuscarPorCedula(string cedula)
        {
            bool encontrado = false;

            for (int i = 0; i < cantidadPacientes; i++)
            {
                if (listaPacientes[i].Cedula == cedula)
                {
                    var p = listaPacientes[i];
                    Console.WriteLine("\nTurno encontrado:");
                    Console.WriteLine($"Nombre: {p.Nombre}");
                    Console.WriteLine($"Fecha del turno: {p.FechaTurno.ToShortDateString()}");
                    Console.WriteLine($"Especialidad: {p.Especialidad}");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
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
            // Crear instancia del sistema de agenda
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
