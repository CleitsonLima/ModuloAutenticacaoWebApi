using PatrimonioSenaiTaguatinga.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace PatrimonioSenaiTaguatinga.EntitiesConfigurations;

public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("Usuario");
        builder.HasKey(u => u.Id);
        builder.Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(50);
        builder.Property(u => u.SobreNome)
                .IsRequired()
                .HasMaxLength(50);
        builder.Property(u => u.Login)
                .IsRequired()
                .HasMaxLength(50);
        builder.Property(u => u.Password)
                .IsRequired()
                .HasMaxLength(50);
        builder.HasOne(u => u.Nivel)
                .WithMany(n => n.Usuarios)
                .HasForeignKey(u => u.IdNivel);
    }
}