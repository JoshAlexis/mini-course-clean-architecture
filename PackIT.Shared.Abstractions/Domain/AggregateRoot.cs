namespace PackIT.Shared.Abstractions.Domain;

public abstract class AggregateRoot<T>
{
    public T Id { get; }
    public int Version { get; protected set; }

    private readonly List<IDomainEvent> _events = new();
    private IEnumerable<IDomainEvent> Events => _events;

    private bool _versionIncremented;

    protected void AddEvent(IDomainEvent @event)
    {
        if (!_events.Any() && !_versionIncremented)
        {
            Version++;
            _versionIncremented = true;
            
            _events.Add(@event);
        }
    }

    public void clearEvents() => _events.Clear();
    
    protected void IncrementVersion()
    {
        if (_versionIncremented)
        {
            return;
        }

        Version++;
        _versionIncremented = true;
    }
}