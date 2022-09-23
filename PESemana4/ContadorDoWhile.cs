namespace PESemana4;

public class ContadorDoWhile
{
    public ContadorDoWhile()
    {
        int contador = 1;
        int limite = 100;
        string salida = "";

        do
        {
            if (contador % 2 == 0 || contador % 3 == 0)
                salida = salida == "" ? contador.ToString() : $"{salida} - {contador}";
            contador++;
        } while (contador <= 100);

        Console.WriteLine($"Resultado:\n{salida}");
    }
}