namespace tetrapak
{
    public interface IIdProvider<out TId>
    {
        TId Id { get; }
    }
}