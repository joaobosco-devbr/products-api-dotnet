using System;
using Microsoft.EntityFrameworkCore;

namespace CadastroProdutos.Database;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public required DbSet<Produto> Produtos { get; set; }
}
