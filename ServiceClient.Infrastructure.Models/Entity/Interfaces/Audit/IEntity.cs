namespace ServiceClient.Infrastructure.Models.Interfaces.Audit
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
