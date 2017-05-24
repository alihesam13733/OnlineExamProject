using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExam.Models.Accounting
{
    public class Registration
    {
        [ScaffoldColumn(false)]

        public Guid Id { get; set; }
        [Display(ResourceType = typeof(AttributeResource), Name = "DisplayUserName")]
        [Required(ErrorMessageResourceType = typeof(AttributeResource), ErrorMessageResourceName = "RequiredUserName")]
        public string UserName { get; set; }
        [DataType(DataType.EmailAddress, ErrorMessageResourceType = typeof(AttributeResource), ErrorMessageResourceName = "DataTypeEmail")]
        [EmailAddress]
        [Display(ResourceType = typeof(AttributeResource), Name = "DisplayEmail")]
        [Required(ErrorMessageResourceType = typeof(AttributeResource), ErrorMessageResourceName = "RequiredEmail")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Display(ResourceType = typeof(AttributeResource), Name = "DisplayPassword")]
        [Required(ErrorMessageResourceType = typeof(AttributeResource), ErrorMessageResourceName = "RequiredPass")]
        public String Password { get; set; }
        [Required(ErrorMessageResourceType = typeof(AttributeResource), ErrorMessageResourceName = "DisplayRepeatPass")]
        [Compare("Password", ErrorMessageResourceType = typeof(AttributeResource), ErrorMessageResourceName = "ComparePassword")]
        [Display(ResourceType = typeof(AttributeResource), Name = "DisplayRepeatPass")]
        public String ConfirmPassword { get; set; }

    }                                             
}
