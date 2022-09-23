namespace PESemana4;

public class ContadorFor : ContadorBase
{
    public ContadorFor()
    {
        for (contador = 1; contador <= limite; contador++) EsDivisibleDosTres();

        MuestraSalida();
    }
}