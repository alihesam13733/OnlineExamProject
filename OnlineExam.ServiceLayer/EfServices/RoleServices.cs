using System.Data.Entity;
using System.Linq;
using OnlineExam.DataLayer.Context;
using OnlineExam.DomainClasses.Entities;
using OnlineExam.ServiceLayer.Interfaces;

namespace OnlineExam.ServiceLayer.EfServices
{
    public class RoleServices:IRoleService
    {
        public IUnitOfWork UnitOfWork { get; }
        public readonly IDbSet<Role> Roles;

        public RoleServices(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
            Roles = unitOfWork.Set<Role>();
        }

        public Role GetRoleByRolrName(string roleeName)
        {
            return Roles.Single(x => x.CaptionEn == roleeName); 
        }
    }
}
