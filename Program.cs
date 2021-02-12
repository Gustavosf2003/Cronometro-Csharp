using System;
using System.Threading;

namespace Cronometer
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
            Console.WriteLine("Cronômetro com C#");
            Console.WriteLine("");
            Console.WriteLine("Quanto tempo você deseja contar");
            Console.WriteLine("");
            Console.WriteLine("Ex:");
           
            Console.WriteLine("10 segundos ====> 10s");
            Console.WriteLine("5 minutos =====>5s");

            // Reduzir chances de bugs
            try{
                 string data = Console.ReadLine().ToLower(); // tudo que foi escrito vira minúsculo
            char minusculo = char.Parse(data.Substring(data.Length - 1, 1)); //pega a última letra


            int time = int.Parse(data.Substring(0, data.Length - 1));


            int mult = 1;

            if (minusculo == 'm' )
            {
                mult = 60;

            }

            if (time == 0)
            {
                System.Environment.Exit(0);
            }

            PreStart(time * mult);
            }catch{
        Console.Clear();
        Console.WriteLine("Hmmmmm. Parece que você não digitou um número da maneira correta");
        Console.WriteLine("Vamos tentar denovo?");
            Thread.Sleep(2000);
            Console.Clear();
            Menu();
        }
           

        }

        static void PreStart(int time)
        {

            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Steady...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(1000);
            Start(time);


        }
        static void Start(int time)

        {


            short current = 0;
            while (current != time)
            {
                Console.Clear();
                current++;
                Console.WriteLine(current);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Acabou o Tempo!!!");

            Thread.Sleep(1500);
            Console.WriteLine("Deseja contar outra vez? (sim/nao)");

            string novamente = Console.ReadLine().ToLower();

            if(novamente == "sim" || novamente == "s" || novamente == "yes"  ){
                Console.Clear();
                Menu();

            }else{
            System.Environment.Exit(0);
            }

            


        }


    }


}
