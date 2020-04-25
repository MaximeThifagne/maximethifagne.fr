namespace MaximeThifagne.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjoutTableArticle : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "mt.ARTICLE",
                c => new
                    {
                        ARTICLE_ID = c.Int(nullable: false, identity: true),
                        ARTICLE_TITLE = c.String(),
                        ARTICLE_BODY = c.String(),
                        ARTICLE_PHOTO = c.Binary(),
                        ARTICLE_SOURCE = c.String(),
                        ARTICLE_SOURCE_LINK = c.String(),
                    })
                .PrimaryKey(t => t.ARTICLE_ID);
            
        }
        
        public override void Down()
        {
            DropTable("mt.ARTICLE");
        }
    }
}
