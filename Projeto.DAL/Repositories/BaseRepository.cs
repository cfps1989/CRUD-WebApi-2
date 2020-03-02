using Projeto.DAL.Context;
using Projeto.DAL.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.DAL.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : class
    {
        public void Insert(T obj)
        {
            using(var context = new DataContext())
            {
                context.Entry(obj).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
            }
       
        }

        public void Update(T obj)
        {
            using(var context = new DataContext())
            {
                context.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(T obj)
        {
            using(var context = new DataContext())
            {
                context.Entry(obj).State = System.Data.Entity.EntityState.Deleted;
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
