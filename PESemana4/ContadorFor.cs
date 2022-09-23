namespace PESemana4;

public class ContadorFor
{
    public ContadorFor()
    {
        int contador, limite;
        limite = 100;
        string salida = "";

        for (contador = 1; contador <= limite; contador++)
            if (contador % 2 == 0 || contador % 3 == 0)
                salida = salida == "" ? contador.ToString() : $"{salida} - {contador}";

        Console.WriteLine($"Resultado:\n{salida}");
    }
}