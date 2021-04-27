﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateNetCore.Models
{
    [Table("TB_T_AccountRole")]
    public class AccountRole
    {
        public string NIK { get; set; }
        public virtual Account Account { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
    }
}
