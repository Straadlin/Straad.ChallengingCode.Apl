namespace Straad.ChallengingCodeApl.ApiService.Presentation.WebApiWinServ.Dtos;

public class PedidoDto
{
    public int Id { get; set; }
    public int ClienteId { get; set; }
    public DateTime Fecha { get; set; }
    public decimal Total { get; set; }
}