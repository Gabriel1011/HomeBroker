using BuscaAcoes.Dominio.Auxiliar.Extensoes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BuscaAcoes.Dominio.Entidades
{
    public class Ativo
    {
        public Ativo()
        {

        }

        public Ativo(string codigo, decimal valorMinimo, decimal valorDesejado, int ordem)
        {
            Codigo = codigo;
            ValorMinimo = valorMinimo;
            ValorDesejado = valorDesejado;
            Ordem = ordem;
        }

        public Ativo(string codigo, string valor, string estatisticas, string link)
        {
            Codigo = codigo;
            Valor = valor;
            Estatisticas = estatisticas;
            Link = link;
        }

        public void AdicionarValores(string valor, string estatisticas, string link)
        {
            Estatisticas = estatisticas;
            Valor = valor;
            Link = link;
        }

        public string Codigo { get; set; }
        public string Valor { get; set; }
        public string Estatisticas { get; set; }
        public decimal ValorDesejado { get; set; }
        public decimal ValorMinimo { get; set; }
        public decimal ValorMerdioPago => ValoresAtivo?.Any() ?? false ? Math.Round(ValoresAtivo.Average(p => p.ValorPago), 2) : 0;
        public string Link { get; set; }
        public int Ordem { get; set; }
        public bool Vermelho => Estatisticas?.Contains("-") ?? false;
        public bool Verde => ((Estatisticas?.Contains("+") ?? false) && Estatisticas?.Split(' ')[0].Remove(0, 1).ToDecimal() > 0);
        public bool Amarelo => ((Estatisticas?.Contains("+") ?? false) && Estatisticas?.Split(' ')[0].Remove(0, 1).ToDecimal() == 0);
        public bool Comprar => ValorDesejado >= Valor.ToDecimal();
        public int QuantidadeCotas => ValoresAtivo?.Sum(p => p.Quantidade) ?? 0;
        public decimal TotalInvestido => ValoresAtivo?.Sum(p => p.TotalInvestido) ?? 0;
        public List<ValorAtivo> ValoresAtivo { get; set; }
        public void AlterarOrdem(int ordem) => Ordem = ordem;
        public decimal Rentabilidade => ValoresAtivo?.Sum(p => p.Rentabilidade) ?? 0;
        public bool Rentavel => Rentabilidade > 0;
        public decimal Variacao => CalcularVariacao(Convert.ToDecimal(Valor), ValorDesejado);

        private decimal CalcularVariacao(decimal valor, decimal valorDesejado) =>
            ((valor - valorDesejado) / valorDesejado) * 100;
    }
}
