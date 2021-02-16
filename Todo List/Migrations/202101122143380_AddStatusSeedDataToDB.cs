namespace Todo_List.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStatusSeedDataToDB : DbMigration
    {
        public override void Up()
        {
            Sql("Insert INTO Status (Name) VALUES ('To Do');");
            Sql("Insert INTO Status (Name) VALUES ('In Progress');");
            Sql("Insert INTO Status (Name) VALUES ('Done');");
        }
        
        public override void Down()
        {
        }
    }
}
