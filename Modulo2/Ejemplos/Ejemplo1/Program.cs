// See https://aka.ms/new-console-template for more information
using Ejemplo1;

Console.WriteLine("POO");
var persona = new Persona();
Console.Write("Nombre: ");
persona.Nombre = Console.ReadLine();
Console.Write("Edad: ");
persona.Edad = int.Parse(Console.ReadLine());
persona.Saludar();
