using Secretaria.Domain.InfoPersonal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Secretaria.Domain.ADO
{
    public class NacionalidadAdo : IAdo<Nacionalidad>
    {
        public SecretariaDbContext contexto { get; set; }

        public NacionalidadAdo()
        {
            contexto = new SecretariaDbContext();
        }

        public void actualizar(Nacionalidad entidad)
        {
            contexto.Update(entidad);

            contexto.SaveChanges();
        }

        public void alta(Nacionalidad entidad)
        {
            contexto.Add(entidad);

            contexto.SaveChanges();
        }

        public void borrar(Nacionalidad entidad)
        {
            contexto.Remove(entidad);

            contexto.SaveChanges();
        }

        public Nacionalidad obtener(int id)
        {
            return contexto.Nacionalidades.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Nacionalidad> obtenerTodo()
        {
            return contexto.Nacionalidades.ToList();
        }
    }
}
