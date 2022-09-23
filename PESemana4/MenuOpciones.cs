namespace PESemana4;

public class MenuOpciones
{
    public MenuOpciones()
    {
        const string tema =
            "Desarrolla un programa que recorra  los números del  1 al 100 y muestre en pantalla únicamente números pares o divisibles entre 3.";

        Console.WriteLine("!Bienvenido a la semana 4!");
        Console.WriteLine("El tema de hoy es: \n \"{0}\"", tema);
        LeeOpcion();
    }

    private void LeeOpcion(bool invalid = false)
    {
        if (invalid) Console.WriteLine("La opcion no es válida");

        char opt;

        Console.WriteLine("Elige una opción:");
        Console.WriteLine("\t 1) implementación con \"for\"");
        Console.WriteLine("\t 2) implementación con \"while\"");
        Console.WriteLine("\t 3) implementación con \"do while\"");
        Console.WriteLine("\t c) para cancelar");

        if (char.TryParse(Console.ReadLine(), out opt))
        {
            switch (opt)
            {
                case '1':
                    new ContadorFor();
                    break;

                case '2':
                    new ContadorWhile();
                    break;

                case '3':
                    new ContadorDoWhile();
                    break;
                
                case 'c':
                    break;
                
                default:
                    LeeOpcion(true);
                    break;
            }
        }
        else LeeOpcion(true);
    }
}