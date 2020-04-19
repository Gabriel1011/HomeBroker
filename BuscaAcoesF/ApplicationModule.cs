using AutoMapper;
using BuscaAcoes.Dominio.Auxiliar;
using BuscaAcoes.Dominio.Auxiliar.Notificacoes;
using BuscaAcoes.Dominio.Interfaces.Repositorios;
using BuscaAcoes.Dominio.Interfaces.Servicos;
using BuscaAcoes.Dominio.Servicos;
using BuscaAcoes.Infraestrutura.Dados;
using BuscaAcoes.Infraestrutura.GerarAquivo;
using HomeBroker.Configuracoes;
using Ninject.Modules;

namespace BuscaAcoesF
{
    public class ApplicationModule : NinjectModule
    {
        public override void Load()
        {
            var mapperConfiguration = new MapperConfiguration(cfg => { cfg.AddProfile<DtoParaDominio>(); });
            this.Bind<IMapper>().ToConstructor(c => new Mapper(mapperConfiguration)).InSingletonScope();

            Bind(typeof(GerarAquivosIniciais<>)).To(typeof(GerarAquivosIniciais<>));


            Bind<IServicoAtivo>().To<ServicoAtivo>();
            Bind<IServicoResumoInvestimento>().To<ServicoResumoInvestimento>();
            Bind<IServicoConfiguracao>().To<ServicoConfiguracao>();

            Bind<IRepositorioAtivo>().To<RepositorioAtivo>();
            Bind<IRepositorioResumoInvestimento>().To<RepositorioResumoInvestimento>();
            Bind<IRepositorioConfiguracao>().To<RepositorioConfiguracao>();

            Bind<INotificador>().To<Notificador>().InSingletonScope();
            Bind<ConfiguracoesSistema>().To<ConfiguracoesSistema>().InSingletonScope();

            //Bind<GerarAquivosIniciais>().To<GerarAquivosIniciais>();
        }
    }
}
