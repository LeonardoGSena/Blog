using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data.Mappings;

public class UserMap : IEntityTypeConfiguration<User>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<User> builder)
    {
        //tabela
        builder.ToTable("User");

        //chave primaria
        builder.HasKey(x => x.Id);

        //identity
        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();

        //propriedades
        builder.Property(x => x.Name)
            .IsRequired()
            .HasColumnName("Name")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(80);

        builder.Property(x => x.Bio);
        builder.Property(x => x.Email);
        builder.Property(x => x.Image);
        builder.Property(x => x.PasswordHash);

        builder.Property(x => x.Slug)
            .IsRequired()
            .HasColumnName("Slug")
            .HasColumnType("VARCHAR")
            .HasMaxLength(80);

        //índice
        builder.HasIndex(x => x.Slug, "IX_User_Slug")
            .IsUnique();
    }
}