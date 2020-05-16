using System;

namespace Ejercicio_1__4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1 capitulo 3.
            Console.WriteLine("Hacer un programa que le pida al usuario un número y la computadora responda si es par o impar.\n");
            float numero = 0;
            string N = "";

            Console.Write("Digite un numero: ");
            N = Console.ReadLine();
            numero = Convert.ToSingle(N);

            if(numero % 2 == 0)
            {
                Console.WriteLine("El numero " + numero + " es par.\n\n");
            }
            else
            {
                Console.WriteLine("El numero " + numero + " es impar.\n\n");
            }


            //Ejercicio 4 capitulo 3.
            Console.WriteLine("Hacer un programa que le pida al usuario un número del 1 al 7 y escriba el nombre del día que corresponde ese número en la semana.\n");
            float dia = 0;
            string D = "";

            Console.Write("Digite un numero entre el 1 y el 7: ");
            D = Console.ReadLine();
            dia = Convert.ToSingle(D);

            if(dia == 1)
            {
                Console.Write("Lunes.\n");
            }
            else if (dia == 2)
            {
                Console.Write("Martes.\n");
            }
            else if(dia == 3)
            {
                Console.Write("Miercoles.\n");
            }
            else if(dia == 4)
            {
                Console.Write("Jueves.\n");
            }
            else if(dia == 5)
            {
                Console.Write("Viernes.\n");
            }
            else if(dia == 6)
            {
                Console.Write("Sabado.\n");
            }
            else if(dia == 7)
            {
                Console.Write("Domingo.\n");
            }
            else if(dia >=8)
            {
                Console.Write("\nDebe ingresar un numero entre el 1 y el 7 usted ingreso el " + D + ".\n");
            }
            else if(dia <= 0)
            {
                Console.Write("\nDebe ingresar un numero entre el 1 y el 7 usted ingreso el " + D + ".\n");
            }
        
        }
    }
}
