using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyProjectMVC.Models.ViewModels
{
    public class MeuMiniCursoViewModel
    {
        public Curso Curso { get; set; }
        public List<MiniCurso> MiniCursos { get; set; }
    }
}