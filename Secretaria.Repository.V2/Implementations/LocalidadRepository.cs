using Microsoft.EntityFrameworkCore;
using Secretaria.Domain.InfoPersonal;
using Secretaria.Repository.V2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Secretaria.Repository.V2.Implementations
{
    public class LocalidadRepository : Repository<Localidad>, ILocalidadRepository
    {
        public LocalidadRepository(DbContext context) : base(context)
        {
        }
    }
}
