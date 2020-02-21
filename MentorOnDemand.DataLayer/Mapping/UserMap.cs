using FluentNHibernate.Mapping;
using MentorOnDemand.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MentorOnDemand.DataLayer.Mapping
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Id(x => x.Id);

            Map(x => x.UserName);

            Map(x => x.Password);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.ContactNumber);
            Map(x => x.Role);
            Map(x => x.LinkedinURL);
            Map(x => x.Experience);
            Map(x => x.Active);
            Map(x => x.ConfirmedSignUp);
            Map(x => x.ResetPassword);
            Map(x => x.ResetPasswordDate);
            Table("product");
        }

    }
}
