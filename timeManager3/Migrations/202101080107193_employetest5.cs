namespace timeManager3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class employetest5 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.employes", name: "ApplicationUser_Id", newName: "ClientId");
            RenameIndex(table: "dbo.employes", name: "IX_ApplicationUser_Id", newName: "IX_ClientId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.employes", name: "IX_ClientId", newName: "IX_ApplicationUser_Id");
            RenameColumn(table: "dbo.employes", name: "ClientId", newName: "ApplicationUser_Id");
        }
    }
}
