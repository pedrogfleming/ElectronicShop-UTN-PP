using System;
using System.Collections.Generic;
using System.Linq;

namespace ElectronicShop.Models.Users.Validator
{
    public static class UserValidator
    {
        /// <summary>
        /// A dictionary matching the users with their role
        /// </summary>
        private static Dictionary<User,ERoles> Users { get; }
        /// <summary>
        /// We populate our users and their roles
        /// </summary>
        static UserValidator()
        {
            User owner = new();
            User seller = new();
            owner.DNI = "26489798";
            owner.Name = "Oscar Lopez";
            owner.Email = "oscar_lopez@gmail.com";
            owner.Password = "123456";

            seller.DNI = "31949721";
            seller.Name = "Fabian Lopez";
            seller.Email = "fabian_lopez@gmail.com";
            seller.Password = "123456";
            Users = new();
            Users.Add(owner,ERoles.Owner);
            Users.Add(seller,ERoles.Seller);
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
