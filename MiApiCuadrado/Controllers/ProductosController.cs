using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Dapper;
using MiApiCuadrado.Models;

namespace MiApiCuadrado.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductosController : ControllerBase
{
    private readonly IConfiguration _configuration;

    public ProductosController(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    [HttpGet]
    public IActionResult GetProductos()
    {
        string connectionString = _configuration.GetConnectionString("SomeeConnection")!;

        using (var connection = new SqlConnection(connectionString))
        {
            var productos = connection.Query<Producto>("SELECT Id, Nombre, Precio FROM Productos");
            return Ok(productos);
        }
    }

    [HttpPost]
    public IActionResult CrearProducto([FromBody] Producto producto)
    {
        string connectionString = _configuration.GetConnectionString("SomeeConnection")!;

        using (var connection = new SqlConnection(connectionString))
        {
            string query = "INSERT INTO Productos (Nombre, Precio) VALUES (@Nombre, @Precio)";
            connection.Execute(query, new { producto.Nombre, producto.Precio });
            return Ok("Producto creado correctamente.");
        }
    }
}