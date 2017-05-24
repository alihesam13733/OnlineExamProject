using System.Data.Entity;
using System.Linq;
using OnlineExam.DataLayer.Context;
using OnlineExam.DomainClasses.Entities;
using OnlineExam.ServiceLayer.Enums;
using OnlineExam.ServiceLayer.Interfaces;

namespace OnlineExam.ServiceLayer.EfServices
{
   public  class UserServices:IUserSevice
    {
        public IUnitOfWork UnitOfWork { get; }
        public readonly IDbSet<User> Users;

        public UserServices(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
            Users = unitOfWork.Set<User>();
        }

        public AddUserStatus Add(User user)
        {
            if (ExistEmail(user.Email))
            {
                return AddUserStatus.EmailExist;
            }
            Users.Add(user);
            return AddUserStatus.AddingUserSuccessfully;
        }

        public bool ExistEmail(string email)
        {
            return Users.Any(x => x.Email == email);
        }
    }
}
