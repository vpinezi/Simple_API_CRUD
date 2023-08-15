using MediatR;
using Microsoft.AspNetCore.Mvc;
using Simple_API_CRUD.Commands;
using Simple_API_CRUD.Models;
using Simple_API_CRUD.Queries;

namespace Simple_API_CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IMediator mediator;

        public AccountsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<List<AccountDetails>> GetAccountListAsync()
        {
            var accountDetails = await mediator.Send(new GetAccountListQuery());

            return accountDetails;
        }

        [HttpGet("accountId")]
        public async Task<AccountDetails> GetAccountByIdAsync(int accountId)
        {
            var accountDetails = await mediator.Send(new GetAccountByIdQuery() { Id = accountId });

            return accountDetails;
        }

        [HttpPost]
        public async Task<AccountDetails> AddAccountAsync(AccountDetails accountDetails)
        {
            var accountDetail = await mediator.Send(new CreateAccountCommand(
                accountDetails.FullName,
                accountDetails.Email,
                accountDetails.Address));
            return accountDetail;
        }

        [HttpPut]
        public async Task<int> UpdateAccountAsync(AccountDetails accountDetails)
        {
            var isAccountDetailUpdated = await mediator.Send(new UpdateAccountCommand(
               accountDetails.Id,
               accountDetails.FullName,
               accountDetails.Email,
               accountDetails.Address));
            return isAccountDetailUpdated;
        }

        [HttpDelete]
        public async Task<int> DeleteAccountAsync(int Id)
        {
            return await mediator.Send(new DeleteAccountCommand() { Id = Id });
        }
    }
}
