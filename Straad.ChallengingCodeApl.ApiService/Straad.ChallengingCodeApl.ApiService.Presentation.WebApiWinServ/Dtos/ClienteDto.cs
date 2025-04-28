using System.ComponentModel.DataAnnotations;

namespace Straad.ChallengingCodeApl.ApiService.Presentation.WebApiWinServ.Dtos;

public class ClienteDto
{
    public ClienteDto()
    {
        Nombre = string.Empty;
        Email = string.Empty;
    }

    public int Id { get; set; }
    [Required]
    [MinLength(3)]
    [MaxLength(30)]
    public string Nombre { get; set; }
    [Required]
    public string Email { get; set; }
}