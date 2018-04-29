using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web_teste.lib;
using web_teste.Models;

namespace web_teste.Controllers
{
    public class AplicacaoController : Controller
    {
        static Conteudo conteudo = new Conteudo();

        // GET: Criptografar
        public ActionResult Criptografar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Criptografar(string texto)
        {
            Criptografar cp = new Criptografar();
            conteudo.Texto = texto;

            conteudo.CriptografiaVigenere = conteudo.CriptografarConteudo(cp);

            return View(conteudo);
        }

        public ActionResult Descriptografar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Descriptografar(string texto)
        {
            Descriptografar desc = new Descriptografar();
            conteudo.CriptografiaVigenere = texto;

            conteudo.DescriptografarConteudo(desc);

            return View(conteudo);
        }
    }
}