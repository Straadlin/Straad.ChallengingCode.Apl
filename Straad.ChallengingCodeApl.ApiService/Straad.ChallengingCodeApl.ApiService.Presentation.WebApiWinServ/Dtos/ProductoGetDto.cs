namespace Straad.ChallengingCodeApl.ApiService.Presentation.WebApiWinServ.Dtos;

public class ProductoGetDto
{
    public ProductoGetDto()
    {
        Nombre = string.Empty;
    }

    public int Id { get; set; }
    public string Nombre { get; set; }
    public decimal? Precio { get; set; }
}