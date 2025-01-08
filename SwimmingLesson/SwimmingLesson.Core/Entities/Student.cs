using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//check using- if need it and why

namespace SwimmingLessons.Entities
{
    public enum HealthFund
    {
        MACABI, CLALIT, MEHUCHEDET, LEHUMIT
    }
    public class Student
    {
        [Key]
        public int CodeStudent { get; set; }//key
        public string Name { get; set; }
        public string Tz { get; set; }
        public DateTime DateBirth { get; set; }
        public HealthFund HealthFund { get; set; }
        public double Price { get; set; }
        public int ProofPayment { get; set; }
       // public int CodeGroup { get; set; }//key
        public double Mark { get; set; }

        public List<Group> Groups { get; set; }//many-to-many

    }
}
