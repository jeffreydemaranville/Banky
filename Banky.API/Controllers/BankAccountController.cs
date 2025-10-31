using Banky.Services.Interfaces;
using Banky.Services.Models;
using Microsoft.AspNetCore.Mvc;

namespace Banky.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BankAccountController : ControllerBase
    {
        private readonly ILogger<BankAccountController> _logger;
        private readonly IBankAccountService _accountService;

        public BankAccountController(ILogger<BankAccountController> logger, IBankAccountService accountService)
        {
            _logger = logger;
            _accountService = accountService;
        }

        [HttpPost("deposit")]
        [ProducesResponseType(typeof(AccountDepositResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> SubmitDeposit([FromBody] AccountDeposit deposit)
        {
            if (deposit == null)
            {
                return BadRequest("Missing transaction information");
            }

            var result = await _accountService.DepositFunds(deposit);
            return result.Succeeded ? Ok(result) : BadRequest(result);
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
