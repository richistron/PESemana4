namespace PESemana4;

public class ContadorDoWhile : ContadorBase
{
    public ContadorDoWhile()
    {
        do
        {
            EsDivisibleDosTres();
            IncrementaContador();
        } while (contador <= limite);

        MuestraSalida();
    }
}