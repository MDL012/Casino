using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace CasinoProject.Model;

public partial class CasinoContext : DbContext
{
    public CasinoContext()
    {
    }

    public CasinoContext(DbContextOptions<CasinoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Game> Games { get; set; }

    public virtual DbSet<Play> Plays { get; set; }

    public virtual DbSet<Player> Players { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;database=casino;user=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.28-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8_hungarian_ci")
            .HasCharSet("utf8");

        modelBuilder.Entity<Game>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("games")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Game1)
                .HasMaxLength(15)
                .HasColumnName("game");
            entity.Property(e => e.Id)
                .HasColumnType("int(1)")
                .HasColumnName("id");
        });

        modelBuilder.Entity<Play>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("plays")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasColumnType("int(4)")
                .HasColumnName("amount");
            entity.Property(e => e.GameId)
                .HasColumnType("int(1)")
                .HasColumnName("gameId");
            entity.Property(e => e.PlayerId)
                .HasColumnType("int(2)")
                .HasColumnName("playerId");
        });

        modelBuilder.Entity<Player>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("players")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Amount)
                .HasColumnType("int(5)")
                .HasColumnName("amount");
            entity.Property(e => e.Email)
                .HasMaxLength(26)
                .HasColumnName("email");
            entity.Property(e => e.Id)
                .HasColumnType("int(2)")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(35)
                .HasColumnName("name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
