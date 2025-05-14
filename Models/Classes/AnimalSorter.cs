namespace Build_a_zoo.Models.Classes;

using System.Security.Cryptography;
using Build_a_zoo.Interfaces;

public class AnimalSorter<T> : IAnimalSorter<T> where T : Animal
{
    public void SortByAge(IEnumerable<T> animals)
    {
        animals.ToList().Sort((a, b) => a.Age.CompareTo(b.Age));
        Console.WriteLine("Animals Sorted by age:");
        foreach (var animal in animals)
        {
            Console.WriteLine($"- {animal.Name} ({animal.Age} years)");
        }
    }
}
