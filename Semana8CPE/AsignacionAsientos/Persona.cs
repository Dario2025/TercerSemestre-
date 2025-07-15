using System;

namespace ParqueDiversiones
{
    // Clase que representa a una persona en la fila
    public class Persona
    {
        public string Nombre { get; set; }
        public int NumeroTurno { get; set; }

        public Persona(string nombre, int numeroTurno)
        {
            Nombre = nombre;
            NumeroTurno = numeroTurno;
        }

        // Representación en texto de la persona
        public override string ToString()
        {
            return $"Turno #{NumeroTurno}: {Nombre}";
        }
    }
}
