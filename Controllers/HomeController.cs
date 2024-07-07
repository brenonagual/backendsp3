using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // instancias do tipo cliente
        Cliente cliente1 = new Cliente(01, "Arthur A. Ferreira", "887.999.980-98", "arthur@arthur.com", "Madruga");
        Cliente cliente2 = new Cliente(02, "asArthur A. Ferreira", "788.999.980-98", "artur@arthur.com", "Maga");
        Cliente cliente3 = new Cliente(03, "Arthuasasr A. Ferreira", "888.989.980-98", "arur@arthur.com", "Mauga");
        Cliente cliente4 = new Cliente(04, "Arthur A. Ferreasasira", "888.979.980-98", "ar@arthur.com", "Maduga");

        // lista de clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);

        ViewBag.listaClientes = listaClientes;

        // instancias do tipo fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01, "has PET S/A", "14.182.102/0001-00", "casua@ahsuas.com");
        Fornecedor fornecedor2 = new Fornecedor(02, "ha546465s PET S/A", "74.182.102/0001-00", "ca@ahsuas.com");
        Fornecedor fornecedor3 = new Fornecedor(03, "ha1231315 PET S/A", "14.172.102/0001-00", "casa@ahsuas.com");
        Fornecedor fornecedor4 = new Fornecedor(04, "has6455555 PET S/A", "14.782.102/0001-00", "sua@ahsuas.com");

        // lista de fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);

        ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
