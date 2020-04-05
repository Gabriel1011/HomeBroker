using System;
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
    }
}
