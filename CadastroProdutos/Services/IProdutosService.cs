using System.Collections.Generic;

namespace CadastroProdutos.Services;

public interface IProdutosService
{
    List<Produto> ObterTodos();
    Produto? ObterPorId(int id);
    void Adicionar(Produto novoProduto);
    Produto? Atualizar(int id, Produto produtoAtualizado);
    bool Remover(int id);
}
