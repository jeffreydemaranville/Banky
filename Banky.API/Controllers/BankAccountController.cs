using Microsoft.AspNetCore.Mvc;

namespace Banky.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BankAccountController : ControllerBase
    {
        private readonly ILogger<BankAccountController> _logger;

        public BankAccountController(ILogger<BankAccountController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> SubmitDeposit()
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> SubmitWithdrawal()
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAccount()
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CloseAccount()
        {
            return Ok();
        }
    }
}
