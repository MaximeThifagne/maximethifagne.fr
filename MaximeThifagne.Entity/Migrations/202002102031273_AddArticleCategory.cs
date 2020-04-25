namespace MaximeThifagne.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddArticleCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("mt.ARTICLE", "Category", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("mt.ARTICLE", "Category");
        }
    }
}
