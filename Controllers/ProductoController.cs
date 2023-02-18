using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiPrimeraApi.Models;
using MiPrimeraApi.Repository;

namespace MiPrimeraApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        [HttpPost]
        public Producto CrearProducto(Producto producto)
        {
            ProductoHandler.CrearProducto(producto);
            return producto;
        }

        [HttpGet("{idUsuario}")]
        public List<Producto> TraerProducto(long idUsuario)
        {
            List<Models.Producto> producto = new List<Models.Producto>();
            return ProductoHandler.TraerProducto(idUsuario);
        }

        [HttpDelete("{id}")]
        public int EliminarProducto (long id)
        {
            return ProductoHandler.EliminarProducto(id);
        }

        [HttpPut]
        public int ModificarProducto(Producto producto)
        {
            return ProductoHandler.ModificarProducto(producto);
        }

    }


}

