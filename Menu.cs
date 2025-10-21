using System;

namespace Evaluacion_T2
{
    internal class Menu
    {
        public static int ElijeOpcion(){
            int numero;

            do
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("   SISTEMA DE GESTION DE TRANSPORTE    ");
                Console.WriteLine("---------------------------------------");

                Console.WriteLine("      [1]- VENTA DE PASAJES            ");
                Console.WriteLine("      [2]- EQUIPAJE Y ENCOMIENDAS      ");
                Console.WriteLine("      [3]- GESTIONAR CARGA             ");
                Console.WriteLine("      [4]- SALIR DEL PROGRAMA          ");
                Console.WriteLine("---------------------------------------");
                Console.Write("Ingrese una de las opciones del 1 - 4: ");

                numero = Convert.ToInt32(Console.ReadLine());

                if (numero < 1 || numero > 4)

                {
                    Console.WriteLine("Ingresó un número no valido. Vuelva a ingresar");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (numero < 1 || numero > 4);
            return numero;
        
        }
        
        
        
    }
}
