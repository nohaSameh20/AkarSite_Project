using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace AkaraProject.CustomeAuthentication
{
    public class CustomPrincipal : IPrincipal
    {
        #region Identity Properties  
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string UserEmail { get; set; }
        public string Phone { get; set; }
        public string Image { get; set; }
        public string Password { get; set; }
        public string[] Roles { get; set; }
        #endregion

        public IIdentity Identity
        {
            get; private set;
        }
        public CustomPrincipal(string username)
        {
            Identity = new GenericIdentity(username);
        }

        public bool IsInRole(string role)
        {
            if (Roles.Any(r => role.Contains(r)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}