namespace CodeFirstExistingDatabaseSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "Point", c=>c.Int());           

        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "Point");
        }
    }
}
