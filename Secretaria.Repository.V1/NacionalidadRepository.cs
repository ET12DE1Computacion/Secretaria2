using Microsoft.EntityFrameworkCore;
using Secretaria.Domain.InfoPersonal;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Secretaria.Repository.V1
{
    public class NacionalidadRepository : INacionalidadRepository
    {
        private DbContext context;

        public NacionalidadRepository(DbContext context)
        {
            this.context = context;
        }

        public void Add(Nacionalidad entidad)
        {
            context.Set<Nacionalidad>().Add(entidad);
        }

        public IEnumerable<Nacionalidad> Get()
        {
            return context.Set<Nacionalidad>().ToList();
        }

        public Nacionalidad Get(int id)
        {
            return context.Set<Nacionalidad>().SingleOrDefault(x => x.Id == id);
        }
    }
}
