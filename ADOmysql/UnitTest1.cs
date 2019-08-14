using Microsoft.VisualStudio.TestTools.UnitTesting;
using DominioSecretaria.InfoPersonal;
using DominioSecretaria.Escuela;
using System;
using DominioSecretaria.ADO;

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
            Persona p1 = new Persona()
            {
                Nombre = "Carlo",
                Apellido = "Santana",
                Domicilio = d1,
                Mail = "carlosantanita10@gmail.com",
                NroDocumento = 456123789,
                Nacimiento = new DateTime(2004, 12, 02)
            };
            AdoEntityCoreMySQL ado1 = new AdoEntityCoreMySQL();
            ado1.Database.EnsureCreated();
            ado1.altaPersona(p1);
        }
    }
}
