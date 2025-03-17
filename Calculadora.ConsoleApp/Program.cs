namespace Calculadora.ConsoleApp;
internal class Program
{
    static string[] historicoOperacoes = new string[100];
    static int contadorHistorico = 0;
    private static void Main(string[] args)
    {
        while (true) // enquanto
        {
            //Exibe o Menu e redireciona para a operação selecionada
            string opcao = ExibirMenu();

            //estrutura de decisão
            if (OpcaoSairFoiEscolhida(opcao) == true)
                break;

            else if (OpcaoTabuadaFoiEscolhida(opcao))
                ExibirTabuada();

            else if (OpcaoHistoricoFoiEscolhida(opcao))
                ExibirHistoricoDeOperacoes();

            else
            {
                //operações e avaliações              
                ExibirResultado(RealizarCalculo(opcao));
            }

        }
    }

    //metodo para ExibirMenu, precisa retornar o valor que o usuário digitou
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

        
        //variável opcao não precisa necessariamente ter este nome
        string opcao = Console.ReadLine()!.ToUpper();

        return opcao;
    }
    static bool OpcaoSairFoiEscolhida(string opcao)
    {
        bool opcaoSairFoiEscolhida = opcao == "S";

        return opcaoSairFoiEscolhida;
    }
    static bool OpcaoTabuadaFoiEscolhida (string opcao)
    {
        bool opcaoTabuadaFoiEscolhida = opcao == "5";

        return opcaoTabuadaFoiEscolhida;
    }
    static void ExibirTabuada()
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
        Console.WriteLine("--------------------------");
        Console.WriteLine("Aperte ENTER para continuar");
        Console.WriteLine("--------------------------");
        Console.ReadLine();

    }
    static bool OpcaoHistoricoFoiEscolhida(string opcao)
    {
        bool opcaoHistoricoFoiEscolhida = opcao == "6";

        return opcaoHistoricoFoiEscolhida;

    }
    static void ExibirHistoricoDeOperacoes()
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
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Aperte Enter para continuar");
        Console.ReadLine();
    }
    static decimal RealizarCalculo(string operacao)
    {
        Console.Write("Digite o primeiro número: ");        
        decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Digite o segundo número: ");        
        decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

        decimal resultado = 0;

        if (operacao == "1")
        {
            resultado = Calculadora.Somar(primeiroNumero, segundoNumero);
            historicoOperacoes[contadorHistorico] = $"{primeiroNumero} + {segundoNumero} = {resultado}";            
        }

        else if (operacao == "2")
        {
            resultado = Calculadora.Subtrair(primeiroNumero, segundoNumero);
            historicoOperacoes[contadorHistorico] = $"{primeiroNumero} - {segundoNumero} = {resultado}";
        }
        else if (operacao == "3")
        {
            resultado = Calculadora.Multiplicar(primeiroNumero, segundoNumero);
            historicoOperacoes[contadorHistorico] = $"{primeiroNumero} * {segundoNumero} = {resultado}";
        }
        else if (operacao == "4")
        {

            if (segundoNumero == 0)
            {
                Console.WriteLine("Não é possível dividir um número por 0.");                
                segundoNumero = Convert.ToDecimal(Console.ReadLine());
            }
            resultado = Calculadora.Dividir(primeiroNumero, segundoNumero);
            historicoOperacoes[contadorHistorico] = $"{primeiroNumero} / {segundoNumero} = {resultado}";

        }
        contadorHistorico += 1;

        return resultado;
    }
    static void ExibirResultado(decimal resultado)
    {
        Console.WriteLine("--------------------------");
        Console.WriteLine("Resultado: " + resultado.ToString("F2")); // floating points = 2
        Console.WriteLine("--------------------------");
        Console.WriteLine("Aperte ENTER para continuar");
        Console.WriteLine("--------------------------");

        Console.ReadLine();
    }
}