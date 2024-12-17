namespace WebApplication2.Models
{
    public class Salon
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string WorkingHours { get; set; }
    public List<Service> Services { get; set; }
}

}
