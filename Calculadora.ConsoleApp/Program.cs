internal class Program
{
    private static void Main(string[] args)
    {        
        string[] historicoOperacoes = new string[100];
        int contadorHistorico = 0;

        while (true) // enquanto
        {

            //Exibe o Menu e redireciona para a operação selecionada
            string opcao = ExibirMenu();                 

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

            else if(opcao == "6")
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Histórico de Operações");
                Console.WriteLine("-------------------------------");
                
                for (int contador = 0; contador < historicoOperacoes.Length; contador++)
                {
                    string valorAtual = historicoOperacoes[contador];
                    if (valorAtual != null)
                    Console.WriteLine(valorAtual);
                }
                Console.WriteLine("Aperte Enter para continuar");
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
                historicoOperacoes[contadorHistorico] = $"{primeiroNumero} + {segundoNumero} = {resultado}";
                contadorHistorico += 1;
            }

            else if (opcao == "2")
            {
                resultado = primeiroNumero - segundoNumero;
                historicoOperacoes[contadorHistorico] = $"{primeiroNumero} - {segundoNumero} = {resultado}";
            }
            else if (opcao == "3")
            {
                resultado = primeiroNumero * segundoNumero;
                historicoOperacoes[contadorHistorico] = $"{primeiroNumero} * {segundoNumero} = {resultado}";
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
                historicoOperacoes[contadorHistorico] = $"{primeiroNumero} / {segundoNumero} = {resultado}";
            }

            contadorHistorico += 1;

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

    static string ExibirMenu()
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
        Console.WriteLine("6 - Histórico de Operações");
        Console.WriteLine("S - Sair");

        Console.WriteLine("Escolha uma opção: ");

        string opcao = Console.ReadLine()!.ToUpper();

        return opcao;
    }
        
}