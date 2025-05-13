namespace Build_a_zoo.Interfaces;

public interface IPoppable<out T>
{
    T Pop();
}