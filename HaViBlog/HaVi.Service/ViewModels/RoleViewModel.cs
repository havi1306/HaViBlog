using System;
using System.Collections.Generic;
using System.Text;

namespace HaViBlog.Service.ViewModels
{
    public class RoleViewModel
    {
        public int Id { get; set; }

        public string RoleName { get; set; }
        public string Description { get; set; }
        public string BusinessRoleId { get; set; }
    }
}
