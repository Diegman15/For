using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Imprime los numeros del x hasta y  de -1 ");
            Console.WriteLine("De donde arrancamos el ciclo (Mayor): ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("De donde arrancamos el ciclo (Menor): ");
            y = Convert.ToInt32(Console.ReadLine());
            for (int i = x; i >= y; i--)
            {
                Console.WriteLine("i = " + i);
            }
        }
    }
}
