using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
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
        var productos = new List<Producto>();
        string connectionString = _configuration.GetConnectionString("SomeeConnection")!;

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT Id, Nombre, Precio FROM Productos";

            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    productos.Add(new Producto
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Precio = reader.GetDecimal(2)
                    });
                }
            }
        }

        return Ok(productos);
    }
}