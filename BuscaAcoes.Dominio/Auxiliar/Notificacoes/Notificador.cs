using System.Collections.Generic;
using System.Linq;

namespace BuscaAcoes.Dominio.Auxiliar.Notificacoes
{
    public class Notificador : INotificador
    {
        public bool ErroOrigemDados { get; private set; }

        public List<Notificacao> Notificacoes { get; private set; }

        public Notificador()
        {
            Notificacoes = new List<Notificacao>();
        }

        public void AdicionarNotificacao(Notificacao notificacao) =>
            Notificacoes.Add(notificacao);

        public void AdicionarNotificacoes(IList<Notificacao> mensagem) =>
          Notificacoes.AddRange(mensagem);

        public void AtualizarErroOrigem(bool erro = false) => ErroOrigemDados = erro;
    }
}
