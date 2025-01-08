using Microsoft.EntityFrameworkCore;
using SwimmingLesson.Core.InterfaceRepository;
using SwimmingLessons.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingLesson.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        //readonly DataContext _context;
        //public CourseRepository(DataContext context) 
        //{
        //    _context = context;
        //}
        private readonly DbSet<Course> _dbset;
        public CourseRepository(DataContext context)
        {
            _dbset = context.Set<Course>();
        }
        public bool Add(Course obj)
        {
            _dbset.Add(obj);
            return true;
        }
        public bool Delete(int code)
        {
            if (_dbset.Find(code) != null)
            {
                _dbset.Remove(_dbset.Find(code));
                return true;
            }
            return false;
        }
        public IEnumerable<Course> Get()
        {
            return _dbset.Include(c =>  c.Groups).Include(c=>c.guides);
        }

        public Course? GetByCode(int code)
        {
            return _dbset.Find(code);
        }

        public bool Update(int id, Course obj)
        {

            _dbset.Update(obj);
            return true;
        }

        


    }
}
