using System;
using System.Collections.Generic;

namespace ParqueDiversiones
{
    // Clase que representa la atracción del parque
    public class Atraccion
    {
        private Queue<Persona> cola; // Cola que almacena a las personas
        private int capacidadMaxima; // Máximo de personas permitido
        private int contadorTurnos; // Turno automático

        // Constructor
        public Atraccion(int capacidad)
        {
            cola = new Queue<Persona>();
            capacidadMaxima = capacidad;
            contadorTurnos = 1;
        }

        // Método para ingresar una persona a la atracción
        public void IngresarPersona(string nombre)
        {
            if (cola.Count >= capacidadMaxima)
            {
                Console.WriteLine($"No se puede agregar a {nombre}. Asientos agotados.");
                return;
            }

            Persona nuevaPersona = new Persona(nombre, contadorTurnos++);
            cola.Enqueue(nuevaPersona);
            Console.WriteLine($"{nombre} ha sido agregado correctamente.");
        }

        // Muestra la lista de personas asignadas a los asientos
        public void MostrarAsientosAsignados()
        {
            Console.WriteLine("\nPersonas asignadas a los 30 asientos:");
            foreach (var persona in cola)
            {
                Console.WriteLine(persona);
            }
            Console.WriteLine($"Total: {cola.Count} personas.");
        }

        // Muestra el estado actual de ocupación de la atracción
        public void ConsultarEstado()
        {
            Console.WriteLine($"\nAsientos ocupados: {cola.Count}/{capacidadMaxima}");
            if (cola.Count < capacidadMaxima)
            {
                Console.WriteLine($"Aún se pueden agregar {capacidadMaxima - cola.Count} personas.");
            }
            else
            {
                Console.WriteLine("Asientos completos.");
            }
        }
    }
}
