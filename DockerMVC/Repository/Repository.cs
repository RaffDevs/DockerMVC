using DockerMVC.Context;
using DockerMVC.Models;

namespace DockerMVC.Repository;

public class Repository : IRepository
{
    private readonly DatabaseContext _context;

    public Repository(DatabaseContext context)
    {
        _context = context;
    }

    public IEnumerable<Produto> GetProdutos()
    {
        return _context.Produtos.ToList();
    }
}