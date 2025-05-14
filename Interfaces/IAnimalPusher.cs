namespace Build_a_zoo.Interfaces;

public interface IAnimalPusher<in T> : IPushable<T>, ICountable;