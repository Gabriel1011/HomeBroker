using System.Collections.Generic;

namespace BuscaAcoes.Dominio.Auxiliar.Notificacoes
{
    public class Notificador : INotificador
    {
        public bool ErroOrigemDados { get; private set; }

        public IList<Notificacao> Notificacoes { get; private set; }

        public void AdicionarNotificacao(Notificacao notificacao) =>
            Notificacoes.Add(notificacao);

        public void AtualizarErroOrigem(bool erro = false) => ErroOrigemDados = erro;
    }
}
