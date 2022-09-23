namespace PESemana4;

public class ContadorWhile : ContadorBase
{
    public ContadorWhile()
    {
        while (contador <= limite)
        {
            EsDivisibleDosTres();
            IncrementaContador();
        }

        MuestraSalida();
    }
}