namespace AutoSalon.Domain.Abstract
{
    using System.Linq;

    public interface IRepository<T> where T : class
    {
        IQueryable<T> All();

        void Add(T entity);

        int SaveChanges();
    }
}
