using API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository.IRepository
{
    public interface IMarcaRepository
    {
        int CreateCategoria(Marca DatosCategoria);
        ICollection<int> CreateCategoria(ICollection<Marca> DatosCategoria);
        Marca UpdateCategoria(Marca DatosCategoria);
        ICollection<Marca> UpdateCategoria(ICollection<Marca> DatosCategoria);
        bool DeleteCategoria(int Id);
        bool ExisteCategoria(string Nombre);
        bool ExisteCategoria(int IdMarca);
        Marca getCategoria(int IdCategoria);
        ICollection<Marca> getCategoria();
    }
}
