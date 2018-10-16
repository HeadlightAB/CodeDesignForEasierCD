using Business;
using Microsoft.AspNetCore.Mvc;

namespace ApiFront.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly ILessGoodMananger _lessGoodMananger;
        private readonly IBetterManager _betterManager;

        public StockController(ILessGoodMananger lessGoodMananger, IBetterManager betterManager)
        {
            _lessGoodMananger = lessGoodMananger;
            _betterManager = betterManager;
        }

        [HttpPut]
        [Route("inout")]
        public ActionResult InOut(int quantity)
        {
            _lessGoodMananger.InOut(quantity);
            return Ok(_lessGoodMananger.GetBalance());
        }

        [HttpPut]
        [Route("in")]
        public ActionResult<int> In(uint quantity)
        {
            _betterManager.In(quantity);
            return Ok(_betterManager.GetBalance());
        }

        [HttpPut]
        [Route("out")]
        public ActionResult Out(uint quantity)
        {
            _betterManager.Out(quantity);
            return Ok(_betterManager.GetBalance());
        }
    }
}