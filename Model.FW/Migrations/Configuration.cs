
namespace Model.FW.Migrations
{
    using Model.FW.Entity;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;



    internal sealed class Configuration : DbMigrationsConfiguration<Model.FW.Context.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Model.FW.Context.AppDbContext context)
        {
            List<CompanyUserRole> roleList = new List<CompanyUserRole>()
            {
                new CompanyUserRole
                {
                    MasterID=1,
                    Role="admin"
                },
                new CompanyUserRole
                {
                    MasterID=2,
                    Role="visitor"
                }
            };



            List<CompanyUser> userList = new List<CompanyUser>()
           {
               new CompanyUser
               {
                   ID=Guid.NewGuid(),
                   UserName="irem",
                   Password="123",
                   MasterID=1

               },
               new CompanyUser
               {
                   ID=Guid.NewGuid(),
                   UserName="stajyer",
                   Password="1234",
                   MasterID=2
               }
           };

            CompanyUserAndRole userAndRole = new CompanyUserAndRole();


            if (!context.CompanyUserRoles.Any())
            {
                foreach (CompanyUserRole role in roleList)
                {
                    context.CompanyUserRoles.Add(role);
                    context.SaveChanges();
                }
            }

            if (!context.CompanyUsers.Any())
            {
                foreach (CompanyUser user in userList)
                {
                    context.CompanyUsers.Add(user);
                    context.SaveChanges();
                }

                userAndRole.CompanyUserID = context.CompanyUsers.Where(x => x.UserName == "irem").FirstOrDefault().ID;
                userAndRole.CompanyRoleID = context.CompanyUserRoles.Where(x => x.Role == "Admin").FirstOrDefault().ID;
                context.CompanyUserAndRoles.Add(userAndRole);

            }
        }
    }
}
