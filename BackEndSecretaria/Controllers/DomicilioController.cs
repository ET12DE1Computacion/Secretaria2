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
    public class DomicilioController : ControllerBase
    {
        // GET: api/Domicilio
        [HttpGet]
        public IEnumerable<Domicilio> Get()
        {
            AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL();
            return ado.traerDomicilios();
        }

        // GET: api/Domicilio/5
        [HttpGet("{id}")]
        public Domicilio Get(int id)
        {
            AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL();
            return ado.traerDomicilioById(id);
        }

        // POST: api/Domicilio
        [HttpPost]
        public void Post([FromBody] Domicilio domicilio)
        {
            AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL();
            ado.altaDomicilio(domicilio);
        }

        // PUT: api/Domicilio/5
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
