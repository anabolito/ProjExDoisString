internal class Program
{
    private static void Main(string[] args)
    {
        string texto1, texto2;
        Console.WriteLine("Digite seu primeiro texto: ");
        texto1 = Console.ReadLine();
        texto1 = texto1.Trim(' ');
        Console.WriteLine("Digite seu segundo texto: ");
        texto2 = Console.ReadLine();
        texto2 = texto2.Trim(' ');


        if (texto1 == texto2)
            Console.WriteLine("Os textos são iguais.");
        else
            Console.WriteLine("Os textos não são iguais.");
    }
}