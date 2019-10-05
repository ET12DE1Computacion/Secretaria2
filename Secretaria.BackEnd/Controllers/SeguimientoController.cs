using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Secretaria.BackEnd.ViewModel;
using DominioSecretaria.ADO;
using DominioSecretaria.Escuela;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Secretaria.BackEnd.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SeguimientoController : ControllerBase
    {
        private readonly Contexto contexto;

        public SeguimientoController(Contexto contexto)
        {
            this.contexto = contexto;
        }
        // GET: api/Seguimiento
        [HttpGet]
        public IEnumerable<SeguimientoViewModel> TraerTodos()
        {
            AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL(contexto);

            var seguimiento = ado.traerSeguimientos().Select(x => new SeguimientoViewModel{ legajo = x.Alumno.legajo, observacion = x.Observacion, fecha = x.Fecha });
            
            return seguimiento;
        }

        // GET: api/Seguimiento/5
        [HttpGet("{id}")]
        public SeguimientoViewModel TraerPorId (int id)
        {
            AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL(contexto);

            var seguimiento = ado.traerSeguimientoById(id);
            
            var seguimientoViewModel = new SeguimientoViewModel
            {
                legajo=seguimiento.Alumno.legajo,
                observacion=seguimiento.Observacion,
                fecha=seguimiento.Fecha
            };
            
            return seguimientoViewModel;
        }

        // POST: api/Seguimiento
        [HttpPost]
        public void Crear([FromBody] SeguimientoViewModel seguimientoViewModel)
        {
            AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL(contexto);
            
            var alumnoxlegajo = contexto.Alumnos.SingleOrDefault(x => x.legajo == seguimientoViewModel.legajo);

            var seguimiento = new Seguimiento
            {
               Observacion=seguimientoViewModel.observacion,
               Fecha=seguimientoViewModel.fecha,
               Alumno=alumnoxlegajo
            };
            
            ado.altaSeguimiento(seguimiento);
        }

    }
}
