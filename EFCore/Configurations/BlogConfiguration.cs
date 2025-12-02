using EFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EFCore.Configurations
{
    public class BlogConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.Property(b => b.Url)
                .IsRequired();

            #region  change the default schema using Fluent API 

            // builder.ToTable("Blogs", "TestNewSchema");

            #endregion

            #region Change Column Name By Fluent Api

            // builder.Property(b => b.Url).HasColumnName("NewChangeNameOfColumn");
            
            #endregion



        }
    }
}
