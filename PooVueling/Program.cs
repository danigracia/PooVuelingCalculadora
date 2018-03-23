using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculadora iCalculadora = new Calculadora();
            int caseSwitch = 0;
            while (true)
            {                
                int num1;
                int num2;               

                if (caseSwitch == 5)
                {                    
                    break;
                }


                Console.WriteLine("Menu calculadora:");
                Console.WriteLine("-----------------");
                Console.WriteLine("1-Sumar:");
                Console.WriteLine("2-Restar:");
                Console.WriteLine("3-Multiplicar:");
                Console.WriteLine("4-Dividir:");
                Console.WriteLine("5-Salir:");
                Console.WriteLine("Elige una opcion: ");
                caseSwitch = Convert.ToInt32(Console.ReadLine());

                switch (caseSwitch)
                {
                    case 1:
                        Console.WriteLine("Has selecionado la opcion sumar:");
                        Console.WriteLine("Introduce el numero 1:");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Introduce el numero 2:");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El resultado es: " + iCalculadora.Suma(num1,num2));
                        Console.WriteLine("Presiona cualquier tecla para continuar...");
                        Console.ReadLine();

                        break;
                    case 2:
                        Console.WriteLine("Has selecionado la opcion resta:");
                        Console.WriteLine("Introduce el numero 1:");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Introduce el numero 2:");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El resultado es: " + iCalculadora.Resta(num1, num2));
                        Console.WriteLine("Presiona cualquier tecla para continuar...");
                        Console.ReadLine();

                        break;
                    case 3:
                        Console.WriteLine("Has selecionado la opcion multiplicacion:");
                        Console.WriteLine("Introduce el numero 1:");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Introduce el numero 2:");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El resultado es: " + iCalculadora.Multiplicacion(num1, num2));
                        Console.WriteLine("Presiona cualquier tecla para continuar...");
                        Console.ReadLine();

                        break;
                    case 4:
                        Console.WriteLine("Has selecionado la opcion division:");
                        Console.WriteLine("Introduce el numero 1:");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Introduce el numero 2:");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El resultado es: " + iCalculadora.Division(num1, num2));
                        Console.WriteLine("Presiona cualquier tecla para continuar...");
                        Console.ReadLine();

                        break;
                    case 5:
                        Console.WriteLine("Presiona cualquier tecla para salir...");
                        Console.ReadLine();
                        break;

                }
            }
            
        }
            
            
       
    }
}
