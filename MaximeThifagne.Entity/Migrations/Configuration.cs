using System.Data.Entity.Migrations;

namespace MaximeThifagne.Entity.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<MaximeThifagneDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MaximeThifagneDbContext context)
        {
           
        }
    }
}
