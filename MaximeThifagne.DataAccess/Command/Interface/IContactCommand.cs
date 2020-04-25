using MaximeThifagne.DTO;

namespace MaximeThifagne.DataAccess.Command.Interface
{
    public interface IContactCommand
    {
        bool SendMessage(ContactDto message);
    }
}
