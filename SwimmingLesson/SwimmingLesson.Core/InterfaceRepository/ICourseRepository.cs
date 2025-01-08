using SwimmingLessons.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingLesson.Core.InterfaceRepository
{
    public interface ICourseRepository
    {
        public IEnumerable<Course> Get();
        public Course GetByCode(int code);
        public bool Add(Course obj);
        public bool Update(int id, Course obj);
        public bool Delete(int code);
    }
}
