using System;
using System.Collections.Generic;
using Lesson4DbFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace Lesson4DbFirst.Data;

public partial class FoodyByteDbContext : DbContext
{
    public FoodyByteDbContext()
    {
    }

    public FoodyByteDbContext(DbContextOptions<FoodyByteDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Dish> Dishes { get; set; }

    public virtual DbSet<Media> Medias { get; set; }

    public virtual DbSet<PhoneNumber> PhoneNumbers { get; set; }

    public virtual DbSet<Restaurant> Restaurants { get; set; }

    public virtual DbSet<Review> Reviews { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=STHQ0118-01;Initial Catalog=FoodyByteDb;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Dish>(entity =>
        {
            entity.HasIndex(e => e.CategoryId, "IX_Dishes_CategoryId");

            entity.HasIndex(e => e.MediaId, "IX_Dishes_MediaId")
                .IsUnique()
                .HasFilter("([MediaId] IS NOT NULL)");

            entity.HasIndex(e => e.RestaurantId, "IX_Dishes_RestaurantId");

            entity.HasOne(d => d.Category).WithMany(p => p.Dishes)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Media).WithOne(p => p.Dish).HasForeignKey<Dish>(d => d.MediaId);

            entity.HasOne(d => d.Restaurant).WithMany(p => p.Dishes).HasForeignKey(d => d.RestaurantId);
        });

        modelBuilder.Entity<PhoneNumber>(entity =>
        {
            entity.HasIndex(e => e.RestaurantId, "IX_PhoneNumbers_RestaurantId");

            entity.HasOne(d => d.Restaurant).WithMany(p => p.PhoneNumbers).HasForeignKey(d => d.RestaurantId);
        });

        modelBuilder.Entity<Restaurant>(entity =>
        {
            entity.HasIndex(e => e.AddressId, "IX_Restaurants_AddressId").IsUnique();

            entity.HasOne(d => d.Address).WithOne(p => p.Restaurant).HasForeignKey<Restaurant>(d => d.AddressId);
        });

        modelBuilder.Entity<Review>(entity =>
        {
            entity.HasIndex(e => e.RestaurantId, "IX_Reviews_RestaurantId");

            entity.HasIndex(e => e.UserId, "IX_Reviews_UserId");

            entity.HasOne(d => d.Restaurant).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.RestaurantId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.User).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasIndex(e => e.MediaId, "IX_Users_MediaId")
                .IsUnique()
                .HasFilter("([MediaId] IS NOT NULL)");

            entity.HasOne(d => d.Media).WithOne(p => p.User).HasForeignKey<User>(d => d.MediaId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
