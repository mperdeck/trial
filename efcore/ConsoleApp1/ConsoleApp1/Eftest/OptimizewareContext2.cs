using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ConsoleApp1.Eftest
{
    public partial class OptimizewareContext2 : DbContext
    {
        public virtual DbSet<Person> People { get; set; }
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

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasOne(d => d.MyClient)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.MyClientId)
                    .HasConstraintName("FK_Person_Client");
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
