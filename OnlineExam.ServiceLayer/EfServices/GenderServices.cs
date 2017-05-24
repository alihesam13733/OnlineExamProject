using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using OnlineExam.DataLayer.Context;
using OnlineExam.DomainClasses.Entities;
using OnlineExam.ServiceLayer.Interfaces;

namespace OnlineExam.ServiceLayer.EfServices
{
   public  class GenderServices:IGenderService
    {
        public IUnitOfWork UnitOfWork { get; }
        public readonly IDbSet<Gender> Genders;

        public GenderServices(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
            Genders = unitOfWork.Set<Gender>();

        }
        public List<Gender> GetAllGenders()
        {
            return Genders.ToList();
        }
    }
}
