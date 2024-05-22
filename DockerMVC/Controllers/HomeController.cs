using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DockerMVC.Models;
using DockerMVC.Repository;

namespace DockerMVC.Controllers;

public class HomeController : Controller
{
    private readonly IRepository _repository;
    private string message;

    public HomeController(IRepository repository, IConfiguration config)
    {
        _repository = repository;
        message = config["MESSAGE"] ?? "ASP NET Core MVC - Docker";
    }

    public IActionResult Index()
    {
        ViewBag.Message = message;
        return View(_repository.GetProdutos());
    }
}