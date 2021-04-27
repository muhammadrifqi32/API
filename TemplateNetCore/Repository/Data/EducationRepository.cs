using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemplateNetCore.Context;
using TemplateNetCore.Models;

namespace TemplateNetCore.Repository.Data
{
    public class EducationRepository : GeneralRepository<MyContext, Education, string>
    {
        public EducationRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
