using System.ComponentModel.DataAnnotations;

namespace iSkedyul.Models.DB
{
    public class Appointments
    {
        [Key]
        public int AppointmentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfAppointment { get; set; }
        public DateTime TimeOfAppointment { get; set; }
        public string Purpose { get; set; }
    }
}