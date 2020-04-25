using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximeThifagne.Entity.Entities
{
    [Table("mt.USER")]
    public class UserEntity
    {
        [Key]
        [Column(name: "USER_ID")]
        public int UserId { get; set; }

        [Column(name: "USER_LAST_NAME")]
        public string UserLastName { get; set; }

        [Column(name: "USER_FIRST_NAME")]
        public string UserFirstName { get; set; }

        [Column(name: "USER_LOGIN")]
        public string Login { get; set; }

        [Column(name: "USER_PASSWORD")]
        public string Password { get; set; }
    }
}
