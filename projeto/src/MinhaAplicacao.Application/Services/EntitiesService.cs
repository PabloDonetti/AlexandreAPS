using System.Collections.Generic;
using System.Threading.Tasks;
using MinhaAplicacao.Application.DTOs;
using MinhaAplicacao.Application.Interfaces;
using MinhaAplicacao.Domain.Entities;
using MinhaAplicacao.Domain.Repositories;

namespace MinhaAplicacao.Application.Services
{
    public class EntitiesService : IEntitiesService
    {
        private readonly IEntityRepository _entityRepository;

        public EntitiesService(IEntityRepository entityRepository)
        {
            _entityRepository = entityRepository;
        }

        public async Task<IEnumerable<EntityDto>> GetAllAsync()
        {
            var entities = await _entityRepository.GetAllAsync();
            // Map entities to EntityDto
            return Mapper.Map<IEnumerable<EntityDto>>(entities);
        }

        public async Task<EntityDto> GetByIdAsync(int id)
        {
            var entity = await _entityRepository.GetByIdAsync(id);
            // Map entity to EntityDto
            return Mapper.Map<EntityDto>(entity);
        }

        public async Task CreateAsync(EntityDto entityDto)
        {
            var entity = Mapper.Map<Entity>(entityDto);
            await _entityRepository.AddAsync(entity);
        }

        public async Task UpdateAsync(EntityDto entityDto)
        {
            var entity = Mapper.Map<Entity>(entityDto);
            await _entityRepository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _entityRepository.DeleteAsync(id);
        }
    }
}