using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TemplateNetCore.Repository.Interface;

namespace TemplateNetCore.Base
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<Entity, Repository, Key> : ControllerBase
        where Entity : class
        where Repository : IRepository<Entity, Key>
    {
        private readonly Repository repository;
        public BaseController(Repository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public ActionResult<Entity> Get()
        {
            var result = repository.Get();
            if (result != null)
            {
                return Ok(new { status = HttpStatusCode.OK, result, message = "Data Ditemukan" });
            }
            else
            {
                return StatusCode(500, new { status = HttpStatusCode.InternalServerError, result, message = "Terjadi Kesalahan" });
            }
        }

        [HttpGet("{key}")]
        public ActionResult<Entity> Get(Key key)
        {
            var result = repository.Get(key);
            if (result != null)
            {
                return Ok(new { status = HttpStatusCode.OK, result, message = "Data Ditemukan" });
            }
            else
            {
                return StatusCode(500, new { status = HttpStatusCode.InternalServerError, result, message = "Terjadi Kesalahan" });
            }
        }

        [HttpPost]
        public ActionResult Post(Entity entity)
        {
            var result = repository.Insert(entity);
            if (result > 0)
            {
                return Ok(new { status = HttpStatusCode.OK, result = "", message = "Berhasil Membuat Data Baru" });
            }
            else
            {
                return StatusCode(500, new { status = HttpStatusCode.InternalServerError, result = "null", message = "Terjadi Kesalahan" });
            }
        }

        [HttpDelete("{key}")]
        public ActionResult Delete(Key key)
        {
            var result = repository.Delete(key);
            if (result > 0)
            {
                return Ok(new { status = HttpStatusCode.OK, result = " ", message = "Berhasil Menghapus Data" });
            }
            else
            {
                return StatusCode(500, new { status = HttpStatusCode.InternalServerError, message = "Gagal Menghapus Data" });
            }
        }

        [HttpPut]
        public ActionResult Put(Entity entity)
        {
            if (entity == null)
            {
                return BadRequest(new { status = HttpStatusCode.BadRequest, message = "Data yang di-input salah" });
            }
            var result = repository.Update(entity);
            if (result > 0)
            {
                return Ok(new { status = HttpStatusCode.OK, result = " ", message = "Berhasil Memperbaharui Data" });
            }
            else
            {
                return StatusCode(500, new { status = HttpStatusCode.InternalServerError, message = "Gagal Memperbaharui Data" });
            }
        }
    }
}
