using AkaraProject.Models.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AkaraProject.ViewModels
{
    public class LoginViewModel
    {
        public string Name { get; set; }
        public string UserEmail { get; set; }
        public string Password { get; set; }
    }
}