namespace Ejemplo5;
//Esta define que hace la clase, no el como
public interface IVehiculo
{
    void Conducir();
}
//Se forza a definir el como, no el que.
public class Auto : IVehiculo
{
    public void Conducir()
    {
        Console.WriteLine("Conduciendo un auto...");
    }
}
public class Pasola : IVehiculo
{
    public void Conducir()
    {
        Console.WriteLine("Conduciendo una pasola...");
    }
}