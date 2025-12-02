using EFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore.Configurations
{
    public class BlogConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.Property(b => b.Url)
                .IsRequired();

            #region To change the default schema using Fluent API 

            // builder.ToTable("Blogs", "TestNewSchema");

            #endregion


        }
    }
}
