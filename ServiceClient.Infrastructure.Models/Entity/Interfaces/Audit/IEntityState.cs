namespace ServiceClient.Infrastructure.Models.Interfaces.Audit
{
    public interface IEntityState
    {
        bool IsDeleted { get; set; }
    }
}
