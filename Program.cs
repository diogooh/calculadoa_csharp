using System.Text;

namespace Calculadora
{
    internal class Program
    {
        public static int soma(int a,int b)
        {
            return a + b;
        }

        public static int sub(int a, int b)
        {
            return a - b;
        }

        public static int multi(int a, int b)
        {
            return a * b;
        }

        public static int divisao(int a, int b)
        {
            return a / b;
        }

        public static int area(int a, int b) 
        {
            return (a * b) / 2;
        }

        public static float clas()
        {
            float result = 0;
            Console.WriteLine("Digite os três lados do seu triangulo.");
            float lad1 = Convert.ToSingle(Console.ReadLine());
            float lad2 = Convert.ToSingle(Console.ReadLine());
            float lad3 = Convert.ToSingle(Console.ReadLine());
            if (lad1 == lad2 && lad2 == lad3)
            {
                result = 1;
                return result;
            }
            else if (lad1 != lad2 && lad1 != lad2 && lad2 != lad3)
            {
                result = 2;
                return result;
            }
            else
            {
                result = 3;
                return result;
            }
        }





        static void Main(string[] args)
        {
            Console.WriteLine("Introduza a sua opção que deseja:\n 1-Soma \n 2-Subtração\n 3-Multiplicação\n 4-Divisão\n 5-Área do Triângulo e classificar quanto aos lados.\n ");
            int menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1: Console.WriteLine("Soma");
                    Console.WriteLine("Digite 2 números");
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());
                    soma(num1, num2);
                    Console.WriteLine($"Resultado: {soma(num1, num2)}");
                    break;

                case 2: Console.WriteLine("Subtração");
                    Console.WriteLine("Digite 2 números");
                    int num3 = int.Parse(Console.ReadLine());
                    int num4 = int.Parse(Console.ReadLine());
                    sub(num3, num4);
                    Console.WriteLine($"Resultado: {sub(num3, num4)}");
                    break;

                case 3:
                    Console.WriteLine("Multiplicação");
                    Console.WriteLine("Digite 2 números");
                    int num5 = int.Parse(Console.ReadLine());
                    int num6 = int.Parse(Console.ReadLine());
                    multi(num5, num6);
                    Console.WriteLine($"Resultado: {multi(num5, num6)}");
                    break;

                case 4:
                    Console.WriteLine("Divisão");
                    Console.WriteLine("Digite 2 números");
                    int num7 = int.Parse(Console.ReadLine());
                    int num8 = int.Parse(Console.ReadLine());
                    divisao(num7, num8);
                    Console.WriteLine($"Resultado: {divisao(num7, num8)}");
                    break;

                case 5:
                    Console.WriteLine("Área de Triângulos\n");
                    Console.WriteLine("Digite 2 números");
                    int num9 = int.Parse(Console.ReadLine());
                    int num10 = int.Parse(Console.ReadLine());
                    area(num9, num10);
                    Console.WriteLine($"Resultado: {area(num9, num10)}");

                    //Classificar os lados
                    clas();



                    break;
                default: Console.WriteLine("Erro, repita o programa, digitou algum caracter errado ou algum número não pedido"); break;
            }
        }
    }
}