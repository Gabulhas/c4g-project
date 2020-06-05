using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;

using C4G.Models.C4G;

namespace C4G.Data
{
  public partial class C4GContext : Microsoft.EntityFrameworkCore.DbContext
  {
    public C4GContext(DbContextOptions<C4GContext> options):base(options)
    {
    }

    public C4GContext()
    {
    }

    partial void OnModelBuilding(ModelBuilder builder);

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<C4G.Models.C4G.Indisponibilidade>().HasKey(table => new {
          table.id_pedido, table.id_recursos
        });
        builder.Entity<C4G.Models.C4G.Atribuicao>()
              .HasOne(i => i.Recurso)
              .WithMany(i => i.Atribuicaos)
              .HasForeignKey(i => i.id_recursos)
              .HasPrincipalKey(i => i.id_recursos);
        builder.Entity<C4G.Models.C4G.Atribuicao>()
              .HasOne(i => i.Servico)
              .WithMany(i => i.Atribuicaos)
              .HasForeignKey(i => i.id_servico)
              .HasPrincipalKey(i => i.id_servico);
        builder.Entity<C4G.Models.C4G.Dado>()
              .HasOne(i => i.Laboratorio)
              .WithMany(i => i.Dados)
              .HasForeignKey(i => i.id_lab)
              .HasPrincipalKey(i => i.id_lab);
        builder.Entity<C4G.Models.C4G.Dado>()
              .HasOne(i => i.Recurso)
              .WithMany(i => i.Dados)
              .HasForeignKey(i => i.id_recursos)
              .HasPrincipalKey(i => i.id_recursos);
        builder.Entity<C4G.Models.C4G.Equipamento>()
              .HasOne(i => i.Laboratorio)
              .WithMany(i => i.Equipamentos)
              .HasForeignKey(i => i.id_lab)
              .HasPrincipalKey(i => i.id_lab);
        builder.Entity<C4G.Models.C4G.Equipamento>()
              .HasOne(i => i.Recurso)
              .WithMany(i => i.Equipamentos)
              .HasForeignKey(i => i.id_recursos)
              .HasPrincipalKey(i => i.id_recursos);
        builder.Entity<C4G.Models.C4G.Formaco>()
              .HasOne(i => i.Laboratorio)
              .WithMany(i => i.Formacos)
              .HasForeignKey(i => i.id_lab)
              .HasPrincipalKey(i => i.id_lab);
        builder.Entity<C4G.Models.C4G.Formaco>()
              .HasOne(i => i.Recurso)
              .WithMany(i => i.Formacos)
              .HasForeignKey(i => i.id_recursos)
              .HasPrincipalKey(i => i.id_recursos);
        builder.Entity<C4G.Models.C4G.Indisponibilidade>()
              .HasOne(i => i.Pedido)
              .WithMany(i => i.Indisponibilidades)
              .HasForeignKey(i => i.id_pedido)
              .HasPrincipalKey(i => i.id_pedido);
        builder.Entity<C4G.Models.C4G.Indisponibilidade>()
              .HasOne(i => i.Recurso)
              .WithMany(i => i.Indisponibilidades)
              .HasForeignKey(i => i.id_recursos)
              .HasPrincipalKey(i => i.id_recursos);
        builder.Entity<C4G.Models.C4G.Laboratorio>()
              .HasOne(i => i.Instituico)
              .WithMany(i => i.Laboratorios)
              .HasForeignKey(i => i.id_instituicao)
              .HasPrincipalKey(i => i.id_instituicao);
        builder.Entity<C4G.Models.C4G.Pedido>()
              .HasOne(i => i.Servico)
              .WithMany(i => i.Pedidos)
              .HasForeignKey(i => i.id_servico)
              .HasPrincipalKey(i => i.id_servico);
        builder.Entity<C4G.Models.C4G.Pedido>()
              .HasOne(i => i.Pessoa)
              .WithMany(i => i.Pedidos)
              .HasForeignKey(i => i.id_pessoa)
              .HasPrincipalKey(i => i.id_pessoa);
        builder.Entity<C4G.Models.C4G.Pessoa>()
              .HasOne(i => i.Instituico)
              .WithMany(i => i.Pessoas)
              .HasForeignKey(i => i.id_instituicao)
              .HasPrincipalKey(i => i.id_instituicao);
        builder.Entity<C4G.Models.C4G.Produto>()
              .HasOne(i => i.Laboratorio)
              .WithMany(i => i.Produtos)
              .HasForeignKey(i => i.id_lab)
              .HasPrincipalKey(i => i.id_lab);
        builder.Entity<C4G.Models.C4G.Produto>()
              .HasOne(i => i.Recurso)
              .WithMany(i => i.Produtos)
              .HasForeignKey(i => i.id_recursos)
              .HasPrincipalKey(i => i.id_recursos);
        builder.Entity<C4G.Models.C4G.RecursosHumano>()
              .HasOne(i => i.Laboratorio)
              .WithMany(i => i.RecursosHumanos)
              .HasForeignKey(i => i.id_lab)
              .HasPrincipalKey(i => i.id_lab);
        builder.Entity<C4G.Models.C4G.RecursosHumano>()
              .HasOne(i => i.Recurso)
              .WithMany(i => i.RecursosHumanos)
              .HasForeignKey(i => i.id_recursos)
              .HasPrincipalKey(i => i.id_recursos);
        builder.Entity<C4G.Models.C4G.Servico>()
              .HasOne(i => i.Pessoa)
              .WithMany(i => i.Servicos)
              .HasForeignKey(i => i.supervisionador)
              .HasPrincipalKey(i => i.id_pessoa);


