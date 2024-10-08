using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardService.Domain.Exceptions
{
    public class BoardException : Exception
    {
        public BoardException(string message) : base(message) { }
    }

    public class OrganizationNotFoundException : BoardException
    {
        public OrganizationNotFoundException(int organizationId)
            : base($"Organization with ID {organizationId} not found.")
        {
        }
    }

    public class BoardTitleTooShortException : BoardException
    {
        public BoardTitleTooShortException(int minLength)
            : base($"Board title must be at least {minLength} characters long.")
        {
        }
    }

    public class BoardTitleTooLongException : BoardException
    {
        public BoardTitleTooLongException(int maxLength)
            : base($"Board title must not exceed {maxLength} characters.")
        {
        }
    }

    public class BoardDescriptionTooShortException : BoardException
    {
        public BoardDescriptionTooShortException(int minLength)
            : base($"Board description must be at least {minLength} characters long.")
        {
        }
    }

    public class BoardDescriptionTooLongException : BoardException
    {
        public BoardDescriptionTooLongException(int maxLength)
            : base($"Board description must not exceed {maxLength} characters.")
        {
        }
    }
}
