using Api.Domain.Entities.Relation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class RelationPostUserMap : IEntityTypeConfiguration<RelationPostUserEntity>
    {
        public void Configure(EntityTypeBuilder<RelationPostUserEntity> builder)
        {
            builder.ToTable("RelationPostUser");

            builder.HasKey(c => c.Id);

            //attributes
            builder.Property(p => p.Id);
            builder.Property(p => p.CreateAt);
            builder.Property(p => p.UpdateAt);
            builder.Property(p => p.Active);
            builder.Property(p => p.Post_Id);
            builder.Property(p => p.Id_User);
        }
    }
}
