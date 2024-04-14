namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatePost1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.tb_Posts", "isSale");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_Posts", "isSale", c => c.Boolean(nullable: false));
        }
    }
}
