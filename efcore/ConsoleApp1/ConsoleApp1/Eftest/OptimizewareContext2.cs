using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ConsoleApp1.Eftest
{
    public partial class OptimizewareContext2 : DbContext
    {
        public virtual DbSet<Person> People { get; set; }

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
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
