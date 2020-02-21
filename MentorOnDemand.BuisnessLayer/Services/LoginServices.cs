using MentorOnDemand.BuisnessLayer.Interfaces;
using MentorOnDemand.DataLayer.NHibernateConfigurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MentorOnDemand.BuisnessLayer.Services
{
    public class LoginServices : ILoginServices
    {
        private readonly IMapperSession _session;

        public LoginServices(IMapperSession session)
        {
            _session = session;
        }
        public bool SignIn(string UserName, string Password)
        {
            return true;
        }

        public bool SignUp(string Role, string UserName, string Password, long ContactNumber)
        {
            return true;
        }
    }
}
