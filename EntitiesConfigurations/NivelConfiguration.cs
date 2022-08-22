using PatrimonioSenaiTaguatinga.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace PatrimonioSenaiTaguatinga.EntitiesConfigurations;

public class NivelConfiguration : IEntityTypeConfiguration<Nivel>
{
    public void Configure(EntityTypeBuilder<Nivel> builder)
    {
        builder.ToTable("Nivel");
        builder.HasKey(n=>n.Id);
        builder.Property(n=>n.NomeNivel)
                .IsRequired()
                .HasMaxLength(50);
    }
}