using DockerMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace DockerMVC.Context;

public class DatabaseContext: DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
        
    }
    
    public DbSet<Produto> Produtos { get; set; }
}