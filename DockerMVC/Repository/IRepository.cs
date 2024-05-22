using DockerMVC.Models;

namespace DockerMVC.Repository;

public interface IRepository
{
    IEnumerable<Produto> GetProdutos();
}