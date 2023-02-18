using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiPrimeraApi.Models;
using MiPrimeraApi.Repository;

namespace MiPrimeraApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        [HttpGet("{idUsuario}")]
        public List<Venta> TraerVentas(long idUsuario)
        {
            List<Models.Venta> ventas = new List<Models.Venta>();
            return VentaHandler.TraerVentas(idUsuario);
        }

        [HttpPost("{idUsuario}")]
        public void CargarVenta (long idUsuario, List<Producto> productosVendidos)
        {
            VentaHandler.CargarVenta(idUsuario, productosVendidos);
        }
    }
}
