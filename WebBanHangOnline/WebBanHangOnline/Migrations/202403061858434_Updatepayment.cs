namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatepayment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Order", "Typepayment", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Order", "Typepayment");
        }
    }
}
