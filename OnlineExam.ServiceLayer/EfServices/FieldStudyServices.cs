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
    class FieldStudyServices:IFieldStudyService
    {
        public IUnitOfWork UnitOfWork { get; }
        public readonly IDbSet<FieldStudy> FieldStudies ;

        public FieldStudyServices(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
            FieldStudies = unitOfWork.Set<FieldStudy>();

        }
        public List<FieldStudy> GetAllFieldStudies()
        {
            return FieldStudies.ToList();
        }
    }
}
