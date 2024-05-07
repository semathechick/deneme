using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class ImageConfiguration : IEntityTypeConfiguration<Image>
{
    public void Configure(EntityTypeBuilder<Image> builder)
    {
        builder.ToTable("Images").HasKey(i => i.Id);

        builder.Property(i => i.Id).HasColumnName("Id").IsRequired();
        builder.Property(i => i.PublicId).HasColumnName("PublicId");
        builder.Property(i => i.ImageUrl).HasColumnName("ImageUrl");
        builder.Property(i => i.IsPrimary).HasColumnName("IsPrimary");
        builder.Property(i => i.BookId).HasColumnName("BookId");
        builder.Property(i => i.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(i => i.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(i => i.DeletedDate).HasColumnName("DeletedDate");

        builder.HasQueryFilter(i => !i.DeletedDate.HasValue);
    }
}