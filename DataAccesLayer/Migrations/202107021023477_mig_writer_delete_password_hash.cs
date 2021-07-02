namespace DataAccesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_writer_delete_password_hash : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WriterPassword", c => c.String(maxLength: 200));
            DropColumn("dbo.Writers", "WriterPasswordHash");
            DropColumn("dbo.Writers", "WriterPasswordSalt");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Writers", "WriterPasswordSalt", c => c.Binary());
            AddColumn("dbo.Writers", "WriterPasswordHash", c => c.Binary());
            DropColumn("dbo.Writers", "WriterPassword");
        }
    }
}
