using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace socmed_api.Models;

public partial class VxSocmedDbContext : DbContext
{
    public VxSocmedDbContext()
    {
    }

    public VxSocmedDbContext(DbContextOptions<VxSocmedDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Post> Posts { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Name=ConnectionStrings:vx-socmed-db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Post>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("posts_pkey");

            entity.ToTable("posts");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateCreated)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("date_created");
            entity.Property(e => e.PostBody).HasColumnName("post_body");
            entity.Property(e => e.PostedByUserId).HasColumnName("posted_by_user_id");

            entity.HasOne(d => d.PostedByUser).WithMany(p => p.Posts)
                .HasForeignKey(d => d.PostedByUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("posts_posted_by_user_id_fkey");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users");

            entity.HasIndex(e => e.Username, "users_username_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Username).HasColumnName("username");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
