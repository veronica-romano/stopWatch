using System;
using System.Threading;

namespace stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("S - Segundos. Ex:10s  = 10 segundos");
            Console.WriteLine("M - Minutos Ex:10m  = 10 minutos");
            Console.WriteLine("0s - Sair");
            Console.WriteLine("Quanto tempo deseja contar?");
            String data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;
                if (type == 'm')
                    multiplier = 60;
                if (time == 0)
                    System.Environment.Exit(0);
            PreStart(time * multiplier);
        }


        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Go!");
            Thread.Sleep(1000);
            Start(time);
        }
        static void Start(int time)
        {           
            int currentTime = 0;
            while(currentTime != time)
            {
                 Console.Clear();
                 currentTime++;
                 Console.WriteLine(currentTime);
                 Thread.Sleep(1000); 
            }
            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(1000); 


        }

    }
}
