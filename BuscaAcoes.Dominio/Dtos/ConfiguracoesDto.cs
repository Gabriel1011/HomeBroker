using BuscaAcoes.Dominio.Dtos.Base;
using Flunt.Validations;

namespace BuscaAcoes.Dominio.Dtos
{
    public class ConfiguracaoDto : DtoBase
    {
        public bool ModoDesenvolvimento { get; set; }
        public int TempoAtualizacaoDados { get; set; }
        public string NomeUsuario { get; set; }
        public string MensagemErroOrigem { get; set; }
        public string HoraInicioAtualizacaoDados { get; set; }
        public string HoraFimAtualizacaoDados { get; set; }
        public int PorcentagemVariavao { get; set; }
        public decimal ValorCorretagem { get; set; }

        public ConfiguracaoDto(bool modoDesenvolvimento,
            int tempoAtualizacaoDados,
            string nomeUsuario,
            string mensagemErroOrigem,
            string horaInicioAtualizacaoDados,
            string horaFimAtualizacaoDados,
            int porcentagemVariavao, 
            decimal? valorCorretagem)
        {
            ModoDesenvolvimento = modoDesenvolvimento;
            TempoAtualizacaoDados = tempoAtualizacaoDados;
            NomeUsuario = nomeUsuario;
            MensagemErroOrigem = mensagemErroOrigem;
            HoraInicioAtualizacaoDados = horaInicioAtualizacaoDados;
            HoraFimAtualizacaoDados = horaFimAtualizacaoDados;
            PorcentagemVariavao = porcentagemVariavao;
            ValorCorretagem = valorCorretagem ?? 0;

            Validar();
        }


        private void Validar()
        {
            AddNotifications(new Contract()
                            .Requires()
                            .IsGreaterThan(TempoAtualizacaoDados, 0, "", "O tempo de atualização deve ser maior ou igual 1")
                            .IsNotNullOrEmpty(NomeUsuario, "", "Nome do usuário não pode estar em branco")
                            .IsNotNullOrEmpty(MensagemErroOrigem, "", "Mensagem de erro origem não pode estar em branco")
                            .IsNotNullOrEmpty(HoraInicioAtualizacaoDados, "", "Para alterar a hora de monitoramento o campo de início deve ser prenchido")
                            .IsNotNullOrEmpty(HoraFimAtualizacaoDados, "", "Para alterar a hora de monitoramento o campo de final deve ser prenchido")
                            .IsGreaterThan(PorcentagemVariavao, 0, "", "A porcentagem da variação deve ser maior ou igual 1")
                        );
        }
    }
}
