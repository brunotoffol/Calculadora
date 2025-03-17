namespace Calculadora.ConsoleApp
{
    public static class Calculadora // C# assume que tudo é privado por default
    {
        //atributos de classe
        static string[] historicoOperacoes = new string[100];
        static int contadorHistorico = 0;
        public static decimal Somar(decimal primeiroNumero, decimal segundoNumero)
        {
            decimal resultado = primeiroNumero + segundoNumero;

            historicoOperacoes[contadorHistorico] = $"{primeiroNumero} + {segundoNumero} = {resultado}";

            contadorHistorico += 1;

            return resultado;
        }
        public static decimal Subtrair(decimal primeiroNumero, decimal segundoNumero)
        {
            decimal resultado = primeiroNumero - segundoNumero;
            historicoOperacoes[contadorHistorico] = $"{primeiroNumero} - {segundoNumero} = {resultado}";

            contadorHistorico += 1;

            return resultado;
        }
        public static decimal Multiplicar(decimal primeiroNumero, decimal segundoNumero)
        {
            decimal resultado = primeiroNumero * segundoNumero;

            historicoOperacoes[contadorHistorico] = $"{primeiroNumero} * {segundoNumero} = {resultado}";

            contadorHistorico += 1;
            
            return resultado;
        }
        public static decimal Dividir(decimal primeiroNumero, decimal segundoNumero)
        {
            decimal resultado = primeiroNumero / segundoNumero;
            
            historicoOperacoes[contadorHistorico] = $"{primeiroNumero} / {segundoNumero} = {resultado}";

            contadorHistorico += 1;

            return resultado;
        }
        public static string[] GerarTabuada(int numeroTabuada)
        {
            string[] linhasTabuadas = new string[10];
            
            for (int contador = 1; contador <= 10; contador++)
            {
                int resultadoTabuada = numeroTabuada * contador;
                //interpolação de string com variaveis
                linhasTabuadas[contador - 1] = $"{numeroTabuada} x {contador} = {resultadoTabuada}";
            }

            return linhasTabuadas;
        }
        public static string[] ObterHistoricoDeOperacacoes()
        {
            return historicoOperacoes;
        }
    }
}
