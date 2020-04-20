using System.Collections.Generic;

namespace BuscaAcoes.Dominio.Auxiliar.Notificacoes
{
    public interface INotificador
    {
        bool ErroOrigemDados { get; }

        List<Notificacao> Notificacoes { get; }

        void AtualizarErroOrigem(bool erro = false);

        void AdicionarNotificacao(Notificacao mensagem);

        void AdicionarNotificacoes(IList<Notificacao> mensagem);
    }
}
