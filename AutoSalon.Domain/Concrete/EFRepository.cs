namespace AutoSalon.Domain.Concrete
{
    using System;
    using System.Linq;
    using AutoSalon.Domain.Abstract;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public class EFRepository<T> : IRepository<T> where T : class
    {    
        public EFRepository(EFDbContext context)
        {
            if (context == null)
            {
                throw new ArgumentException("An instance of DbContext is required to use this repository.", "context");
            }

            this.Context = context;
            this.DbSet = this.Context.Set<T>();
        }

        public virtual IQueryable<T> All()
        {
            return this.DbSet.AsQueryable();
        }

        public virtual void Add(T entity)
        {
            DbEntityEntry entry = this.Context.Entry(entity);
            if (entry.State != EntityState.Detached)
            {
                entry.State = EntityState.Added;
            }
            else
            {
                this.DbSet.Add(entity);
            }
        }

        public int SaveChanges()
        {
            return this.Context.SaveChanges();
        }

        protected DbContext Context { get; set; }

        protected IDbSet<T> DbSet { get; set; }
    }
}
