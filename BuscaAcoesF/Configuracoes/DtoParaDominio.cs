using AutoMapper;
using BuscaAcoes.Dominio.Dtos;
using BuscaAcoes.Dominio.Entidades;

namespace HomeBroker.Configuracoes
{
    public class DtoParaDominio  : Profile
    {
        public DtoParaDominio()
        {
            CreateMap<ConfiguracaoDto, Configuracao>();
        }
    }
}
