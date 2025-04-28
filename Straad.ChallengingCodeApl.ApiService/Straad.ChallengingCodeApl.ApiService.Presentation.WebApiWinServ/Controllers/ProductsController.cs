using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Straad.ChallengingCodeApl.ApiService.Presentation.WebApiWinServ.Data;
using Straad.ChallengingCodeApl.ApiService.Presentation.WebApiWinServ.Dtos;
using Straad.ChallengingCodeApl.ApiService.Presentation.WebApiWinServ.Entities;

namespace Straad.ChallengingCodeApl.ApiService.Presentation.WebApiWinServ.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController(ChallengingCodeAplDbContext dbContext) : ControllerBase
{
    [HttpGet(Name = "GetProduct")]
    public async Task<ActionResult<IEnumerable<ProductoGetDto>>> Get()
    {
        var products = await dbContext.Productos.ToListAsync();
        var productDtos = products.Select(p => new ProductoGetDto
        {
            Id = p.Id,
            Nombre = p.Nombre,
            Precio = p.Precio
        }).ToList();

        if (productDtos.Any())
            return Ok(productDtos);

        return NoContent();
    }

    [HttpPost(Name = "PostProduct")]
    public async Task<ActionResult> Post([FromBody] ProductoPostDto productoDto)
    {
        if (ModelState.IsValid)
        {
            var producto = new Producto
            {
                Nombre = productoDto.Nombre,
                Precio = productoDto.Precio
            };

            await dbContext.Productos.AddAsync(producto);
            await dbContext.SaveChangesAsync();

            var productFound = await dbContext.Productos.FirstOrDefaultAsync<Producto>(p => p.Nombre == producto.Nombre);

            if (productFound is not null)
                return CreatedAtAction(nameof(Get), new { id = productFound.Id }, productoDto);
        }

        return BadRequest(ModelState);
    }
}