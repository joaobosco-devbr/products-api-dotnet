using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace CadastroProdutos.Services
{
    public class ProdutosService : IProdutosService
    {
        private static readonly List<Produto> produtos = new()
        {
            new Produto { Id = 1, Nome = "Produto A", Preco = 99.90M, Estoque = 50 },
            new Produto { Id = 2, Nome = "Produto B", Preco = 149.90M, Estoque = 30 }
        };

        public List<Produto> ObterTodos() => produtos;

        public Produto? ObterPorId(int id) => produtos.FirstOrDefault(x => x.Id == id);

        public void Adicionar(Produto novoProduto) => produtos.Add(novoProduto);

        public Produto? Atualizar(int id, Produto produtoAtualizado)
        {
            var produto = produtos.FirstOrDefault(x => x.Id == id);
            if (produto is null) return null;

            produto.Nome = produtoAtualizado.Nome;
            produto.Preco = produtoAtualizado.Preco;
            produto.Estoque = produtoAtualizado.Estoque;

            return produto;
        }

        public bool Remover(int id)
        {
            var produto = produtos.FirstOrDefault(x => x.Id == id);
            if (produto is null) return false;
            produtos.Remove(produto);
            return true;
        }
    }
}
