using Microsoft.EntityFrameworkCore.Migrations;

namespace FniteApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Weapon",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeaponType = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    RarityType = table.Column<string>(nullable: true),
                    Rating = table.Column<string>(nullable: true),
                    DPS = table.Column<decimal>(nullable: false),
                    DamageB = table.Column<int>(nullable: false),
                    DamageH = table.Column<int>(nullable: false),
                    FireRate = table.Column<decimal>(nullable: false),
                    MagazineSize = table.Column<int>(nullable: false),
                    ReloadTime = table.Column<decimal>(nullable: false),
                    StructureDamage = table.Column<int>(nullable: false),
                    BulletType = table.Column<string>(nullable: true),
                    BRStatus = table.Column<bool>(nullable: false),
                    VaultedStatus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapon", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Weapon");
        }
    }
}
