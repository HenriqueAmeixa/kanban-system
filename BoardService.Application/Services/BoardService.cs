using AutoMapper;
using BoardService.Application.Commands.Boards;
using BoardService.Application.DTOs.Board;
using BoardService.Application.Interfaces;
using BoardService.Application.Queries.Boards;
using BoardService.Domain.Entities;
using BoardService.Domain.Interfaces;
using MediatR;

namespace BoardService.Application.Services
{
    public class BoardService : IBoardService
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public BoardService(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        public async Task<BoardSelectDTO> GetByIdAsync(int? id)
        {
            var boardByIdQuery = new GetBoardById(id.Value);
            var result = await _mediator.Send(boardByIdQuery);
            return _mapper.Map<result>(BoardSelectDTO);
        }

        public async Task CreateAsync(BoardCreateDTO boardCreateDTO)
        {
            var boardCreateCommand = _mapper.Map<BoardCreateCommand>(boardCreateDTO);
            await _mediator.Send(boardCreateCommand);
        }

        public async Task UpdateAsync(BoardUpdateDTO boardUpdateDTO)
        {
            var boardUpdateCommand = _mapper.Map<BoardUpdateCommand>(boardUpdateDTO);
            await _mediator.Send(boardUpdateCommand);
        }

        public async Task DeleteAsync(int id)
        {
            await _boardRepository.DeleteAsync(id);
        }
    }
}