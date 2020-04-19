using System.Collections.Generic;

namespace BuscaAcoes.Dominio.Auxiliar.Notificacoes
{
    public interface INotificador
    {
        bool ErroOrigemDados { get; }

        IList<Notificacao> Notificacoes { get; }

        void AtualizarErroOrigem(bool erro = false);

        void AdicionarNotificacao(Notificacao mensagem);
    }
}
