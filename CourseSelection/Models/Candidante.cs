using System.ComponentModel.DataAnnotations;

namespace CourseSelection.Models
{
    public class Candidante
    {
        [Required(ErrorMessage = "E-mail is required")]
        public string? Email { get; set; } = String.Empty;
        [Required(ErrorMessage = "Name is required")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Surname is required")]
        public string? SurName { get; set; }
        public string? FullName => $"{Name} {SurName?.ToUpper()}";
        public int? Age { get; set; }
        [Required(ErrorMessage = "Please chose a course")]
        public string? SelectedCourse { get; set; }=String.Empty; 
        public DateTime ApplyAt { get; set; }

        public Candidante()
        {
                ApplyAt=DateTime.Now;
        }
    }
}
