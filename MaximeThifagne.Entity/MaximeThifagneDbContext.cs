using MaximeThifagne.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximeThifagne.Entity
{
    public partial class MaximeThifagneDbContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<ArticleEntity> Articles { get; set; }
        public DbSet<SubArticleEntity> SubArticles { get; set; }
        public DbSet<CommentEntity> Comments { get; set; }

        public MaximeThifagneDbContext()
            : base("MaximeThifagne")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
