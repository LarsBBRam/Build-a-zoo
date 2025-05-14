namespace Build_a_zoo.Interfaces;

public interface IAnimalShow<out T>
{
    T GetNextPerformer();
    int PerformerCount { get; }
}