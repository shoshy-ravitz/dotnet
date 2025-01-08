using SwimmingLesson.Core.InterfaceRepository;
using SwimmingLesson.Core.InterfaceService;
using SwimmingLessons.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingLesson.Service.Services
{
    public class LessonService : ILessonService
    {
        readonly IRepository<Lesson> _lessonRepository;
        readonly IRepositoryManager<Lesson> _lessonManager;
        public LessonService(IRepository<Lesson> lessonRepository, IRepositoryManager<Lesson> lessonManager)
        {
            _lessonRepository = lessonRepository;
            _lessonManager = lessonManager;
        }

        public bool AddLesson(Lesson lesson)
        {
            bool res= _lessonRepository.Add(lesson);
            _lessonManager.save();
            return res;
        }

        public bool DeleteLesson(int codeLesson)
        {
            bool res= _lessonRepository.Delete(codeLesson);
            _lessonManager.save();
            return res;
        }

        public Lesson GetLessonByCode(int codeLesson)
        {
            return _lessonRepository.GetByCode(codeLesson);
        }

        public IEnumerable<Lesson> GetLessons()
        {
            return _lessonRepository.Get();
        }

        public bool UpdateLesson(int lessonId, Lesson lesson)
        {
            bool res= _lessonRepository.Update(lessonId, lesson);
            _lessonManager.save();
            return res;
        }
    }
}
