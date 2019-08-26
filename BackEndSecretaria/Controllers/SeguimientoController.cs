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
        [HttpGet("{id}")]
        public Seguimiento Get(int id)
        {
            AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL();
            return ado.traerSeguimientoById(id);
        }

        // POST: api/Seguimiento
        [HttpPost]
        public void Post([FromBody] Seguimiento seguimiento)
        {
            AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL();
            ado.altaSeguimiento(seguimiento);
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
