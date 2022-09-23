// See https://aka.ms/new-console-template for more information

const string tema =
    "Desarrolla un programa que recorra  los números del  1 al 100 y muestre en pantalla únicamente números pares o divisibles entre 3.";

Console.WriteLine("!Bienvenido a la semana 4!");
Console.WriteLine("El tema de hoy es: \n \"{0}\"", tema);

int contador, limite;
limite = 100;
string salida = "";

for (contador = 1; contador <= limite; contador++)
    if (contador % 2 == 0 || contador % 3 == 0)
        salida = salida == "" ? contador.ToString() : $"{salida} - {contador}";

Console.WriteLine($"Resultado:\n{salida}");