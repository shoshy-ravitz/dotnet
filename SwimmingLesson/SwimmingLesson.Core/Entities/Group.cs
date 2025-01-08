using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//check using- if need it and why

namespace SwimmingLessons.Entities
{
    [Table("group")]
    public class Group
    {
        [Key]
        public int CodeGroup { get; set; }//key
        public int CodeGuide { get; set; }//
        public int CodeStudent { get; set; }
        public int MaxStudent { get; set; }
        public int CountStudent { get; set; }
        public int CodeCourse { get; set; }//Key
        
        [ForeignKey(nameof(CodeCourse))]
        public Course Course { get; set;}//one-to-many

        [ForeignKey(nameof(CodeGuide))]
        public Guide Guide { get; set; }//one-to-many
        public List<Student> Students { get; set; }//mamy-to-many
        public List<Lesson> Lessons { get; set; }//many-to-one
    }
}
