namespace ProjetoNovo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Pratos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pratos",
                c => new
                    {
                        idPrato = c.Int(nullable: false, identity: true),
                        nomePrato = c.String(nullable: false),
                        valorPrato = c.Single(nullable: false),
                        idRestaurante = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idPrato)
                .ForeignKey("dbo.Restaurantes", t => t.idRestaurante, cascadeDelete: true)
                .Index(t => t.idRestaurante);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pratos", "idRestaurante", "dbo.Restaurantes");
            DropIndex("dbo.Pratos", new[] { "idRestaurante" });
            DropTable("dbo.Pratos");
        }
    }
}
