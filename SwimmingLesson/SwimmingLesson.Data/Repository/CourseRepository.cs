//using SwimmingLesson.Core.InterfaceRepository;
//using swimmingLwssons.Entities;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SwimmingLesson.Data.Repository
//{
//    public class CourseRepository : ICourseRepository
//    {
//        readonly DataContext _data;
//        public CourseRepository(DataContext data)
//        {
//            _data = data;
//        }
//        public bool AddCourse(Course course)
//        {
//            _data.Courses.Add(course);
//            return _data.SaveData(_data.Courses);
//        }
//        public bool DeleteCourse(int CodeCourse)
//        {
//            _data.Courses.Remove(_data.Courses.FirstOrDefault((course)=>course.CodeCourse==CodeCourse));
//            return _data.SaveData(_data.Courses); ;
//        }

//        public Course GetCourseByCode(int CodeCourse)
//        {       
//            return _data.Courses.FirstOrDefault((course) => course.CodeCourse == CodeCourse);
//        }

//        public  List<Course> GetCourses()
//        {
//            return _data.Courses;
//        }

//        public bool UpdateCourse(int CourseId, Course course)
//        {
//            foreach (Course c in _data.Courses)
//            {
//                if (c.CodeCourse == CourseId)
//                {
//                    c.CountLessons = course.CountLessons;
//                    c.KindSwim = course.KindSwim;
//                    c.Price = course.Price;
//                    return _data.SaveData(_data.Courses);
//                }
//            }
//            return false;
//        }
//    }
//}
