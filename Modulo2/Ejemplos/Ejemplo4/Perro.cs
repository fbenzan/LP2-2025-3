namespace Ejemplo4;

public class Perro : Animal //Herencia (Primer pilar de la POO)
{
    public override void Comer() //Polimorfismo (Segundo pilar de la POO)
    {
        Console.WriteLine("El perro está comiendo!...");
    }
    public void Ladrar()
    {
        Console.WriteLine("El perro está ladrando!...");
    }
}

public class Gato : Animal
{
    
}

public class AnimalService
{
    public static void Alimmentar(Animal variable)
    {
        if (variable is Perro)
        {
            Console.WriteLine("Se está alimantando el perro...");
        }
        else if (variable is Gato)
        {
            Console.WriteLine("Se está alimantando el gato...");
        }
        else Console.WriteLine("Se está alimantando el animal...");
    }
}