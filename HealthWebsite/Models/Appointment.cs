namespace HealthWebsite.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
    }
}
