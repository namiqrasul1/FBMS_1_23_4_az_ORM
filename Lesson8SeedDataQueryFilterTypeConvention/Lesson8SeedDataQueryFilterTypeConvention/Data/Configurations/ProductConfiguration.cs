using Lesson8SeedDataQueryFilterTypeConvention.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Lesson8SeedDataQueryFilterTypeConvention.Data.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.Property(p => p.Price)
               .HasColumnType("money")
               .IsRequired();


        // Seed Data
        builder.HasData(
                        new Product { Id = 1, Name = "Sarikiz", Price = 1.0, IsDeleted = false },
                        new Product { Id = 2, Name = "Sirab", Price = 0.5, IsDeleted = true },
                        new Product { Id = 3, Name = "Cola", Price = 2.0, IsDeleted = true }
                    );

        // Query Filter

        builder.HasQueryFilter(p => !p.IsDeleted);
        // context.Products.ToList();
        /*
         Select * From (Select * From Products Where IsDelete != true)
        */
    }
}
