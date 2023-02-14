using UniRx;

public interface IHungerManager
{
    public ReactiveProperty<int> Hunger { get; }

    public void AddHunger(int value);

    public void RemoveHunger(int value);
}