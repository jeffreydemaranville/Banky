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
        [ProducesResponseType(typeof(CustomerTransactionResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> SubmitDeposit([FromBody] CustomerTransaction deposit)
        {
            if (deposit == null)
            {
                return BadRequest("Missing transaction information");
            }

            var result = await _accountService.DepositFunds(deposit);
            return result.Succeeded ? Ok(result) : BadRequest(result);
        }

        [HttpPost("withdraw")]
        [ProducesResponseType(typeof(CustomerTransactionResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> SubmitWithdrawal([FromBody] CustomerTransaction withdrawal)
        {
            if (withdrawal == null)
            {
                return BadRequest("Missing transaction information");
            }

            var result = await _accountService.WithdrawFunds(withdrawal);
            return result.Succeeded ? Ok(result) : BadRequest(result);
        }

        [HttpPost("create-account")]
        [ProducesResponseType(typeof(CreateCustomerAccountResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateAccount([FromBody] CreateCustomerAccount account)
        {
            if (account == null)
            {
                return BadRequest("Missing account information");
            }

            var result = await _accountService.CreateAccount(account);
            return result.Succeeded ? Ok(result) : BadRequest(result);
        }

        [HttpPut("close-account")]
        [ProducesResponseType(typeof(CustomerAccountResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CloseAccount([FromBody] CustomerAccount account)
        {
            if (account == null)
            {
                return BadRequest("Missing account information");
            }
            var result = await _accountService.CloseAccount(account).ConfigureAwait(false);
            return result.Succeeded ? Ok(result) : BadRequest(result);
        }
    }
}
