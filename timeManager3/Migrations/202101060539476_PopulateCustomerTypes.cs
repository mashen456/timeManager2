namespace timeManager3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomerTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CustomerTypes (Id, Name,Type) VALUES (1,'Employee', 0) ");
            Sql("INSERT INTO CustomerTypes (Id, Name,Type) VALUES (2,'CEO', 1) ");
            Sql("INSERT INTO CustomerTypes (Id, Name,Type) VALUES (3,'Manager', 2) ");
        }
        
        public override void Down()
        {
        }
    }
}
