namespace PESemana4;

public class ContadorDoWhile : ContadorBase
{
    public ContadorDoWhile()
    {
        do
        {
            EsDivisibleDosTres();
            IncrementaContador();
        } while (contador <= 100);

        MuestraSalida();
    }
}