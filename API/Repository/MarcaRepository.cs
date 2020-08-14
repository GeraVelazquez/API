using API.Infraestructure;
using API.Model;
using API.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository
{
    public class MarcaRepository : IMarcaRepository
    {
        private readonly CatalogoDbContext dbContext;
        public MarcaRepository(CatalogoDbContext dbContext) => this.dbContext = dbContext;

        public int CreateCategoria(Marca DatosCategoria)
        {
            throw new NotImplementedException();
        }

        public ICollection<int> CreateCategoria(ICollection<Marca> DatosCategoria)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCategoria(int Id)
        {
            throw new NotImplementedException();
        }

        public bool ExisteCategoria(string Nombre)
        {
            throw new NotImplementedException();
        }

        public bool ExisteCategoria(int IdMarca)
        {
            throw new NotImplementedException();
        }

        public Marca getCategoria(int IdCategoria)
        {
            throw new NotImplementedException();
        }

        public ICollection<Marca> getCategoria()
        {
            throw new NotImplementedException();
        }

        public Marca UpdateCategoria(Marca DatosCategoria)
        {
            throw new NotImplementedException();
        }

        public ICollection<Marca> UpdateCategoria(ICollection<Marca> DatosCategoria)
        {
            throw new NotImplementedException();
        }
    }
}
