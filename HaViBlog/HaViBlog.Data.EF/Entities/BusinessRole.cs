﻿using HaViBlog.Infrastructure.DomainEntity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HaViBlog.Data.EF.Entities
{
    [Table("BusinessRole")]
    public class BusinessRole : DomainEntity<string>
    {
        [Column(TypeName = "varchar(250)")]
        public string BusinessRoleName { get; set; }

        public ICollection<Role> Roles { get; set; }
    }
}