using MediatR;
using Simple_API_CRUD.Commands;
using Simple_API_CRUD.Repositories;

namespace Simple_API_CRUD.Handlers
{
    public class UpdateAccountHandler : IRequestHandler<UpdateAccountCommand, int>
    {
        private readonly IAccountRepository _accountRepository;

        public UpdateAccountHandler(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public async Task<int> Handle(UpdateAccountCommand command, CancellationToken cancellationToken)
        {
            var accountDetails = await _accountRepository.GetAccountByIdAsync(command.Id);
            if (accountDetails == null)
                return default;

            accountDetails.FullName = command.FullName;
            accountDetails.Email = command.Email;
            accountDetails.Address = command.Address;

            return await _accountRepository.UpdateAccountAsync(accountDetails);
        }
    }
}
