using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace OnlineExam.ViewModels.Accounting
{
    public class UserViewModel
    {
        [DisplayName(@"نام")]
        public Guid Id { get; set; }

        public string Fname { get; set; }

        public string Lname { get; set; }

        public string Email { get; set; }

        public String Password { get; set; }

        public Guid DegreeId { get; set; }

        public Guid  CityId { get; set; }

        public Guid  GenderId { get; set; }

        public Guid  RoleId { get; set; }

        public String Mobile { get; set; }

    }
}
