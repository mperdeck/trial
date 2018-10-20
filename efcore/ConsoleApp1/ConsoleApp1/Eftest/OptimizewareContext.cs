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
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }

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

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasOne(d => d.MyClient)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.MyClientId)
                    .HasConstraintName("FK_Person_Client");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
