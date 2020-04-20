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
        public decimal ValorCorretagem { get; set; }

        public Configuracao()
        {
            
        }

        public Configuracao(bool modoDesenvolvimento,
            int tempoAtualizacaoDados,
            string nomeUsuario,
            string mensagemErroOrigem,
            string horaInicioAtualizacaoDados,
            string horaFimAtualizacaoDados,
            int porcentagemVariavao, 
            decimal valorCorretagem)
        {
            ModoDesenvolvimento = modoDesenvolvimento;
            TempoAtualizacaoDados = tempoAtualizacaoDados;
            NomeUsuario = nomeUsuario;
            MensagemErroOrigem = mensagemErroOrigem;
            HoraInicioAtualizacaoDados = horaInicioAtualizacaoDados;
            HoraFimAtualizacaoDados = horaFimAtualizacaoDados;
            PorcentagemVariavao = porcentagemVariavao;
            ValorCorretagem = valorCorretagem;
        }


    }
}
