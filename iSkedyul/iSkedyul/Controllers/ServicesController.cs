using iSkedyul.Models.DB;
using iSkedyul.Models.EntityManager;
using Microsoft.AspNetCore.Mvc;

namespace iSkedyul.Controllers
{
    public class ServicesController : Controller
    {
        public ActionResult SubmitApplication()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(Appointments appointment)
        {
            AppointmentManager appointmentManager = new AppointmentManager();
            if (!string.IsNullOrWhiteSpace(appointment.Purpose))
            {
                appointmentManager.AddAppointment(appointment);
                return RedirectToAction("", "Home");
            }
            else
                ModelState.AddModelError("", "Please add valid informations.");

            return View();
        }
        
    }
}
