using API.Infraestructure;
using API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository
{

    public class CategoriaRepository 
    {
        private readonly CatalogoDbContext dbContext;
        public CategoriaRepository(CatalogoDbContext dbContext) => this.dbContext = dbContext;

        public int CreateCategoria(Categoria DatosCategoria)
        {
            dbContext.Categoria.Add(DatosCategoria);
            dbContext.SaveChanges();
            return DatosCategoria.IdCategoria;
        }
        public ICollection<int> CreateCategoria(ICollection<Categoria> DatosCategoria)
        {
            dbContext.Categoria.AddRange(DatosCategoria);
            dbContext.SaveChanges();
            return DatosCategoria.Select(x => x.IdCategoria).ToList();
        }

        public Categoria UpdateCategoria(Categoria DatosCategoria)
        {
            Categoria categoria = getCategoria(DatosCategoria.IdCategoria);
            categoria.Nombre = DatosCategoria.Nombre;
            dbContext.SaveChanges();
            return categoria;
        }
        public ICollection<Categoria> UpdateCategoria(ICollection<Categoria> DatosCategoria)
        {
            List<Categoria> lstCategoria = dbContext.Categoria.Where(x => DatosCategoria.Select(y => y.IdCategoria).ToList().Contains(x.IdCategoria)).ToList();
            lstCategoria.ForEach(x =>
            {
                x.Nombre = DatosCategoria.Where(i => i.IdCategoria == x.IdCategoria).Select(n => n.Nombre).FirstOrDefault();
            });
            dbContext.SaveChanges();
            return DatosCategoria;
        }
        public bool DeleteCategoria(int Id)
        {
            dbContext.Remove(getCategoria(Id));
            dbContext.SaveChanges();
            return true;
        }


        public bool ExisteCategoria(string Nombre) => dbContext.Categoria.Any(x => x.Nombre == Nombre);

        public Categoria getCategoria(int IdCategoria) => dbContext.Categoria.Where(x => x.IdCategoria == IdCategoria).FirstOrDefault();
        public ICollection<Categoria> getCategorias() => dbContext.Categoria.Where(x => x.Activo).ToList();

    }
}
