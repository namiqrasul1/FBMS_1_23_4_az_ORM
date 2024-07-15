using System;
using System.Collections.Generic;
using Lesson5EagerLazyLoading.Models;
using Microsoft.EntityFrameworkCore;

namespace Lesson5EagerLazyLoading.Data;

public partial class LibraryContext : DbContext
{
    public LibraryContext()
    {
    }

    public LibraryContext(DbContextOptions<LibraryContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<SCard> SCards { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            //.UseLazyLoadingProxies()
            .UseSqlServer("Data Source=STHQ0118-01;Initial Catalog=Library;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
            
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.FirstName).HasMaxLength(15);
            entity.Property(e => e.LastName).HasMaxLength(25);
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Comment).HasMaxLength(50);
            entity.Property(e => e.IdAuthor).HasColumnName("Id_Author");
            entity.Property(e => e.IdCategory).HasColumnName("Id_Category");
            entity.Property(e => e.IdPress).HasColumnName("Id_Press");
            entity.Property(e => e.IdThemes).HasColumnName("Id_Themes");
            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.Author).WithMany(p => p.Books)
                .HasForeignKey(d => d.IdAuthor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Books_Author");
        });

        modelBuilder.Entity<SCard>(entity =>
        {
            entity.ToTable("S_Cards");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DateIn).HasColumnType("datetime");
            entity.Property(e => e.DateOut).HasColumnType("datetime");
            entity.Property(e => e.IdBook).HasColumnName("Id_Book");
            entity.Property(e => e.IdLib).HasColumnName("Id_Lib");
            entity.Property(e => e.IdStudent).HasColumnName("Id_Student");

            entity.HasOne(d => d.Book).WithMany(p => p.SCards)
                .HasForeignKey(d => d.IdBook)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_S_Cards_Book");

            entity.HasOne(d => d.Student).WithMany(p => p.SCards)
                .HasForeignKey(d => d.IdStudent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_S_Cards_Stud");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.FirstName).HasMaxLength(15);
            entity.Property(e => e.IdGroup).HasColumnName("Id_Group");
            entity.Property(e => e.LastName).HasMaxLength(25);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
