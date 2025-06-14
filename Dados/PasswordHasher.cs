using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    using BCrypt.Net;
 public class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            return BCrypt.HashPassword(password, BCrypt.GenerateSalt(12));
        }

        public static bool VerifyPassword(string password, string hashedPassword)
        {
            return BCrypt.Verify(password, hashedPassword);
        }
    }
}
