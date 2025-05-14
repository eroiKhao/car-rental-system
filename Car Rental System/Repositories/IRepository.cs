namespace Car_Rental_System.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetByIdAsync(Guid id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task AddAsync(TEntity entity);
        Task DeleteAsync(Guid id);
        Task UpdateAsync(TEntity entity);
    }
}
