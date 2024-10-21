using MediatR;
using BoardService.Domain.Entities;

namespace BoardService.Application.Commands
{
    public abstract class BoardCommand : IRequest<Board>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int OrganizationId { get; set; }

    }
}
