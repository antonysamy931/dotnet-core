using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Test.Models
{
    public partial class SignalRContext : DbContext
    {
        public virtual DbSet<ConnectionMapping> ConnectionMapping { get; set; }
        public virtual DbSet<ConnectionMappings> ConnectionMappings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Data Source=(local);Initial Catalog=SignalR;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ConnectionMapping>(entity =>
            {
                entity.Property(e => e.ConnectionId)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(max)");
            });
        }
    }
}