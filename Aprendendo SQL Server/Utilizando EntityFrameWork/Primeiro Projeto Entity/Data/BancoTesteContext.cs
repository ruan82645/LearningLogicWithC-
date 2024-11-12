using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Primeiro_projeto_Entity.Models;

namespace Primeiro_projeto_Entity.Data;

public partial class BancoTesteContext : DbContext
{
    public BancoTesteContext()
    {
    }

    public BancoTesteContext(DbContextOptions<BancoTesteContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Jorge> Jorges { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Banco_Teste;User ID=ruan;Password=82645;MultipleActiveResultSets=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdClient);

            entity.Property(e => e.IdClient).HasColumnName("id_client");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Nome)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Salario)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("salario");
            entity.Property(e => e.Telefone)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("telefone");
        });

        modelBuilder.Entity<Jorge>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("jorges");

            entity.Property(e => e.Jorge1)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("jorge");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
