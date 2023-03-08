using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class cedvel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Əlaqəs",
                columns: table => new
                {
                    ƏlaqəID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecabook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Instagram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Əlaqəs", x => x.ƏlaqəID);
                });

            migrationBuilder.CreateTable(
                name: "Haqqımızdas",
                columns: table => new
                {
                    HaqqımızdaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Məlumat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Şəkil = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Haqqımızdas", x => x.HaqqımızdaID);
                });

            migrationBuilder.CreateTable(
                name: "Xəbərlərs",
                columns: table => new
                {
                    XəbərlərID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Başlıq = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Məlumat = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Xəbərlərs", x => x.XəbərlərID);
                });

            migrationBuilder.CreateTable(
                name: "Mesajs",
                columns: table => new
                {
                    MesajID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Məlumat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tarix = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesajs", x => x.MesajID);
                });

            migrationBuilder.CreateTable(
                name: "Müəllimlərs",
                columns: table => new
                {
                    MüəllimlərID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Məlumat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Şəkil = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Müəllimlərs", x => x.MüəllimlərID);
                });

            migrationBuilder.CreateTable(
                name: "Tələbələrs",
                columns: table => new
                {
                    TələbələrID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Şəkil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nəticəsi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Məlumat = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tələbələrs", x => x.TələbələrID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Əlaqəs");

            migrationBuilder.DropTable(
                name: "Haqqımızdas");

            migrationBuilder.DropTable(
                name: "Xəbərlərs");

            migrationBuilder.DropTable(
                name: "Mesajs");

            migrationBuilder.DropTable(
                name: "Müəllimlərs");

            migrationBuilder.DropTable(
                name: "Tələbələrs");
        }
    }
}
