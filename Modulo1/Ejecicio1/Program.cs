// See https://aka.ms/new-console-template for more information
Console.WriteLine("Cual es tu nombre?");//Salida por consola
var nombre = Console.ReadLine();//Entrada
Console.WriteLine($"Hola! {nombre}");//Salida
//Operaciones matematicas
Console.WriteLine("Ingresa un número cualquiera: ");
var N1 = decimal.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Ingresa otro número cualquiera: ");
var N2 = decimal.Parse(Console.ReadLine() ?? "0");
var suma = N1 + N2;
Console.WriteLine($"Suma: {suma}");