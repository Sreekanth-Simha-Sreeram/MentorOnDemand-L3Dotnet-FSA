using System;
using System.Collections.Generic;
using System.Text;

namespace MentorOnDemand.BuisnessLayer.Interfaces
{
    public interface ILoginServices
    {
        bool SignUp(string Role, string UserName, string Password, long ContactNumber);
        bool SignIn(string UserName, string Password);
    }
}
