using System;

namespace BuscaAcoes.Dominio.Auxiliar.Extensoes
{
    public static class ExtencaoString
    {
        public static decimal ToDecimal(this String texto) => Convert.ToDecimal(texto);

        public static string RemoveFirst(this String texto) => texto.Remove(0);
    }
}
