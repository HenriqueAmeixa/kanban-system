
namespace BoardService.Domain.Entities
{
    public class Board
    {
        public int Id { get; set; }  // Identificador único do Board

        public string Name { get; set; }  // Nome do quadro

        public Guid OrganizationId { get; set; }  // Identificador da organização que possui o Board

        public ICollection<Column> Columns { get; set; } = new List<Column>();  // Colunas dentro do Board

        public ICollection<UserBoard> UserBoards { get; set; } = new List<UserBoard>();  // Relacionamento com usuários

        public DateTime CreatedAt { get; set; }  // Data de criação do Board

        public DateTime UpdatedAt { get; set; }
    }
}
