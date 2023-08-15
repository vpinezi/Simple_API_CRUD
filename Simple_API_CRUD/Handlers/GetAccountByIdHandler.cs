using MediatR;
using Simple_API_CRUD.Models;
using Simple_API_CRUD.Queries;
using Simple_API_CRUD.Repositories;

namespace Simple_API_CRUD.Handlers
{
    public class GetAccountByIdHandler : IRequestHandler<GetAccountByIdQuery, AccountDetails>
    {
        private readonly IAccountRepository _accountRepository;

        public GetAccountByIdHandler(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<AccountDetails> Handle(GetAccountByIdQuery query, CancellationToken cancellationToken)
        {
            return await _accountRepository.GetAccountByIdAsync(query.Id);
        }
    }
}
