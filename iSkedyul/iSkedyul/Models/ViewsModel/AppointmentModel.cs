using System.ComponentModel.DataAnnotations;

namespace iSkedyul.Models.ViewModel
{
    public class AppointmentModel
    {
        [Key]
        public int AppointmentID { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Date of Appointment")]
        public DateTime DateOfAppointment { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Time of Appointment")]
        public DateTime TimeOfAppointment { get; set; }
        [Required(ErrorMessage = "*")]
        [Display(Name = "Purpose")]
        public string Purpose { get; set; }
    }
}