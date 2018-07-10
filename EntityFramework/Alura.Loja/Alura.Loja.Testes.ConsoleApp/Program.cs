using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var contexto = new LojaContext())
            {
                //Acionando ao LOGGER !!
                SqlLoggerProvider.LogContext(contexto);

                var cliente = contexto
                    .Clientes
                    .Include(c => c.EnderecoDeEntrega)
                    .FirstOrDefault();

                Console.WriteLine($"Endereco de Entrega: {cliente.EnderecoDeEntrega.Logradouro}");

                /////////////////////////////////////////////
                //Pegar as compras de um produto !!
                //var produto = contexto
                //    .Produtos
                //    .Where(p => p.Id == 3002)
                //    .Include(p => p.Compras)
                //    .FirstOrDefault();

                //Console.WriteLine("## Pegar as compras de um produto !!");
                //Console.WriteLine($"Mostrando as Compras do Produto: {produto.Nome}");
                //foreach (var item in produto.Compras)
                //{
                //    Console.WriteLine("\t" + item);
                //}

                /////////////////////////////////////////////
                //Pegar as compras acima de um valor para um produto !!
                var produto2 = contexto
                    .Produtos
                    .Where(p => p.Id == 3002)
                    .FirstOrDefault();

                contexto.Entry(produto2)
                    .Collection(p => p.Compras)
                    .Query()        //tranforma em IQueryable !!
                    .Where(c => c.Preco > 10)
                    .Load();

                Console.WriteLine("## Pegar as compras acima de um valor para um produto !!");
                Console.WriteLine($"Mostrando as Compras do Produto: {produto2.Nome}");
                foreach (var item in produto2.Compras)
                {
                    Console.WriteLine("\t" + item);
                }
            }
        }

        private static void ComprarPaoFrances()
        {
            //Fazer varias comprars de pao frances !!
            using (var context = new LojaContext())
            {
                var paoFrances = context.Produtos.Where(p => p.Id == 3002).FirstOrDefault();

                var c1 = new Compra();
                c1.Produto = paoFrances;
                c1.Quantidade = 43;
                c1.Preco = c1.Quantidade * paoFrances.PrecoUnitario;

                var c2 = new Compra();
                c2.Produto = paoFrances;
                c2.Quantidade = 30;
                c2.Preco = c2.Quantidade * paoFrances.PrecoUnitario;

                var c3 = new Compra();
                c3.Produto = paoFrances;
                c3.Quantidade = 27;
                c3.Preco = c3.Quantidade * paoFrances.PrecoUnitario;

                context.Compras.Add(c1);
                context.Compras.Add(c2);
                context.Compras.Add(c3);

                context.SaveChanges();
            }
        }

        private static void ExibeProdutosDaPromocao()
        {
            using (var contexto2 = new LojaContext())
            {
                //Acionando ao LOGGER !!
                SqlLoggerProvider.LogContext(contexto2);

                var promocao = contexto2
                                .Promocoes
                                .Include(p => p.Produtos)       //Pega os resultados dentro da Tabela 'PromocaoProduto' com INNER JOIN da tabela 'Promocao'
                                .ThenInclude(pp => pp.Produto)  //Pega os da tabela 'Produtos' relacionados com a tabela 'PromocaoProduto' com INNER JOIN na tabela 'Promocao'
                                .FirstOrDefault();
                Console.WriteLine("\nMostrando os produtos da promoção ...");
                foreach (var item in promocao.Produtos)
                {
                    Console.WriteLine(item.Produto);
                }
            }
        }

        private static void ExibeEntries(IEnumerable<EntityEntry> entries)
        {
            Console.WriteLine("=============================");

            foreach (var e in entries)
            {
                Console.WriteLine(e.Entity.ToString() + " - " + e.State);
            }
        }

        private static void IncluirPromocao()
        {
            using (var contexto = new LojaContext())
            {
                //Acionando ao LOGGER !!
                SqlLoggerProvider.LogContext(contexto);

                var promocao = new Promocao();
                promocao.Descricao = "Queima total Janeiro 2017";
                promocao.DataInicio = new DateTime(2017, 01, 01);
                promocao.DataTermino = new DateTime(2017, 01, 31);

                var produtos = contexto
                                .Produtos
                                .Where(p => p.Categoria == "Bebidas")
                                .ToList();

                foreach (var item in produtos)
                {
                    promocao.IncluiProduto(item);
                }

                contexto.Promocoes.Add(promocao);
                ExibeEntries(contexto.ChangeTracker.Entries());

                contexto.SaveChanges();
            }
        }

        ////////////////////////////////////////////////////////////////////
        ///// RELACIONAMENTOS
        private static void UmparaUm()
        {
            var fulano = new Cliente();
            fulano.Nome = "Fulano de Tal";
            fulano.EnderecoDeEntrega = new Endereco()
            {
                Numero = 12,
                Logradouro = "Rua dos Inválidos",
                Complemento = "sobrado",
                Bairro = "Centro",
                Cidade = "Cidade"
            };

            using (var contexto = new LojaContext())
            {
                //Acionando o LOGGER !!
                var serviceProvider = contexto.GetInfrastructure<IServiceProvider>();
                var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
                loggerFactory.AddProvider(SqlLoggerProvider.Create());

                contexto.Clientes.Add(fulano);
                contexto.SaveChanges();
            }
        }

        private static void MuitosParaMuitos()
        {
            var p1 = new Produto() { Nome = "Suco de Laranja", Categoria = "Bebidas", PrecoUnitario = 8.79, Unidade = "Litros" };
            var p2 = new Produto() { Nome = "Café", Categoria = "Bebidas", PrecoUnitario = 12.45, Unidade = "Gramas" };
            var p3 = new Produto() { Nome = "Macarrão", Categoria = "Alimentos", PrecoUnitario = 4.23, Unidade = "Gramas" };

            var promocaoDePascoa = new Promocao();
            promocaoDePascoa.Descricao = "Páscoa Feliz";
            promocaoDePascoa.DataInicio = DateTime.Now;
            promocaoDePascoa.DataTermino = DateTime.Now.AddMonths(3);

            promocaoDePascoa.IncluiProduto(p1);
            promocaoDePascoa.IncluiProduto(p2);
            promocaoDePascoa.IncluiProduto(p3);

            using (var contexto = new LojaContext())
            {
                //Acionando o LOGGER !!
                var serviceProvider = contexto.GetInfrastructure<IServiceProvider>();
                var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
                loggerFactory.AddProvider(SqlLoggerProvider.Create());


                var promocao = contexto.Promocoes.Find(1);
                contexto.Promocoes.Remove(promocao);

                ExibeEntries(contexto.ChangeTracker.Entries());
                //contexto.SaveChanges();
            }
        }


        ////////////////////////////////////////////////////////////////////
        ///// Nova LOJA
        //static void Main(string[] args)
        //{
        //    var paofrances = new Produto()
        //    {
        //        Nome = "Pão Francês",
        //        PrecoUnitario = 0.40,
        //        Unidade = "Unidade",
        //        Categoria = "Padaria"
        //    };

        //    var compra = new Compra();
        //    compra.Quantidade = 6;
        //    compra.Produto = paofrances;
        //    compra.Preco = paofrances.PrecoUnitario * compra.Quantidade;

        //    using (var contexto = new LojaContext())
        //    {
        //        //Acionando o LOGGER !!
        //        var serviceProvider = contexto.GetInfrastructure<IServiceProvider>();
        //        var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
        //        loggerFactory.AddProvider(SqlLoggerProvider.Create());

        //        contexto.Compras.Add(compra);
        //        ExibeEntries(contexto.ChangeTracker.Entries());

        //        contexto.SaveChanges();
        //    }
        //}

        ////////////////////////////////////////////////////////////////////
        ///// CHANGE TRACKER
        //static void Main(string[] args)
        //{
        //    using (var contexto = new LojaContext())
        //    {
        //        //Acionando o LOGGER !!
        //        var serviceProvider = contexto.GetInfrastructure<IServiceProvider>();
        //        var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
        //        loggerFactory.AddProvider(SqlLoggerProvider.Create());

        //        var produtos = contexto.Produtos.ToList();
        //        ExibeEntries(contexto.ChangeTracker.Entries());

        //        var novoProduto = new Produto()
        //        {
        //            Nome = "Sabão em pó",
        //            Categoria = "Limpeza",
        //            Preco = 4.99
        //        };
        //        contexto.Produtos.Add(novoProduto);

        //        ExibeEntries(contexto.ChangeTracker.Entries());

        //        contexto.Produtos.Remove(novoProduto);

        //        ExibeEntries(contexto.ChangeTracker.Entries());

        //        //contexto.SaveChanges();
        //        var entry = contexto.Entry(novoProduto);
        //        Console.WriteLine("\n\n" + entry.Entity.ToString() + " - " + entry.State);

        //        //ExibeEntries(contexto.ChangeTracker.Entries());
        //    }
        //}


    }
}
