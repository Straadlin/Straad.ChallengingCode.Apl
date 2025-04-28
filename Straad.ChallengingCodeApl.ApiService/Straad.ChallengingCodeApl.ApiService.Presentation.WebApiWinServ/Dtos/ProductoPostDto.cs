using System.ComponentModel.DataAnnotations;

namespace Straad.ChallengingCodeApl.ApiService.Presentation.WebApiWinServ.Dtos;

public class ProductoPostDto
{
    public ProductoPostDto()
    {
        Nombre = string.Empty;
    }

    [Required]
    [MinLength(3)]
    [MaxLength(30)]
    public string Nombre { get; set; }
    public decimal? Precio { get; set; }
}