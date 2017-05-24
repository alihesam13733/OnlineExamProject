using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExam.DomainClasses.Entities
{
    public class Question
    {
        #region Properties

        public Guid Id { get; set; }

        public String Text { get; set; }

        public String FirstOption { get; set; }

        public String SecondOption { get; set; }

        public String ThirdOption { get; set; }

        public String FouthOption { get; set; }

        public String CurrentAnswer { get; set; }

        public Byte[] Image { get; set; }

        public Degree Degree { get; set; }

        public Lesson Lesson { get; set; }

        public Level Level { get; set; }

        #endregion Properties

    }
}
