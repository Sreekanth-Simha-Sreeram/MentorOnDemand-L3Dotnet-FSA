using MentorOnDemand.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorOnDemand.DataLayer.NHibernateConfigurations
{
    public interface IMapperSession
    {
        void BeginTransaction();
        Task Commit();
        Task Rollback();
        void CloseTransaction();
        Task Save(List<User> entity);
        Task Delete(User entity);
        IQueryable<User> user { get; }
    }
}
