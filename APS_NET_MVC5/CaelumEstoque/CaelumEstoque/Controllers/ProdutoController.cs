using CaelumEstoque.DAO;
using CaelumEstoque.Filtros;
using CaelumEstoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CaelumEstoque.Controllers
{
    [AutorizacaoFilter]
    public class ProdutoController : Controller
    {
        // GET: Produto
        [Route("produtos", Name ="ListaProdutos")]
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
        [ValidateAntiForgeryToken]
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

        [Route("produtos/{id}", Name ="VisualizaProduto")]
        public ActionResult Visualiza(int id)
        {
            ViewBag.Produto = new ProdutosDAO().BuscaPorId(id);
            return View();
        }

        public ActionResult DecrementaQtd(int id)
        {
            ProdutosDAO dao = new ProdutosDAO();

            Produto produto = dao.BuscaPorId(id);
            produto.Quantidade--;

            dao.Atualiza(produto);

            //return RedirectToAction("Index");
            return Json(produto);
        }
    }
}