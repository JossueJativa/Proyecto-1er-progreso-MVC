using Microsoft.AspNetCore.Mvc;
using MVCproyecto.Models;

namespace MVCproyecto.Controllers
{
    public class ClienteController : Controller
    {

        private readonly APIGateway _api;

        public ClienteController(APIGateway api)
        {
            this._api = api;
        }
        //Crear una lista de lo que ve
        public IActionResult Index()
        {
            List<Cliente> clientes;
            clientes = _api.ListCliente();
            return View(clientes);
        }

        [HttpGet]
        public IActionResult Create() {
            Cliente cliente = new Cliente();
            return View(cliente);
        }

        [HttpPost]
        public IActionResult Create(Cliente cliente)
        {
            return RedirectToAction("Index");
        }

        public IActionResult Details (int id)
        {
            Cliente cliente = new Cliente();

            return View(cliente);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Cliente cliente = new Cliente();
            return View(cliente);
        }

        [HttpPost]
        public IActionResult Edit(Cliente cliente)
        {
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Cliente cliente = new Cliente();
            return View(cliente);
        }

        [HttpPost]
        public IActionResult Delete(Cliente cliente)
        {
            return RedirectToAction("Index");
        }
    }
}
