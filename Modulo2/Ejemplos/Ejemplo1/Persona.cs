namespace Ejemplo1;

public class Persona
{
    public string Nombre;
    public int Edad;

    public void Saludar()
    {
        Console.WriteLine($"Hola, me llamo {Nombre} y tengo {Edad} años.");
    } 
}