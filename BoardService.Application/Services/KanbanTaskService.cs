using AutoMapper;
using BoardService.Application.DTOs.KanbanTask;
using BoardService.Application.Interfaces;
using BoardService.Domain.Entities;
using BoardService.Domain.Interfaces;

namespace BoardService.Application.Services
{
    public class KanbanTaskService : IKanbanTaskService
    {
        private readonly IKanbanTaskRepository _kanbanTaskRepository;
        private readonly IMapper _mapper;

        public KanbanTaskService(IKanbanTaskRepository kanbanTaskRepository, IMapper mapper)
        {
            _kanbanTaskRepository = kanbanTaskRepository;
            _mapper = mapper;
        }

        public async Task<KanbanTaskSelectDTO> GetByIdAsync(int id)
        {
            var kanbanTask = await _kanbanTaskRepository.GetByIdAsync(id);
            return _mapper.Map<KanbanTaskSelectDTO>(kanbanTask);
        }

        public async Task CreateAsync(KanbanTaskCreateDTO kanbanTaskCreateDTO)
        {
            var kanbanTask = _mapper.Map<KanbanTask>(kanbanTaskCreateDTO);
            await _kanbanTaskRepository.CreateAsync(kanbanTask);
        }

        public async Task UpdateAsync(KanbanTaskUpdateDTO kanbanTaskUpdateDTO)
        {
            var kanbanTask = _mapper.Map<KanbanTask>(kanbanTaskUpdateDTO);
            await _kanbanTaskRepository.UpdateAsync(kanbanTask);
        }

        public async Task DeleteAsync(int id)
        {
            await _kanbanTaskRepository.DeleteAsync(id);
        }
    }
}
