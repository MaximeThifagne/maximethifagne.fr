namespace MaximeThifagne.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjoutTableComment : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "mt.COMMENT",
                c => new
                    {
                        COMMENT_ID = c.Int(nullable: false, identity: true),
                        COMMENT_COMMENTATOR_NAME = c.String(),
                        COMMENT_COMMENTATOR_EMAIL = c.String(),
                        COMMENT_COMMENTATOR_WEBSITE = c.String(),
                        COMMENT_MESSAGE = c.String(),
                        ARTICLE_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.COMMENT_ID)
                .ForeignKey("mt.ARTICLE", t => t.ARTICLE_ID, cascadeDelete: false)
                .Index(t => t.ARTICLE_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("mt.COMMENT", "ARTICLE_ID", "mt.ARTICLE");
            DropIndex("mt.COMMENT", new[] { "ARTICLE_ID" });
            DropTable("mt.COMMENT");
        }
    }
}
