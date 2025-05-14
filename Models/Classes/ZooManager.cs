namespace Build_a_zoo.Models.Classes;


using Build_a_zoo.Interfaces;
using Build_a_zoo.Models.Classes.Animals;

public class ZooManager
{

    //Thanks to Contravariance we can use AnimalShow<Lion>, AnimalShow<Elephant>, and so on.

    public static void RunSHow(IAnimalShow<Animal> show)
    {

        Console.WriteLine("\n=== Animal Show Starting ===");
        for (int i = 0; i < show.PerformerCount; i++)
        {
            var performer = show.GetNextPerformer();

            Console.WriteLine($"{performer.Name} performs for the audience.");

            //We can use type-specific functionality via Casting

            if (performer is Lion lion)
                lion.Roar();
            else if (performer is Elephant elephant)
                elephant.Spray();
            else if (performer is Penguin penguin)
                penguin.Slide();
            else
                Console.WriteLine($"{performer.Name} does a generic trick!");
        }
        Console.WriteLine("\n=== Animal Show ended ===");
    }

    //because of Contravariance we can use AnimalSorter<animal> for all animals.

    public static void OrganizeExhibit<T>(IEnumerable<T> animals, AnimalSorter<T> sorter) where T : Animal
    {
        Console.WriteLine("\n=== Organizing New Exhibit ===");
        sorter.SortByAge(animals);
        Console.WriteLine("=== Exhibit Ready ===\n");
    }

    //This method shows both Covariance and Contravariance

    public static void FeedAndTrain<T>(IAnimalPopper<T> source, IPushable<Animal> destination) where T : Animal
    {
        Console.WriteLine("\n=== Feeding and Training Session ===");
        for (int i = 0; i < Math.Min(5, source.Count); i++)
        {
            var animal = source.Pop();
            Console.WriteLine($"Training {animal.Name}....");
            destination.Push(animal); // This works because Animal is a superclass of T
        }
        Console.WriteLine("=== Session Complete ===\n");
    }
}