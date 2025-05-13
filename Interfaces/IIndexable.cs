namespace Build_a_zoo.Interfaces;

public interface IIndexable<out T>
{
    T this[int index] { get; }
}