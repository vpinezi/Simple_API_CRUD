using MediatR;
using Simple_API_CRUD.Commands;
using Simple_API_CRUD.Models;
using Simple_API_CRUD.Repositories;

namespace Simple_API_CRUD.Handlers
{
    public class CreateAccountHandler : IRequestHandler<CreateAccountCommand, AccountDetails>
    {
        private readonly IAccountRepository _accountRepository;

        public CreateAccountHandler(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public async Task<AccountDetails> Handle(CreateAccountCommand command, CancellationToken cancellationToken)
        {
            var accountDetails = new AccountDetails()
            {
                FullName = command.FullName,
                Email = command.Email,
                Address = command.Address
            };

            return await _accountRepository.AddAccountAsync(accountDetails);
        }
    }
}
