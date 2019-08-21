using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DominioSecretaria.ADO;
using DominioSecretaria.InfoPersonal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndSecretaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocalidadController : ControllerBase
    {
        // GET: api/Localidad
        [HttpGet]
        public IEnumerable<Localidad> Get()
        {
            AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL();
            return ado.traerLocalidades();
        }

        // GET: api/Localidad/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Localidad
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Localidad/5
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
