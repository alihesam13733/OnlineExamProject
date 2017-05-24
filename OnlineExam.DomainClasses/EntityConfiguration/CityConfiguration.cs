using System.Data.Entity.ModelConfiguration;
using OnlineExam.DomainClasses.Entities;

namespace OnlineExam.DomainClasses.EntityConfiguration
{
   public  class CityConfiguration:EntityTypeConfiguration<City>
    {
        public CityConfiguration()
        {
            Property(x => x.CaptionFa).IsRequired().HasMaxLength(50);
            // one-to-one
            //this.HasOptional(x => x.Province)
            //.WithRequired(x => x.Cities)
            //.WillCascadeOnDelete();
        }
    }
}
