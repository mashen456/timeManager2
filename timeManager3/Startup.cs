﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using timeManager3.Models;

[assembly: OwinStartupAttribute(typeof(timeManager3.Startup))]
namespace timeManager3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRolls();
        }

        private void AddSuperAdmin()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            var user = new ApplicationUser();
            user.Email = "admin@timetable.com";

            string userPWD = "adsaA@Zasd200a7!!11";

            var chkUser = UserManager.Create(user, userPWD);

            //Add default User to Role Admin    
            if (chkUser.Succeeded)
            {
                var result1 = UserManager.AddToRole(user.Id, "Admin");

            }
        }

        private void CreateRolls()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            if (!roleManager.RoleExists("Admin"))
            {

                // first we create Admin rool    
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);

      
            }

            // creating Creating Manager role     
            if (!roleManager.RoleExists("Manager"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Manager";
                roleManager.Create(role);

            }

            // creating Creating Employee role     
            if (!roleManager.RoleExists("Employee"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Employee";
                roleManager.Create(role);

            }

            if (!roleManager.RoleExists("Unknown"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Unknown";
                roleManager.Create(role);

            }






        }
    }

}
