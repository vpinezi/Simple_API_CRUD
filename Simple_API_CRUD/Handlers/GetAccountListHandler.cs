using MediatR;
using Simple_API_CRUD.Models;
using Simple_API_CRUD.Queries;
using Simple_API_CRUD.Repositories;

namespace Simple_API_CRUD.Handlers
{
    public class GetAccountListHandler : IRequestHandler<GetAccountListQuery, List<AccountDetails>>
    {
        private readonly IAccountRepository _accountRepository;

        public GetAccountListHandler(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<List<AccountDetails>> Handle(GetAccountListQuery query, CancellationToken cancellationToken)
        {
            return await _accountRepository.GetAccountListAsync();
        }
    }
}
