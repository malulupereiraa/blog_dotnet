using Api.Data.Mapping;
using Api.Domain.Entities;
using Api.Domain.Entities.Relation;
using Microsoft.EntityFrameworkCore;


namespace Api.Data.Context
{
    public class MyContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }

        public DbSet<PostEntity> Posts { get; set; }

        public DbSet<CommentsEntity> Comments { get; set; }

        public DbSet<RelationPostCommentsEntity> RelationPostComments { get; set; }

        public DbSet<RelationPostUserEntity> RelationPostUser { get; set; }


        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserEntity>(new UserMap().Configure);

            modelBuilder.Entity<PostEntity>(new PostMap().Configure);

            modelBuilder.Entity<CommentsEntity>(new CommentsMap().Configure);

            modelBuilder.Entity<RelationPostCommentsEntity>(new RelationPostCommentsMap().Configure);

            modelBuilder.Entity<RelationPostUserEntity>(new RelationPostUserMap().Configure);
        }

    }
}
