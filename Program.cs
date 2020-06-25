using System;

namespace Aula25Recursividade
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Fibonacci sequencia = new Fibonacci();

            sequencia.GerarFibonacci(0, 1, 10);
            System.Console.WriteLine("----------------------------");
            sequencia.GerarTribonacci(0, 1, 1, 10);


        }
    }
}
