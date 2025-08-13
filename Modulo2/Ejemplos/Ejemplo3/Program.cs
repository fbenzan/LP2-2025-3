using Ejemplo3;

var C1 = new CuentaBancaria();
Console.WriteLine($"Saldo: {C1.Consultar()}");
C1.Depositar(1500);
Console.WriteLine($"Saldo: {C1.Consultar()}");