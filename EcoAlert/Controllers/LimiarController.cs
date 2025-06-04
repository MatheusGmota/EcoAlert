using EcoAlert.Application.Dtos;
using EcoAlert.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EcoAlert.Controllers
{
    public class LimiarController : Controller
    {
        private readonly ILimiarApplication _limiarApplication;

        public LimiarController(ILimiarApplication limiarApplication)
        {
            _limiarApplication = limiarApplication;
        }

        public IActionResult Index()
        {
            var limiares = _limiarApplication.ObterTodos();

            return View(limiares);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.ParametrosSensor = ObterListaParametrosSensor();

            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(LimiarDto model)
        {
            if (ModelState.IsValid)
            {
                _limiarApplication.SalvarDados(model);

                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var limiar = _limiarApplication.ObterPorId(id ?? 0);

            ViewBag.ParametrosSensor = ObterListaParametrosSensor();

            return View(limiar);
        }


        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Edit(LimiarEditDto model)
        {
            if (ModelState.IsValid)
            {
                _limiarApplication.EditarDados(model.Id, model);

                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }


        [HttpGet]
        public IActionResult Delete(int? id)
        {
            var limiar = _limiarApplication.ObterPorId(id ?? 0);

            return View(limiar);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult DeleteForm(int id)
        {
            var limiar = _limiarApplication.DeletarDados(id);

            if (limiar is not null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View();
        }

        private IEnumerable<SelectListItem> ObterListaParametrosSensor()
        {
            return new List<SelectListItem>
            {
                new SelectListItem { Text = "Umidade", Value = "umidade" },
                new SelectListItem { Text = "Temperatura", Value = "temperatura" },
                new SelectListItem { Text = "Nivel Àgua(cm)", Value = "nivelagua" },
                new SelectListItem { Text = "Porcentagem Nivel Àgua", Value = "porcentagemnivel" }
            };
        }

    }
}
