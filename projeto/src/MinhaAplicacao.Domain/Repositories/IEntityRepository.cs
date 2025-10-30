namespace MinhaAplicacao.Domain.Repositories
{
    public interface IEntityRepository
    {
        Task<IEnumerable<Entity>> GetAllAsync();
        Task<Entity> GetByIdAsync(Guid id);
        Task AddAsync(Entity entity);
        Task UpdateAsync(Entity entity);
        Task DeleteAsync(Guid id);
    }
}