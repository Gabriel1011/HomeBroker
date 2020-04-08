using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace BuscaAcoes.Dominio.Auxiliar.Extensoes
{
    public static class ExtencaoString
    {
        public static decimal ToDecimal(this string texto) => Convert.ToDecimal(texto);

        public static string RemoveFirst(this string texto) => texto.Remove(0);

        public static async Task CheckAndCreateDirectory(this string caminho) =>
            await Task.Run(() => { if (!Directory.Exists(caminho)) Directory.CreateDirectory(caminho); });

        public static async Task CheckAndCreateFile(this string caminho) =>
           await Task.Run(() => { if (!File.Exists(caminho)) File.Create(caminho); });


        public static async Task<IList<int>> IndexesOf(this string texto, char caracter) =>
            await ObterIndices(texto, caracter, 0);

        public static async Task<string> Inserts(this string texto, IList<int> indexes, string insertTexto)
        {
            foreach (var ind in indexes)
                texto = texto.Insert(ind, insertTexto);

            return await Task.FromResult(texto);
        }


        private static async Task<IList<int>> ObterIndices(string texto, char caracter, int indiciInicio)
        {
            var inds = new List<int>();

            var ind = texto.IndexOf(caracter, indiciInicio);
            if (ind == -1) return inds;

            inds.Add(ind);
            inds.AddRange(await ObterIndices(texto, caracter, ind + 1));

            return inds;
        }
    }
}
