using System.Collections.Generic;

namespace BuscaAcoes.Dominio.Auxiliar.Extensoes
{
    public static class ExtencaoList
    {
        public static IList<int> GetIndexesMod(this IList<int> lista, int mod)
        {
            var indexes = new List<int>();
            var multiplicador = 1;

            while(lista.Count - 1 > mod * multiplicador)
                indexes.Add(lista[mod * multiplicador++]);

            return indexes;
        }
    }
}
