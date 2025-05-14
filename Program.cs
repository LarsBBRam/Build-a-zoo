using Build_a_zoo.Models.Classes;
using Build_a_zoo.Models.Classes.Animals;

namespace Build_a_zoo;


class Program
{
    static void Main(string[] args)
    {
        //create Animal pens
        var bearPen = new AnimalPen<Bear>(10);
        var camelPen = new AnimalPen<Camel>(10);
        var lionPen = new AnimalPen<Lion>(5);
        var elephantPen = new AnimalPen<Elephant>(3);
        var penguinPen = new AnimalPen<Penguin>(10);

        //add animals
        bearPen.Push(new Bear("Oluf", FoodConsumption.Omnivore, 12, "Brown"));
        bearPen.Push(new Bear("Randi", FoodConsumption.Carnivore, 10, "Polar"));

        camelPen.Push(new Camel("Kari", FoodConsumption.Herbivore, 8, 2));
        camelPen.Push(new Camel("Oscar", FoodConsumption.Herbivore, 10, 2));


        lionPen.Push(new Lion("Simba", FoodConsumption.Carnivore, 5, "Male"));
        lionPen.Push(new Lion("Nala", FoodConsumption.Carnivore, 4, "Female"));
        lionPen.Push(new Lion("Mufasa", FoodConsumption.Carnivore, 12, "Male"));

        elephantPen.Push(new Elephant("Dumbo", FoodConsumption.Herbivore, 3, "Small"));
        elephantPen.Push(new Elephant("Ellie", FoodConsumption.Herbivore, 15, "Big"));

        penguinPen.Push(new Penguin("Pingu", FoodConsumption.Carnivore, 2, "Emperor"));
        penguinPen.Push(new Penguin("Emperor", FoodConsumption.Carnivore, 7, "African"));
        penguinPen.Push(new Penguin("Happy", FoodConsumption.Carnivore, 4, "Northern Rockhopper"));
        penguinPen.Push(new Penguin("Gloria", FoodConsumption.Carnivore, 6, "Fairy"));

        Console.ReadKey();
        //Feeds the animals - works thanks to Covariance
        ZooFeeder.Feed(bearPen);
        Console.ReadKey();
        ZooFeeder.Feed(camelPen);
        Console.ReadKey();
        ZooFeeder.Feed(lionPen);
        Console.ReadKey();
        ZooFeeder.Feed(elephantPen);
        Console.ReadKey();
        ZooFeeder.Feed(penguinPen);

        //Creates animal shows
        Console.ReadKey();
        var lionShow = new AnimalShow<Lion>([
            new Lion ("Leo", FoodConsumption.Carnivore, 8, "Male"),
            new Lion ("Leona", FoodConsumption.Carnivore, 7, "Female")
        ]);

        var elephantShow = new AnimalShow<Elephant>([
            new Elephant ("Ellie", FoodConsumption.Herbivore, 43, "Big")
        ]);

        var penguinShow = new AnimalShow<Penguin>([
            new Penguin("Scribbles", FoodConsumption.Carnivore, 3, "Fairy"),
            new Penguin("Chuck", FoodConsumption.Carnivore, 7, "King")
        ]);

        var camelShow = new AnimalShow<Camel>([
            new Camel("Linda", FoodConsumption.Herbivore, 7, 2),
            new Camel("Eggsy", FoodConsumption.Herbivore, 5, 11)
        ]);

        var bearShow = new AnimalShow<Bear>([
            new Bear ("Billy", FoodConsumption.Omnivore, 11, "Grey, mottled"),
            new Bear ("Boingo", FoodConsumption.Omnivore, 5832, "Psychedelic purple")
        ]);
        //Runs a show, works thanks to Covariance


        ZooManager.RunSHow(lionShow);
        Console.ReadKey();
        ZooManager.RunSHow(elephantShow);
        Console.ReadKey();
        ZooManager.RunSHow(bearShow);
        Console.ReadKey();
        ZooManager.RunSHow(camelShow);
        Console.ReadKey();
        ZooManager.RunSHow(penguinShow);

        //Organize an exhibition - shows Contravariance
        List<Lion> allLions = [

            new Lion("King", FoodConsumption.Carnivore, 7, "Male"),
            new Lion("Queen", FoodConsumption.Carnivore, 7, "Female")
        ];

        var animalSorter = new AnimalSorter<Animal>();
        Console.ReadKey();

        ZooManager.OrganizeExhibit(allLions, animalSorter);

        //Generic container for all animals

        var generalPen = new AnimalPen<Animal>(20);

        //Demonstrates both Covariance and Contravariance
        Console.ReadKey();
        ZooManager.FeedAndTrain(lionPen, generalPen);
        Console.ReadKey();
        ZooManager.FeedAndTrain(elephantPen, generalPen);

    }

}
