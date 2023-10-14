using Dataton_API.Modules.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dataton_API.Context
{
    public class DocumentsDbContext:DbContext
    {
    public DocumentsDbContext(DbContextOptions<DocumentsDbContext> options) 
            : base(options) 
        {
        }
        public DbSet<Articles> Articles { get; set; }
        public DbSet<LifeSituations> LifeSituations { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Services> Services { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Articles>().HasData(
                new Articles
                {
                    Hashtag=2884,
                    Id = 135747,
                    SysLang="ru",
                    Project= "departament-kkbtu-sko",
                    Title= "Бешенство – смертельная угроза для человека!",
                    Content= "Бешенство – природно-очаговое особо опасное, смертельное заболевание. Среди инфекционных болезней бе...",
                    URL= "https://www.gov.kz/memleket/entities/departament-kkbtu-sko/press/article/details/135747?lang=ru"
                }
                );
            modelBuilder.Entity<LifeSituations>().HasData(
                new LifeSituations 
                {
                    Hashtag=202904,
                    Id=62,
                    SysLang="ru",
                    Intro= "Инвалиды – это лица, которые из-за стойких расстройств функций организма могут иметь некоторые огран...",
                    TitleMain= "Как установить инвалидность",
                    TitleSub= "Прохождение медико-социальной экспертизы (МСЭ)",
                    SubId=245,
                    Instructions= "Для установления инвалидности сначала нужно обратиться в медицинскую организацию по месту жительства...",
                    URL= "https://beta2.egov.kz/situations/62/245?lang=ru "

                }
                );
            modelBuilder.Entity<News>().HasData(
                new News 
                {
                    Hashtag=102884,
                    Id=117143,
                    SysLang="qq",
                    Projects= "mangystau",
                    Title="MAŃǴYSTAÝDA I ZhÁNE II DEŃGEILI INFEKTsIIaLYQ STATsIONARLARDA 57 NAÝQAS ZhATYR",
                    Body= "Mańǵystaýda 4 qarashadaǵy zhaǵdaiǵa sáikes I-II deńgeili infektsiialyq statsionarlarda 57 adam em qa...",
                    ShortDescription="",
                    URL= "https://www.gov.kz/memleket/entities/mangystau/press/news/details/117143?lang=qq"
                }
                );
            modelBuilder.Entity<Services>().HasData(
                new Services 
                {
                    Hashtag=0,
                    Id=3087,
                    SysLang="en",
                    AdditionalInfo="Rules for providing state services",
                    Description= "Dear citizens of the Republic of Kazakhstan! In order to prevent the spread of coronavirus infection...",
                    FullTitle= "Issuance of passports, Identification cards for citizens of the Republic of Kazakhstan",
                    ShortTitle= "Obtainment of passport, national ID",
                    Title= "Obtainment of passport, national ID",
                    ResultDescription= "Issuance of passport and (or) national ID of a citizen of the Republic of Kazakhstan.",
                    URL= "https://beta2.egov.kz/services/3087?lang=en"
                }
                );
        }
    }
}
