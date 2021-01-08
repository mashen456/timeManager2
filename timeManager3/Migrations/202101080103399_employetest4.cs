namespace timeManager3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class employetest4 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.employes", name: "ApplicationUser_Id", newName: "ApplicationUserId");
            RenameIndex(table: "dbo.employes", name: "IX_ApplicationUser_Id", newName: "IX_ApplicationUserId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.employes", name: "IX_ApplicationUserId", newName: "IX_ApplicationUser_Id");
            RenameColumn(table: "dbo.employes", name: "ApplicationUserId", newName: "ApplicationUser_Id");
        }
    }
}
