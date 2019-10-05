using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Secretaria.BackEnd.ViewModel;
using DominioSecretaria.ADO;
using DominioSecretaria.Escuela;
using DominioSecretaria.InfoPersonal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Secretaria.BackEnd.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AlumnoController : ControllerBase
    {
        private readonly Contexto contexto;

        public AlumnoController(Contexto contexto)
        {
            this.contexto = contexto;
        }
        // GET: api/Alumno
        [HttpGet]
        public IEnumerable<AlumnoSinDetalleViewModel> TraerTodosSinDetalle()
        {
            AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL(contexto);
            var alumnos = ado.traerAlumnosSinDetalle();
            var alumnosSinDetalle = alumnos.Select(x => new AlumnoSinDetalleViewModel
            { legajo = x.legajo,
                apellido = x.Apellido,
                nombre = x.Nombre,
                libro =x.Libro ,
                folio =x.Folio,anio=x.CursoActual.Anio,
                division =x.CursoActual.Division,NumeroDocumento=x.Persona.NroDocumento
            });
            return alumnosSinDetalle;

        }

        [HttpGet]
        public IEnumerable<AlumnoConDetalleViewModel> TraerTodosConDetalle()
        {
            AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL(contexto);
            var alumnos = ado.traerAlumnosConDetalle();
            var alumnosConDetalle = alumnos.Select(x => new AlumnoConDetalleViewModel
            {
                legajo = x.legajo,
                apellido = x.Apellido,
                nombre = x.Nombre,
                libro = x.Libro,
                folio = x.Folio,
                anio = x.CursoActual.Anio,
                division = x.CursoActual.Division,
                nroDocumento = x.Persona.NroDocumento,
                nacimiento=x.Persona.Nacimiento,
                //telefono1=x.Persona.telefono1,
                telefono1=0,
                //telefono2=x.Persona.telefono2,
                telefono2=0,
                mail=x.Persona.Mail,
                nacionalidad=x.Persona.Nacionalidad.Cadena,
                tipoDocumento=x.Persona.TipoDocumento.Cadena,
                dominio=x.Persona.Mail,
                calle=x.Persona.Domicilio.Calle,
                altura=x.Persona.Domicilio.Altura,
                piso=x.Persona.Domicilio.Piso,
                departamento=x.Persona.Domicilio.Departamento,
                codigoPostal=x.Persona.Domicilio.CodigoPostal,
                //observacionDomicilio=x.Persona.Domicilio.observacionDomicilio,
                observacionDomicilio="",
                localidad=x.Persona.Domicilio.Localidad.Cadena
            });
            return alumnosConDetalle;

        }

        // GET: api/Alumno/5
        [HttpGet("{id}")]
        public AlumnoConDetalleViewModel TraerPorId(int id)
        {
            AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL(contexto);
            var alumno= ado.traerAlumnoById(id);
            var alumnoConDetalle = new AlumnoConDetalleViewModel
            {
                legajo =alumno.legajo,
                apellido = alumno.Apellido,
                nombre = alumno.Nombre,
                libro = alumno.Libro,
                folio = alumno.Folio,
                anio = alumno.CursoActual.Anio,
                division = alumno.CursoActual.Division,
                nroDocumento = alumno.Persona.NroDocumento,
                nacimiento = alumno.Persona.Nacimiento,
                //telefono1=x.Persona.telefono1,
                telefono1 = 0,
                //telefono2=x.Persona.telefono2,
                telefono2 = 0,
                mail = alumno.Persona.Mail,
                nacionalidad = alumno.Persona.Nacionalidad.Cadena,
                tipoDocumento = alumno.Persona.TipoDocumento.Cadena,
                dominio = alumno.Persona.Mail,
                calle = alumno.Persona.Domicilio.Calle,
                altura = alumno.Persona.Domicilio.Altura,
                piso = alumno.Persona.Domicilio.Piso,
                departamento = alumno.Persona.Domicilio.Departamento,
                codigoPostal = alumno.Persona.Domicilio.CodigoPostal,
                //observacionDomicilio=x.Persona.Domicilio.observacionDomicilio,
                observacionDomicilio = "",
                localidad = alumno.Persona.Domicilio.Localidad.Cadena
            };
            return alumnoConDetalle;
        }

        // POST: api/Alumno
        [HttpPost]
        public void Crear([FromBody] AlumnoConDetalleViewModel alumno)
        {
            //TODO: Optimizar consultas, realizar metodos en el ADO que simplifiquen las consultas SQL generadas
            AdoEntityCoreMySQL ado = new AdoEntityCoreMySQL(contexto);

            Nacionalidad nacionalidad = ado.traerNacionalidades()
                .FirstOrDefault(x => x.Cadena == alumno.nacionalidad);
            
            if (nacionalidad == null)
                nacionalidad = new Nacionalidad { Cadena = alumno.nacionalidad };
            
            TipoDocumento tipoDocumento = ado.traerTipoDocumentos()
                .FirstOrDefault(x => x.Cadena == alumno.tipoDocumento);
            
            if (tipoDocumento == null)
                tipoDocumento = new TipoDocumento { Cadena = alumno.tipoDocumento };
            
            Domicilio dom = ado.traerDomicilios()
                .FirstOrDefault(x => x.Calle == alumno.calle &&
                                     x.Altura == alumno.altura &&
                                     x.Piso == alumno.piso &&
                                     x.CodigoPostal == alumno.codigoPostal &&
                                     x.Departamento == alumno.departamento &&
                                     x.Localidad.Cadena == alumno.localidad
                                     );
            
            Localidad localidad = ado.traerLocalidades()
              .FirstOrDefault(x => x.Cadena == alumno.localidad);
            
            if (localidad == null)
                localidad = new Localidad { Cadena = localidad.Cadena };

            if (dom == null)
                dom = new Domicilio {
                    Calle = alumno.calle,
                    Altura = alumno.altura,
                    Piso = alumno.piso,
                    CodigoPostal = alumno.codigoPostal,
                    Departamento = alumno.departamento,
                    Localidad = localidad
                };
          
            Persona persona = new Persona();
            persona.Nacionalidad = nacionalidad;
            persona.TipoDocumento = tipoDocumento;
            persona.Domicilio = dom;
            persona.Domicilio.Localidad = localidad;
            persona.Mail = alumno.mail;

            var alum = new Alumno
            {
                legajo = alumno.legajo,
                Folio = alumno.folio,
                Libro = alumno.libro,
                Persona = persona
            };

            ado.altaAlumno(alum);
        }

    }
}
