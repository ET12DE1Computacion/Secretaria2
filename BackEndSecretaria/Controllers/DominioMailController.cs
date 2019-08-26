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
    public class DominioMailController : ControllerBase
    {
        // GET: api/DominioMail
        [HttpGet]
        public IEnumerable<DominioMail> Get()
        {
            AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL();
            return ado.traerDominioMails();
        }

        // GET: api/DominioMail/5
        [HttpGet("{id}")]
        public DominioMail Get(int id)
        {
            AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL();
            return ado.traerDominioMailById(id);
        }

        // POST: api/DominioMail
        [HttpPost]
        public void Post([FromBody] DominioMail dominioMail)
        {
            AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL();
            ado.altaDominioMail(dominioMail);
        }

        // PUT: api/DominioMail/5
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
