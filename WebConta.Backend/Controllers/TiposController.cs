using Microsoft.AspNetCore.Mvc;
using WebConta.Backend.UnitOfWork.Interfaces;
using WebConta.Shared.Entities;

namespace WebConta.Backend.Controllers
{
    //Data Notation para que funcione como controlador
    [ApiController]
    [Route("api/[controller]")]
    public class TiposController : GenericController<Tipo>
    {
        public TiposController(IGenericUnitOfWork<Tipo> unit) : base(unit)
        { }
    }
}