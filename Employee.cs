namespace WebApplication2.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; } // مثل حلاق، مصفف شعر، إلخ
        public bool IsAvailable { get; set; } // حالة التوفر
    }

}
