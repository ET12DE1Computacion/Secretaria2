using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEndSecretaria.ViewModel;
using DominioSecretaria.ADO;
using DominioSecretaria.Escuela;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndSecretaria.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CursadaController : ControllerBase
    {
        private readonly Contexto contexto;

        public CursadaController(Contexto contexto)
        {
            this.contexto = contexto;
        }
        // GET: api/Curso
        [HttpGet]
        public IEnumerable<CursadaViewModel> TraerTodos()
        {
            AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL(contexto);
            var cursadas = ado.traerCursada();

            var cursadasViewModel = new List<CursadaViewModel>();
            //var cursadaViewModel = cursada.Select(x => new CursadaViewModel
            //{
            //    cicloElectivo=x.CicloLectivo,
            //    anio=x.Curso.Anio,
            //    division=x.Curso.Division,
            //    turno="",
            //    especialidad=""
            //});

            string estado="";

            foreach (var cursada in cursadas)
            {
                if ((cursada.Curso.Anio == 1) || (cursada.Curso.Anio == 2))
                {
                    estado = "Primer Ciclo";
                }
                if ((cursada.Curso.Anio == 3))
                {
                    estado = "Segundo Ciclo";
                }
                if ((cursada.Curso.Division == 7) || (cursada.Curso.Division == 8))
                {
                    estado = "Computacion";
                }
                             
                cursadasViewModel.Add(new CursadaViewModel
                {
                    cicloElectivo = cursada.CicloLectivo,
                    especialidad = estado,
                    anio=cursada.Curso.Anio,
                    division=cursada.Curso.Division,
                    turno=""
                });
            }

            return cursadasViewModel;
        }

        // GET: api/Curso/5
        //[HttpGet("{id}")]
        //public CursadaViewModel TraerPorId(int id)
        //{
        //    AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL(contexto);
        //    var cursada = ado.traerCursoById(id);
        //    var cursadaViewModel = new CursadaViewModel
        //    {           
        //        anio = cursada.Anio,
        //        division = cursada.Division,
        //    };
        //    return cursadaViewModel;
        //}

        // POST: api/Curso
        //[HttpPost]
        //public void Crear([FromBody] CursadaViewModel curso)
        //{
        //    AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL(contexto);
        //    var cursada = new Cursada
        //    {
        //        a
        //    };
        //    ado.altaCurso(cursada);
        //}
    }
}
