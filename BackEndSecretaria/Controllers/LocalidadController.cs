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
    public class LocalidadController : ControllerBase
    {
        private readonly Contexto contexto;

        public LocalidadController(Contexto contexto)
        {
            this.contexto = contexto;
        }
        // GET: api/Localidad
        [HttpGet]
        public IEnumerable<LocalidadViewModel> TraerTodos()
        {
            AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL(contexto);

            var LocalidadesViewModel = ado.traerLocalidades().Select(x => new LocalidadViewModel { IdLocalidad = x.Id , Localidad = x.Cadena });
            
            return LocalidadesViewModel;
        }

        // GET: api/Localidad/5
        [HttpGet("{id}")]
        public LocalidadViewModel TraerPorId(byte id)
        {
            AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL(contexto);

            var localidad = ado.traerLocalidadById(id);

            var localidadViewModel = new LocalidadViewModel
            {
                IdLocalidad = localidad.Id,
                Localidad = localidad.Cadena
            };

            return localidadViewModel;
        }

        // POST: api/Localidad
        [HttpPost]
        public void Crear([FromBody] LocalidadViewModel localidadViewModel)
        {
            AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL(contexto);

            var localidad = new Localidad
            {
                Id = localidadViewModel.IdLocalidad,
                Cadena = localidadViewModel.Localidad
            };

            ado.altaLocalidad(localidad);
        }
    }
}
