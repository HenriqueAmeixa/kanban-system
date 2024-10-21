using BoardService.Domain.Entities;
using MediatR;

namespace BoardService.Application.Queries.Boards
{
    public class GetBoardById : IRequest<Board>
    {
        public int Id { get; set; }
        public GetBoardById(int id)
        {
            Id = id;
        }
    }
}
