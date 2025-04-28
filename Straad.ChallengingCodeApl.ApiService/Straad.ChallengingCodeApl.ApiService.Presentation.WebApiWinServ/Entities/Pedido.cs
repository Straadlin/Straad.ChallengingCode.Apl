namespace Straad.ChallengingCodeApl.ApiService.Presentation.WebApiWinServ.Entities;

public class Pedido
{
    public int Id { get; set; }
    public int ClienteId { get; set; }
    public DateTime Fecha { get; set; }
    public decimal Total { get; set; }

    public virtual Cliente? Client { get; set; }
}