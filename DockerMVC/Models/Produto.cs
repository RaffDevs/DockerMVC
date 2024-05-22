using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DockerMVC.Models;

[Table("Produtos")]
public class Produto
{
    [Key]
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Categoria { get; set; }
    public double Preco { get; set; } = 0;

    public Produto(int id, string? nome, string? categoria, double preco)
    {
        Id = id;
        Nome = nome;
        Categoria = categoria;
        Preco = preco;
    }
}