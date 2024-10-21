using MediatR;
using BoardService.Domain.Entities;

namespace BoardService.Application.Commands.Boards
{
    public class BoardDeleteCommand : IRequest<Board>
    {
        public int Id { get; set; }
        public BoardDeleteCommand(int id)
        {
            Id = Id;
        }
    }
}
