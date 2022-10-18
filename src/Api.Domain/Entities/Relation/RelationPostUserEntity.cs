namespace Api.Domain.Entities.Relation
{
    public class RelationPostUserEntity : BaseEntity
    {
        public int Post_Id { get; set; }
        public int Id_User { get; set; }
    }
}
