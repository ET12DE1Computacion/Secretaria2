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
    public class CursadaController : ControllerBase
    {
        // GET: api/Cursada
        [HttpGet]
        public IEnumerable<Cursada> Get()
        {
            AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL();
            // TODO averiguar de donde viene el alumno
            //return ado.traerCursadas(Alumno alumno);
            throw new NotImplementedException();
        }

        // GET: api/Cursada/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Cursada
        [HttpPost]
        public void Post([FromBody] Cursada cursada)
        {
            AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL();
            //ado.altaCursada(cursada);
        }

        // PUT: api/Cursada/5
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
