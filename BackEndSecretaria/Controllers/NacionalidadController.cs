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
    public class NacionalidadController : ControllerBase
    {
        // GET: api/Nacionalidad
        [HttpGet]
        public IEnumerable<Nacionalidad> Get()
        {
            AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL();
            return ado.traerNacionalidades();
        }

        // GET: api/Nacionalidad/5
        [HttpGet("{id}")]
        public Nacionalidad Get(int id)
        {
            AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL();
            return ado.traerNacionalidadById(id);
        }

        // POST: api/Nacionalidad
        [HttpPost]
        public void Post([FromBody] Nacionalidad nacionalidad)
        {
            AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL();
            ado.altaNacionalidad(nacionalidad);
        }

        // PUT: api/Nacionalidad/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL();
            ado.bajaNacionalidad(id);
        }
    }
}
