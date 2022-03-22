using Core.Interfaces.Iservices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Repositories
{
    public class UserServices : IUserServices
    {
        public bool CheckUser(string userName, string password)
        {
            return userName.Equals("name") && password.Equals("123456");
        }
    }
}
