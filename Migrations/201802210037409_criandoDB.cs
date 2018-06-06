namespace ProjetoNovo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class criandoDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Restaurantes",
                c => new
                    {
                        idRestaurante = c.Int(nullable: false, identity: true),
                        nomeRestaurante = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.idRestaurante);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Restaurantes");
        }
    }
}
