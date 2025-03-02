﻿
namespace BoardService.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }  

        public string Name { get; set; }  

        public string Email { get; set; } 

        public string PasswordHash { get; set; }  

        public ICollection<UserBoard> UserBoards { get; set; } = new List<UserBoard>();
        public DateTime CreatedAt { get; private set; }

        public DateTime UpdatedAt { get; private set; }
    }
}
