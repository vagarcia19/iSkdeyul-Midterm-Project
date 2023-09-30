using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iSkedyul.Models.DB
{
    public class Appointments
    {
        [Key]
        public int AppointmentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Column(TypeName = "Date")]
        public DateTime DateOfAppointment { get; set; }
        [Column(TypeName = "Time(7)")]
        public DateTime TimeOfAppointment { get; set; }
        public string Purpose { get; set; }
    }
}