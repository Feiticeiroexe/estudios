using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numEj;
            Console.WriteLine("Introduzca el número del ejercicio:");
            numEj = int.Parse(Console.ReadLine());
            Console.Clear();
            while(numEj < 1 || numEj > 5)
            {
                Console.WriteLine("Ese ejercicio no existe, vuelva a introducir uno:");
                numEj = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            if(numEj == 1)
            {
                Console.WriteLine("EJERCICIO 1:");
                List<int> ejercicio1 = new List<int>();
                Random generador = new Random();
                for(int i = 1; i < 51; i++)
                {
                    int num = generador.Next(1, 26);
                    ejercicio1.Add(num);
                }
                //A
                int a1;
                bool apartA = ejercicio1.Contains(2);
                if(apartA == true)
                {
                    a1 = ejercicio1.IndexOf(2);
                    Console.WriteLine("El 2 se encuentra en la posición: " + a1);
                }
                else
                {
                    Console.WriteLine("No hay un 2 en esta lista.");
                }
                Console.ReadLine();
                //B
                int sumaB = 0;
                foreach(int i in ejercicio1)
                {
                    sumaB = sumaB + i;
                }
                Console.WriteLine("La suma de los valores de la lista es: " + sumaB);
                Console.ReadLine();
                //C
                float mediaC = (float)sumaB / ejercicio1.Count();
                Console.WriteLine("La media de los valores: " +  mediaC);
                Console.ReadLine();
                //D
                int contadorD = 0;
                foreach(int i in ejercicio1)
                {
                    if(i > 20)
                    {
                        contadorD++;
                    }
                }
                float porcentajeD = ((float)contadorD/ejercicio1.Count()) * 100;
                Console.WriteLine("Porcentaje de números superiores a 20: " +  porcentajeD + "%");
                Console.ReadLine();
                //E
            }
        }
    }
}
