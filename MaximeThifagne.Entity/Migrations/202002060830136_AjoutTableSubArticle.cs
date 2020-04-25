namespace MaximeThifagne.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjoutTableSubArticle : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "mt.SUB_ARTICLE",
                c => new
                    {
                        SUB_ARTICLE_ID = c.Int(nullable: false, identity: true),
                        SUB_ARTICLE_TITLE = c.String(),
                        SUB_ARTICLE_BODY = c.String(),
                        SUB_ARTICLE_PHOTO = c.Binary(),
                        ARTICLE_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SUB_ARTICLE_ID)
                .ForeignKey("mt.ARTICLE", t => t.ARTICLE_ID, cascadeDelete: true)
                .Index(t => t.ARTICLE_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("mt.SUB_ARTICLE", "ARTICLE_ID", "mt.ARTICLE");
            DropIndex("mt.SUB_ARTICLE", new[] { "ARTICLE_ID" });
            DropTable("mt.SUB_ARTICLE");
        }
    }
}
