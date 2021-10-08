using System;

namespace INSS
{
    class Program
    {
        static void Main(string[] args)
        {
            var calcular = new CalculadorInss();
            decimal salario;
            DateTime data;
            Console.WriteLine("Informe o salário:");

            salario = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe a data no formato dd/MM/yyyy (Ano 2011 ou 2012):");

            data = DateTime.Parse(Console.ReadLine());

            var resultado = calcular.CalcularDesconto(data, salario);
            Console.WriteLine("Desconto de INSS de acordo com a tabela {0}: {1}", data.Year, resultado.ToString("N2"));
            Console.ReadLine();
        }
    }
}
