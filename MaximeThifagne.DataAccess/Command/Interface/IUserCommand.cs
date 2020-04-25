namespace MaximeThifagne.DataAccess.Command.Interface
{
    public interface IUserCommand
    {
        bool ValidateUser(string userLogin, string password);
    }
}
