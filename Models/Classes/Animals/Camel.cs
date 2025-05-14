namespace Build_a_zoo.Models.Classes.Animals;

public class Camel(string name, FoodConsumption food, int age, int humps) : Animal(name, food, age)
{
    public int Humps { get; set; } = humps;
}