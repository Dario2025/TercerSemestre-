using System;

// Clase Estudiante con sus atributos
class Estudiante
{
    public int Id;
    public string Nombres;
    public string Apellidos;
    public string Direccion;
    public string[] Telefonos = new string[3]; // Array de 3 teléfonos

    // Método para mostrar todos los datos del estudiante
    public void MostrarDatos()
    {
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Nombres: " + Nombres);
        Console.WriteLine("Apellidos: " + Apellidos);
        Console.WriteLine("Dirección: " + Direccion);
        Console.WriteLine("Teléfonos:");
        foreach (string telefono in Telefonos)
        {
            Console.WriteLine("- " + telefono);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear un objeto de tipo Estudiante
        Estudiante estudiante = new Estudiante();

        // Asignar valores a sus atributos
        estudiante.Id = 1;
        estudiante.Nombres = "Dario Anthonino";
        estudiante.Apellidos = "Moyano Montenegro";
        estudiante.Direccion = "Av. Piedra de Vapor";

        // Asignar valores al array de teléfonos
        estudiante.Telefonos[0] = "0982593778";
        estudiante.Telefonos[1] = "0987654321";
        estudiante.Telefonos[2] = "0971122334";

        // Llamar al método para mostrar los datos
        estudiante.MostrarDatos();
    }
}
