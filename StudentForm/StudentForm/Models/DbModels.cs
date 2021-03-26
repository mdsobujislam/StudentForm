using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace StudentForm.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required,StringLength(50),Display(Name = "Student Name")]
        public string StudentName { get; set; }
        [Required, StringLength(50), Display(Name = "Father's Name")]
        public string FatherName { get; set; }
        [Required, StringLength(50), Display(Name = "Mother's Name")]
        public string MotherName { get; set; }
        [Required, StringLength(50), Display(Name = "Email")]
        public string Email { get; set; }
        [Required, StringLength(50), Display(Name = "Phone No")]
        public string PhoneNo { get; set; }
        [Required, StringLength(50), Display(Name = "Religious")]
        public string Religious { get; set; }
        [Required,Display(Name = "Gender")]
        public string Gender { get; set; }
        [Required, Display(Name = "Date Of Birth"), Column(TypeName = "date"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DateOfBirth { get; set; }
        [Required, StringLength(200), Display(Name = "Present Address")]
        public string PresentAddress { get; set; }
        [Required, StringLength(200), Display(Name = "Permanent Address")]
        public string PermanentAddress { get; set; }
        [Required,Display(Name = "Qualification")]
        public string Qualification { get; set; }
        [Required, Display(Name = "Course Applied For")]
        public string CourseApplied { get; set; }
    }
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options):base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
