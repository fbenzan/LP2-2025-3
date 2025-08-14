namespace Ejercicio5;
/*
Implementa una clase abstracta Figura 
con el método CalcularArea() y deriva Circulo y 
Cuadrado.
*/
public abstract class Figura
{
    public abstract double CalcularArea();
}
public class Circulo : Figura
{
    public double Radio;

    public Circulo(double radio)
    {
        Radio = radio;
    }

    public override double CalcularArea()
    {
        return Math.PI * Math.Pow(Radio, 2);
    }
}
public class Cuadrado : Figura
{
    public Cuadrado(double @base, double altura)
    {
        Base = @base;
        Altura = altura;
    }

    public double Base { get; set; }
    public double Altura { get; set; }
    public override double CalcularArea()
    {
        return Base * Altura;
    }
}