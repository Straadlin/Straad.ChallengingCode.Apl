using Microsoft.EntityFrameworkCore;
using Straad.ChallengingCodeApl.ApiService.Presentation.WebApiWinServ.Configurations;
using Straad.ChallengingCodeApl.ApiService.Presentation.WebApiWinServ.Entities;

namespace Straad.ChallengingCodeApl.ApiService.Presentation.WebApiWinServ.Data;

public class ChallengingCodeAplDbContext: DbContext
{
    public ChallengingCodeAplDbContext(DbContextOptions<ChallengingCodeAplDbContext> options)
        : base(options)
    {
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return base.SaveChangesAsync(cancellationToken);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ClientConfiguration());
        modelBuilder.ApplyConfiguration(new PedidoConfiguration());
        modelBuilder.ApplyConfiguration(new ProductoConfiguration());
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Pedido> Pedidos { get; set; }
    public DbSet<Producto> Productos { get; set; }
}