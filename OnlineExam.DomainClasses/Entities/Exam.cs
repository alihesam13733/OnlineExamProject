using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExam.DomainClasses.Entities
{
    public class Exam
    {
        #region Properties

        public Guid Id { get; set; }

        public string Title { get; set; }

        public Level Leval { get; set; }

        public bool ScoreNegative { get; set; }

        public FieldStudy FieldStudy { get; set; }
       
        public byte[] Time { get; set; }
       
        public Lesson Lesson { get; set; }
       
        public decimal Price { get; set; }
        
        public Degree Degree { get; set; }
        #endregion
    }
}
