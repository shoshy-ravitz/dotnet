using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//check using- if need it and why

namespace SwimmingLessons.Entities
{
    public enum KindSwim
    {
        //to fill in 
        //רגיל ,חתירה,מתקדם,...
        NORMAL,HARD
    }
    [Table("course")]
    public class Course
    {
        [Key]
        public int CodeCourse { get; set; }//key
        //public KindSwim KindSwim { get; set; }
        public int CountLessons { get; set; }
        public double Price { get; set; }
        public List<Group> Groups { get; set; }//many-to-one
        //many-to-many
        public List<Guide> guides { get; set; }//רשימה של מדריכים מוסמכים לקורס זה
    }
}