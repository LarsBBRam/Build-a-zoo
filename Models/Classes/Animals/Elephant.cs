namespace Build_a_zoo.Models.Classes.Animals;

public class Elephant(string name, FoodConsumption food, int age, string earSize) : Animal(name, food, age)
{
    public string EarSize { get; set; } = earSize;
    public void Spray() => Console.WriteLine($"{Name} sprays water out of its trunk!");
}