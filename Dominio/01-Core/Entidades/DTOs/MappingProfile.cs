using AutoMapper;
using Dominio._01_Core.Entidades.DTOs.Veiculos;
using Dominio.Entidades;

namespace TrabalhoFinal._03_Entidades.DTOs
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateCarroDTO, Carro>().ReverseMap();
        }
    }
}
