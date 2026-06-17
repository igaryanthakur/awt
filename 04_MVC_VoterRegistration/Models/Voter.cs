using System.ComponentModel.DataAnnotations;

namespace MVCVoter.Models
{
    public class Voter
    {
        // Auto-implemented properties with Data Annotations for validation

        [Required(ErrorMessage = "Voter ID is required")]
        [Display(Name = "Voter ID")]
        public string VoterId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be 2-100 characters")]
        [Display(Name = "Full Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Range(18, 120, ErrorMessage = "Age must be between 18 and 120")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(200, ErrorMessage = "Address too long")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Mobile number is required")]
        [RegularExpression(@"^[6-9]\d{9}$", ErrorMessage = "Enter valid 10-digit Indian mobile number")]
        [Display(Name = "Mobile Number")]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Constituency is required")]
        public string Constituency { get; set; }
    }
}
