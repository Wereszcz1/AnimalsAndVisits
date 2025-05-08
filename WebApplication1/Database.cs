using WebApplication1.Models;

namespace WebApplication1;

public class Database
{
    public static List<Animal> Animals = new()
    {
        new Animal
        {
            Id = 1,
            Name = "Leo",
            Category = "Cat",
            Weight = 4.5,
            Color = "Brown",
            Visits = new List<Visit>
            {
                new Visit
                {
                    Id = 1,
                    VisitDate = new DateTime(2019, 12, 10, 9, 15, 0),
                    Description = "Observing lions",
                    Price = 9.99,
                }
            }
        },
        new Animal
        {
            Id = 2,
            Name = "Stompy",
            Category = "Elephant",
            Weight = 404.5,
            Color = "Grey",
            Visits = new List<Visit>
            {
                new Visit
                {
                Id = 2,
                VisitDate = new DateTime(2019, 12, 27, 10, 45, 10),
                Description = "Stompy Birthday",
                Price = 19.99,
                } 
            }
       },
        new Animal
        {
            Id = 3,
            Name = "Rocky",
            Category = "Dog",
            Weight = 30.2,
            Color = "Black",
            Visits = new List<Visit>
            {
                new Visit
                {
                    Id = 3,
                    VisitDate = new DateTime(2021, 7, 14, 15, 0, 0),
                    Description = "Vaccination visit",
                    Price = 49.99,
                },
                new Visit
                {
                    Id = 4,
                    VisitDate = new DateTime(2022, 3, 5, 11, 30, 0),
                    Description = "Check-up after surgery",
                    Price = 59.99,
                }
            }
        },
        new Animal
        {
            Id = 4,
            Name = "Coco",
            Category = "Parrot",
            Weight = 0.9,
            Color = "Green",
            Visits = new List<Visit>
            {
                new Visit
                {
                    Id = 5,
                    VisitDate = new DateTime(2020, 5, 20, 13, 45, 0),
                    Description = "Beak trimming",
                    Price = 29.99,
                }
            }
        },
        new Animal
        {
            Id = 5,
            Name = "Bella",
            Category = "Rabbit",
            Weight = 2.3,
            Color = "White",
            Visits = new List<Visit>() // na razie bez wizyt
        }
    };
}