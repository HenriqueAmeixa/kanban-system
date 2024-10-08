
using BoardService.Domain.Exceptions;

namespace BoardService.Domain.Entities
{
    public sealed class Board
    {
        public int Id { get; private set; }

        public string Name { get; private set; }
        public string Description { get; private set; }

        public int OrganizationId { get; private set; }

        public ICollection<Column> Columns { get; private set; } = new List<Column>();

        public ICollection<UserBoard> UserBoards { get; private set; } = new List<UserBoard>();
        public ICollection<KanbanTask> KanbanTasks { get; private set; } = new List<KanbanTask>();

        public DateTime CreatedAt { get; private set; }

        public DateTime UpdatedAt { get; private set; }

        public Board(string name, string description, int organizationId)
        {
            const int minTitleLength = 3;
            const int maxTitleLength = 100;
            const int minDescriptionLength = 10;
            const int maxDescriptionLength = 500;

            if (!OrganizationExists(organizationId))
            {
                throw new OrganizationNotFoundException(organizationId);
            }

            if (name.Length < minTitleLength)
            {
                throw new BoardTitleTooShortException(minTitleLength);
            }

            if (name.Length > maxTitleLength)
            {
                throw new BoardTitleTooLongException(maxTitleLength);
            }

            if (description.Length < minDescriptionLength)
            {
                throw new BoardDescriptionTooShortException(minDescriptionLength);
            }

            if (description.Length > maxDescriptionLength)
            {
                throw new BoardDescriptionTooLongException(maxDescriptionLength);
            }

            Name = name;
            Description = description;
            OrganizationId = organizationId;
        }

        private bool OrganizationExists(int organizationId)
        {
            return organizationId > 0;
        }
    }
}
