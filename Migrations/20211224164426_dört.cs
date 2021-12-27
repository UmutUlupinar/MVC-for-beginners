using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DestekApp.Migrations
{
    public partial class dört : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roller",
                columns: table => new
                {
                    RolID = table.Column<int>(type: "int", nullable: false),
                    RolAdı = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roller", x => x.RolID);
                });

            migrationBuilder.CreateTable(
                name: "Kullanıcılar",
                columns: table => new
                {
                    KullanıcıID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Eposta = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Şifre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RolID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanıcılar", x => x.KullanıcıID);
                    table.ForeignKey(
                        name: "FK_Kullanıcılar_Roller_RolID",
                        column: x => x.RolID,
                        principalTable: "Roller",
                        principalColumn: "RolID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roller",
                columns: new[] { "RolID", "RolAdı" },
                values: new object[,]
                {
                    { 1, "UserCandidate" },
                    { 2, "UserNormal" },
                    { 3, "Admin" },
                    { 4, "Supervisor" }
                });

            migrationBuilder.InsertData(
                table: "Kullanıcılar",
                columns: new[] { "KullanıcıID", "Eposta", "RolID", "Şifre" },
                values: new object[,]
                {
                    { 1, "gizem@gmail.com", 1, "123456" },
                    { 2, "ali@icloud.com", 3, "123456" },
                    { 3, "mahmut@outlook.com", 4, "123456" },
                    { 4, "mansur @hotmail.com", 2, "123456" },
                    { 5, "gamze@hotmail.com", 2, "123456" },
                    { 6, "miraç@icloud.com", 3, "123456" },
                    { 7, "yücel@hotmail.com", 2, "123456" },
                    { 8, "kubilay@icloud.com", 3, "123456" },
                    { 9, "hayati@gmail.com", 1, "123456" },
                    { 10, "bedriye müge@icloud.com", 3, "123456" },
                    { 11, "birsen@icloud.com", 3, "123456" },
                    { 12, "serdal@hotmail.com", 2, "123456" },
                    { 13, "bünyamin@icloud.com", 3, "123456" },
                    { 14, "özgür@icloud.com", 3, "123456" },
                    { 15, "ferdi@gmail.com", 1, "123456" },
                    { 16, "reyhan@icloud.com", 3, "123456" },
                    { 17, "ilhan@outlook.com", 4, "123456" },
                    { 18, "gülşah@hotmail.com", 2, "123456" },
                    { 19, "nalan@hotmail.com", 2, "123456" },
                    { 20, "semih@gmail.com", 1, "123456" },
                    { 21, "ergün@outlook.com", 4, "123456" },
                    { 22, "fatih@outlook.com", 4, "123456" },
                    { 23, "şenay@icloud.com", 3, "123456" },
                    { 24, "serkan@outlook.com", 4, "123456" },
                    { 25, "emre@icloud.com", 3, "123456" },
                    { 26, "peker@icloud.com", 3, "123456" },
                    { 27, "irazca@icloud.com", 3, "123456" },
                    { 28, "hatice@hotmail.com", 2, "123456" },
                    { 29, "bariş@outlook.com", 4, "123456" },
                    { 30, "rezan@icloud.com", 3, "123456" },
                    { 31, "fatih@icloud.com", 3, "123456" },
                    { 32, "fuat@icloud.com", 3, "123456" },
                    { 33, "gökhan@hotmail.com", 2, "123456" },
                    { 34, "orhan@gmail.com", 1, "123456" },
                    { 35, "mehmet@gmail.com", 1, "123456" },
                    { 36, "evren@hotmail.com", 2, "123456" },
                    { 37, "oktay@gmail.com", 1, "123456" },
                    { 38, "harun@outlook.com", 4, "123456" },
                    { 39, "yavuz@gmail.com", 1, "123456" },
                    { 40, "pinar@outlook.com", 4, "123456" },
                    { 41, "mehmet@hotmail.com", 2, "123456" },
                    { 42, "umut@gmail.com", 1, "123456" }
                });

            migrationBuilder.InsertData(
                table: "Kullanıcılar",
                columns: new[] { "KullanıcıID", "Eposta", "RolID", "Şifre" },
                values: new object[,]
                {
                    { 43, "mesude@hotmail.com", 2, "123456" },
                    { 44, "seko@gmail.com", 1, "123456" },
                    { 45, "yunus@gmail.com", 1, "123456" },
                    { 46, "eyyup sabri@icloud.com", 3, "123456" },
                    { 47, "umut@icloud.com", 3, "123456" },
                    { 48, "cengiz@outlook.com", 4, "123456" },
                    { 49, "ufuk@icloud.com", 3, "123456" },
                    { 50, "ahmet ali@icloud.com", 3, "123456" },
                    { 51, "mediha@gmail.com", 1, "123456" },
                    { 52, "hasan@outlook.com", 4, "123456" },
                    { 53, "kamil@icloud.com", 3, "123456" },
                    { 54, "nebi@hotmail.com", 2, "123456" },
                    { 55, "özcan@hotmail.com", 2, "123456" },
                    { 56, "ilayda@icloud.com", 3, "123456" },
                    { 57, "ceren@hotmail.com", 2, "123456" },
                    { 58, "serkan@gmail.com", 1, "123456" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kullanıcılar_RolID",
                table: "Kullanıcılar",
                column: "RolID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kullanıcılar");

            migrationBuilder.DropTable(
                name: "Roller");
        }
    }
}
