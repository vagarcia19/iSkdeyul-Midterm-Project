using iSkedyul.Models.DB;
using iSkedyul.Models.ViewModel;

namespace iSkedyul.Models.EntityManager
{
    public class AppointmentManager
    {
        public void AddAppointment(Appointments ap)
        {
            using (MyDBContext dBContext = new MyDBContext()) 
            {
                Appointments appt = new Appointments
                {
                    AppointmentID = ap.AppointmentID,
                    FirstName = ap.FirstName,
                    LastName = ap.LastName,
                    DateOfAppointment = ap.DateOfAppointment.Date,
                    TimeOfAppointment = ap.TimeOfAppointment,
                    Purpose = ap.Purpose
                };

                Console.WriteLine(appt.AppointmentID);
                Console.WriteLine(appt.FirstName);
                Console.WriteLine(appt.LastName);
                Console.WriteLine(appt.DateOfAppointment);
                Console.WriteLine(appt.TimeOfAppointment);
                Console.WriteLine(appt.Purpose);

                dBContext.Appointments.Add(appt);
                dBContext.SaveChanges();
            }
        }
    }
}
