using ClassLibraryDados.Context;
using ClassLibraryDados.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ClassLibraryDados.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : class
    {

        public void Insert(T obj)
        {
            using(var context = new DataContext())
            {
                context.Entry(obj).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(T obj)
        {
            using (var context = new DataContext())
            {
                context.Entry(obj).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using(var context = new DataContext())
            {
                var obj = context.Set<T>().Find(id);

                context.Entry(obj).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<T> SelectAll()
        {
            using(var context = new DataContext())
            {
                return context.Set<T>().ToList();
            }
        }

        public T SelectById(int id)
        {
            using(var context = new DataContext())
            {
                return context.Set<T>().Find(id);
                
            }
        }

    }
}
