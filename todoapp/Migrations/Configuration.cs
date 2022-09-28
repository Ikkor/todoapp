namespace todoapp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<todoapp.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(todoapp.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            AddUser(context);

        }

        void AddUser(todoapp.Models.ApplicationDbContext context)
        {
            var user = new ApplicationUser
            {
                UserName = "johny@email.com"

            };
            var userMgr = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context));
            userMgr.Create(user, "password");
        }
    }
}
