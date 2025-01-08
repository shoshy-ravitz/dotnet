using SwimmingLessons.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingLesson.Core.InterfaceRepository
{
    public interface ILessonRepository
    {
        public List<Lesson> GetLessons();
        public Lesson GetLessonByCode(int CodeLesson);
        public bool AddLesson(Lesson lesson);
        public bool UpdateLesson(int lessonId, Lesson lesson);
        public bool DeleteLesson(int CodeLesson);
    }
}
