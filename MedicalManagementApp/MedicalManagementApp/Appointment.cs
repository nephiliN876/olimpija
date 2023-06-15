using System;

namespace MedicalManagementApp
{
    internal class Appointment
    {
        public string PatientName { get; internal set; }
        public DateTime DateOfBirth { get; internal set; }
        public string PhoneNumber { get; internal set; }
        public object AppointmentId { get; internal set; }
    }
}