using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Secretaria.BackEnd.ViewModel;
using DominioSecretaria.ADO;
using DominioSecretaria.InfoPersonal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Secretaria.BackEnd.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TipoDocumentoController : ControllerBase
    {
        private readonly Contexto contexto;

        public TipoDocumentoController(Contexto contexto)
        {
            this.contexto = contexto;
        }

        // GET: api/TipoDocumento
        [HttpGet]
        public IEnumerable<TipoDocumentoViewModel> TraerTodos()
        {
            AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL(contexto);

            var tipoDocumentosViewModel =  ado.traerTipoDocumentos().Select(x => new TipoDocumentoViewModel { IdTipoDocumento = x.Id, TipoDocumento = x.Cadena });

            return tipoDocumentosViewModel;
        }

        // GET: api/TipoDocumento/5
        [HttpGet("{id}")]
        public TipoDocumentoViewModel TraerPorId(int id)
        {
            AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL(contexto);

            var documento = ado.traerTipoDocumentoById(id);

            var tipoDocumentoViewModel = new TipoDocumentoViewModel
            {
                IdTipoDocumento = documento.Id,
                TipoDocumento = documento.Cadena
            };

            return tipoDocumentoViewModel;
        }

        // POST: api/TipoDocumento
        [HttpPost]
        public void Crear([FromBody] TipoDocumentoViewModel tipoDocumentoViewModel)
        {
            AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL(contexto);

            var tipoDocumento = new TipoDocumento
            {
                Cadena = tipoDocumentoViewModel.TipoDocumento
            };

            ado.altaTipoDocumento(tipoDocumento);
        }
    }
}
