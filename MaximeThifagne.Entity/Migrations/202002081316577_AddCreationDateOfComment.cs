namespace MaximeThifagne.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCreationDateOfComment : DbMigration
    {
        public override void Up()
        {
            AddColumn("mt.COMMENT", "COMMENT_CREATION_DATE", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("mt.COMMENT", "COMMENT_CREATION_DATE");
        }
    }
}
