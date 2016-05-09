namespace DataEntities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fdf : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Options", "Item_Id", c => c.Int());
            CreateIndex("dbo.Options", "Item_Id");
            AddForeignKey("dbo.Options", "Item_Id", "dbo.Items", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Options", "Item_Id", "dbo.Items");
            DropIndex("dbo.Options", new[] { "Item_Id" });
            DropColumn("dbo.Options", "Item_Id");
        }
    }
}
