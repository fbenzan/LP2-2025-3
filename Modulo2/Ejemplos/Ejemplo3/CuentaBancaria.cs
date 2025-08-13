namespace Ejemplo3;

public class CuentaBancaria
{
    private decimal saldo = 0;

    public void Depositar(decimal valor)
    {
        if (valor > 0)
        {
            saldo += valor;
            return ;
        }
        Console.WriteLine("Este valor no se puede depositar!");
    }
    public decimal Consultar() => saldo;
}