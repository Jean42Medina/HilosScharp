using System;
using System.Threading;
using System.Threading.Tasks;

namespace Hilos.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Calcular();
            Console.Read();
        }
        async static void Calcular()
        {
            // el Await espera que la promesa se cumpla para entrar en ejecucion
            await Calcular1_2();
            Calcular3();
        }

        //  Uso de las promesas Task y el Task.Run asincrono
        async static Task Calcular1_2()
        {
            var resultado1 = await Task.Run(() =>
            {
                return Calcular1();
            });

            Calcular2(resultado1);

        }
        // Usu del Thread
        static int Calcular1()
        {
            Thread.Sleep(300);
            Console.WriteLine("Calcular resultado1");
            return 100;
        }

        static int Calcular2(int resultado1)
        {

            Console.WriteLine("Calcular resultado2");
            return resultado1 * 2;
        }

        static int Calcular3()
        {
            Console.WriteLine("Calcular resultado3");
            return 300;
        }
    }
}



