using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace calculadora1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        // Propiedades para los números y el resultado
        [BindProperty]
        public double Numero1 { get; set; }

        [BindProperty]
        public double Numero2 { get; set; }

        [BindProperty]
        public string Operacion { get; set; }

        public string Resultado { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            try
            {
                switch (Operacion)
                {
                    case "Suma":
                        Resultado = (Numero1 + Numero2).ToString();
                        break;
                    case "Multiplicacion":
                        Resultado = (Numero1 * Numero2).ToString();
                        break;
                    default:
                        Resultado = "Operación no válida.";
                        break;
                }
            }
            catch (Exception ex)
            {
                Resultado = "Error: " + ex.Message;
            }
        }
    }
}
