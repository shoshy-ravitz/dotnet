using SwimmingLessons.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingLesson.Core.InterfaceRepository
{
    public interface IRepository<T>
    {
        public List<T> Get();
        public T GetByCode(int code);
        public bool Add(T obj);
        public bool Update(int id, T obj);
        public bool Delete(int code);
    }
}
