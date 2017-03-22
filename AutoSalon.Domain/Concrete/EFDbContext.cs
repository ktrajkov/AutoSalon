namespace AutoSalon.Domain.Concrete
{
    using Entities;
    using Migrations;
    using System.Data.Entity;

    public class EFDbContext : DbContext
    {
        public EFDbContext()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<EFDbContext, Configuration>());
        }

        public IDbSet<Car> Cars { get; set; }
    }

}
