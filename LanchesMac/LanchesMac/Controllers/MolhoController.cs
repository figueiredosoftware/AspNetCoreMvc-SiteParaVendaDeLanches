using LanchesMac.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class MolhoController : Controller
    {
        private readonly IMolhoRepository _molhoRepository;

        public MolhoController(IMolhoRepository molhoRepository)
        {
            _molhoRepository = molhoRepository;
        }

        public IActionResult ListaDeMolhos()
        {
            var molhos = _molhoRepository.Molhos;
            var totalDeMolhos = molhos.Count();

            ViewBag.TituloMolhos = "Lista de Molhos :";
            ViewBag.TituloTotalDeMolhos = "Total de Molhos : ";
            ViewBag.TotalDeMolhos = totalDeMolhos;
            ViewBag.Data = DateTime.Now;
            ViewData["Data2"] = DateTime.Now;
            TempData["Nome"] = "Alessandro Figueiredo";

            return View(molhos);
        }
    }
}
