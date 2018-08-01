using System;

namespace Aula3107_Console
{
    class Program
    {
        public static double Num1 { get; set; }
        public static double Num2 { get; set; }
        public static string Operador { get; set; }
        public static double Resultado { get; set; }

        static void Main(string[] args)
        {
            Console.Write("1° Numero: ");
            Num1 = double.Parse(Console.ReadLine());
            Console.Write("Operador: ");
            Operador = Convert.ToString(Console.ReadLine());

                switch (Operador)
                {
                    case "+":
                        {
                            Console.Write("2° Numero: ");
                            Num2 = double.Parse(Console.ReadLine());
                            Resultado = Num1 + Num2;
                            Console.WriteLine("Resultado = " + Resultado);
                            Console.ReadKey();
                            break;
                        }
                    case "-":
                        {
                            Console.Write("2° Numero: ");
                            Num2 = double.Parse(Console.ReadLine());
                            Resultado = Num1 - Num2;
                            Console.WriteLine("Resultado = " + Resultado);
                            Console.ReadKey();
                            break;
                        }
                    case "/":
                        {
                            Console.Write("2° Numero: ");
                            Num2 = double.Parse(Console.ReadLine());
                            Resultado = Num1 / Num2;
                            Console.WriteLine("Resultado = " + Resultado);
                            Console.ReadKey();
                            break;
                        }
                    case "*":
                        {
                            Console.Write("2° Numero: ");
                            Num2 = double.Parse(Console.ReadLine());
                            Resultado = Num1 * Num2;
                            Console.WriteLine("Resultado = " + Resultado);
                            Console.ReadKey();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Digite um operador válido(+|-|*|/)");
                            Console.ReadKey();
                            Console.Clear();
                            Main(null);
                            break;
                        }
                }
        }
    }
}
