using ecom.core.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ecom.api.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class categoriesController : baseController
    {
        public categoriesController(iunitofwork work) : base(work)
        {
        }
        [HttpGet("get-all")]
        public async Task<IActionResult> get()
        {
            try
            {
                var catregory = await work.categoryrepository.getallasync();
                if (catregory is null) 
                    return BadRequest();
                return Ok(catregory);
                
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
