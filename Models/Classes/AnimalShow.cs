namespace Build_a_zoo.Models.Classes;
using Build_a_zoo.Interfaces;

public class AnimalShow<T>(List<T> performers) : IAnimalShow<T>

{
    private List<T> _performers = performers;

    public T GetNextPerformer()
    {
        //returnerer en utøver og roterer listen

        var performer = _performers[0];

        _performers.RemoveAt(0);
        _performers.Add(performer);

        return performer;
    }

    public int PerformerCount => _performers.Count;
}
