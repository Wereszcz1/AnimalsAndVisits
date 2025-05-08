using WebApplication1.Controllers;

namespace WebApplication1.Models;

public class Visit
{
    public int Id { get; set; }
    public DateTime VisitDate { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
}