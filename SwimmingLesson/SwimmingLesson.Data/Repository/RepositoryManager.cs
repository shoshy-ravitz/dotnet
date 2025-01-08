using SwimmingLesson.Core.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingLesson.Data.Repository
{
    public  class RepositoryManager<T>:IRepositoryManager<T> where T : class
    {
        readonly DataContext _context;
        public IRepository<T> _repository;
        public RepositoryManager(DataContext context,IRepository<T> repository)
        {
            _context = context;
            _repository = repository;
        }   
        public void save()
        {
            _context.SaveChanges();
        }
    }
}
