using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HaViBlog.Service.ViewModels
{
    public class BusinessRoleViewModel
    {
        public string Id { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string BusinessRoleName { get; set; }
    }
}
