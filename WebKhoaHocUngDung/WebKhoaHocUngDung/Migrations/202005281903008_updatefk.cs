namespace WebKhoaHocUngDung.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatefk : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.GIAOVIEN", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.HOCSINH", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.NHANVIEN", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.HOCSINH", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.GIAOVIEN", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.NHANVIEN", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.HOCSINH", "ApplicationUser_Id");
            DropColumn("dbo.GIAOVIEN", "ApplicationUser_Id");
            DropColumn("dbo.NHANVIEN", "ApplicationUser_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NHANVIEN", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.GIAOVIEN", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.HOCSINH", "ApplicationUser_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.NHANVIEN", "ApplicationUser_Id");
            CreateIndex("dbo.GIAOVIEN", "ApplicationUser_Id");
            CreateIndex("dbo.HOCSINH", "ApplicationUser_Id");
            AddForeignKey("dbo.NHANVIEN", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.HOCSINH", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.GIAOVIEN", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
