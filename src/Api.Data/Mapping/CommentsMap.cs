using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class CommentsMap : IEntityTypeConfiguration<CommentsEntity>
    {
        public void Configure(EntityTypeBuilder<CommentsEntity> builder)
        {
            builder.ToTable("Comments");

            builder.HasKey(c => c.Id);

            builder.HasIndex(c => c.Email)
                   .IsUnique();

            builder.Property(c => c.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(c => c.Email)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(c => c.Comment)
                    .IsRequired()
                    .HasMaxLength(5000);

            builder.Property(p => p.Active);
            builder.Property(p => p.CreateAt);
            builder.Property(p => p.UpdateAt);
        }
    }
}
