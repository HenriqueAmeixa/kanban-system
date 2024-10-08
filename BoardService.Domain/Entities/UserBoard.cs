
using BoardService.Domain.Exceptions;

namespace BoardService.Domain.Entities
{
    public class UserBoard
    {
        public int UserId { get; private set; }
        public User User { get; private set; }

        public int BoardId { get; private set; }
        public Board Board { get; private set; }

        public bool IsAdmin { get; private set; }

        public UserBoard(int userId, User user, int boardId, Board board, bool isAdmin)
        {
            SetUser(userId, user);
            SetBoard(boardId, board);
            SetIsAdmin(isAdmin);
        }

        public void SetUser(int userId, User user)
        {
            if (user == null)
            {
                throw new UserNotFoundException(userId);
            }

            UserId = userId;
            User = user;
        }

        public void SetBoard(int boardId, Board board)
        {
            if (board == null)
            {
                throw new BoardNotFoundException(boardId);
            }

            BoardId = boardId;
            Board = board;
        }

        public void SetIsAdmin(bool isAdmin)
        {
            if (isAdmin != true && isAdmin != false)
            {
                throw new InvalidAdminFlagException();
            }

            IsAdmin = isAdmin;
        }
    }

}
