using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineExam.DomainClasses.Entities;
using OnlineExam.ServiceLayer.Enums;

namespace OnlineExam.ServiceLayer.Interfaces
{
    public interface IUserSevice
    {
        AddUserStatus Add(User user);
    }
}
