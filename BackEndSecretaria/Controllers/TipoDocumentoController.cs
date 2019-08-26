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
    public class TipoDocumentoController : ControllerBase
    {
        // GET: api/TipoDocumento
        [HttpGet]
        public IEnumerable<TipoDocumento> Get()
        {
            AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL();
            return ado.traerTipoDocumentos();
            //return new string[] { "value1", "value2" };
        }

        // GET: api/TipoDocumento/5
        [HttpGet("{id}")]
        public TipoDocumento Get(int id)
        {
            AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL();
            return ado.traerTipoDocumentoById(id);
        }

        // POST: api/TipoDocumento
        [HttpPost]
        public void Post([FromBody] TipoDocumento tipoDocumento)
        {
            AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL();
            ado.altaTipoDocumento(tipoDocumento);
        }

        // PUT: api/TipoDocumento/5
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
