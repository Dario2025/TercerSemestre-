public class Jugador
{
    public string Nombre { get; set; }

    public Jugador(string nombre)
    {
        Nombre = nombre;
    }

    public override string ToString()
    {
        return Nombre;
    }

    // Igualdad por nombre sin distinguir mayúsculas/minúsculas para evitar duplicados en HashSet
    public override bool Equals(object obj)
    {
        if (obj is Jugador otro)
        {
            return Nombre != null && otro.Nombre != null &&
                   Nombre.Trim().ToLower() == otro.Nombre.Trim().ToLower();
        }
        return false;
    }

    public override int GetHashCode()
    {
        return (Nombre ?? string.Empty).Trim().ToLower().GetHashCode();
    }
}
