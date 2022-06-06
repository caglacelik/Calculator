using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class UserManager
    {
        private static UserManager _userManager;
        static object _lockObject = new object();

        private List<User> _users;

        private UserManager()
        {
            HashingHelper.CreatePasswordHash("burak123", out byte[] passwordHash, out byte[] passwordSalt);
            _users = new List<User>
            {
                new User {Username = "burak", PasswordSalt = passwordSalt, PasswordHash = passwordHash},
            };
        }

        public static UserManager CreateAsSingleton()
        {
            lock (_lockObject)
            {
                if (_userManager == null)
                {
                    _userManager = new UserManager();
                }
            }
            return _userManager;
        }

        public bool Login(string userName, string password)
        {
            User user = _users.SingleOrDefault(u => u.Username == userName);

            if (user == null) return false;

            return HashingHelper.VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt);
        }

        public bool SignUp(string userName, string password)
        {
            if (_users.Any(u => u.Username == userName)) return false;

            HashingHelper.CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);
            _users.Add(new User { Username = userName, PasswordSalt = passwordSalt, PasswordHash = passwordHash });

            return true;
        }
    }
}
