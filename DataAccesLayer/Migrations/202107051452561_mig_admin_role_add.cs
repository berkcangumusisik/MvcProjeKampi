namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_admin_role_add : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        RoleName = c.String(maxLength: 1),
                        Description = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.RoleId);
            
            AddColumn("dbo.Admins", "AdminName", c => c.String());
            AddColumn("dbo.Admins", "AdminStatus", c => c.Boolean(nullable: false));
            AddColumn("dbo.Admins", "RoleId", c => c.Int());
            CreateIndex("dbo.Admins", "RoleId");
            AddForeignKey("dbo.Admins", "RoleId", "dbo.Roles", "RoleId");
            DropColumn("dbo.Admins", "AdminRole");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Admins", "AdminRole", c => c.String(maxLength: 1));
            DropForeignKey("dbo.Admins", "RoleId", "dbo.Roles");
            DropIndex("dbo.Admins", new[] { "RoleId" });
            DropColumn("dbo.Admins", "RoleId");
            DropColumn("dbo.Admins", "AdminStatus");
            DropColumn("dbo.Admins", "AdminName");
            DropTable("dbo.Roles");
        }
    }
}
