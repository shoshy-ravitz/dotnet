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
        public List<Course> GetCourses();
        public Course GetCourseByCode(int CodeCourse);
        public bool AddCourse(Course course);
        public bool UpdateCourse(int CourseId, Course course);
        public bool DeleteCourse(int CodeCourse);
    }
}
