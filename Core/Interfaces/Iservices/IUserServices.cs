using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces.Iservices
{
    public interface IUserServices
    {
        bool CheckUser(string userName, string password);
    }
}
