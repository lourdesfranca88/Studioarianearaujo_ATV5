using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Studioarianearaujo_ATV5.Models;

namespace Studioarianearaujo_ATV5.Controllers

{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Listar(){

            List<Atendimento> Listagem = Solicitacoes.Listar();

            return View(Listagem);
        }

        public IActionResult Procedimento(){
            return View();
        }

        public IActionResult Solicitar(){
            return View();
        }

        [HttpPost]

        public IActionResult Solicitar(Atendimento atend){

            Solicitacoes.Incluir(atend);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
