using Microsoft.AspNetCore.Mvc;
using trabalhoClientes.Context;

namespace trabalhoClientes.Controllers
{
    public class CadastroController : Controller
    {
        private readonly AppCont _appCont;

        public CadastroController(AppCont appCont)
        {
            _appCont = appCont;
        }
        public IActionResult Index()
        {   
            var alltasks = _appCont.Clientes.ToList();
            return View(alltasks);
        }
    }
}