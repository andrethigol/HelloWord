namespace HelloWord;
 class Progran
{
    static void Main()
    {
        string texto1 = "A primeira frase.";
        string texto2 = "Segunda frase";

        string paragrafo = texto1 + " " + texto2;

        Console.WriteLine(paragrafo);


        DateOnly dia = new DateOnly(2024, 11, 20);
        
        string diaEmTexto = dia.ToLongDateString();

        DateTime dia1 = new DateTime(2024, 11, 20, 08, 34, 20);

        Console.WriteLine(dia1);
    }

}
