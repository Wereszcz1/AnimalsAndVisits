using Microsoft.AspNetCore.Mvc;
using WebApplication1;
using WebApplication1.Models;

namespace ShelterApi.Controllers;

[ApiController]
[Route("api/animals/{animalId}/[controller]")]
public class VisitsController : ControllerBase
{
    // GET: /api/animals/{animalId}/visits
    [HttpGet]
    public ActionResult<IEnumerable<Visit>> GetAllVisits(int animalId)
    {
        var animal = Database.Animals.FirstOrDefault(a => a.Id == animalId);
        if (animal == null)
            return NotFound();

        return Ok(animal.Visits);
    }

    // POST: /api/animals/{animalId}/visits
    [HttpPost]
    public ActionResult<Visit> AddVisit(int animalId, Visit visit)
    {
        var animal = Database.Animals.FirstOrDefault(a => a.Id == animalId);
        if (animal == null)
            return NotFound();

        visit.Id = animal.Visits.Any() ? animal.Visits.Max(v => v.Id) + 1 : 1;
        animal.Visits.Add(visit);
        return CreatedAtAction(nameof(GetAllVisits), new { animalId = animalId }, visit);
    }
}