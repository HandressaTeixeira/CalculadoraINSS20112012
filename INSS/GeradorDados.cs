using System.Collections.Generic;

namespace INSS
{
    public static class GeradorDados
    {
        public static List<Inss> ListarInss()
        {
            List<Inss> lista = new List<Inss>
            {
                new Inss
                {
                    Ano = 2011,
                    Aliquota = 8,
                    FaixaInicial = 0,
                    FaixaFinal = 1106.90M
                },  new Inss
                {
                    Ano = 2011,
                    Aliquota = 9,
                    FaixaInicial = 1106.91M,
                    FaixaFinal = 1844.83M
                },
                new Inss
                {
                    Ano = 2011,
                    Aliquota = 11,
                    FaixaInicial = 1844.83M,
                    FaixaFinal = 3689.66M
                },
                new Inss
                {
                    Ano = 2011,
                    FaixaInicial = 3689.67M,
                    FaixaFinal = decimal.MaxValue,
                    ValorTeto = 405.86M
                },

                new Inss
                {
                    Ano = 2012,
                    Aliquota = 7,
                    FaixaInicial = 0,
                    FaixaFinal = 1000.00M
                },
                new Inss
                {
                    Ano = 2012,
                    Aliquota = 8,
                    FaixaInicial = 1000.01M,
                    FaixaFinal = 1500.00M
                },
                new Inss
                {
                    Ano = 2012,
                    Aliquota = 9,
                    FaixaInicial = 1500.01M,
                    FaixaFinal = 3000.00M
                },
                new Inss
                {
                    Ano = 2012,
                    Aliquota = 11,
                    FaixaInicial = 3000.01M,
                    FaixaFinal = 4000.00M
                },
                new Inss
                {
                    Ano = 2012,
                    FaixaInicial = 4000.01M,
                    FaixaFinal = decimal.MaxValue,
                    ValorTeto = 500.00M
                }
            };


            return lista;
        }
    }
}
