namespace GB.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialCreate1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Adherents", "BibliothequeFK");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Adherents", "BibliothequeFK", c => c.Int());
        }
    }
}
