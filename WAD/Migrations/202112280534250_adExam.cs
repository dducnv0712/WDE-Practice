namespace WAD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adExam : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Exams",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        examSubject = c.String(nullable: false),
                        startTime = c.String(nullable: false),
                        examDate = c.String(nullable: false),
                        examDuration = c.String(nullable: false),
                        classRoom = c.String(nullable: false),
                        facully = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Exams");
        }
    }
}
