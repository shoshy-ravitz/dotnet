using SwimmingLessons.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingLesson.Core.InterfaceService
{
    public interface IStudentService
    {
        public List<Student> GetStudents();
        public Student GetStudentByCode(int CodeStudent);
        public bool AddStudent(Student student);
        public bool UpdateStudent(int studentId, Student student);
        public bool DeleteStudent(int CodeStudent);
    }
}
