namespace Build_a_zoo.Models.Classes;

using Build_a_zoo.Interfaces;

public class ZooFeeder

{
    public static void Feed<T>(IAnimalPopper<T> animals)
    where T : Animal
    {

        for (int i = 0; i < animals.Count; i++)
        {
            var animal = animals.Pop();

            var food = animal.Consumption switch

            {
                FoodConsumption.Herbivore => "a fresh salad.",
                FoodConsumption.Carnivore => "a nice, juicy salmon.",
                FoodConsumption.Omnivore => "whatever they wanted.",
                _ => "this foodtype is not registered"

            };
            Console.WriteLine($"Fed {animal.Name} {food}");
        }

    }
}