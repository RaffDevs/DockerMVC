using DockerMVC.Models;

namespace DockerMVC.Repository;

public class Repository : IRepository
{
    private static Produto[] _produtos =
    {
        new Produto(new Random().Next(), "Iphone 11", "Smartphones", 3800.0),
        new Produto(new Random().Next(), "Iphone 12", "Smartphones", 4800.0),
        new Produto(new Random().Next(), "Iphone 13", "Smartphones", 5800.0),
        new Produto(new Random().Next(), "Macbook Air M1", "Notebooks", 5800.0),
        new Produto(new Random().Next(), "Ipad Pro", "Tablet", 7800.0),
        new Produto(new Random().Next(), "Apple Watch", "Wearables", 3200.0),
    };
    
    public IEnumerable<Produto> GetProdutos()
    {
        return _produtos;
    }
}