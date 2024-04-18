using SistemaContable.AccesoDatos.Data;
using SistemaContable.AccesoDatos.Repositorio.IRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaContable.AccesoDatos.Repositorio
{
    public class UnidadTrabajo : IUnidadTrabajo
    {

        private readonly ApplicationDbContext _db;

        public IClienteRepositorio Cliente { get; private set; }

        public UnidadTrabajo(ApplicationDbContext db)
        {
            _db = db;
            Cliente = new ClienteRepositorio(_db);
        }
      //  public IClienteRepositorio Cliente => throw new NotImplementedException();

        public void Dispose()
        {
            _db.Dispose();
        }

        public async Task Guardar()
        {
            await _db.SaveChangesAsync();
        }
    }
}
