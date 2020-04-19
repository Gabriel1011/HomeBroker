using Flunt.Notifications;
using System.Collections.Generic;
using System.Linq;

namespace BuscaAcoes.Dominio.Dtos.Base
{
    public class DtoBase : Notifiable
    {
        public bool Valido => Valid;
        public IList<string> Notificacoes => Notifications.Select(p => p.Message).ToList();
    }
}
