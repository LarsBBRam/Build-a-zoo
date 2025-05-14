namespace Build_a_zoo.Models.Classes;

public class Animal(string name, FoodConsumption food, int age)
{
    public string Name { get; set; } = name;
    public FoodConsumption Consumption { get; set; } = food;
    public int Age { get; set; } = age;

}