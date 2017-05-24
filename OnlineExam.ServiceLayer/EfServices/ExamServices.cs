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
    class ExamServices:IExamService
    {
        public IUnitOfWork UnitOfWork { get; }
        public readonly IDbSet<Exam> Exams;

        public ExamServices(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
            Exams = unitOfWork.Set<Exam>();

        }
        public List<Exam> GetAllExams()
        {
            return Exams.ToList();
        }
    }
}
