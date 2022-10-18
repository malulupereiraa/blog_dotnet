using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class PostMap : IEntityTypeConfiguration<PostEntity>
    {
        public void Configure(EntityTypeBuilder<PostEntity> builder)
        {
            builder.ToTable("Post");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Title)
                   .IsRequired()
                   .HasMaxLength(300);

            builder.Property(p => p.Text)
                   .IsRequired();

            builder.Property(p => p.Active);
            builder.Property(p => p.CreateAt);
            builder.Property(p => p.UpdateAt);

            //relations
            builder.Property(p => p.PostUser);
            builder.Property(p => p.PostComments);
        }
    }
}
