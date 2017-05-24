using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineExam.DomainClasses.Entities;

namespace OnlineExam.DomainClasses.EntityConfiguration
{
    public class LessonConfiguration:EntityTypeConfiguration<Lesson>
    {
        public LessonConfiguration()
        {
            Property(x => x.Name).IsRequired().HasMaxLength(200);
            Property(x => x.Subject).IsRequired().HasMaxLength(100).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}
