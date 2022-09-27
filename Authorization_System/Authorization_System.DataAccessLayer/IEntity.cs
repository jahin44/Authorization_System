namespace Authorization_System.DataAccessLayer
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}