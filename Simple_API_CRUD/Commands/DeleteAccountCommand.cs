using MediatR;

namespace Simple_API_CRUD.Commands
{
    public class DeleteAccountCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
