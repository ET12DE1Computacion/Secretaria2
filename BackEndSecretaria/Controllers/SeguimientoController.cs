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
    public class SeguimientoController : ControllerBase
    {
        // GET: api/Seguimiento
        [HttpGet]
        public IEnumerable<Seguimiento> Get()
        {
            AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL();
            return ado.traerSeguimientos();
        }

        // GET: api/Seguimiento/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Seguimiento
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Seguimiento/5
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
