﻿internal class Program
{
    private static void Main(string[] args)
    {
        //Loop de execucação 0 -1

              
        while (true) // enquanto
        {
            Console.Clear();            
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Calculadora Tabajara 2025");
            Console.WriteLine("-------------------------------");

            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Tabuada");
            Console.WriteLine("S - Sair");

            Console.WriteLine("Escolha uma opção: ");


            string opcao = Console.ReadLine().ToUpper(); // converte para maiúsculo        

            //estrutura de decisão
            if (opcao == "S")            
                break;

            else if (opcao =="5")
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Tabuada");
                Console.WriteLine("-------------------------------");
                //usuario digita um número e é feito o calculo da tabuada até o 10                

                Console.Write("Digite o número: ");
                int numeroTabuada = Convert.ToInt32(Console.ReadLine());

                for (int contador = 1; contador <= 10; contador++)
                {
                    int resultadoTabuada = numeroTabuada * contador;
                    //interpolação de string com variaveis
                    Console.WriteLine($"{numeroTabuada} x {contador} = {resultadoTabuada}");                 
                                        
                }
                Console.ReadLine();

                continue;
            }


            Console.Write("Digite o primeiro número: ");
            string primeiroNumeroString = Console.ReadLine();
            decimal primeiroNumero = Convert.ToDecimal(primeiroNumeroString);

            Console.Write("Digite o segundo número: ");
            string segundoNumeroString = Console.ReadLine();
            decimal segundoNumero = Convert.ToDecimal(segundoNumeroString);

            decimal resultado = 0;

            if (opcao == "1")
            {
                resultado = primeiroNumero + segundoNumero;
            }

            else if (opcao == "2")
            {
                resultado = primeiroNumero - segundoNumero;
            }
            else if (opcao == "3")
            {
                resultado = primeiroNumero * segundoNumero;
            }
            else if (opcao == "4")
            {
            
                if (segundoNumero == 0)
                {
                    Console.WriteLine("Não é possível dividir um número por 0.");
                    Console.ReadLine();
                    continue;
                }
                resultado = primeiroNumero / segundoNumero;
            }

                Console.WriteLine("--------------------------");
            Console.WriteLine("Resultado: " + resultado.ToString("F2")); // floating points = 2
            Console.WriteLine("--------------------------");

            Console.WriteLine("Deseja continuar? (S/N)");
            string opcaoContinuar = Console.ReadLine().ToUpper();

            if (opcaoContinuar != "S")
                break;
            
            Console.ReadLine();
        }
    }

        
}