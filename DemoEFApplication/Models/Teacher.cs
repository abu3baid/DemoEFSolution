using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoEFApplication.Models
{
    public class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MinLength(10)]
        [MaxLength(60)]
        public string TeacherName { get; set; }
        [Range(22,70)]
        public int TeacherAge { get; set; }
    }
}
