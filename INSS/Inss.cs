using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    public class Inss
    {
        public decimal FaixaInicial { get; set; }
        public decimal FaixaFinal { get; set; }
        public int Aliquota { get; set; }
        public int Ano { get; set; }
        public decimal ValorTeto { get; set; }
    }
}
