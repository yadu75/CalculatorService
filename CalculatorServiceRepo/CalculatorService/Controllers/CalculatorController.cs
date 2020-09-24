using Microsoft.AspNetCore.Mvc;

namespace CalculatorService.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/[controller]/[action]")]
    public class CalculatorController : ControllerBase
    {
        // GET: api/Calculator
        [HttpGet]
        public ActionResult<decimal> Add(decimal numberOne, decimal numberTwo)
        {
            return Ok(numberOne + numberTwo);
        }

        [HttpGet()]
        public ActionResult<decimal> Subtract(decimal numberOne, decimal numberTwo)
        {
            return Ok(numberOne - numberTwo);
        }

        [HttpGet()]
        public ActionResult<decimal> Multiply(decimal numberOne, decimal numberTwo)
        {
            return Ok(numberOne * numberTwo);
        }

        [HttpGet()]
        public ActionResult<decimal> Divide(decimal numberOne, decimal numberTwo)
        {
            return Ok(numberOne / numberTwo);
        }
    }
}
