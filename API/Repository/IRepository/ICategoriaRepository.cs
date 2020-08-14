using API.Model;
using System.Collections.Generic;

namespace API.Repository.IRepository
{
    public interface ICategoriaRepository
    {
        int CreateCategoria(Categoria DatosCategoria);
        ICollection<int> CreateCategoria(ICollection<Categoria> DatosCategoria);
        Categoria UpdateCategoria(Categoria DatosCategoria);
        ICollection<Categoria> UpdateCategoria(ICollection<Categoria> DatosCategoria);
        bool DeleteCategoria(int Id);
        bool ExisteCategoria(string Nombre);
        Categoria getCategoria(int IdCategoria);
        ICollection<Categoria> getCategorias();
    }
}
