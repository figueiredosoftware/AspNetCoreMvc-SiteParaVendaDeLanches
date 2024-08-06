using LanchesMac.Migrations;
using LanchesMac.Repositories.Interfaces;
using LanchesMac.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class MulhoController : Controller
    {
        private readonly IMulhoRepository _mulhoRepository;

        public MulhoController(IMulhoRepository mulhoRepository)
        {
            _mulhoRepository = mulhoRepository;
        }

        public IActionResult ListaDeMulhos()
        {
            //var mulhos = _mulhoRepository.Mulhos;
            var mulhosListaViewModel = new MulhosListaViewModel();
            mulhosListaViewModel.Mulhos = _mulhoRepository.Mulhos;
            mulhosListaViewModel.CategoriaAtual = "Categoria Atual";

            ViewBag.TituloMolhos = "Lista de Molhos :";
            TempData["Nome"] = "Alessandro Figueiredo";
            ViewData["Data2"] = DateTime.Now;
            ViewBag.TituloTotalDeMolhos = "Total de Molhos : ";
            ViewBag.TotalDeMolhos = mulhosListaViewModel.Mulhos.Count();


            return View(mulhosListaViewModel);
        }
    }
}
