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
    public class PersonaController : ControllerBase
    {
        // GET: api/Persona
        [HttpGet]
        public IEnumerable<Persona> Get()
        {
            AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL();
            return ado.traerPersonas();
        }

        // GET: api/Persona/5
        [HttpGet("{id}")]
        public Persona Get(int id)
        {
            AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL();
            return ado.traerPersonasById(id); 
        }

        // POST: api/Persona
        [HttpPost]
        public void Post([FromBody] Persona persona)
        {
            AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL();
            ado.altaPersona(persona);
        }

        // PUT: api/Persona/5
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
