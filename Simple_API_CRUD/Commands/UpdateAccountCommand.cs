using MediatR;

namespace Simple_API_CRUD.Commands
{
    public class UpdateAccountCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public UpdateAccountCommand(int id, string fullName, string email, string address)
        {
            Id = id;
            FullName = fullName;
            Email = email;
            Address = address;
        }
    }
}
