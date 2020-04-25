namespace MaximeThifagne.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjoutPropsUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("mt.USER", "USER_LAST_NAME", c => c.String());
            AddColumn("mt.USER", "USER_FIRST_NAME", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("mt.USER", "USER_FIRST_NAME");
            DropColumn("mt.USER", "USER_LAST_NAME");
        }
    }
}
