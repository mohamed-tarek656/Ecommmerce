using ecom.core.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ecom.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class baseController : ControllerBase
    {
        protected readonly iunitofwork work;
        public baseController(iunitofwork work)
        {
            this.work = work; 
        }
    }
}
