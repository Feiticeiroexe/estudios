using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz_2d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numEj;
            Console.WriteLine("Introduzca el número del ejercicio:");
            numEj = int.Parse(Console.ReadLine());
            if(numEj == 44)
            {
                Random generador = new Random();
                int[,] ej44 = new int[3, 3];
                for(int i = 0; i < ej44.GetLength(0); i++)
                {
                    for(int a = 0; a < ej44.GetLength(1); a++)
                    {
                        int num = generador.Next(0, 11);
                        ej44[i, a] = num;
                    }
                }
                // A)
                int numFila;
                Console.WriteLine("Escoge una fila que quieras ver e introduce el número de la fila:");
                numFila = int.Parse(Console.ReadLine());
                numFila--;
                for(int i = 0; i < ej44.GetLength(1); i++)
                {
                    Console.Write(ej44[numFila, i]);
                    Console.Write(",");
                }
                Console.ReadLine();
                Console.WriteLine();
                // B)
                for(int i = 0; i < ej44.GetLength(0); i++)
                {
                    ej44[i, (ej44.GetLength(1) - 1)] = 0;
                }
                int suma;
                for(int i = 0; i < ej44.GetLength(1); i++)
                {
                    
                }
            }
            else if(numEj == 45)
            {
            }
            else if(numEj == 47)
            {
            }
        }
    }
}
