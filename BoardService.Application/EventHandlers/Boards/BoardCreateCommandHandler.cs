using BoardService.Application.Commands.Boards;
using BoardService.Domain.Entities;
using BoardService.Domain.Interfaces;
using MediatR;

namespace BoardService.Application.EventHandlers.Boards
{
    public class BoardCreateCommandHandler : IRequestHandler<BoardCreateCommand, Board>
    {
        private readonly IBoardRepository _boardRepository;
        public BoardCreateCommandHandler(IBoardRepository boardRepository)
        {
            _boardRepository = boardRepository;
        }
        public async Task<Board> Handle(BoardCreateCommand request, CancellationToken cancellationToken)
        {
            var board = new Board(request.Name, request.Description, request.OrganizationId);
            
            if(board == null)
            {
                throw new ApplicationException("Error creating entity");
            }
            else
            {
                return await _boardRepository.CreateAsync(board);
            }
        }
    }
}
