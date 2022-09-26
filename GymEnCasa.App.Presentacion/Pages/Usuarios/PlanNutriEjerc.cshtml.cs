using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GymEnCasa.App.Presentacion.Pages
{
    public class PlanNutriEjercModel : PageModel
    {
        public void OnGet()
        {
        }
         void IrEjercNutri()
        {
            Console.WriteLine("Seleccionó Ir");
        }
    }
}
