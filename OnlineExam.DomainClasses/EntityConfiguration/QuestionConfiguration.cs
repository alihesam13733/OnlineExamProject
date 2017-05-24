using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineExam.DomainClasses.Entities;

namespace OnlineExam.DomainClasses.EntityConfiguration
{
    public class QuestionConfiguration:EntityTypeConfiguration<Question>
    {
        public QuestionConfiguration()
        {
            Property(x => x.CurrentAnswer).IsRequired().HasMaxLength(200);
            Property(x => x.FirstOption).IsRequired().HasMaxLength(200);
            Property(x => x.SecondOption).IsRequired().HasMaxLength(200);
            Property(x => x.ThirdOption).IsRequired().HasMaxLength(200);
            Property(x => x.FouthOption).IsRequired().HasMaxLength(200);
            Property(x => x.Text).IsRequired();

        }
    }
}
