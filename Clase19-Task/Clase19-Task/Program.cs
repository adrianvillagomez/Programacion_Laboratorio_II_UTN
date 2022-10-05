using System;
using System.Threading;
using System.Threading.Tasks;

namespace Clase19_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cancellation = new CancellationTokenSource();
            CancellationToken cancellationToken = cancellation.Token;  
            
            ConsoleKey teclaPresionada;
            //Task tarea = new Task (ImprimirHora);//Otro forma de inicializar task
            Task.Run(()=>ImprimirHora(cancellation),cancellationToken);
            // Task.Run(ImprimirHora); Sin lambda
            do
            {
                teclaPresionada = Console.ReadKey().Key;
                Console.WriteLine($"La tecla presionada es {teclaPresionada}");
                if(teclaPresionada == ConsoleKey.Spacebar)
                {
                    cancellation.Cancel();
                }

            } while (teclaPresionada != ConsoleKey.Escape);


        }

        static void ImprimirHora(CancellationTokenSource cancellation)
        {
            do
            {
                Console.WriteLine($"La hora actual es: {DateTime.Now}");
                Thread.Sleep(1000);
            }while (!cancellation.IsCancellationRequested);  
        }


    }
}
