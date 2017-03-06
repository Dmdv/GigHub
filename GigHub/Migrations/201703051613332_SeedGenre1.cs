namespace GigHub.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedGenre1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) values('Folk')");
            Sql("INSERT INTO Genres (Name) values('Jazz')");
            Sql("INSERT INTO Genres (Name) values('Rock')");
            Sql("INSERT INTO Genres (Name) values('Blues')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id in ('Folk', 'Jazz', 'Rock', 'Blues')");
        }
    }
}
