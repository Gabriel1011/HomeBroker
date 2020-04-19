using AutoMapper;

namespace HomeBroker.Configuracoes
{
    public sealed class AutoMapperConfig
    {
        private static readonly AutoMapperConfig Instance = new AutoMapperConfig();

        private readonly MapperConfiguration mapperConfiguration;

        public readonly Mapper Mapper;

        public AutoMapperConfig()
        {
            mapperConfiguration = new MapperConfiguration(cfg => { cfg.AddProfile<DtoParaDominio>(); });

            Mapper = new Mapper(mapperConfiguration);
        }

        public static AutoMapperConfig GetMapper() => Instance;
    }
}
