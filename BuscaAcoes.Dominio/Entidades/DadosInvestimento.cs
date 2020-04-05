using System;
using System.Collections.Generic;
using System.Text;

namespace BuscaAcoes.Dominio.Entidades
{
    public class DadosInvestimento
    {
        public string AtivoMaisRentavel { get; set; }
        public string AtivoMenosRentavel { get; set; }
        public decimal TotalGanho{ get; set; }
        public decimal TotalPerdido { get; set; }
        public decimal TotalRentabilidade { get; set; }
        public decimal TotalInvestimento { get; set; }
        public string PossiveisCompras { get; set; }
        public decimal TotalRetorno => TotalInvestimento + TotalRentabilidade;
    }
}
