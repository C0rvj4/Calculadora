using System.Data;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menu();











            //===Funções===//


            static void menu()
            {
                Console.Clear();

                Console.WriteLine("================");
                Console.WriteLine("Calculadora");
                Console.WriteLine("================");

                Console.WriteLine("Digite 1 - Soma");
                Console.WriteLine("Digite 2 - Subtração");
                Console.WriteLine("Digite 3 - Multiplicação");
                Console.WriteLine("Digite 4 - Divisão");
                Console.WriteLine("Digite 5 - Raiz");



                int opcao;
                if (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 5)
                {
                    Console.WriteLine("Opção inválida!");
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
                    Console.ReadKey();
                    menu();
                    return;
                }



                switch (opcao)
                {

                    case 1:
                        soma();
                        break;
                    case 2:
                        Subtracao();
                        break;
                    case 3:
                        Multiplicacao();
                        break;
                    case 4:
                        // Divisao();
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }


                








                static void soma()
                {
                    Console.Clear();

                    Console.WriteLine("================");
                    Console.WriteLine("Soma");
                    Console.WriteLine("================");

                    try
                    {
                        Console.WriteLine("Primeiro número a ser somado");
                        int num1 = int.Parse(Console.ReadLine());


                        Console.WriteLine("Segundo número a ser somado");
                        int num2 = int.Parse(Console.ReadLine());

                        double resultado = num1 + num2;

                        Console.WriteLine($"O resultado da soma é {resultado}");
                        Console.WriteLine("\nPressione -S- para continuar somando");
                        Console.WriteLine("Precione -M- para voltar ao Menu");
                    }
                    catch (FormatException erro)
                    {
                        Console.WriteLine($"Formato não permitido, insira apenas número inteiros. Erro: {erro.Message}");
                        Console.WriteLine("Precione S para continuar a somar, ou M para retornar ao Menu");

                    }
                    
                    

                    ConsoleKeyInfo teclaPressionada = Console.ReadKey();

                    switch (teclaPressionada.Key)
                    {
                        case ConsoleKey.S:
                            PrimeiraAlternativa();
                            break;

                        case ConsoleKey.M:
                            SegundaAlternativa();
                            break;

                        default:
                            Console.WriteLine("Opção invalida");
                            break;



                    }
                    static void PrimeiraAlternativa()
                    {
                        soma();
                    }
                    static void SegundaAlternativa()
                    {
                        menu();
                    }
                }








                static void Subtracao()
                {
                    Console.Clear();

                    Console.WriteLine("================");
                    Console.WriteLine("Subtracao");
                    Console.WriteLine("================");



                    try
                    {
                        Console.WriteLine("Digite o maior número");
                        int num1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o menor número");
                        int num2 = int.Parse(Console.ReadLine());

                        double resultado = num1 - num2;
                        Console.WriteLine($"O resultado da Subtração é {resultado}");
                        Console.WriteLine("\nPressione -S- para continuar Subtraindo");
                        Console.WriteLine("Precione -M- para voltar ao Menu");
                    }
                    catch (FormatException Erro)
                    {
                        Console.WriteLine($"O formato não permitido, insira apenas números inteiros");
                        Console.WriteLine("Digite S para continuar a Subtração ou digite M para retornar ao Menu");

                    }
                   

                    ConsoleKeyInfo teclaPressionada = Console.ReadKey();

                    switch (teclaPressionada.Key)
                    {
                        case ConsoleKey.S:
                            PrimeiraAlternativa();
                            break;

                        case ConsoleKey.M:
                            SegundaAlternativa();
                            break;
                     
                    }
                    static void PrimeiraAlternativa()
                    {
                        Subtracao();
                    }
                    static void SegundaAlternativa()
                    {
                        menu();
                    }

                }










                static void Multiplicacao()
                {
                    Console.Clear();

                    Console.WriteLine("================");
                    Console.WriteLine("Multiplicação");
                    Console.WriteLine("================");

                    try
                    {
                        Console.WriteLine("Em quantas vezes deseja múltiplicar?");
                        int num1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Qual o número a ser múltiplicado");
                        int num2 = int.Parse(Console.ReadLine());

                        double resultado = num2 * num1;
                        Console.WriteLine($"O resultado da Multiplicação é {resultado}");
                        Console.WriteLine("\nPressione -S- para continuar Multiplicando");
                        Console.WriteLine("Precione -M- para voltar ao Menu");
                    }
                    catch (FormatException erro)
                    {
                        Console.WriteLine("Formato não permitido, utilize apenas números inteiros");
                        Console.WriteLine("Digite S para continuar a multiplicação ou M para retornar ao Menu");
                       
                    }




                    ConsoleKeyInfo teclaPressionada = Console.ReadKey();

                    switch (teclaPressionada.Key)
                    {
                        case ConsoleKey.S:
                            PrimeiraAlternativa();
                            break;

                        case ConsoleKey.M:
                            SegundaAlternativa();
                            break;
                        default:
                            Console.WriteLine("Opção invalida");
                            break;


                    }
                    static void PrimeiraAlternativa()
                    {
                        Multiplicacao();
                    }
                    static void SegundaAlternativa()
                    {
                        menu();
                    }
                }
            }
        }
    }
}
