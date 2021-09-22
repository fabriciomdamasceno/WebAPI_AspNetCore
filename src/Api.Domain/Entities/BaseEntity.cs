namespace Api.Domain.Entities
{
    public class BaseEntity
    {
        public Guid id { get; set; }
    }

    private DateTime? _createAt;
    public DateTime? CreateAt
    {
        get { return _createAt; }
        set { _createAt = (value == null ? DateTime.UtcNow : value) ; }
    }
    
}