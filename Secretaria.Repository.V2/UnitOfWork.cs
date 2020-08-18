using Secretaria.Domain.ADO;
using Secretaria.Repository.V2.Implementations;
using Secretaria.Repository.V2.Interfaces;

namespace Secretaria.Repository.V2
{
    public class UnitOfWork : IUnitOfWork
    {
        private SecretariaDbContext context;

        private INacionalidadRepository nacionalidadRepository;
        private ILocalidadRepository localidadRepository;

        public INacionalidadRepository Nacionalidades
        {
            get { return nacionalidadRepository = nacionalidadRepository ?? new NacionalidadRepository(context); }
        }

        public ILocalidadRepository Localidades => localidadRepository ?? new LocalidadRepository(context);

        public UnitOfWork(SecretariaDbContext secretariaDbContext)
        {
            this.context = secretariaDbContext;
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
