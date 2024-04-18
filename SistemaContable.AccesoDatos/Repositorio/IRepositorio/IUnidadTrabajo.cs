using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaContable.AccesoDatos.Repositorio.IRepositorio
{
    public interface IUnidadTrabajo : IDisposable 
    {
        IClienteRepositorio Cliente { get; }

        Task Guardar();
    }
}
