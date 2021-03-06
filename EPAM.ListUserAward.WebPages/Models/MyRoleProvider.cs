﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace EPAM.ListUserAward.WebPages.Models
{
    public class MyRoleProvider : RoleProvider
    {

        private AuthModel _authModel = new AuthModel();

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
            else if (_authModel.GetByEmail(username).UserRights == "Admin")
            {
                return new string[] { "Admin" };
            }
            else
            {
                return new string[] { "User" };
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