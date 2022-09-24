using System;
using System.Collections.Generic;
using System.Linq;

namespace ElectronicShop.Models.Users.Validator
{
    public static class UserValidator
    {
        private static Dictionary<User,ERoles> Users { get; }

        static UserValidator()
        {
            Owner o = new();
            Seller s = new();
            o.DNI = "26489798";
            o.Name = "Oscar Lopez";
            o.Email = "oscar_lopez@gmail.com";
            o.Password = "123456";

            s.DNI = "31949721";
            s.Name = "Fabian Lopez";
            s.Email = "fabian_lopez@gmail.com";
            s.Password = "123456";
            Users = new();
            Users.Add(o,ERoles.Owner);
            Users.Add(s,ERoles.Seller);
        }
        /// <summary>
        /// Authenticates an user from an email and password provided
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns>Return the role of the user input</returns>
        public static ERoles AuthUser(string email,string password)
        {
            User u = Users.Keys.FirstOrDefault(u => u.Email == email && u.Password == password);
            return u is null ? ERoles.NotAuthenticated : Users[u];
        }
    }
}
