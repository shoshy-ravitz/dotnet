using Microsoft.EntityFrameworkCore;
using SwimmingLessons.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
namespace SwimmingLesson.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Course> Courses { get; set; } 
        public DbSet<Student> Students { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Group> Groups { get; set; }

         
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = DESKTOP-SSNMLFD; Initial Catalog = swimmingLesson; Integrated Security = true; ");
        }
    }
    //public class DataContext
    //{
    //    public  List<Course> Courses { get; set; } 
    //    public  List<Student> Students { get; set; }
    //    public  List<Guide> Guides { get; set; } 
    //    public  List<Lesson> Lessons { get; set; }
    //    public  List<Group> Groups { get; set; }
    //    public DataContext()
    //    {
    //        //string path = "C:\\Users\\user1\\Desktop\\SwimmingLesson\\SwimmingLesson.Data\\DTO\\course.json";
    //        //string jsonString = File.ReadAllText(path);
    //        //JsonSerializer.Deserialize<Course>(jsonString);
    //    }
    //    //public bool SaveData(List<Course> data)
    //    //{
    //    //    try
    //    //    {
    //    //        string path = Path.Combine(AppContext.BaseDirectory, "Data", "data.json");
    //    //        List<Course> dataToSave = data;
    //    //        string jsonString = JsonSerializer.Serialize<List<Course>>(dataToSave);
    //    //        if (File.Exists(path))
    //    //        {
    //    //            File.Delete(path);
    //    //        }
    //    //        File.WriteAllText(path, jsonString);
    //    //        return true;
    //    //    }
    //    //    catch
    //    //    {
    //    //        return false;
    //    //    }
    //    //}
    //}
}

