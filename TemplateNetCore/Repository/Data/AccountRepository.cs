using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemplateNetCore.Context;
using TemplateNetCore.Models;

namespace TemplateNetCore.Repository.Data
{
    public class AccountRepository : GeneralRepository<MyContext, Account, string>
    {
        public AccountRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
