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

        public UserBoard(int userId, int boardId, bool isAdmin)
        {
            SetUser(userId);
            SetBoard(boardId);
            SetIsAdmin(isAdmin);
        }

        public void SetUser(int userId)
        {
            if (userId == null)
            {
                throw new UserNotFoundException(userId);
            }

            UserId = userId;
        }

        public void SetBoard(int boardId)
        {
            if (boardId == null)
            {
                throw new BoardNotFoundException(boardId);
            }

            BoardId = boardId;
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
