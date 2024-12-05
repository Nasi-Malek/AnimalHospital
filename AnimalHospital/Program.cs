using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimalHospital
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>
        {
            new Animal { Name = "Bella", Type = "Hund", Age = 5, IsVaccinated = true, NumberOfLegs = 4 },
            new Animal { Name = "Milo", Type = "Katt", Age = 3, IsVaccinated = false, NumberOfLegs = 4 },
            new Animal { Name = "Rocky", Type = "Hund", Age = 8, IsVaccinated = true, NumberOfLegs = 4 },
            new Animal { Name = "Luna", Type = "Katt", Age = 2, IsVaccinated = true, NumberOfLegs = 4 },
            new Animal { Name = "Shadow", Type = "Hund", Age = 7, IsVaccinated = false, NumberOfLegs = 4 },
            new Animal { Name = "Charlie", Type = "Fågel", Age = 1, IsVaccinated = true, NumberOfLegs = 2 },
            new Animal { Name = "Daisy", Type = "Kaninhund", Age = 6, IsVaccinated = true, NumberOfLegs = 4 },
            new Animal { Name = "Loki", Type = "Orm", Age = 4, IsVaccinated = false, NumberOfLegs = 0 },
            new Animal { Name = "Zoe", Type = "Katt", Age = 9, IsVaccinated = true, NumberOfLegs = 4 },
            new Animal { Name = "Cooper", Type = "Hund", Age = 1, IsVaccinated = false, NumberOfLegs = 4 },
            new Animal { Name = "Max", Type = "Hund", Age = 3, IsVaccinated = true, NumberOfLegs = 4 }
        };

            // Fråga a
            int numberOfDogs = animals.Count(a => a.Type == "Hund");
            Console.WriteLine($"Antal hundar: {numberOfDogs}");

            // Fråga b
            Animal oldestAnimal = animals.OrderByDescending(a => a.Age).FirstOrDefault();
            Console.WriteLine($"Det äldsta djuret är {oldestAnimal.Name}, en {oldestAnimal.Type} på {oldestAnimal.Age} år.");

            // Fråga c
            var vaccinatedAnimals = animals.Where(a => a.IsVaccinated).ToList();
            Console.WriteLine("Vaccinerade djur:");
            foreach (var animal in vaccinatedAnimals)
            {
                Console.WriteLine($"{animal.Name} ({animal.Type})");
            }

            // Fråga d
            var fourLeggedOverThreeYears = animals.Where(a => a.NumberOfLegs == 4 && a.Age > 3).ToList();
            Console.WriteLine("Djur med 4 ben och över 3 år:");
            foreach (var animal in fourLeggedOverThreeYears)
            {
                Console.WriteLine($"{animal.Name} ({animal.Type})");
            }

            // Fråga e
            bool hasShadow = animals.Any(a => a.Name == "Shadow");
            Console.WriteLine($"Finns det ett djur som heter Shadow? {hasShadow}");
        }
    }
}
