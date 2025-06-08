using EcoAlert.Application.Dtos;
using EcoAlert.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EcoAlert.Controllers.Web
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
    }
}
