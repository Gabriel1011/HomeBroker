using BuscaAcoes.Dominio.Auxiliar.Extensoes;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace BuscaAcoes.Infraestrutura.GerarAquivo
{
    public class GerarAquivosIniciais<T> where T : class
    {
        #if DEBUG
                public string CaminhoPasta = @"C:\BuscaAcoesDev";
        #else
                 public string CaminhoPasta = @"C:\BuscaAcoes";
        #endif

        public string ArquivoCadastroAtivos;
        public string ArquivoResumoInvestimento;
        public string ArquivoConfiguracao;

        public string Caminho { get; set; }

        public GerarAquivosIniciais() => CriarRepositorio();

        private async Task CriarRepositorio()
        {
            ArquivoCadastroAtivos = $@"{CaminhoPasta}\CadastroAtivos.json";
            ArquivoResumoInvestimento = $@"{CaminhoPasta}\ResumoInvestimento.json";
            ArquivoConfiguracao = $@"{CaminhoPasta}\Configuracoes.json";

            await CaminhoPasta.CheckAndCreateDirectory();
            await ArquivoCadastroAtivos.CheckAndCreateFile();
            await ArquivoResumoInvestimento.CheckAndCreateFile();
            await ArquivoConfiguracao.CheckAndCreateFile();
        }


        public async Task<IList<T>> ObterLista()
        {
            using (StreamReader fs = new StreamReader(new FileStream(Caminho, FileMode.Open, FileAccess.Read)))
                return JsonConvert.DeserializeObject<List<T>>(fs.ReadToEnd()) ?? new List<T>();
        }

        public void GerarJsonLista(IList<T> objeto)
        {
            using (StreamWriter fs = new StreamWriter(new FileStream(Caminho, FileMode.Create, FileAccess.Write)))
                fs.Write(JsonConvert.SerializeObject(objeto, Formatting.Indented));
        }

        public async Task<T> Obter()
        {
            using (StreamReader fs = new StreamReader(new FileStream(Caminho, FileMode.Open, FileAccess.Read)))
                return JsonConvert.DeserializeObject<T>(fs.ReadToEnd());
        }

        public async Task GerarJsons(T objeto)
        {
            using (StreamWriter fs = new StreamWriter(new FileStream(Caminho, FileMode.Create, FileAccess.Write)))
                new JsonSerializer().Serialize(fs, objeto);
        }
    }
}
