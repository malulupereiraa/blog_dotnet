namespace Api.Domain.Entities.Relation
{
    public class RelationPostCommentsEntity : BaseEntity
    {
        public int Post_Id { get; set; }
        public int Comments_Id { get; set; }
    }
}
