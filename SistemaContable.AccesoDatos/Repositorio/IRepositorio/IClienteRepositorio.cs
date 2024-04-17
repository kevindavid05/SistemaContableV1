using SistemaContable.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaContable.AccesoDatos.Repositorio.IRepositorio
{
    internal interface IClienteRepositorio : IRepositorio<Cliente>
    {
        void Actualizar(Cliente Icliente);
    }
}
