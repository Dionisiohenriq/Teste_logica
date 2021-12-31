namespace Exercicio_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _001 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Compras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.Int(nullable: false),
                        QtdPecas = c.Int(nullable: false),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Peca_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pecas", t => t.Peca_Id)
                .Index(t => t.Peca_Id, name: "IX_Compra_Peca_Id");
            
            CreateTable(
                "dbo.Pecas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.Int(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Compras", "Peca_Id", "dbo.Pecas");
            DropIndex("dbo.Compras", "IX_Compra_Peca_Id");
            DropTable("dbo.Pecas");
            DropTable("dbo.Compras");
        }
    }
}
