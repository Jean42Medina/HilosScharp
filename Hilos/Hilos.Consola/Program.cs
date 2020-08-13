using System;
using System.Threading;


namespace Hilos.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Un solo hilo");
            // Instanciamos el objeto thread/hilo
            //Thread miHilo = new Thread(Saludos);
            // Ahora lo inicializamos
            //miHilo.Start();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Saludo desde main");
            // forma de pasar datos al hilo
            Thread miHilo = new Thread(MiMensaje);
            // Al inicializar el hilo mandamos mensaje
            miHilo.Start(5);
        }

         
        // Creamos un metodo que se ejecutara en el segundo hilo
        //debemos considir con el delegado
        static void Saludos()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Saludos desde el hilo");
        }
        // este es un metodo q va al segundo hilo y se recibe un parametro exterior
        static void MiMensaje(object o) 
        {
            int m = Convert.ToInt32(0);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Saludo desde mensaje {0},{1}", m, m*2);

        }

    }
}
