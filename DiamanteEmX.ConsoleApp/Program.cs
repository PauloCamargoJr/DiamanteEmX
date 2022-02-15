using System;

namespace DiamanteEmX.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número ímpar:");
            int x = Convert.ToInt32(Console.ReadLine());
            int l = x;
            if(x%2 == 1)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                for (int i = 0; i < x; i++)
                {
                    if(i%2 == 1)
                    {
                        for(int k = l; k > 0;)
                        {
                            Console.Write(" ");
                            k -= 2;
                        }
                    } 
                    for (int j = 0; j < i; j++)
                    {
                        if (i % 2 == 1)
                            Console.Write("X");
                    }
                    if (i % 2 == 1)
                        Console.Write("\n");
                    l--;
                }
                for (int i = x; i > 0; i--)
                {
                    if (i % 2 == 1)
                    {
                        for (int k = 0; k < l;)
                        {
                            Console.Write(" ");
                            k += 2;
                        }
                    }
                    for (int j = 0; j < i; j++)
                    {
                        if (i % 2 == 1)
                            Console.Write("X");
                    }
                    if (i % 2 == 1)
                        Console.Write("\n");
                    l++;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor par não pode ser aceito!");
            }
            Console.ReadKey();
        }
    }
}
