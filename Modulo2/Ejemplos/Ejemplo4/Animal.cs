namespace Ejemplo4;
//dotnet new console -n Ejemplo4
//dotnet new class -n Animal
public class Animal
{
    public virtual void Comer()
    {
        //Aqui va el codigo para hacer saber que el animal esta comiendo.
        Console.WriteLine("El animal está comiendo!...");
    }
}
