using SwimmingLessons.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingLesson.Core.InterfaceService
{
    public interface ICourseService
    {
        public IEnumerable<Course> GetCourses();
        public Course GetCourseByCode(int codeCourse);
        public bool AddCourse(Course course);
        public bool UpdateCourse(int courseId, Course course);
        public bool DeleteCourse(int codeCourse);

    }
}
