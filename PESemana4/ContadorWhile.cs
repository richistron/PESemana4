namespace PESemana4;

public class ContadorWhile
{
    public ContadorWhile()
    {
        int contador = 1;
        int limite = 100;
        string salida = "";

        while (contador <= limite)
        {
            if (contador % 2 == 0 || contador % 3 == 0)
                salida = salida == "" ? contador.ToString() : $"{salida} - {contador}";
            contador++;
        }

        Console.WriteLine($"Resultado:\n{salida}");
    }
}