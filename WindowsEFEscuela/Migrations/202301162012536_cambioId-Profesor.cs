namespace WindowsEFEscuela.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambioIdProfesor : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Docente", name: "ProfesorId", newName: "Id");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Docente", name: "Id", newName: "ProfesorId");
        }
    }
}
