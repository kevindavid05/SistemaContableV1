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
        private readonly ApplicationDbContext _db;

        public ClienteRepositorio(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Actualizar(Cliente cliente)
        {
            var clienteBD = _db.Clientes.FirstOrDefault(b => b.ClId == cliente.ClId);
            if (clienteBD !=null)
            {
                clienteBD.Clnombre = cliente.Clnombre; 
                clienteBD.Cldireccion = cliente.Cldireccion;    
                clienteBD.Clemail = cliente.Clemail;
                clienteBD.Clnit = cliente.Clnit;
                clienteBD.Cltelefono = cliente.Cltelefono;
                _db.SaveChanges();
                
            }

        }
    }
}
