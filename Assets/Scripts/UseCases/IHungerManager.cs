using UniRx;



public interface IManager
{
    public ReactiveProperty<int> Resource { get; set; }

    public void Add(int value);

    public void Subtract(int value);
}