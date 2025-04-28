using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Straad.ChallengingCodeApl.ApiService.Presentation.WebApiWinServ.Entities;

namespace Straad.ChallengingCodeApl.ApiService.Presentation.WebApiWinServ.Configurations;

public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
{
    public void Configure(EntityTypeBuilder<Producto> builder)
    {
        // Fluent API
        builder.ToTable("PRODUCTO");
        builder.HasKey(u => u.Id);

        //

        //

        builder.Property(e => e.Id).HasColumnName("PRODUCTO_ID").IsRequired();
        builder.Property(e => e.Nombre).HasColumnName("NOMBRE").IsRequired();
        builder.Property(e => e.Precio).HasColumnName("PRECIO").IsRequired();
    }
}