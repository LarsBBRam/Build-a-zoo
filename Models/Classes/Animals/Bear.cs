namespace Build_a_zoo.Models.Classes.Animals;

public class Bear(string name, FoodConsumption food, int age, string coat) : Animal(name, food, age)
{
    public string Coat { get; set; } = coat;
}