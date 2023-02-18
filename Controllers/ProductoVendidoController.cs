using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiPrimeraApi.Models;
using MiPrimeraApi.Repository;

namespace MiPrimeraApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {
        [HttpDelete("{idProducto}")]
        public int EliminarProductosVendidos (long idProducto)
        {
            return ProductoVendidoHandler.EliminarProductosVendidos(idProducto);
        }

        [HttpGet("{idUsuario}")]
        public List<Producto> TraerProductoVendido(long idUsuario)
        {
            List<Models.ProductoVendido> producto = new List<Models.ProductoVendido>();
            return ProductoVendidoHandler.TraerProductosVendidos(idUsuario);
        }
    }
}
