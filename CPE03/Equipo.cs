
public class Equipo
{
    public string Nombre { get; }
    private readonly HashSet<Jugador> _jugadores;

    public Equipo(string nombre)
    {
        Nombre = nombre;
        _jugadores = new HashSet<Jugador>();
    }

    public bool AgregarJugador(Jugador jugador)
    {
        return _jugadores.Add(jugador); // true si se agregó; false si ya existía
    }

    public void MostrarJugadores()
    {
        Console.WriteLine($"\nJugadores del equipo {Nombre}:");
        if (_jugadores.Count == 0)
        {
            Console.WriteLine("  No hay jugadores registrados.");
            return;
        }

        foreach (var j in _jugadores)
        {
            Console.WriteLine($"  - {j.Nombre}");
        }
    }
}
