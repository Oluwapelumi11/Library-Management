using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management.Models.Factories
{
    internal static class UserFactory
    {
        public static User CreateUser(string type)
        {
            switch (type.ToLower())
            {
                case "administrator":
                    return new Administrator();
                default:
                    return new NormalUser();
            }
        }
    }
}
