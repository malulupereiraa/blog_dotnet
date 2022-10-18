namespace Api.Domain.Entities
{
    public class CommentsEntity : BaseEntity
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Comment { get; set; }
    }
}
