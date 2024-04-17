using SistemaContable.AccesoDatos.Data;
using SistemaContable.AccesoDatos.Repositorio.IRepositorio;
using SistemaContable.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaContable.AccesoDatos.Repositorio
{
    public class ClienteRepositorio : Repositorio<Cliente>, IClienteRepositorio
    {
        private readonly ApplicationDbContext _db
        public void Actualizar(Cliente Icliente)
        {
            throw new NotImplementedException();
        }
    }
}
