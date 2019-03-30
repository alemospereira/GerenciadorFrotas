namespace DadosFrotas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Veiculos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Chassi = c.String(nullable: false, maxLength: 17, unicode: false),
                        TipoVeiculo = c.Int(nullable: false),
                        NumeroPassageiros = c.Byte(nullable: false),
                        Cor = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Veiculos");
        }
    }
}
