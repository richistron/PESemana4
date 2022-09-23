namespace PESemana4;

public class ContadorBase
{
    private protected int contador = 1;
    private protected int limite = 100;
    private string salida = "";

    private void ConcatenaSalida()
    {
        salida = salida == "" ? contador.ToString() : $"{salida} - {contador}";
    }

    private protected void MuestraSalida()
    {
        Console.WriteLine($"Resultado:\n{salida}");
    }

    private protected void EsDivisibleDosTres()
    {
        if (contador % 2 == 0 || contador % 3 == 0) ConcatenaSalida();
    }

    private protected void IncrementaContador()
    {
        contador++;
    }
}