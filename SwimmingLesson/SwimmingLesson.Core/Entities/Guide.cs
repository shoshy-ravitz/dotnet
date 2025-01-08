using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//check using- if need it and why

namespace SwimmingLessons.Entities
{
    public class Guide
    {
        [Key]
        public int Id { get; set; }//key
        public string Name { get; set; }
        public string Tz { get; set; }
        public DateTime DateBirth { get; set; }
        public int Seniority { get; set; }//ותק        
        public double Salary { get; set; }
        public List<Group> Groups { get; set; }//many-to-one
        public List<Course> Courses { get; set; }//many-to-many
    }
}
