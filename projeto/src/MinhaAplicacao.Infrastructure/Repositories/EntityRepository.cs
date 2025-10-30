using System.Collections.Generic;
using System.Threading.Tasks;
using MinhaAplicacao.Domain.Entities;
using MinhaAplicacao.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace MinhaAplicacao.Infrastructure.Repositories
{
    public class EntityRepository : IEntityRepository
    {
        private readonly AppDbContext _context;

        public EntityRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Entity>> GetAllAsync()
        {
            return await _context.Entities.ToListAsync();
        }

        public async Task<Entity> GetByIdAsync(int id)
        {
            return await _context.Entities.FindAsync(id);
        }

        public async Task AddAsync(Entity entity)
        {
            await _context.Entities.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Entity entity)
        {
            _context.Entities.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                _context.Entities.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}