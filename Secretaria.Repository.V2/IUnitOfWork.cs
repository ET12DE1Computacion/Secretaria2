using Secretaria.Repository.V2.Interfaces;
using System;

namespace Secretaria.Repository.V2
{
    public interface IUnitOfWork : IDisposable
    {
        INacionalidadRepository Nacionalidades { get; }
        ILocalidadRepository Localidades { get; }

        void SaveChanges();
    }
}