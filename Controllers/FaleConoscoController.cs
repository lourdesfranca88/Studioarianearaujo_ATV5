using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Studioarianearaujo_ATV5.Models;

namespace Studioarianearaujo_ATV5.Controllers
{
    public class FaleConoscoController :Controller
    {
          public IActionResult Lista(){
         
           FaleConoscoRepository falec = new FaleConoscoRepository();
            return View(falec.Listar());
           
        }

        public IActionResult Excluir(int Id){

            FaleConoscoRepository falec = new FaleConoscoRepository();
            FaleConosco comentarioEncontrado = falec.BuscarPorID(Id);
            
            if (comentarioEncontrado.Id>0) {
                falec.remover(comentarioEncontrado);

            } else {

                ViewData["mensagem"] = "Comentario não localizado";

            }

            return RedirectToAction("Lista");
        }

        public IActionResult Inserir(){
           return View();
        }
        [HttpPost]

        public IActionResult Inserir(FaleConosco novoComentario ){

            FaleConoscoRepository falec = new FaleConoscoRepository();
           falec.inserir(novoComentario);

             ViewData["mensagem"] = "Comentario realisado com sucesso";
            return View();
        }

        public IActionResult Alterar(int Id){

            FaleConoscoRepository falec = new FaleConoscoRepository();
            FaleConosco comentarioEncontrado = falec.BuscarPorID(Id);

            return View(comentarioEncontrado);

        }

        [HttpPost]

        public IActionResult Alterar(FaleConosco faleconosco){

            FaleConoscoRepository falec = new FaleConoscoRepository();
            falec.atualizar(faleconosco);

            return RedirectToAction("Lista");
        }
    }
}