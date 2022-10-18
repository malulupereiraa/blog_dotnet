using Api.Domain.Entities.Relation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class RelationPostCommentsMap : IEntityTypeConfiguration<RelationPostCommentsEntity>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<RelationPostCommentsEntity> builder)
        {
            builder.ToTable("RelationPostComments");

            builder.HasKey(c => c.Id);

            //attributes
            builder.Property(p => p.Id);
            builder.Property(p => p.CreateAt);
            builder.Property(p => p.UpdateAt);
            builder.Property(p => p.Active);
            builder.Property(p => p.Post_Id);
            builder.Property(p => p.Comments_Id);
        }
    }
}
