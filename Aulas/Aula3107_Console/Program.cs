using System;

namespace Aula3107_Console
{
    class Program
    {
        public static int num { get; set; }
        public static int num2 { get; set; }
        public static int operador { get; set; }
        public static double final { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o operador?/n");
            Console.WriteLine("1 - Soma +");
            Console.WriteLine("2 - Sub -");
            Console.WriteLine("3 - div /");
            Console.WriteLine("4 - mult x");
            operador = int.Parse(Console.ReadLine());

            if(operador == 1)
            {
                final = Soma(num, num2);

            }else if(operador == 2)
            {
                final = Sub(num, num2);
            }else if(operador == 3)
            {
                final = Div(num, num2);
            }else if(operador == 4)
            {
                final = Mult(num, num2);
            }

            Console.WriteLine("Resultado: "+ final);
            Console.ReadKey();
        }

        static int Soma(int num, int num2)
        {
            int x;
            x = num + num2;
            return x;

        }

        static int Sub(int num, int num2)
        {
            int x;
            x = num - num2;
            return x;
        }

        static double Div(int num, int num2)
        {
            double x;
            x = num / num2;
            return x;
        }

        static int Mult(int num, int num2)
        {
            int x;
            x = num * num2;
            return x;
        }
    }
}
