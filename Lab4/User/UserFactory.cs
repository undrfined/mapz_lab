using System;

namespace Lab4.User
{
    public class UserFactory
    {
        public static User Create(string type)
        {
            switch (type)
            {
                case "developer":
                    return new Developer();
                case "admin":
                    return new Admin();
                case "customerSupport":
                    return new CustomerSupport();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}