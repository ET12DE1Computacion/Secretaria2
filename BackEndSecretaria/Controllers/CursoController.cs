using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DominioSecretaria.ADO;
using DominioSecretaria.Escuela;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndSecretaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : ControllerBase
    {
        // GET: api/Curso
        [HttpGet]
        public IEnumerable<Curso> Get()
        {
            AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL();
            return ado.traerCursos();
        }

        // GET: api/Curso/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Curso
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Curso/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
