using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExam.DomainClasses.Entities
{
    public class User
    {
        #region Properties

        public Guid Id { get; set; }

        public string  UserName { get; set; }

        //public string Fname { get; set; }

        //public string Lname { get; set; }

        public string Email { get; set; }

        public String Password { get; set; }

        //public virtual Degree Degree { get; set; }

        //public virtual Gender Gender { get; set; }

        //public City City { get; set; }

        public Role Role { get; set; }

        #endregion Properties
    }
}
