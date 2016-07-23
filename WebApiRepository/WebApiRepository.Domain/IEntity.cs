namespace WebApiRepository.Domain
{
    /// <summary>
    /// Interface that defines a contract with all domain objects.
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// This assume that all IDs will be integers
        /// You could easily make this an object as well,
        /// but for the purposes of this demonstration, we 
        /// will keep it as an integer.
        /// </summary>
        int Id { get; set; }
    }
}