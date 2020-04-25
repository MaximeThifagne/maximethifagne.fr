using MaximeThifagne.DataAccess.Command.Interface;
using MaximeThifagne.DataAccess.Helper;
using MaximeThifagne.DTO;
using MaximeThifagne.Entity;
using MaximeThifagne.Entity.Entities;
using System.Linq;

namespace MaximeThifagne.DataAccess.Command.Implementation
{
    public class UserCommand : IUserCommand
    {
        private MaximeThifagneDbContext dbContext;
        public UserCommand()
        {
            dbContext = new MaximeThifagneDbContext();
        }

        public bool ValidateUser(string userLogin, string password)
        {
            UserEntity user = GetUserByLogin(userLogin);
            
            if (user != null && user.Password == PasswordHelper.EncryptPassword(password))
                return true;
            else
                return false;
        }

        public UserEntity GetUserByLogin(string userLogin) 
            => dbContext.Users.SingleOrDefault(u => u.Login == userLogin);
    }
}
