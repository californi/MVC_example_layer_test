using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyProjectMVC.Models;
using MyProjectMVC.Models.ViewModels;

namespace MyProjectMVC.Controllers
{
    public class CursosController : Controller
    {
        // GET: Cursos/Random
        public ActionResult Random()
        {
            var curso = new Curso() { Nome = "ADS" };
            var miniCursos = new List<MiniCurso>
            {
                new MiniCurso { Nome = "Teste de Software" },
                new MiniCurso { Nome = "Padrões de Projetos" }
            };

            var viewModel = new MeuMiniCursoViewModel()
            {
                Curso = curso,
                MiniCursos = miniCursos
            };
            
            return View(viewModel);

            //return View(curso);
            //return Content("Na DW2 só tem bom aluno...");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home");
        }

        public ActionResult Edit(int id) {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string SortBy) {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(SortBy))
                SortBy = "Nome";

            return Content(String.Format("PageIndex={0}&sortBy={1}", pageIndex, SortBy));
        }

        public ActionResult PorNivel(int ano, int semestre) {
            return Content(ano + "/" + semestre);
        }

    }
}