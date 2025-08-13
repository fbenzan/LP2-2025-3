/*Elaborar un algoritmo en C#, que me permita sumar dos numeros enteros cualquiera.*/
//Primero declaro las variables con las que trabajaré.
int N1, N2, R;
//Preguntarle al usuario los numeros;
Console.WriteLine("Ingrese el primer numero: ");
//var numero1 = Console.ReadLine();
//N1 = int.Parse(numero1);
N1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero: ");
N2 = int.Parse(Console.ReadLine());
R = N1 + N2; //Proceso de suma númerica
Console.WriteLine($"Resultado: {R}");