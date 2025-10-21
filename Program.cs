using System;


namespace Evaluacion_T2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                opcion = Menu.ElijeOpcion();

                switch (opcion)
                {
                    case 1: VentaPasajes();
                        break;

                    case 2: EquipajeEncomienda();
                        break;

                    case 3: GestionCarga();
                        break;

                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no valida");
                        break;
                } if (opcion != 4)
                {
                    Console.WriteLine("Presione cualquier telca para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (opcion != 4) ;
        }
    }






}

