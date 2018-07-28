using CaelumEstoque.DAO;
using CaelumEstoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CaelumEstoque.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {
            return View( new ProdutosDAO().Lista() );
        }
        
        public ActionResult Form()
        {
            ViewBag.Categorias = new CategoriasDAO().Lista();
            ViewBag.Produto = new Produto();
            return View();
        }

        [HttpPost]
        public ActionResult Adiciona(Produto produto)
        {
            int catInformatica = 1;
            if(produto.CategoriaId == catInformatica && produto.Preco< 100)
            {
                ModelState.AddModelError("produto.PrecoInformaticaInvalido", "Produtos da Categoria 'Informática' devem ter um valor maior ou igual a 100.00!");
            }

            if (ModelState.IsValid)
            {
                ProdutosDAO dao = new ProdutosDAO();
                dao.Adiciona(produto);

                return RedirectToAction("Index", "Produto");
            }
            else
            {
                ViewBag.Categorias = new CategoriasDAO().Lista();
                ViewBag.Produto = produto;
                return View("Form");
            }
        }

        public ActionResult Visualiza(int id)
        {
            ViewBag.Produto = new ProdutosDAO().BuscaPorId(id);
            return View();
        }
    }
}