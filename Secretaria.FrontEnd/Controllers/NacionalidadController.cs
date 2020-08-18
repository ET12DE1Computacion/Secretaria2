using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Secretaria.Domain.ADO;
using Secretaria.Domain.InfoPersonal;
using Secretaria.Repository.V2;

namespace Secretaria.FrontEnd.Controllers
{
    public class NacionalidadController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public NacionalidadController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }


        public IActionResult Index()
        {
            //NacionalidadRepository miRepositorio = new NacionalidadRepository(new SecretariaDbContext());

            //miRepositorio.Get();
            IEnumerable<Nacionalidad> nacionalidades = unitOfWork.Nacionalidades.Get();


            return View();
        }
    }
}
