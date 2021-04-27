using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemplateNetCore.Context;
using TemplateNetCore.Models;

namespace TemplateNetCore.Repository.Data
{
    public class ProfilingRepository : GeneralRepository<MyContext, Profiling, string>
    {
        public ProfilingRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
