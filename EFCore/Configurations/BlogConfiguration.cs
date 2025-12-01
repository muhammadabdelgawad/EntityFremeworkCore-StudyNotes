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
        }
    }
}
