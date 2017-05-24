using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineExam.DomainClasses.Entities;

namespace OnlineExam.DomainClasses.EntityConfiguration
{
    public class UserConfiguration:EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            Property(x => x.Email).IsFixedLength().HasMaxLength(255); //nchar 128
            Property(x => x.UserName).IsFixedLength().HasMaxLength(255); //nchar 128
            Property(x => x.Password).IsRequired().HasMaxLength(50);
            //Property(x => x.Fname).IsRequired().HasMaxLength(50);
            //Property(x => x.Lname).IsRequired().HasMaxLength(50);
            //this.HasOptional(x=>x.Degree).WithRequired(x=>x.User).WillCascadeOnDelete();

        }
    }
}
