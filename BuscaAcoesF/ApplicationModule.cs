using BuscaAcoes.Dominio.Interfaces.Repositorios;
using BuscaAcoes.Dominio.Interfaces.Servicos;
using BuscaAcoes.Dominio.Servicos;
using BuscaAcoes.Infraestrutura.Dados;
using BuscaAcoes.Infraestrutura.GerarAquivo;
using Ninject.Modules;

namespace BuscaAcoesF
{
    public class ApplicationModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(GerarAquivosIniciais<>)).To(typeof(GerarAquivosIniciais<>));

            Bind<IRepositorioAtivo>().To<RepositorioAtivo>();
            Bind<IRepositorioResumoInvestimento>().To<RepositorioResumoInvestimento>();
            Bind<IServicoAtivo>().To<ServicoAtivo>();
            Bind<IServicoResumoInvestimento>().To<ServicoResumoInvestimento>();
            //Bind<GerarAquivosIniciais>().To<GerarAquivosIniciais>();
        }
    }
}
