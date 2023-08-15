using MediatR;
using Simple_API_CRUD.Models;

namespace Simple_API_CRUD.Queries
{
    public class GetAccountListQuery : IRequest<List<AccountDetails>>
    {
    }
}
