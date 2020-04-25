using Secretaria.Domain.ADO;
using Secretaria.Domain.InfoPersonal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ADOmysql
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Localidad caba = new Localidad()
            {
                Cadena = "CABA"
            };
            Domicilio d1 = new Domicilio()
            {
                Calle = "Avenida Libertador",
                Altura = 238,
                Piso = 3,
                Departamento = null,
                CodigoPostal = "1001",
                Localidad = caba
            };

            Nacionalidad nacionalidad = new Nacionalidad();
            nacionalidad.Cadena = "argentina";

            TipoDocumento tipoDocumento = new TipoDocumento();
            tipoDocumento.Cadena ="DNI";

            Persona p1 = new Persona()
            {
                Nombre = "Carlo",
                Apellido = "Santana",
                Domicilio = d1,
                Mail = "carlo@gmail.com",
                NroDocumento = 456123789,
                Nacimiento = new DateTime(2004, 12, 02),
                Nacionalidad = nacionalidad,
                TipoDocumento=tipoDocumento
            };
            
            var ado1 = new AdoEntityCoreMySQL();
            ado1.Contexto = new Contexto();
            ado1.Contexto.Database.EnsureDeleted();
            ado1.Contexto.Database.EnsureCreated();
            ado1.altaPersona(p1);
            ado1.Contexto = new Contexto();
            var persona = ado1.traerPersonas()[0];
            Assert.IsNotNull(persona.Domicilio.Localidad);
            Assert.AreEqual("CABA", persona.Domicilio.Localidad.Cadena);
        }
    }
}
