using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineExam.DomainClasses.Entities;

namespace OnlineExam.ServiceLayer.Interfaces
{
    public interface IGenderService
    {
        List<Gender> GetAllGenders();
    }


}
