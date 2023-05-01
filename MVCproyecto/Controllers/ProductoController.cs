using Microsoft.AspNetCore.Mvc;
using MVCproyecto.Models;

namespace MVCproyecto.Controllers
{
    public class ProductoController : Controller
    {
        private readonly APIGateway _api;

        public ProductoController(APIGateway api)
        {
            this._api = api;
        }
        //Crear una lista de lo que ve
        public IActionResult Index()
        {
            List<Producto> producto;
            producto = _api.ListProducto();
            return View(producto);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Producto producto = new Producto();
            return View(producto);
        }

        [HttpPost]
        public IActionResult Create(Producto producto)
        {
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Producto producto = new Producto();

            return View(producto);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Producto producto = new Producto();
            return View(producto);
        }

        [HttpPost]
        public IActionResult Edit(Producto producto)
        {
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Producto producto = new Producto();
            return View(producto);
        }

        [HttpPost]
        public IActionResult Delete(Producto producto)
        {
            return RedirectToAction("Index");
        }
    }
}
