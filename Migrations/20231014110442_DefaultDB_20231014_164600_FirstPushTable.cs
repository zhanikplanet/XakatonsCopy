using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dataton_API.Migrations
{
    /// <inheritdoc />
    public partial class DefaultDB_20231014_164600_FirstPushTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hashtag = table.Column<int>(type: "int", nullable: false),
                    SysLang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Project = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LifeSituations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hashtag = table.Column<int>(type: "int", nullable: false),
                    SysLang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Intro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleMain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleSub = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubId = table.Column<int>(type: "int", nullable: false),
                    Instructions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LifeSituations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hashtag = table.Column<int>(type: "int", nullable: false),
                    SysLang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Projects = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hashtag = table.Column<int>(type: "int", nullable: false),
                    SysLang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResultDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Content", "Hashtag", "Project", "SysLang", "Title", "URL" },
                values: new object[] { 135747, "Бешенство – природно-очаговое особо опасное, смертельное заболевание. Среди инфекционных болезней бе...", 2884, "departament-kkbtu-sko", "ru", "Бешенство – смертельная угроза для человека!", "https://www.gov.kz/memleket/entities/departament-kkbtu-sko/press/article/details/135747?lang=ru" });

            migrationBuilder.InsertData(
                table: "LifeSituations",
                columns: new[] { "Id", "Hashtag", "Instructions", "Intro", "SubId", "SysLang", "TitleMain", "TitleSub", "URL" },
                values: new object[] { 62, 202904, "Для установления инвалидности сначала нужно обратиться в медицинскую организацию по месту жительства...", "Инвалиды – это лица, которые из-за стойких расстройств функций организма могут иметь некоторые огран...", 245, "ru", "Как установить инвалидность", "Прохождение медико-социальной экспертизы (МСЭ)", "https://beta2.egov.kz/situations/62/245?lang=ru " });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "Body", "Hashtag", "Projects", "ShortDescription", "SysLang", "Title", "URL" },
                values: new object[] { 117143, "Mańǵystaýda 4 qarashadaǵy zhaǵdaiǵa sáikes I-II deńgeili infektsiialyq statsionarlarda 57 adam em qa...", 102884, "mangystau", "", "qq", "MAŃǴYSTAÝDA I ZhÁNE II DEŃGEILI INFEKTsIIaLYQ STATsIONARLARDA 57 NAÝQAS ZhATYR", "https://www.gov.kz/memleket/entities/mangystau/press/news/details/117143?lang=qq" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "AdditionalInfo", "Description", "FullTitle", "Hashtag", "ResultDescription", "ShortTitle", "SysLang", "Title", "URL" },
                values: new object[] { 3087, "Rules for providing state services", "Dear citizens of the Republic of Kazakhstan! In order to prevent the spread of coronavirus infection...", "Issuance of passports, Identification cards for citizens of the Republic of Kazakhstan", 0, "Issuance of passport and (or) national ID of a citizen of the Republic of Kazakhstan.", "Obtainment of passport, national ID", "en", "Obtainment of passport, national ID", "https://beta2.egov.kz/services/3087?lang=en" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "LifeSituations");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}
