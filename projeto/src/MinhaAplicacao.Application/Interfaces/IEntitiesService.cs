namespace MinhaAplicacao.Application.Interfaces
{
    public interface IEntitiesService
    {
        Task<IEnumerable<EntityDto>> GetAllAsync();
        Task<EntityDto> GetByIdAsync(Guid id);
        Task<EntityDto> CreateAsync(EntityDto entityDto);
        Task<EntityDto> UpdateAsync(Guid id, EntityDto entityDto);
        Task<bool> DeleteAsync(Guid id);
    }
}