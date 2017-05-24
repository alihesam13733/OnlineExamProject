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
    class CityServices:ICityService
    {
        public IUnitOfWork UnitOfWork { get; }
        public readonly IDbSet<City> Cities;

        public CityServices(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
            Cities = unitOfWork.Set<City>();

        }

        public List<City> GetAllCities()
        {
            return Cities.ToList();
        }
    }
}
