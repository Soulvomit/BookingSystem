using System.Data.Entity.Migrations;

namespace BookingSystemDataLayer.Migrations
{
    public partial class BookingDBv2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("Customers", "PhoneNum", c => c.Int(nullable: true, defaultValue: null));
        }
        
        public override void Down()
        {
            DropColumn("Customers", "PhoneNum");
        }
    }
}
