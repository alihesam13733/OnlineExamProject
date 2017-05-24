using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineExam.DomainClasses.Entities;

namespace OnlineExam.DomainClasses.EntityConfiguration
{
    public class ExamConfiguration:EntityTypeConfiguration<Exam>
    {
        public ExamConfiguration()
        {
            Property(x => x.Title).IsRequired().HasMaxLength(100);
        }
    }
}
