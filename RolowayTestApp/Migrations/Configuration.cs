namespace RolowayTestApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RolowayTestApp.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RolowayTestApp.Models.ApplicationDbContext context)
        {
            context.Users.AddOrUpdate(i => i.UserName,
                new Models.ApplicationUser
                {
                    UserName = "Adi Timoce",
                    Email = "adi@adi.com",
                    PasswordHash = "Abcd.1234",
                },

                 new Models.ApplicationUser
                 {
                     UserName = "Anca Timoce",
                     Email = "anca@anca.com",
                     PasswordHash = "1234.Abcd",
                 }

           );
        }
    }
}