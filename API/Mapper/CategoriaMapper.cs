using API.DTO;
using API.Model;
using AutoMapper;

namespace API.Mapper
{
    public class CategoriaMapper : Profile
    {
        public CategoriaMapper()
        {
            CreateMap<Categoria, CategoriaDTO>().ReverseMap();
            CreateMap<Marca, MarcaDTO>().ReverseMap();
        }
    }
}
