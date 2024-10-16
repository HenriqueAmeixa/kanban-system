using AutoMapper;
using BoardService.Application.DTOs.Column;
using BoardService.Application.Interfaces;
using BoardService.Domain.Interfaces;
using BoardService.Domain.Entities;

namespace BoardService.Application.Services
{
    public class ColumnService : IColumnService
    {
        private readonly IColumnRepository _columnRepository;
        private readonly IMapper _mapper;

        public ColumnService(IColumnRepository columnRepository, IMapper mapper)
        {
            _columnRepository = columnRepository;
            _mapper = mapper;
        }

        public async Task<ColumnSelectDTO> GetByIdAsync(int id)
        {
            var column = await _columnRepository.GetByIdAsync(id);
            return _mapper.Map<ColumnSelectDTO>(column);
        }

        public async Task CreateAsync(ColumnCreateDTO columnCreateDTO)
        {
            var column = _mapper.Map<Column>(columnCreateDTO);
            await _columnRepository.CreateAsync(column);
        }

        public async Task UpdateAsync(ColumnUpdateDTO columnUpdateDTO)
        {
            var column = _mapper.Map<Column>(columnUpdateDTO);
            await _columnRepository.UpdateAsync(column);
        }

        public async Task DeleteAsync(int id)
        {
            await _columnRepository.DeleteAsync(id);
        }
    }
}
