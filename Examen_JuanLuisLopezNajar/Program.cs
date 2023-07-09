using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_JuanLuisLopezNajar
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //numero par
            int numero = 0;
            int resultado = 0;
            Console.WriteLine("Ingresa Un numero");
            numero = Convert.ToInt32(Console.ReadLine());
            //operacion para verificar si un numero es impar
            resultado = numero % 2;
            //CUmplir la condicion si un numero es impar o no
            if (resultado == 0)
            {
                Console.WriteLine("El numero ingresado es par ");
            }
            else
            {
                Console.WriteLine("el numero ingresado es impar");
            }

            Console.ReadKey();

            //Dos valores almacenados en dos variables sin  utilizar una tercera variable

            int valorUno = 0;
            int valorDos = 0;

            Console.WriteLine("Ingresa un numero:");
            valorUno= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa otro numero:");
            valorDos= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Valores Originales:");
            Console.WriteLine("Valor uno:"+valorUno);
            Console.WriteLine("Valor dos:"+valorDos);

            //Intercambio de las valores sin usar una tercera variable
            valorUno= valorUno+valorDos;
            valorDos=valorUno-valorDos;
            valorUno=valorUno-valorDos;

            Console.WriteLine("Valores intercambiados:");
            Console.WriteLine("Valor uno:"+valorUno);
            Console.WriteLine("Valor dos:"+valorDos);
            Console.ReadKey();





        }
    }
}
