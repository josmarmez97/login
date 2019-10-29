using Microsoft.EntityFrameworkCore;

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

        public  DbSet<RolUsuario> RolUsuario { get; set; }
        public  DbSet<Roles> Roles { get; set; }
        public  DbSet<Usuarios> Usuarios { get; set; }

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
                entity.HasKey(e => e.id_usuarios)
                    .HasName("rol_usuario_pkey");

                entity.ToTable("rol_usuario");

                entity.Property(e => e.id_rol).HasColumnName("id_rol");

                entity.Property(e => e.id_usuarios).HasColumnName("id_usuarios");
            
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.ToTable("roles");

                entity.Property(e => e.id).HasColumnName("id");

                entity.Property(e => e.nombre_rol)
                    .HasColumnName("nombre_rol")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.ToTable("usuarios");

                entity.Property(e => e.id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("nextval('usarios_id_seq'::regclass)");

                entity.Property(e => e.nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(30);

                entity.Property(e => e.pass)
                    .HasColumnName("pass")
                    .HasMaxLength(10);

                entity.Property(e => e.userid)
                    .HasColumnName("userid")
                    .HasMaxLength(30);
            });

            modelBuilder.HasSequence<int>("usarios_id_seq");
        }
    }
}
