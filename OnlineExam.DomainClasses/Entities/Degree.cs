using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExam.DomainClasses.Entities
{
   public  class Degree
    {
        #region Properties

        public Guid Id { get; set; }

        public String CaptionEn { get; set; }

        public String CaptionFa { get; set; }

        public int DisplayOrder { get; set; }

        public virtual User User { get; set; }


        #endregion Properties
    }
}
