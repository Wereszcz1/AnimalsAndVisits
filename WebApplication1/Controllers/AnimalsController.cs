using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    // api/animals => [controller] = Animals
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        // GET: api/animals
        [HttpGet]
        public ActionResult<IEnumerable<Animal>> GetAll()
        {
            return Ok(Database.Animals);
        }
        
        // GET: /api/animals/{id}
        [HttpGet("{id}")]
        public ActionResult<Animal> GetById(int id)
        {
            var animal = Database.Animals.FirstOrDefault(a => a.Id == id);
            if (animal == null)
                return NotFound();
            return Ok(animal);
        }
        
        // POST: /api/animals
        [HttpPost]
        public ActionResult<Animal> Create(Animal animal)
        {
            animal.Id = Database.Animals.Any() ? Database.Animals.Max(a => a.Id) + 1 : 1;
            Database.Animals.Add(animal);
            return CreatedAtAction(nameof(GetById), new { id = animal.Id }, animal);
        }
        
        // PUT: /api/animals/{id}
        [HttpPut("{id}")]
        public ActionResult<Animal> Update(int id, Animal updatedAnimal)
        {
            var animal = Database.Animals.FirstOrDefault(a => a.Id == id);
            if (animal == null)
                return NotFound();
            
            animal.Name = updatedAnimal.Name;
            animal.Category = updatedAnimal.Category;
            animal.Weight = updatedAnimal.Weight;
            animal.Color = updatedAnimal.Color;
            return NoContent();
        }
        
        // DELETE: /api/animals/{id}
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var animal = Database.Animals.FirstOrDefault(a => a.Id == id);
            if (animal == null)
                return NotFound();
            
            Database.Animals.Remove(animal);
            return NoContent();
        }
        
        // GET: /api/animals/seatch/{name}
        [HttpGet("search/{name}")]
        public IActionResult SearchAnimalsByName(string name)
        {
            var foundAnimals = Database.Animals
                .Where(a => a.Name.Contains(name, StringComparison.OrdinalIgnoreCase)) // Ignoruje wielkość liter
                .ToList();

            if (foundAnimals.Any())
            {
                return Ok(foundAnimals);
            }
            return NotFound($"No animals found with the name: {name}");
        }
    }
}
