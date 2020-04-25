namespace MaximeThifagne.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjoutPropsArticle : DbMigration
    {
        public override void Up()
        {
            AddColumn("mt.ARTICLE", "ARTICLE_CREATION_DATE", c => c.DateTime(nullable: false));
            AddColumn("mt.ARTICLE", "ARTICLE_USER_ID", c => c.Int(nullable: false));
            CreateIndex("mt.ARTICLE", "ARTICLE_USER_ID");
            AddForeignKey("mt.ARTICLE", "ARTICLE_USER_ID", "mt.USER", "USER_ID", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("mt.ARTICLE", "ARTICLE_USER_ID", "mt.USER");
            DropIndex("mt.ARTICLE", new[] { "ARTICLE_USER_ID" });
            DropColumn("mt.ARTICLE", "ARTICLE_USER_ID");
            DropColumn("mt.ARTICLE", "ARTICLE_CREATION_DATE");
        }
    }
}
