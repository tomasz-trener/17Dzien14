using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Any;
using P05Sklep.Shared;
using P06Sklep.DataSeeder;

namespace P04Sklep.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Product>().HasData(
            //    new Product()
            //    {
            //        Id = 1,
            //        Description = "desc1",
            //        Color = "c2",
            //        Title = "product1"
            //    },
            //     new Product()
            //     {
            //         Id = 2,
            //         Color = "c2",
            //         Description = "desc2",
            //         Title = "product1"
            //     });
            modelBuilder.Entity<Product>().HasData(ProductSeeder.GenerateProductData());
        }


        public DbSet<Product> Products { get; set; }

    }

    /* cały proces
     * 1) 
     * dotnet ef -> sprawdzmy czy jest zainstalowane dotnet entity framework 
     * - jak nie jest zainstalowane to polecenie :
     * dotnet tool install --global dotnet-ef 
     * 2) Dodanie conn string do appsettings.json 
     * 3) Stwodzenie DataContext
     * 4) z Program.cs wskrzykujemy connString do DataContext 
     *  (uwaga: potrzebne są 2 paczki:
     *   - Microsoft.EntityFrameworkCore
     *   - Microsoft.EntityFrameworkCore.Design
     *   - Microsoft.EntityFrameworkCore.SqlServer 
     *  5) dodanie migracji 
     *  dotnet ef migrations add InitialMigration
     *  6) aktualizacja bazy danych
     *  dotnet ef database update
    */



}
