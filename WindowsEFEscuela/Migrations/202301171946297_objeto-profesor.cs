namespace WindowsEFEscuela.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class objetoprofesor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Alumno", "Profesor_ProfesorId", c => c.Int());
            CreateIndex("dbo.Alumno", "Profesor_ProfesorId");
            AddForeignKey("dbo.Alumno", "Profesor_ProfesorId", "dbo.Docente", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Alumno", "Profesor_ProfesorId", "dbo.Docente");
            DropIndex("dbo.Alumno", new[] { "Profesor_ProfesorId" });
            DropColumn("dbo.Alumno", "Profesor_ProfesorId");
        }
    }
}
