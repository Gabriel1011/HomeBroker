using BuscaAcoes.Dominio.Auxiliar.Extensoes;
using System;

namespace BuscaAcoes.Dominio.Entidades
{
    public class ValorAtivo
    {
        public ValorAtivo(int quantidade, decimal valorPago, int numeroCompra)
        {
            Quantidade = quantidade;
            ValorPago = valorPago;
            NumeroCompra = numeroCompra;
            DataCompra = DateTime.Now;
        }

        public void AdicionarValor(string valor) => Valor = valor;
        public int NumeroCompra { get; set; }
        public string Valor { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorPago { get; set; }
        public DateTime DataCompra { get; set; }
        public decimal TotalInvestido => ValorPago * Quantidade;
        public decimal Rentabilidade => (Valor.ToDecimal() * Quantidade) - (ValorPago * Quantidade);
    }
}
