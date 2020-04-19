using System;
using System.Collections.Generic;
using System.Text;

namespace BuscaAcoes.Dominio.Entidades
{
    public class Configuracao
    {
        public bool ModoDesenvolvimento { get; set; }
        public int TempoAtualizacaoDados { get; set; }
        public string NomeUsuario { get; set; }
        public string MensagemErroOrigem { get; set; }
        public string HoraInicioAtualizacaoDados { get; set; }
        public string HoraFimAtualizacaoDados { get; set; }
        public int PorcentagemVariavao { get; set; }
    }
}
