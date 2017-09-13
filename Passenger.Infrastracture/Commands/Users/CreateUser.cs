namespace Passenger.Infrastracture.Commands.Users
{
    public class CreateUser : IHeadquarters
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
    }
}