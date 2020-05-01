using TypeLite;

namespace MaximeThifagne.DTO
{
    [TsClass]
    public class UserDto
    {
        public int UserId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }
    }
}
