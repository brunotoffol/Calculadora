internal class Program
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
            Console.WriteLine("S - Sair");

            Console.WriteLine("Escolha uma opção: ");

            string opcao = Console.ReadLine().ToUpper(); // converte para maiúsculo        

            //estrutura de decisão
            if (opcao == "S")
            {
                break;
            }

            Console.Write("Digite o primeiro número: ");
            string primeiroNumeroString = Console.ReadLine();
            int primeiroNumero = Convert.ToInt32(primeiroNumeroString);

            Console.Write("Digite o segundo número: ");
            string segundoNumeroString = Console.ReadLine();
            int segundoNumero = Convert.ToInt32(segundoNumeroString);

            int resultado = 0;

            if (opcao == "1")
            {
                resultado = primeiroNumero + segundoNumero;
            }

            else
            {
                resultado = primeiroNumero - segundoNumero;
            }

            Console.WriteLine("--------------------------");
            Console.WriteLine("Resultado: " + resultado);
            Console.WriteLine("--------------------------");

            Console.WriteLine("Deseja continuar? (S/N)");
            string opcaoContinuar = Console.ReadLine().ToUpper();

            if (opcaoContinuar != "S")
            {
                break;
            }



            Console.ReadLine();
        }
    }

        
}