using System.ComponentModel.DataAnnotations.Schema;

namespace HaViBlog.Data.EF.Entities
{
    [Table("UserRole")]
    public class UserRole
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }

        public User User { get; set; }
        public Role Role { get; set; }

        public UserRole()
        {
        }

        public UserRole(int _UserId, int _RoleId)
        {
            UserId = _UserId;
            RoleId = _RoleId;
        }
    }
}