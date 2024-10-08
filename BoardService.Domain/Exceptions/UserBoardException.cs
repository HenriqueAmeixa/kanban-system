using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardService.Domain.Exceptions
{
    public class UserBoardException : Exception
    {
        public UserBoardException(string message) : base(message) { }
    }

    public class UserNotFoundException : UserBoardException
    {
        public UserNotFoundException(int userId)
            : base($"The user with ID '{userId}' was not found.") { }
    }

    public class InvalidAdminFlagException : UserBoardException
    {
        public InvalidAdminFlagException()
            : base("Invalid admin flag value. Admin status should be either true or false.") { }
    }

}
