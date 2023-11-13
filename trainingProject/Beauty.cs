using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingProject
{
    static class Appointment
    {
        public static DateTime Schedule(string appointmentDateDescription)
           => Convert.ToDateTime(appointmentDateDescription);

        public static bool HasPassed(DateTime appointmentDate)
            => appointmentDate < DateTime.Now ? true : false;

        public static bool IsAfternoonAppointment(DateTime appointmentDate)
            => (appointmentDate.Hour >= 12 && appointmentDate.Hour < 18) ? true : false;

        public static string Description(DateTime appointmentDate)
            => $"You have an appointment at {appointmentDate.ToString("MM / dd / yyyy h: mm:ss tt")}";

        public static DateTime AnniversaryDate()
            => new DateTime(DateTime.Today.Year, 9, 15);

    }
}
