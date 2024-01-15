using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hundir_la_flota
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* Barcos:
           * 2x de un pixel
           * 3x de dos pixeles
           * 3x de tres pixeles
           * 1x de cuatro pixeles
           * pixeles totales 21
           * Cuadrícula 10x10
           */
            Random generador = new Random();
            int Vertical;
            int Horizontal;
            int verticalHorizontal;
            int[] bot1 = new int[10];
            int[] bot2 = new int[10];
            int[] bot3 = new int[10];
            int[] bot4 = new int[10];
            int[] bot5 = new int[10];
            int[] bot6 = new int[10];
            int[] bot7 = new int[10];
            int[] bot8 = new int[10];
            int[] bot9 = new int[10];
            int[] bot10 = new int[10];
            int[] jugador1 = new int[10];
            int[] jugador2 = new int[10];
            int[] jugador3 = new int[10];
            int[] jugador4 = new int[10];
            int[] jugador5 = new int[10];
            int[] jugador6 = new int[10];
            int[] jugador7 = new int[10];
            int[] jugador8 = new int[10];
            int[] jugador9 = new int[10];
            int[] jugador10 = new int[10];
            //creación tablero
            //barcos de 1:
            for (int contador = 1; contador <= 2; contador++)
            {
                Vertical = generador.Next(1, 11);
                Horizontal = generador.Next(0, 10);

                if (Vertical == 1)
                {
                    if (bot1[Horizontal] == 4)
                    {
                        contador--;
                    }
                    else
                    {
                        bot1[Horizontal] = 4;
                    }
                }
                else if (Vertical == 2)
                {
                    if (bot2[Horizontal] == 4)
                    {
                        contador--;
                    }
                    else
                    {
                        bot2[Horizontal] = 4;
                    }
                }
                else if (Vertical == 3)
                {
                    if (bot3[Horizontal] == 4)
                    {
                        contador--;
                    }
                    else
                    {
                        bot3[Horizontal] = 4;
                    }
                }
                else if (Vertical == 4)
                {
                    if (bot4[Horizontal] == 4)
                    {
                        contador--;
                    }
                    else
                    {
                        bot4[Horizontal] = 4;
                    }
                }
                else if (Vertical == 5)
                {
                    if (bot5[Horizontal] == 4)
                    {
                        contador--;
                    }
                    else
                    {
                        bot5[Horizontal] = 4;
                    }
                }
                else if (Vertical == 6)
                {
                    if (bot6[Horizontal] == 4)
                    {
                        contador--;
                    }
                    else
                    {
                        bot6[Horizontal] = 4;
                    }
                }
                else if (Vertical == 7)
                {
                    if (bot7[Horizontal] == 4)
                    {
                        contador--;
                    }
                    else
                    {
                        bot7[Horizontal] = 4;
                    }
                }
                else if (Vertical == 8)
                {
                    if (bot8[Horizontal] == 4)
                    {
                        contador--;
                    }
                    else
                    {
                        bot8[Horizontal] = 4;
                    }
                }
                else if (Vertical == 9)
                {
                    if (bot9[Horizontal] == 4)
                    {
                        contador--;
                    }
                    else
                    {
                        bot9[Horizontal] = 4;
                    }
                }
                else if (Vertical == 10)
                {
                    if (bot10[Horizontal] == 4)
                    {
                        contador--;
                    }
                    else
                    {
                        bot10[Horizontal] = 4;
                    }
                }
            }
            foreach (int horizontal2 in bot1)
            {
                Console.Write(bot1[horizontal2]);
            }
            Console.WriteLine();
            foreach (int horizontal2 in bot2)
            {
                Console.Write(bot2[horizontal2]);
            }
            Console.WriteLine();
            foreach (int horizontal2 in bot3)
            {
                Console.Write(bot3[horizontal2]);
            }
            Console.WriteLine();
            foreach (int horizontal2 in bot4)
            {
                Console.Write(bot4[horizontal2]);
            }
            Console.WriteLine();
            foreach (int horizontal2 in bot5)
            {
                Console.Write(bot5[horizontal2]);
            }
            Console.WriteLine();
            foreach (int horizontal2 in bot6)
            {
                Console.Write(bot6[horizontal2]);
            }
            Console.WriteLine();
            foreach (int horizontal2 in bot7)
            {
                Console.Write(bot7[horizontal2]);
            }
            Console.WriteLine();
            foreach (int horizontal2 in bot8)
            {
                Console.Write(bot8[horizontal2]);
            }
            Console.WriteLine();
            foreach (int horizontal2 in bot9)
            {
                Console.Write(bot9[horizontal2]);
            }
            Console.WriteLine();
            foreach (int horizontal2 in bot10)
            {
                Console.Write(bot10[horizontal2]);
            }
            Console.ReadLine();
        }
    }
}
