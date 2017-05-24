using OnlineExam.DomainClasses.Entities;

namespace OnlineExam.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Context.OnlineExamDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;

        }

        protected override void Seed(Context.OnlineExamDbContext context)
        {
            context.Roles.AddOrUpdate(x => new { x.Id, x.CaptionEn, x.CaptionFa },
                new Role { CaptionEn = "Admin", CaptionFa = "مدیر", Id = Guid.NewGuid() },
                new Role { CaptionEn = "User", CaptionFa = "کاربر عادی", Id = Guid.NewGuid() }
                );

            //context.Users.AddOrUpdate(x=>new {x.Role });

            context.SaveChanges();
        }
    }
}
