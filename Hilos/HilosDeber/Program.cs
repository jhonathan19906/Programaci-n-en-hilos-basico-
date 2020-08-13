using System;
using System.Threading;

namespace HilosDeber
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(metodo);
            Thread e = new Thread(metodo1);
            Thread r = new Thread(metodo2);
            e.Start();
            r.Start();
            t.Start();
            Thread.Sleep(2000);
            Console.Write("Hilos finalisados");
            Console.Read();
        }
        static void metodo()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("hola ");
            }
        }
        static void metodo1()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("que mas");
            }
        }
        static void metodo2()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("amigos");
            }
        }
    }
}
