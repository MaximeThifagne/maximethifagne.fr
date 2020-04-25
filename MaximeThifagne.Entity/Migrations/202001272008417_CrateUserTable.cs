namespace MaximeThifagne.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrateUserTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "mt.USER",
                c => new
                    {
                        USER_ID = c.Int(nullable: false, identity: true),
                        USER_LOGIN = c.String(),
                        USER_PASSWORD = c.String(),
                    })
                .PrimaryKey(t => t.USER_ID);
            
        }
        
        public override void Down()
        {
            DropTable("mt.USER");
        }
    }
}
