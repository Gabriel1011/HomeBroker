using System;
using System.Collections.Generic;
using System.Text;

namespace BuscaAcoes.Dominio.Entidades
{
    public class ResumoInvestimento
    {
        public ResumoInvestimento(List<Ativo> ativos, DadosInvestimento dadosInvestimento)
        {
            DataResumo = DateTime.Now;
            Ativos = ativos;
            DadosInvestimento = dadosInvestimento;
        }

        public DateTime DataResumo { get; set; }
        public List<Ativo> Ativos { get; set; }
        public DadosInvestimento DadosInvestimento { get; set; }
    }
}
