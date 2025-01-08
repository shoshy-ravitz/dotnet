using SwimmingLessons.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingLesson.Core.InterfaceService
{
    public interface ILessonService
    {
        public List<Lesson> GetLessons();
        public Lesson GetLessonByCode(int codeLesson);
        public bool AddLesson(Lesson lesson);
        public bool UpdateLesson(int lessonId, Lesson lesson);
        public bool DeleteLesson(int codeLesson);


    }
}

