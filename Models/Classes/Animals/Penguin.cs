namespace Build_a_zoo.Models.Classes.Animals;

public class Penguin(string name, FoodConsumption food, int age, string type) : Animal(name, food, age)
{
    public string Type { get; set; } = type;

    public void Slide() => Console.WriteLine($"{Name} slides with great speed down the ramp into the water.");
}