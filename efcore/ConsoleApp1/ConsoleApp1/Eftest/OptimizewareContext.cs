using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ConsoleApp1.Eftest
{
    public partial class OptimizewareContext : DbContext
    {
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<ClientSupplier> ClientSuppliers { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Templ> Templs { get; set; }
        public virtual DbSet<Templ2> Templ2 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=MPERDECKPC\\MSSQLSERVER01;Initial Catalog=eftest1;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Client_Country");
            });

            modelBuilder.Entity<ClientSupplier>(entity =>
            {
                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientSuppliers)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientSupplier_Client");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.ClientSuppliers)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientSupplier_Supplier");
            });

            modelBuilder.Entity<Templ>(entity =>
            {
                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Templs)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_templ_Client");
            });

            modelBuilder.Entity<Templ2>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Templ2Client)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_templ2_Client");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Templ2IdNavigation)
                    .HasForeignKey<Templ2>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_templ2_Client_2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
