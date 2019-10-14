using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace login.Models
{
    public partial class loginContext : DbContext
    {
        public loginContext()
        {
        }

        public loginContext(DbContextOptions<loginContext> options)
            : base(options)
        {
        }

        public virtual DbSet<RolUsuario> RolUsuario { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=login;Userid=postgres;Password=3E84F243D0");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<RolUsuario>(entity =>
            {
                entity.HasKey(e => e.IdRolUsuarios)
                    .HasName("rol_usuario_pkey");

                entity.ToTable("rol_usuario");

                entity.Property(e => e.IdRolUsuarios).HasColumnName("id_rol_usuarios");

                entity.Property(e => e.IdRol).HasColumnName("id_rol");

                entity.Property(e => e.IdUsuarios).HasColumnName("id_usuarios");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.RolUsuario)
                    .HasForeignKey(d => d.IdRol)
                    .HasConstraintName("rol_usuario_id_rol_fkey");

                entity.HasOne(d => d.IdUsuariosNavigation)
                    .WithMany(p => p.RolUsuario)
                    .HasForeignKey(d => d.IdUsuarios)
                    .HasConstraintName("rol_usuario_id_usuarios_fkey");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.ToTable("roles");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.NombreRol)
                    .HasColumnName("nombre_rol")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.ToTable("usuarios");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('usarios_id_seq'::regclass)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(30);

                entity.Property(e => e.Pass)
                    .HasColumnName("pass")
                    .HasMaxLength(10);

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(30);
            });

            modelBuilder.HasSequence<int>("usarios_id_seq");
        }
    }
}
