using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicios_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numEj;
            Console.WriteLine("Bienvenido a Boletín UD 7 - Strings.");
            Console.WriteLine("Introduzca un ejercicio para ejecutar:");
            numEj = int.Parse(Console.ReadLine());
            while (numEj < 1 || numEj > 26)
            {
                Console.Clear();
                Console.WriteLine("Este ejercicio no existe, introduzca uno de nuevo:");
                numEj = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            if(numEj == 1)
            {
                string[] matriculas = new string[10];
                matriculas[0] = "9947-HUD";
                matriculas[1] = "4733-GMZ";
                matriculas[2] = "3482-MDH";
                matriculas[3] = "9473-LFZ";
                matriculas[4] = "8872-VCM";
                matriculas[5] = "9884-FAS";
                matriculas[6] = "1234-COC";
                matriculas[7] = "3434-ZZZ";
                matriculas[8] = "9999-ZZZ";
                matriculas[9] = "1111-AAA";
                //A
                Console.WriteLine("Matriculas que acaban en Z:");
                for(int i = 0; i < 10; i++)
                {
                    if (matriculas[i].EndsWith("Z"))
                    {
                        Console.WriteLine(matriculas[i]);
                    }
                }
                Console.ReadLine();
                //B
                Console.WriteLine("Matriculas que contienen 34:");
                for (int i = 0; i < 10; i++)
                {
                    if (matriculas[i].Contains("34"))
                    {
                        Console.WriteLine(matriculas[i]);
                    }
                }
                Console.ReadLine();
                //C
                Console.WriteLine("Parte númerica de las matriculas");
                for(int i = 0; i < 10; i++)
                {
                    Console.WriteLine(matriculas[i].Split(("-")[0]));
                }
                Console.ReadLine();
                //D
                Console.WriteLine("Parte alfabética de las matriculas");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(matriculas[i].Split(("-")[1]));
                }
                Console.ReadLine();
                //E
                String ruta = Directory.GetCurrentDirectory() + "\\matriculas.txt";
                StreamWriter escritor = new StreamWriter(ruta, true);
 
            }
        }
    }
}
