using System;
namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundos => 10s = 10 segundos");
            Console.WriteLine("M = Minutos => 1m = 1 minuto");
            Console.WriteLine("R = Deseja acessar a contagem regreciva?");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo quer contar?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplicador = (type == 'm') ? 60 : 1;

            if (type == 'r')
                Countdown(time * multiplicador);
            else if (type == '0')
                Environment.Exit(0);
            else
                Menu();

            PreStart(time * multiplicador);
        }

        static void PreStart(int time)
        {
            CounterMessage();
            Start(time);

        }

        static void Start(int time)
        {

            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("StopWatch finaizado ");
            Thread.Sleep(2500);
            Menu();
        }

        static void Countdown(int valor)
        {
            CounterMessage();

            for (int i = valor; i >= 0; i--)
            {
                Console.Clear();
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Contagem regressiva finalizada");
            Thread.Sleep(2500);
            Menu();
        }

        static void CounterMessage()
        {
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(1000);
        }

    }
}