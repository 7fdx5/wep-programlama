namespace WebApplication2.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public int UserId { get; set; } // معرف المستخدم الذي حجز الموعد
        public int EmployeeId { get; set; } // معرف الموظف الذي قام بالحجز
        public DateTime Date { get; set; } // تاريخ ووقت الحجز
        public string Service { get; set; } // نوع الخدمة المحجوزة
    }

}
