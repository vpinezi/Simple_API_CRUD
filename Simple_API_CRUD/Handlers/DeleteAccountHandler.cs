using MediatR;
using Simple_API_CRUD.Commands;
using Simple_API_CRUD.Repositories;

namespace Simple_API_CRUD.Handlers
{
    public class DeleteAccountHandler : IRequestHandler<DeleteAccountCommand, int>
    {
        private readonly IAccountRepository _accountRepository;

        public DeleteAccountHandler(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<int> Handle(DeleteAccountCommand command, CancellationToken cancellationToken)
        {
            var accountDetails = await _accountRepository.GetAccountByIdAsync(command.Id);
            if (accountDetails == null)
                return default;

            return await _accountRepository.DeleteAccountAsync(accountDetails.Id);
        }
    }
}
