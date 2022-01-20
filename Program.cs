using System;

namespace Uri1016
{
    class Program
    {
        static void Main(string[] args)
        {
            int y;
            Console.Write("Entre com a distancia percorrida: ");
            int distancia = int.Parse(Console.ReadLine());

            y = distancia * 2;

            Console.WriteLine($"O carro Y percorreu {y} minutos");
            Console.ReadLine();
        }
    }
}
