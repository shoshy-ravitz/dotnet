using Microsoft.EntityFrameworkCore;
using SwimmingLesson.Core.InterfaceRepository;
using SwimmingLessons.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SwimmingLesson.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbSet<T> _dbset;
        public Repository(DataContext context)
        {
            _dbset = context.Set<T>();
        }
        public bool Add(T obj)
        {
            _dbset.Add(obj);
            return true;
        }
        public bool Delete(int code)
        {
            if(_dbset.Find(code)!=null)
            {
                _dbset.Remove(_dbset.Find(code));
                return true;
            }
            return false;
        }
        public IEnumerable<T> Get()
        {
           return _dbset.ToList();
        }
        public T? GetByCode(int code)
        {
            return _dbset.Find(code);
        }
        public bool Update(int id, T obj)
        {

            _dbset.Update(obj);
            return true;
        }
    }
}
