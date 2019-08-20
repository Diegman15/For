using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Imprime los numeros del x hasta el 60 de 3x3");
            Console.WriteLine("De donde arrancamos el ciclo: ");
            x = Convert.ToInt32(Console.ReadLine());
            for (int i = x; i <= 60; i +=3)
            {
                Console.WriteLine("i = " + i);
            }
        }
    }
}
