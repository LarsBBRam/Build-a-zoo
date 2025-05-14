namespace Build_a_zoo.Interfaces;

public interface IAnimalSorter<T>
{
    void SortByAge(IEnumerable<T> animals);
}