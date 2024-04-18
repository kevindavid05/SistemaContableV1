using Microsoft.AspNetCore.Mvc;
using SistemaContable.AccesoDatos.Repositorio.IRepositorio;

namespace SistemaContable.Areas.Admin.Controllers

[Area("Admin")]
    public class ClienteController : Controller
    {

        private readonly IUnidadTrabajo _unidadTrabajo;

        public ClienteController(IUnidadTrabajo unidadTrabajo)
        {
            _unidadTrabajo = unidadTrabajo;
        }
        public IActionResult Index()
        {
            return View();
        }

        #region API
        [HttpGet]
        public async Task<IActionResult> ObtenerTodos()
        {
            var todos = await _unidadTrabajo.Cliente.ObtenerTodos();
            return Json(new { data = todos });
        }

        #endregion

    }
}
