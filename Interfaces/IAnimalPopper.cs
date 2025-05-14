namespace Build_a_zoo.Interfaces;

public interface IAnimalPopper<out T> : IPoppable<T>, IIndexable<T>, ICountable;