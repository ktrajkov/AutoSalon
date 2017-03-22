namespace AutoSalon.Domain.Migrations
{
    using Entities;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Concrete.EFDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Concrete.EFDbContext context)
        {
            if (context.Cars.Count() == 0)
            {
                context.Cars.AddOrUpdate(
                    new Car
                    {
                        Brand = "Audi",
                        YearOfManufacture = 2005,
                        Horsepower = 228,
                        Importer = "Happy Cars",
                        Description = "description"
                    },
                    new Car
                    {
                        Brand = "BMW",
                        YearOfManufacture = 2006,
                        Horsepower = 162,
                        Importer = "Funky Vehicles",
                        Description = "some other description"
                    },
                    new Car
                    {
                        Brand = "Dacia",
                        YearOfManufacture = 2007,
                        Horsepower = 44,
                        Importer = "Nice & Cheap",
                        Description = "another description"
                    },
                    new Car
                    {
                        Brand = "Fiat",
                        YearOfManufacture = 2008,
                        Horsepower = 72,
                        Importer = "Bella Italia",
                        Description = "even more description"
                    },
                    new Car
                    {
                        Brand = "Volkswagen",
                        YearOfManufacture = 2010,
                        Horsepower = 96,
                        Importer = "German Automotion",
                        Description = "description once again"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
