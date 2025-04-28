using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Straad.ChallengingCodeApl.ApiService.Presentation.WebApiWinServ.Entities;

namespace Straad.ChallengingCodeApl.ApiService.Presentation.WebApiWinServ.Configurations;

public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
{
    public void Configure(EntityTypeBuilder<Pedido> builder)
    {
        // Fluent API
        builder.ToTable("PEDIDO");
        builder.HasKey(u => u.Id);

        //

        builder.HasOne(p => p.Client)
               .WithMany(r => r.Pedidos)
               .HasForeignKey(r => r.ClienteId);

        //

        builder.Property(e => e.Id).HasColumnName("PEDIDO_ID").IsRequired();
        builder.Property(e => e.ClienteId).HasColumnName("CLIENTE_ID").IsRequired();
        builder.Property(e => e.Fecha).HasColumnName("FECHA").IsRequired();
        builder.Property(e => e.Total).HasColumnName("TOTAL").IsRequired();
    }
}