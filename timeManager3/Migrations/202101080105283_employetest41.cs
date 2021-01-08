namespace timeManager3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class employetest41 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.employes", name: "ApplicationUserId", newName: "ApplicationUser_Id");
            RenameIndex(table: "dbo.employes", name: "IX_ApplicationUserId", newName: "IX_ApplicationUser_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.employes", name: "IX_ApplicationUser_Id", newName: "IX_ApplicationUserId");
            RenameColumn(table: "dbo.employes", name: "ApplicationUser_Id", newName: "ApplicationUserId");
        }
    }
}
