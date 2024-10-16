using AutoMapper;
using BoardService.Application.DTOs.Board;
using BoardService.Application.Interfaces;
using BoardService.Domain.Entities;
using BoardService.Domain.Interfaces;

namespace BoardService.Application.Services
{
    public class BoardService : IBoardService
    {
        private readonly IBoardRepository _boardRepository;
        private readonly IMapper _mapper;

        public BoardService(IBoardRepository boardRepository, IMapper mapper)
        {
            _boardRepository = boardRepository;
            _mapper = mapper;
        }

        public async Task<BoardSelectDTO> GetByIdAsync(int id)
        {
            var board = await _boardRepository.GetByIdAsync(id);
            return _mapper.Map<BoardSelectDTO>(board);
        }

        public async Task CreateAsync(BoardCreateDTO boardCreateDTO)
        {
            var board = _mapper.Map<Board>(boardCreateDTO);
            await _boardRepository.CreateAsync(board);
        }

        public async Task UpdateAsync(BoardUpdateDTO boardUpdateDTO)
        {
            var board = _mapper.Map<Board>(boardUpdateDTO);
            await _boardRepository.UpdateAsync(board);
        }

        public async Task DeleteAsync(int id)
        {
            await _boardRepository.DeleteAsync(id);
        }
    }
}