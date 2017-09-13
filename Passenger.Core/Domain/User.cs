using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Passenger.Core.Domain
{
    public class User
    {
        public Guid Id { get; protected set; }
        public string Email { get; protected set; }
        public string Password { get; protected set; }
        public string Salt { get; protected set; }
        public string Username { get; protected set; }
        public string FullName { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        public DateTime UpdatedAt { get; protected set; }

        private readonly Regex userRegex = new Regex(@"^(?=.{3,20}$)(?![_.])(?!.*[_.]{2})[a-zA-Z0-9._]+(?<![_.])$");
        private readonly Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

        protected User()
        {
        }

        public User(string email, string username, 
            string password, string salt)
        {
            Id = Guid.NewGuid();
            Email = email.ToLowerInvariant();
            Username = username;
            Password = password;
            Salt = salt;
            CreatedAt = DateTime.UtcNow;
        }

        public void SetUsername(string username)
        {
            Match userMatch = userRegex.Match(username);
            if(!userMatch.Success)
            {
                throw new Exception("Username can not be null or empty!");
            }
            Username = username;
            UpdatedAt = DateTime.UtcNow;
        }

        public void SetEmail(string email)
        {
            Match emailMatch = emailRegex.Match(email);
            if(Email==email)
            {
                return;
            }
            if(!emailMatch.Success)
            {
                throw new Exception("Wrong email!");
            }
            Email = email;
            UpdatedAt = DateTime.UtcNow;
        }

        public static implicit operator Task<object>(User v)
        {
            throw new NotImplementedException();
        }
    }
}