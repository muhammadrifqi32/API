using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TemplateNetCore.Base;
using TemplateNetCore.Models;
using TemplateNetCore.Repository.Data;

namespace TemplateNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : BaseController<Person, PersonRepository, string>
    {
        public PersonsController(PersonRepository personRepository) : base(personRepository)
        {

        }
    }
}
