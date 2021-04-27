using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemplateNetCore.Context;
using TemplateNetCore.Models;

namespace TemplateNetCore.Repository.Data
{
    public class PersonRepository : GeneralRepository<MyContext, Person, string>
    {
        public PersonRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
