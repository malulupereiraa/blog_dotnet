using Api.Domain.Entities.Relation;

namespace Api.Domain.Entities
{
    public class PostEntity : BaseEntity
    {
        public string Title { get; set; }

        public string Text { get; set; }

        public virtual RelationPostUserEntity PostUser { get; set; }
        public virtual RelationPostCommentsEntity PostComments { get; set; }
    }
}
