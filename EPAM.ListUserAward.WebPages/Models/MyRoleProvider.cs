using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace EPAM.ListUserAward.WebPages.Models
{
    public class MyRoleProvider : RoleProvider
    {

        public override bool IsUserInRole(string username, string roleName)
        {
            // Do Dictionary<username, roleName> users!
            return (username == "Misha@mail.com" && roleName == "admin") ||
                (username == "Misha@mail.com" && roleName == "User");
        }

        public override string[] GetRolesForUser(string username)
        {
            if (username == "Misha@mail.com")
            {
                return new string[] { "Admin", "User" };
            }
            else
            {
                return new string[] { };
            }
        }

        #region PLACE OF DEATH SOLID
        public override string ApplicationName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}