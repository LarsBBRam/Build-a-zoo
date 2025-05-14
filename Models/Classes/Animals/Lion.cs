namespace Build_a_zoo.Models.Classes.Animals;

public class Lion(string name, FoodConsumption food, int age, string maleOrFemale) : Animal(name, food, age)
{
    public string MaleOrFemale { get; set; } = maleOrFemale;

    public void Roar() => Console.WriteLine($"{Name} roars loudly!");
}