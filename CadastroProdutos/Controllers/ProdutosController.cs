using CadastroProdutos.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CadastroProdutos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutosController : ControllerBase
    {
        private IProdutosService produtosService;

        public ProdutosController(IProdutosService produtosService)
        {
            this.produtosService = produtosService;
        }        
    
        [HttpGet]
        public IActionResult GetAll() => Ok(produtosService.ObterTodos());

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var p = produtosService.ObterPorId(id);
            return p is null ? NotFound() : Ok(p);
        }

        [HttpPost]
        public IActionResult Create(Produto novo)
        {
            produtosService.Adicionar(novo);
            return CreatedAtAction(nameof(GetById), new { id = novo.Id }, novo);
        }

        [HttpPut("{id:int}")]
        public IActionResult Update(int id, Produto atualizado)
        {
            var p = produtosService.Atualizar(id, atualizado);
            return p is null ? NotFound() : Ok(p);
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var removed = produtosService.Remover(id);
            return removed ? Ok($"Produto com ID {id} removido com sucesso") : NotFound($"Produto com ID {id} não encontrado");
        }
    }
}
