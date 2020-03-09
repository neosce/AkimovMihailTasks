using DealShop.ListUsers.BLL.Interfaces;
using DealShop.ListUsers.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace DealShop.Models
{
    public class MyRoleProvider : RoleProvider
    {

        private IUserLogic _userLogic = DependencyResolver.UserLogic;

        public override bool IsUserInRole(string username, string roleName)
        {
            return (username == "Misha@mail.com" && roleName == "SuperAdmin") ||
               (username == "Misha@mail.com" && roleName == "User");
        }

        public override string[] GetRolesForUser(string username)
        {
            
            if (username == "Misha@mail.com")
            {
                return new string[] { "SuperAdmin" };
            }
            else if (_userLogic.GetAll().All(x => x.LoginEmail == username && x.UserRights == "Admin"))
            {
                return new string[] { "Admin" };
            }
            else
            {
                return new string[] { "User" };
            }
        }

        #region NotImplementedException
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