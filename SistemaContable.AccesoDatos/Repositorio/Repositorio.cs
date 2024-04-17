using Microsoft.EntityFrameworkCore;
using SistemaContable.AccesoDatos.Data;
using SistemaContable.AccesoDatos.Repositorio.IRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SistemaContable.AccesoDatos.Repositorio
{
    public class Repositorio<T> : IRepositorio<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> dbSeT;

        public Repositorio(ApplicationDbContext db)
        {
            _db = db;
            this.dbSeT = _db.Set<T>();

        }
        public async Task Agregar(T entidad)
        {
            await dbSeT.AddAsync(entidad);
        }

        public async Task<T> Obtener(int id)
        {
            return await dbSeT.FindAsync(id);
        }


        public async Task<IEnumerable<T>> ObtenerTodos(Expression<Func<T, bool>> filtro = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string incluirPropiedades = null, bool isTracking = true)
        {
            IQueryable<T> query = dbSeT;
            if (filtro != null)
            {
                query = query.Where(filtro);
            }

            if (incluirPropiedades != null)
            {
                foreach  (var incluirProp in incluirPropiedades.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(incluirProp);
                }
            }
            if (orderBy != null)
               {
                query = orderBy(query);
            }
            if (!isTracking)
            {
                query = query.AsNoTracking();
            }
            return await query.ToListAsync();

        }

        public async Task<T> ObtenerPrimero(Expression<Func<T, bool>> filtro = null, string incluirPropiedades = null, bool isTracking = true)
        {
            IQueryable<T> query = dbSeT;
            if (filtro != null)
            {
                query = query.Where(filtro);
            }

            if (incluirPropiedades != null)
            {
                foreach (var incluirProp in incluirPropiedades.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(incluirProp);
                }
            }

            if (!isTracking)
            {
                query = query.AsNoTracking();
            }
            return await query.FirstOrDefaultAsync();
        }

        public void Remover(T entidad)
        {
            dbSeT.Remove(entidad);
        }

        public void RemoverRango(IEnumerable<T> entidad)
        {
            dbSeT.RemoveRange(entidad);
        }
    }
}
