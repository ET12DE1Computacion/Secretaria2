using Secretaria.Domain.InfoPersonal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Secretaria.Repository.V1
{
    public interface INacionalidadRepository
    {
        void Add(Nacionalidad entidad);

        IEnumerable<Nacionalidad> Get();

        Nacionalidad Get(int id);
    }
}
