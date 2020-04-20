using System.Collections.Generic;
using System.Linq;

namespace BuscaAcoes.Dominio.Auxiliar.Extensoes
{
    public static class ExtencaoCollection
    {
        public static IList<int> GetIndexesMod(this IList<int> lista, int mod)
        {
            var indexes = new List<int>();
            var multiplicador = 1;

            while(lista.Count - 1 >= mod * multiplicador)
                indexes.Add(lista[mod * multiplicador++]);

            return indexes;
        }

        public static bool Nothing<T>(this IEnumerable<T> lista) =>
            !lista.Any();
    }
}
