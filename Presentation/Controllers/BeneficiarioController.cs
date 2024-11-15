using System.Linq;
using GS_PowerScore.Application.Dtos;
using GS_PowerScore.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GS_PowerScore.Presentation.Controllers
{
    public class BeneficiarioController : Controller
    {
        private readonly IBeneficiarioApplicationService _beneficiarioService;

        public BeneficiarioController(IBeneficiarioApplicationService beneficiarioService)
        {
            _beneficiarioService = beneficiarioService;
        }

        public IActionResult Index()
        {
            var beneficiarios = _beneficiarioService.ObterTodos();
            return View(beneficiarios);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BeneficiarioDto beneficiario)
        {
            if (ModelState.IsValid)
            {
                _beneficiarioService.Adicionar(beneficiario);
                return RedirectToAction(nameof(Index));
            }
            return View(beneficiario);
        }

        public IActionResult Edit(int id)
        {
            var beneficiario = _beneficiarioService.ObterPorId(id);
            if (beneficiario == null)
            {
                return NotFound();
            }
            return View(beneficiario);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(BeneficiarioDto beneficiario)
        {
            if (ModelState.IsValid)
            {
                _beneficiarioService.Atualizar(beneficiario);
                return RedirectToAction(nameof(Index));
            }
            return View(beneficiario);
        }

        public IActionResult Details(int id)
        {
            var beneficiario = _beneficiarioService.ObterPorId(id);
            if (beneficiario == null)
            {
                return NotFound();
            }
            return View(beneficiario);
        }

        public IActionResult Delete(int id)
        {
            var beneficiario = _beneficiarioService.ObterPorId(id);
            if (beneficiario == null)
            {
                return NotFound();
            }
            return View(beneficiario);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _beneficiarioService.Remover(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
