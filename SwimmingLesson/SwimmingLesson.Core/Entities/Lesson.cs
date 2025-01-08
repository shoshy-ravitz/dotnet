using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//check using- if need it and why

namespace SwimmingLessons.Entities
{
    public class Lesson
    {
        [Key]
        public int CodeLesson{ get; set; }
        public int NumLesson { get; set; }
        public DateTime? DateLesson { get; set; }
        public DateTime? TimeStartLesson { get; set; }
        public DateTime? TimeEndLesson { get;set; }
        public bool FreeSwimming { get; set; }
        public string LearntInLesson { get; set; }
    }
}