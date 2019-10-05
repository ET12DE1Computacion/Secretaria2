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
    public class NacionalidadController : ControllerBase
    {
        private readonly Contexto contexto;

        public NacionalidadController(Contexto contexto)
        {
            this.contexto = contexto;
        }

        // GET: api/Nacionalidad
        [HttpGet]
        public IEnumerable<NacionalidadViewModel> TraerTodos()
        {
            AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL(contexto);

            var NacionalidadesViewModel = ado.traerNacionalidades().Select(x => new NacionalidadViewModel { IdNacionalidad = x.Id, Nacionalidad = x.Cadena });
            
            return NacionalidadesViewModel;
        }

        // GET: api/Nacionalidad/5
        [HttpGet("{id}")]
        public NacionalidadViewModel TraerPorId(int id)
        {
            AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL(contexto);
     
            var nacionalidad = ado.traerNacionalidadById(id);

            var nacionalidadViewModel = new NacionalidadViewModel 
            {
                IdNacionalidad = nacionalidad.Id,
                Nacionalidad = nacionalidad.Cadena
            };

            return nacionalidadViewModel;
        }

        // POST: api/Nacionalidad
        [HttpPost]
        public void Crear([FromBody] NacionalidadViewModel nacionalidadViewModel)
        {
            AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL(contexto);
            
            var nacionalidad = new Nacionalidad
            {
                Id = nacionalidadViewModel.IdNacionalidad,
                Cadena=nacionalidadViewModel.Nacionalidad
            };
            
            ado.altaNacionalidad(nacionalidad);
        }
    }
}
