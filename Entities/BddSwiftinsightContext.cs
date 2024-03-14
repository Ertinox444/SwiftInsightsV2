using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SwiftInsightsV2.Entities;

public partial class BddSwiftinsightContext : DbContext
{
    public BddSwiftinsightContext()
    {
    }

    public BddSwiftinsightContext(DbContextOptions<BddSwiftinsightContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=127.0.0.1;port=3306;user=app;password=SwiftInsight;database=bdd_swiftinsight", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.32-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.IdUser).HasName("PRIMARY");

            entity.ToTable("user");

            entity.Property(e => e.IdUser)
                .HasColumnType("int(11)")
                .HasColumnName("id_user");
            entity.Property(e => e.IsAdmin)
                .HasColumnType("int(11)")
                .HasColumnName("is_Admin");
            entity.Property(e => e.LoginUser)
                .HasMaxLength(255)
                .HasColumnName("login_user");
            entity.Property(e => e.PasswordUser)
                .HasMaxLength(255)
                .HasColumnName("password_user");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
