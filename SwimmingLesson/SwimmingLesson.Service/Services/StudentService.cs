using SwimmingLesson.Core.InterfaceRepository;
using SwimmingLesson.Core.InterfaceService;
using SwimmingLesson.Data.Repository;
using SwimmingLessons.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingLesson.Service.Services
{
    public class StudentService : IStudentService
    {
        readonly IRepository<Student> _studentReposetory;
        readonly IRepositoryManager<Student> _repositoryManager;
        public StudentService(IRepository<Student> studentReposetory, IRepositoryManager<Student> repositoryManager)
        {
            _studentReposetory = studentReposetory;
            _repositoryManager = repositoryManager;
        }

        public bool AddStudent(Student student)
        {
          bool res=  _studentReposetory.Add(student);
            _repositoryManager.save();
            return res;

        }

        public bool DeleteStudent(int Codestudent)
        {
           bool res=_studentReposetory.Delete(Codestudent);
            _repositoryManager.save();
            return res;

        }

        public Student GetStudentByCode(int Codestudent)
        {
            return _studentReposetory.GetByCode(Codestudent);

        }

        public List<Student> GetStudents()
        {
            return _studentReposetory.Get();

        }

        public bool UpdateStudent(int studentId, Student student)
        {

            bool res= _studentReposetory.Update(studentId, student);
            _repositoryManager.save();
            return res;
        }
    }
}
