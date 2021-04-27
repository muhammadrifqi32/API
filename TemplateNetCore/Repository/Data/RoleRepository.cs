using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemplateNetCore.Context;
using TemplateNetCore.Models;

namespace TemplateNetCore.Repository.Data
{
    public class RoleRepository : GeneralRepository<MyContext, Role, int>
    {
        public RoleRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
