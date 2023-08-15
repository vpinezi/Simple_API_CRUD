using MediatR;
using Simple_API_CRUD.Models;

namespace Simple_API_CRUD.Commands
{
    public class CreateAccountCommand : IRequest<AccountDetails>
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public CreateAccountCommand(string fullName, string email, string address)
        {
            FullName = fullName;
            Email = email;
            Address = address;
        }
    }
}
