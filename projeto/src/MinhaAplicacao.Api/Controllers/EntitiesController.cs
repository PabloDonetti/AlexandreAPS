using Microsoft.AspNetCore.Mvc;
using MinhaAplicacao.Application.DTOs;
using MinhaAplicacao.Application.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MinhaAplicacao.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntitiesController : ControllerBase
    {
        private readonly IEntitiesService _entitiesService;

        public EntitiesController(IEntitiesService entitiesService)
        {
            _entitiesService = entitiesService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EntityDto>>> GetAll()
        {
            var entities = await _entitiesService.GetAllAsync();
            return Ok(entities);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EntityDto>> GetById(int id)
        {
            var entity = await _entitiesService.GetByIdAsync(id);
            if (entity == null)
            {
                return NotFound();
            }
            return Ok(entity);
        }

        [HttpPost]
        public async Task<ActionResult<EntityDto>> Create(EntityDto entityDto)
        {
            var createdEntity = await _entitiesService.CreateAsync(entityDto);
            return CreatedAtAction(nameof(GetById), new { id = createdEntity.Id }, createdEntity);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, EntityDto entityDto)
        {
            if (id != entityDto.Id)
            {
                return BadRequest();
            }

            await _entitiesService.UpdateAsync(entityDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _entitiesService.DeleteAsync(id);
            return NoContent();
        }
    }
}