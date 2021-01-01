namespace GB.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BdV2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adherents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(nullable: false),
                        Prenom = c.String(nullable: false),
                        Login = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Bibliotheque_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bibliotheques", t => t.Bibliotheque_Id)
                .Index(t => t.Bibliotheque_Id);
            
            CreateTable(
                "dbo.Bibliotheques",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Documents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titre = c.String(),
                        Resume = c.String(),
                        BibliothequeFK = c.Int(nullable: false),
                        DateParution = c.DateTime(),
                        Auteur = c.String(),
                        Dessinateur = c.String(),
                        Langue = c.String(),
                        NbPages = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bibliotheques", t => t.BibliothequeFK)
                .Index(t => t.BibliothequeFK);
            
            CreateTable(
                "dbo.Emprunts",
                c => new
                    {
                        DateEmprunt = c.DateTime(nullable: false),
                        AdherentFK = c.Int(nullable: false),
                        DocumentFK = c.Int(nullable: false),
                        DateRetour = c.DateTime(),
                        DureeEmprunt = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.DateEmprunt, t.AdherentFK, t.DocumentFK })
                .ForeignKey("dbo.Adherents", t => t.AdherentFK, cascadeDelete: true)
                .ForeignKey("dbo.Documents", t => t.DocumentFK, cascadeDelete: true)
                .Index(t => t.AdherentFK)
                .Index(t => t.DocumentFK);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Emprunts", "DocumentFK", "dbo.Documents");
            DropForeignKey("dbo.Emprunts", "AdherentFK", "dbo.Adherents");
            DropForeignKey("dbo.Documents", "BibliothequeFK", "dbo.Bibliotheques");
            DropForeignKey("dbo.Adherents", "Bibliotheque_Id", "dbo.Bibliotheques");
            DropIndex("dbo.Emprunts", new[] { "DocumentFK" });
            DropIndex("dbo.Emprunts", new[] { "AdherentFK" });
            DropIndex("dbo.Documents", new[] { "BibliothequeFK" });
            DropIndex("dbo.Adherents", new[] { "Bibliotheque_Id" });
            DropTable("dbo.Emprunts");
            DropTable("dbo.Documents");
            DropTable("dbo.Bibliotheques");
            DropTable("dbo.Adherents");
        }
    }
}
