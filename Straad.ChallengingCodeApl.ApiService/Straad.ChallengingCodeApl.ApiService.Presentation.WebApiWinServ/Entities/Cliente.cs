namespace Straad.ChallengingCodeApl.ApiService.Presentation.WebApiWinServ.Entities;

public class Cliente
{
    public Cliente()
    {
        Email = string.Empty;
        Pedidos = new List<Pedido>();
    }

    public int Id { get; set; }
    public int Nombre { get; set; }
    public string Email { get; set; }

    public virtual ICollection<Pedido>? Pedidos { get; set; }
}