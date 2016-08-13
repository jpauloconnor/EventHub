namespace EventHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populatetopicstable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Topics (Id, Name)  VALUES (1, 'JavaScript')");
            Sql("INSERT INTO Topics (Id, Name)  VALUES (2, '.NET')");
            Sql("INSERT INTO Topics (Id, Name)  VALUES (3, 'Python')");
            Sql("INSERT INTO Topics (Id, Name)  VALUES (4, 'iOS')");
            Sql("INSERT INTO Topics (Id, Name)  VALUES (5, 'Java')");
            Sql("INSERT INTO Topics (Id, Name)  VALUES (6, 'Other')");

        }

        public override void Down()
        {
            Sql("DELETE FROM Topics WHERE Id IN (1,2,3,4,5,6)");
        }
    }
}
