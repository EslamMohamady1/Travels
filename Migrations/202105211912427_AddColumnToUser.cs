namespace JobOfferWebiste.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnToUser : DbMigration
    {
        public override void Up() //Add
        {
            AddColumn("dbo.AspNetUsers", "UserType", c => c.String());
        }
        
        public override void Down() //Delete
        {
            DropColumn("dbo.AspNetUsers", "UserType");
        }
    }
}
