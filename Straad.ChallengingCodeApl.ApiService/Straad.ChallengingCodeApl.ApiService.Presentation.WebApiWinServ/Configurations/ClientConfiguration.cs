using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Straad.ChallengingCodeApl.ApiService.Presentation.WebApiWinServ.Entities;

namespace Straad.ChallengingCodeApl.ApiService.Presentation.WebApiWinServ.Configurations;

public class ClientConfiguration : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        // Fluent API
        builder.ToTable("CLIENTE");
        builder.HasKey(u => u.Id);

        //

        builder.HasMany(p => p.Pedidos)
               .WithOne(r => r.Client)
               .HasForeignKey(r => r.ClienteId);

        //

        builder.Property(e => e.Id).HasColumnName("CLIENTE_ID").IsRequired();
        builder.Property(e => e.Nombre).HasColumnName("NOMBRE").IsRequired();
        builder.Property(e => e.Email).HasColumnName("EMAIL").IsRequired();
    }
}