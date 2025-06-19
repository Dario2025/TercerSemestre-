using System;

namespace AgendaClinica
{
    // Clase que representa a un paciente
    public class Paciente
    {
        // Atributos privados del paciente
        private string nombre;
        private string cedula;
        private DateTime fechaTurno;
        private string especialidad;

        // Métodos SET para asignar valores a los atributos
        public void SetNombre(string valor) { nombre = valor; }
        public void SetCedula(string valor) { cedula = valor; }
        public void SetFechaTurno(DateTime valor) { fechaTurno = valor; }
        public void SetEspecialidad(string valor) { especialidad = valor; }

        // Métodos GET para obtener los valores de los atributos
        public string GetNombre() { return nombre; }
        public string GetCedula() { return cedula; }
        public DateTime GetFechaTurno() { return fechaTurno; }
        public string GetEspecialidad() { return especialidad; }
    }

    // Clase que maneja la agenda de turnos
    public class AgendaTurnos
    {
        // Arreglo para almacenar hasta 100 pacientes
        private Paciente[] listaPacientes = new Paciente[100];

        // Contador para llevar el número actual de pacientes registrados
        private int cantidadPacientes = 0;

        // Método para agregar un nuevo turno al arreglo
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
                Console.WriteLine($"Nombre: {p.GetNombre()}, Cédula: {p.GetCedula()}, Fecha: {p.GetFechaTurno().ToShortDateString()}, Especialidad: {p.GetEspecialidad()}");
            }
        }

        // Método para buscar un turno por número de cédula
        public void BuscarPorCedula(string cedula)
        {
            bool encontrado = false;

            for (int i = 0; i < cantidadPacientes; i++)
            {
                if (listaPacientes[i].GetCedula() == cedula)
                {
                    var p = listaPacientes[i];
                    Console.WriteLine("\nTurno encontrado:");
                    Console.WriteLine($"Nombre: {p.GetNombre()}");
                    Console.WriteLine($"Fecha del turno: {p.GetFechaTurno().ToShortDateString()}");
                    Console.WriteLine($"Especialidad: {p.GetEspecialidad()}");
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
            // Crear una instancia de la agenda de turnos
            AgendaTurnos agenda = new AgendaTurnos();
            bool salir = false;

            // Ciclo principal del menú
            while (!salir)
            {
                // Mostrar opciones del menú
                Console.WriteLine("\n--- Menú Agenda de Turnos ---");
                Console.WriteLine("1. Agregar turno");
                Console.WriteLine("2. Ver turnos");
                Console.WriteLine("3. Buscar por cédula");
                Console.WriteLine("4. Salir");

                Console.Write("Opción: ");
                string? opcion = Console.ReadLine();

                // Evaluar la opción elegida
                switch (opcion)
                {
                    case "1":
                        // Crear un nuevo objeto Paciente
                        var nuevo = new Paciente();

                        Console.Write("Nombre: ");
                        nuevo.SetNombre(Console.ReadLine() ?? "");

                        Console.Write("Cédula: ");
                        nuevo.SetCedula(Console.ReadLine() ?? "");

                        // Captura y validación de la fecha del turno
                        Console.Write("Fecha del turno (YYYY-MM-DD): ");
                        string? entradaFecha = Console.ReadLine();
                        if (DateTime.TryParse(entradaFecha, out DateTime fechaTurno))
                        {
                            nuevo.SetFechaTurno(fechaTurno);
                        }
                        else
                        {
                            Console.WriteLine("Fecha inválida. Se asignará la fecha de hoy.");
                            nuevo.SetFechaTurno(DateTime.Today);
                        }

                        Console.Write("Especialidad: ");
                        nuevo.SetEspecialidad(Console.ReadLine() ?? "");

                        // Agregar el turno del paciente a la agenda
                        agenda.AgregarTurno(nuevo);
                        break;

                    case "2":
                        // Mostrar todos los turnos registrados
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
                        // Opción no válida
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }
            }
        }
    }
}
