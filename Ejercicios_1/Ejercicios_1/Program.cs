using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

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
                foreach(string matricula in matriculas)
                {
                    Console.WriteLine(matricula.Split('-')[0]);
                }
                Console.ReadLine();
                //D
                Console.WriteLine("Parte alfabética de las matriculas");
                foreach(string matricula in matriculas)
                {
                    Console.WriteLine(matricula.Split('-')[1]);
                }
                Console.ReadLine();
                //E
                String ruta = Directory.GetCurrentDirectory() + "\\matriculas.txt";
                StreamWriter escritor = new StreamWriter(ruta, true);
                Console.WriteLine(ruta);
                Console.ReadLine();
                for(int i = 0; i < 10; i++)
                {
                    escritor.WriteLine(matriculas[i]);
                }
                escritor.Close();
            }
            else if(numEj == 2)
            {
                string palabra;
                char caracter;
                int contador = 0;
                Console.WriteLine("Introduzca una frase o palabra:");
                palabra = Console.ReadLine();
                Console.WriteLine("Pulse la tecla del caracter que quieras que se cuente cuantas veces aparece en tu frase/palabra:");
                caracter = Console.ReadKey().KeyChar;
                Console.WriteLine();
                for(int i = 0; i < palabra.Length; i++)
                {
                    if (palabra[i] == caracter)
                    {
                        contador++;
                    }
                }
                Console.WriteLine($"El caracter {caracter} aparece {contador} veces en {palabra}");
                Console.ReadLine();
            }
            else if(numEj == 3)
            {
                string DNI;
                bool corrector = true;
                do
                {
                    corrector = true;
                    Console.WriteLine("Introduzca su DNI:");
                    DNI = Console.ReadLine();
                    if (DNI.Length != 9)
                    {
                        corrector = false;
                    }
                    else
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            if (char.IsLetter(DNI[i]))
                            {
                                corrector = false;
                            }
                        }
                    }
                    if (char.IsDigit(DNI[DNI.Length - 1]))
                    {
                        corrector = false;
                    }
                    Console.Clear();
                }
                while (corrector == false);
                char[] letras = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E'};
                string numeros = DNI.Substring(0, 7);
                int numeros2 = Convert.ToInt32(numeros);
                int numLetra = (numeros2 % 23) - 1;
                char letraCorrespondiente = letras[numLetra];
                char letraOr = char.ToUpper(DNI[DNI.Length - 1]);
                if(letraCorrespondiente == letraOr)
                {
                    Console.WriteLine("El DNI es correcto.");
                }
                else
                {
                    Console.WriteLine($"La letra esta mal, la correcta seria: {letraCorrespondiente}");
                }
                Console.ReadLine();
            }
            else if(numEj == 4)
            {
                string frase;
                Console.WriteLine("Introduzca la frase a analizar:");
                frase = Console.ReadLine();
                string[] palabras = frase.Split(' ');
                foreach(string palabra in palabras)
                {
                    if(palabra.StartsWith("b") || palabra.StartsWith("B"))
                    {
                        Console.WriteLine(palabra);
                    }
                }
                Console.ReadLine();
            }
            else if(numEj == 5)
            {
                string frase;
                Console.WriteLine("Introduzca lla frase:");
                frase = Console.ReadLine();
                bool yoquese = frase.Contains("@");
                if(yoquese == true)
                {
                    Console.WriteLine("Contriene @");
                }
                else
                {
                    Console.WriteLine("No contiene @");
                }
                Console.ReadLine();
            }
            else if(numEj == 6)
            {

            }
            else if(numEj == 7)
            {
                string correo;
                Console.WriteLine("Introduce tu correo electronico:");
                correo = Console.ReadLine();
                Console.WriteLine(correo.Split('@')[1]);
                Console.ReadLine();
            }
            else if(numEj == 8)
            {
                string código;
                Console.WriteLine("Introduzca el código:");
                código = Console.ReadLine();
                if(código.Length == 4)
                {
                    if (char.IsLetter(código[0]) && char.IsLetter(código[1]) && char.IsDigit(código[2]) && char.IsDigit(código[3]))
                    {
                        Console.WriteLine("El formato es correcto.");
                    }
                    else
                    {
                        Console.WriteLine("Formato incorrecto.");
                    }
                }
                else
                {
                    Console.WriteLine("Formato incorrecto.");
                }
                Console.ReadLine();
            }
            else if(numEj == 9)
            {
                string frase;
                Console.WriteLine("Introduzca la frase:");
                frase = Console.ReadLine();
                char[] letras = new char[frase.Length];
                for(int i = 0; i < frase.Length; i++)
                {
                    letras[i] = frase[i];
                }
                for (int i = 0; i < letras.Length; i++)
                {
                    if (letras[i] == ' ')
                    {
                        letras[i] = '*';
                    }
                }
                foreach(char c in letras)
                {
                    Console.Write(c);
                }
                Console.ReadLine();
            }
            else if(numEj == 10)
            {
                string pedro = "Pedro Jimenez*14Julio1990?2500";
                string Maria = "Maria Benitez*9070!06Agosto1998";
                string salarioPedro = pedro.Split('?')[1];
                string salarioMaria = Maria.Split('*', '!')[1];
                int salarioPedro2, salarioMaria2;
                salarioPedro2 = Convert.ToInt32(salarioPedro);
                salarioMaria2 = Convert.ToInt32(salarioMaria);
                if(salarioPedro2 >= 1000)
                {
                    Console.WriteLine("El salario de Pedro es mayor que 1000, es correcto.");
                }
                else
                {
                    Console.WriteLine("El salario de Pedro es menor que 1000, es incorrecto.");
                }
                if (salarioMaria2 >= 1000)
                {
                    Console.WriteLine("El salario de Maria es mayor que 1000, es correcto.");
                }
                else
                {
                    Console.WriteLine("El salario de Maria es menor que 1000, es incorrecto.");
                }
                Console.ReadLine();
            }
        }
    }
}
