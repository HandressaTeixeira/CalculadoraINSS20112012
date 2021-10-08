using System;
using System.Linq;

namespace INSS
{
    public class CalculadorInss : ICalculadorInss
    {
        public decimal CalcularDesconto(DateTime data, decimal salario)
        {
            var listaInss = GeradorDados.ListarInss();

            var inss = listaInss
                .Where(x => x.Ano == data.Year
                && salario >= x.FaixaInicial
                && salario <= x.FaixaFinal).FirstOrDefault();

            return inss.Aliquota == 0 ? inss.ValorTeto : salario * ((decimal)inss.Aliquota / 100);
        }
    }
}
