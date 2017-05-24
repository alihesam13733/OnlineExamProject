using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineExam.DataLayer.Context;
using OnlineExam.DomainClasses.Entities;
using OnlineExam.ServiceLayer.Interfaces;

namespace OnlineExam.ServiceLayer.EfServices
{
    class DegreeServices:IDegreeService
    {
        public IUnitOfWork UnitOfWork { get; }
        public readonly IDbSet<Degree> Degrees;

        public DegreeServices(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
            Degrees = unitOfWork.Set<Degree>();

        }
        public List<Degree> GetAllDegrees()
        {
            return Degrees.ToList();
        }
    }
}
