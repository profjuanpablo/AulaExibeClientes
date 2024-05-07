using AulaExibeClientes.Models;
using Microsoft.AspNetCore.Mvc;

namespace AulaExibeClientes.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            //Simular lista de clientes
            var clientes = new List<Cliente> {
                new Cliente { Id = 1, Nome="Mangabeira", Email="mangabeira@gmail.com"},
                new Cliente { Id = 2, Nome="zandra", Email="zandra@gmail.com"},
                new Cliente { Id = 3, Nome="Yasmin", Email="yasmin@gmail.com"},
            };
            ViewBag.Clientes = clientes;
            return View();
        }
    }
}