        builder.Entity<C4G.Models.C4G.Equipamento>()
              .Property(p => p.data_registo)
              .HasColumnType("date");

        builder.Entity<C4G.Models.C4G.Indisponibilidade>()
              .Property(p => p.start_date)
              .HasColumnType("date");

        builder.Entity<C4G.Models.C4G.Indisponibilidade>()
              .Property(p => p.end_date)
              .HasColumnType("date");

        builder.Entity<C4G.Models.C4G.Pedido>()
              .Property(p => p.order_date)
              .HasColumnType("date");

        builder.Entity<C4G.Models.C4G.Pedido>()
              .Property(p => p.end_date)
              .HasColumnType("date");

        builder.Entity<C4G.Models.C4G.Pedido>()
              .Property(p => p.start_date)
              .HasColumnType("date");

        this.OnModelBuilding(builder);
    }


    public DbSet<C4G.Models.C4G.Atribuicao> Atribuicaos
    {
      get;
      set;
    }

    public DbSet<C4G.Models.C4G.Dado> Dados
    {
      get;
      set;
    }

    public DbSet<C4G.Models.C4G.Equipamento> Equipamentos
    {
      get;
      set;
    }

    public DbSet<C4G.Models.C4G.Formaco> Formacos
    {
      get;
      set;
    }

    public DbSet<C4G.Models.C4G.Indisponibilidade> Indisponibilidades
    {
      get;
      set;
    }

    public DbSet<C4G.Models.C4G.Instituico> Instituicos
    {
      get;
      set;
    }

    public DbSet<C4G.Models.C4G.Laboratorio> Laboratorios
    {
      get;
      set;
    }

    public DbSet<C4G.Models.C4G.Pedido> Pedidos
    {
      get;
      set;
    }

    public DbSet<C4G.Models.C4G.Pessoa> Pessoas
    {
      get;
      set;
    }

    public DbSet<C4G.Models.C4G.Produto> Produtos
    {
      get;
      set;
    }

    public DbSet<C4G.Models.C4G.Recurso> Recursos
    {
      get;
      set;
    }

    public DbSet<C4G.Models.C4G.RecursosHumano> RecursosHumanos
    {
      get;
      set;
    }

    public DbSet<C4G.Models.C4G.Servico> Servicos
    {
      get;
      set;
    }
  }
}
