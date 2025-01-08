using SwimmingLesson.Core.InterfaceRepository;
using SwimmingLesson.Core.InterfaceService;
using SwimmingLesson.Data;
using SwimmingLessons.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingLesson.Service.Service
{
    public class CourseService : ICourseService
    {
         readonly ICourseRepository _dataRepository;
        readonly IRepositoryManager<Course> _repositoryManager;

        public CourseService(ICourseRepository data, IRepositoryManager<Course> repositoryManager)
        {
            _dataRepository = data;
            _repositoryManager = repositoryManager;
        }
        public bool AddCourse(Course course)
        {
            bool res= _dataRepository.Add(course);
            _repositoryManager.save();
            return res;
        }

        public bool DeleteCourse(int CodeCourse)
        {
            bool res= _dataRepository.Delete(CodeCourse);
            _repositoryManager.save();
            return res;
        }

        public Course GetCourseByCode(int CodeCourse)
        {
            return _dataRepository.GetByCode(CodeCourse);
        }

        public IEnumerable<Course> GetCourses()
        {
            return _dataRepository.Get();
        }

        public bool UpdateCourse(int CourseId, Course course)
        {

            bool res= _dataRepository.Update(CourseId, course);
            _repositoryManager.save();
            return res;
        }
    }
}
