namespace Build_a_zoo.Interfaces;

public interface IPushable<in T>
{
    void Push(T obj);
}